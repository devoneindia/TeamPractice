using HandlingDb.Components;
using HandlingDb.Models;
using Serilog.Core;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

/* ... */

/* Serilog configuration
 * here I use BrowserHttp sink to send log entries to my Server app
 */
var levelSwitch = new LoggingLevelSwitch();
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.ControlledBy(levelSwitch)
    .Enrich.WithProperty("InstanceId", Guid.NewGuid().ToString("n"))
    .WriteTo.Console()
    .CreateLogger();

/* this is used instead of .UseSerilog to add Serilog to providers */
builder.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

builder.Logging.AddSerilog();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
