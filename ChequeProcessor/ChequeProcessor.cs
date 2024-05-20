using System.Xml.Serialization;
using SharedLibrary;
using Microsoft.Extensions.Logging;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ChequeProcessor
{

    private readonly ILogger<ChequeProcessor> _logger;
    private readonly HttpClient _httpClient;
    private Configuration config;
    private ChequeBpmApi apiInstance;
    public ChequeProcessor(HttpClient httpClient, ILogger<ChequeProcessor> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
        config = new Configuration();
        config.BasePath = "http://localhost";
        
        apiInstance = new ChequeBpmApi(config);
    }
 
    public List<string> GetUniqueIdentifiers(List<Cheque> cheques)
    {
        var uniqueIdentifiers = cheques
            .SelectMany(c => new[] { c.Drawer,c.Payee,c.Guarantor})
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
                (true, true, _, _) => $"Missing signer data with id {cheque.Drawer} and holder data with id {cheque.Payee} for cheque {cheque.No}",
                (true, _, true, false) => $"Missing signer data with id {cheque.Drawer} and guarantor data with id {cheque.Guarantor} for cheque {cheque.No}",
                (_, true, true, false) => $"Missing holder data with id {cheque.Payee} and guarantor data with id {cheque.Guarantor} for cheque {cheque.No}",
                (true, _, _, _) => $"Missing signer data with id {cheque.Drawer} for cheque {cheque.No}",
                (_, true, _, _) => $"Missing holder data with id {cheque.Payee} for cheque {cheque.No}",
                (_, _, true, false) => $"Missing guarantor data with id {cheque.Guarantor} for cheque {cheque.No}",
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
        //Get memzuc data
        apiInstance.Configuration = config;
        KKBChequeInfoRequest body = new KKBChequeInfoRequest(tCKNVKN: identifier);
        KKBChequeResponse kkbChequeResponse = await apiInstance.ApiV1ChequeBpmKKBChequeInfoPostAsync(body);
        MemzucInfoRequest memzucInfoRequest = new MemzucInfoRequest(tCKNVKN: identifier);
        MemzucEntResponse memzucEntResponse = await apiInstance.ApiV1ChequeBpmMemzucInfoPostAsync(memzucInfoRequest);
        return AugmentedSignerDataMapper.Map(memzucEntResponse, kkbChequeResponse);
    }


}

