using CodingPortfolioWebsite;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using System.Globalization;
using System.Text.RegularExpressions;

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

if (!string.IsNullOrWhiteSpace(storedCulture))
{
    var culture = new CultureInfo(storedCulture);
    CultureInfo.DefaultThreadCurrentCulture = culture;
    CultureInfo.DefaultThreadCurrentUICulture = culture;
}
else
{
    CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
    CultureInfo.DefaultThreadCurrentUICulture = defaultCulture;

}

try
{
    await host.RunAsync();
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    throw;
}