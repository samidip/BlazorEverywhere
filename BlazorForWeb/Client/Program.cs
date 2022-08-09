using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorForWeb.Client;
using BlazorForWeb.Client.Services;
using BlazorSharedUI.SharedServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IPlatformInfo, PlatformInfo>();
builder.Services.AddScoped<BrowserService>();

await builder.Build().RunAsync();

