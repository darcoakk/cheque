using Dapr.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedLibrary;
using Microsoft.Extensions.Logging;

public class ChequeProcessor
{

    private readonly ILogger<ChequeProcessor> _logger;
    private readonly HttpClient _httpClient;

    public ChequeProcessor(HttpClient httpClient, ILogger<ChequeProcessor> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }
 
    public async Task<ResponseData> ProcessChequesAsync(List<Cheque> cheques)
    {
        var signerIds = cheques.SelectMany(c => c.SignerIds).Distinct();
        var dataTasks = signerIds.ToDictionary(id => id, id => FetchSignerDataAsync(id));

        await Task.WhenAll(dataTasks.Values);

        var signerDataDictionary = dataTasks
        .Where(pair => pair.Value.Result != null)
        .ToDictionary(pair => pair.Key, pair => pair.Value.Result);

        var decisionTasks = cheques.Select(async cheque =>
        {
            var relatedSigners = cheque.SignerIds
                .Select(id => signerDataDictionary.ContainsKey(id) ? signerDataDictionary[id] : null)
                .ToList();

            cheque.Decision = relatedSigners.Any(signer => signer == null) 
                                ? "NoDecision" 
                                : await MakeDecisionAsync(cheque, relatedSigners.Cast<AugmentedSignerData>().ToList());
        });

        await Task.WhenAll(decisionTasks);
        return new ResponseData { Cheques = cheques, AugmentedSignerDataList = signerDataDictionary.Values.ToList() };
    }

    private async Task<string> MakeDecisionAsync(Cheque cheque, List<AugmentedSignerData> relatedSigners)
    {
        // Create a Random object
        var random = new Random();

        // Create a list of decisions
        var decisions = new List<string> { "Green", "Yellow", "Red" };

        // Select a random decision
        var decision = decisions[random.Next(decisions.Count)];

        return decision;
    } 

    private async Task<AugmentedSignerData> FetchSignerDataAsync(string signerId)
    {
        try
        {
            // Fetch signer data using signerId
            var response1 = await _httpClient.GetAsync($"http://localhost:7002/dataservice1/data/{signerId}");
            var response2 = await _httpClient.GetAsync($"http://localhost:7003/dataservice2/data/{signerId}");

            response1.EnsureSuccessStatusCode();
            response2.EnsureSuccessStatusCode();

            var data1 = await response1.Content.ReadAsAsync<DataService1Response>();
            var data2 = await response2.Content.ReadAsAsync<DataService2Response>();

            return new AugmentedSignerData
            {
                SignerId = signerId,
                Name = data1.Name,
                Email = data1.Email,
                TotalTransactionsLastYear = data2.TotalTransactionsLastYear,
                AverageTransactionAmount = data2.AverageTransactionAmount
            };
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, $"Error fetching signer data for {signerId}");
            return null;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error fetching signer data for {signerId}");
            return null;
        }
    }


}

