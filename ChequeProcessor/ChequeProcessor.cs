using Dapr.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

using SharedLibrary;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using KKB;
using Memzuc;


public class ChequeProcessor
{

    private readonly ILogger<ChequeProcessor> _logger;
    private readonly HttpClient _httpClient;

    public ChequeProcessor(HttpClient httpClient, ILogger<ChequeProcessor> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }
 
    public List<string> GetUniqueIdentifiers(List<Cheque> cheques)
    {
        var uniqueIdentifiers = cheques
            .SelectMany(c => new[] { c.Drawer, c.Payee, c.Guarantor })
            .Where(id => id != null)
            .Distinct()
            .ToList();

        return uniqueIdentifiers;
    }

    public async Task<Either<List<ChequeResult>, List<string>>> ProcessChequesAsync(List<Cheque> cheques)
    {
        var errors = cheques.SelectMany(c => c.Validate()).ToList();
        if (errors.Any())
        {
            return new Either<List<ChequeResult>, List<string>>(errors);
        }
            
        var identifiers = GetUniqueIdentifiers(cheques);
        var dataTasks = identifiers.ToDictionary(id => id, id => FetchIdentifierDataAsync(id));

        await Task.WhenAll(dataTasks.Values);
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} - WhenAll complete");

        var signerDataDictionary = dataTasks
            .Where(pair => pair.Value.Result != null)
            .ToDictionary(pair => pair.Key, pair => pair.Value.Result);

        var chequeResults = new List<ChequeResult>();

        foreach (var cheque in cheques)
        {
            var drawerData = signerDataDictionary[cheque.Drawer];
            var payeeData = signerDataDictionary[cheque.Payee];
            var guarantorData = cheque.Guarantor != null ? signerDataDictionary[cheque.Guarantor] : null;

            // If any of the required data is missing, skip this cheque and add an error for each missing data
            // Use a switch expression to handle the different combinations of missing data
            var missingData = (drawerData == null, payeeData == null, guarantorData == null, cheque.Guarantor == null) switch
            {
                (true, true, _, _) => $"Missing signer data with id {cheque.Drawer} and holder data with id {cheque.Payee} for cheque {cheque.Id}",
                (true, _, true, false) => $"Missing signer data with id {cheque.Drawer} and guarantor data with id {cheque.Guarantor} for cheque {cheque.Id}",
                (_, true, true, false) => $"Missing holder data with id {cheque.Payee} and guarantor data with id {cheque.Guarantor} for cheque {cheque.Id}",
                (true, _, _, _) => $"Missing signer data with id {cheque.Drawer} for cheque {cheque.Id}",
                (_, true, _, _) => $"Missing holder data with id {cheque.Payee} for cheque {cheque.Id}",
                (_, _, true, false) => $"Missing guarantor data with id {cheque.Guarantor} for cheque {cheque.Id}",
                _ => null
            };

            if (missingData != null)
            {
                errors.Add(missingData);
                continue;
            }

            

            //cheque.Decision = await MakeDecisionAsync(cheque, new List<AugmentedSignerData> { signerData, holderData, guarantorData });

            chequeResults.Add(new ChequeResult { Cheque = cheque, DrawerData = drawerData, PayeeData = payeeData, GuarantorData = guarantorData });
        }

        if (errors.Any())
        {
            return new Either<List<ChequeResult>, List<string>>(errors);
        }
        else
        {
            return new Either<List<ChequeResult>, List<string>>(chequeResults);
        }
    }

    

    private async Task<AugmentedSignerData> FetchIdentifierDataAsync(string identifier)
    {
        try
        {
            // Start both requests
            Task<HttpResponseMessage> response1Task = _httpClient.GetAsync($"http://localhost:3000/kkbcek/{identifier}");
            Task<HttpResponseMessage> response2Task = _httpClient.GetAsync($"http://localhost:3000/memzuc/{identifier}");

            // Await both requests
            HttpResponseMessage[] responses = await Task.WhenAll(response1Task, response2Task);

            // Ensure both requests were successful
            responses[0].EnsureSuccessStatusCode();
            responses[1].EnsureSuccessStatusCode();

            // Read the responses as streams
            Stream kkbChequeStream = await responses[0].Content.ReadAsStreamAsync();
            Stream memzucEntStream = await responses[1].Content.ReadAsStreamAsync();

            var kkbSerializer = new XmlSerializer(typeof(KKBChequeResponse));
            KKBChequeResponse kkbChequeData = (KKBChequeResponse)kkbSerializer.Deserialize(kkbChequeStream);

            var memzucSerializer = new XmlSerializer(typeof(MemzucEntResponse));
            MemzucEntResponse memzucEntData = (MemzucEntResponse)memzucSerializer.Deserialize(memzucEntStream);
            foreach (var item in memzucEntData.Data.MemzucEntResults)
            {
                if (!string.IsNullOrEmpty(item.Period))
                {
                    item.SetPeriodDate();
                }
            }
            return ToAugmentedSignerData.Map(memzucEntData, kkbChequeData);
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, $"Error fetching signer data for {identifier}");
            return null;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error fetching signer data for {identifier}");
            return null;
        }
    }


}

