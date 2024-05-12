using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection; 
using Microsoft.AspNetCore.Http;
using SharedLibrary;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
var app = builder.Build();

var logger = app.Services.GetRequiredService<ILogger<ChequeProcessor>>();
var httpClient = app.Services.GetRequiredService<HttpClient>();



var processor = new ChequeProcessor(httpClient,logger);

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapPost("/cheques", async (List<Cheque> cheques) =>
{
    var allErrors = new List<string>();
    cheques.ForEach(cheque =>
    {
        var validationResults = cheque.Validate();
        if (validationResults.Any())
        {
            allErrors.AddRange(validationResults);
        }
    });

    if (allErrors.Any()) // Make sure 'allErrors' is defined or accessible in this scope
    {
        return Results.BadRequest(new List<string>(allErrors));
    }

    try
    {
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} - Starting processing of cheques");

        var eitherResult = await processor.ProcessChequesAsync(cheques);

        return eitherResult.Match(
            left => Results.Ok(new List<ChequeResult>(left)), // Success case
            right => Results.BadRequest(new List<string>(right)) // Error case
        );
    }
    catch (Exception ex)
    {
        // Handle unexpected errors here
        logger.LogError(ex, "An unexpected error occurred while processing cheques");
        return Results.StatusCode(StatusCodes.Status500InternalServerError);
    }
})
.Produces<List<ChequeResult>>(StatusCodes.Status200OK)
.Produces<List<string>>(StatusCodes.Status400BadRequest)
.WithName("ProcessCheques");


await app.RunAsync();



