using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection; 

using SharedLibrary;


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

app.MapPost("/process-cheques", (List<Cheque> cheques) =>
{
    return processor.ProcessChequesAsync(cheques);
});

await app.RunAsync();



