using CodingPortfolioWebsite;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddLocalization();

var defaultCulture = new CultureInfo("en-US");

var host = builder.Build();

var js = host.Services.GetRequiredService<IJSRuntime>();

var storedCulture = await js.InvokeAsync<string>(
    "cultureManager.get"
    );

CultureInfo culture;

// If localStorage contains garbage
try
{
    culture = !string.IsNullOrWhiteSpace(storedCulture)
        ? new CultureInfo(storedCulture)
        : new CultureInfo("en-US");
}

catch (CultureNotFoundException)
{
    culture = new CultureInfo("en-US");
}

CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;


await host.RunAsync();