using Microsoft.AspNetCore.Components.WebView.Maui;
using BlazorForNative.Data;
using BlazorSharedUI.SharedServices;
using BlazorForNative.Services;

namespace BlazorForNative;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddScoped<IPlatformInfo, PlatformInfo>();

		return builder.Build();
	}
}

