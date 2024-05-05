using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapGet("/dataservice2/data/{signerId}", async (string signerId) => 
{
    var stopwatch = Stopwatch.StartNew();

    // Create a Random object
    var random = new Random();

    // Generate a random delay time between 500ms and 2000ms
    var delayTime = random.Next(500, 2000);

    // Wait for the random delay time
    await Task.Delay(delayTime);
    
    stopwatch.Stop();

    if (delayTime > 1800)
    {
        throw new Exception("Delay time exceeded 1.5 seconds.");
    }

    Console.WriteLine($"Processed request for signerId {signerId} in {stopwatch.ElapsedMilliseconds} ms");

    return new DataService2Response 
    {
        TotalTransactionsLastYear = 100,
        AverageTransactionAmount = 200.0m
    };
});

await app.RunAsync();

public class DataService2Response
{
    public int TotalTransactionsLastYear { get; set; }
    public decimal AverageTransactionAmount { get; set; }
}