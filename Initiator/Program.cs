using Initiator;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using QuickFix;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IApplication, InitiatorFixApp>();

builder.Host.UseSerilog(logger);

builder.Services
    .AddHostedService<Worker>()
    .AddLogging(builder =>
    {
        builder.ClearProviders();
        builder.AddSerilog(logger);
    });

var app = builder.Build();

app
    .UseAuthorization()
    .UseSwagger()
    .UseSwaggerUI();

app.MapControllers();

app.Run();
