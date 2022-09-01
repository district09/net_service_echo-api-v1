using CorrelationId;
using CorrelationId.DependencyInjection;
using Digipolis.Serilog.Elk.Configuration;
using District09.Echo;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseDigipolisSerilog();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDefaultCorrelationId(o =>
{
    o.RequestHeader = "CorrelationId";
    o.ResponseHeader = "CorrelationId";
});

builder.Services.AddSingleton<IStartupFilter>(
    new PathBaseStartupFilter(builder.Configuration["APP_NAMESPACE_PREFIX"] ?? ""));

var app = builder.Build();

app.UseCorrelationId();
app.UseDigipolisRequestLogging();
app.MapGet("/", Routes.ReturnOk);

app.Run();