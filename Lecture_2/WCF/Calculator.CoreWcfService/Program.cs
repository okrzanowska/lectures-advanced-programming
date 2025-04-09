using CoreWCF;
using CoreWCF.Configuration;
using Calculator.CoreWcfService;
using CoreWCF.Description;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();

var app = builder.Build();

app.UseServiceModel(serviceBuilder =>
{
    serviceBuilder
        .AddService<CalculatorService>()
        .AddServiceEndpoint<CalculatorService, ICalculatorService>(
            new BasicHttpBinding(), "/soap/calculator");
});

// Getting WSDL URL
var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
serviceMetadataBehavior.HttpGetEnabled = true;
serviceMetadataBehavior.HttpGetUrl = new Uri("http://localhost:5189/soap/calculator/wsdl");

app.Run();
