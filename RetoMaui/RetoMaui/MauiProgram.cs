using Microsoft.Extensions.Logging;
using RetoMaui.ViewModels;
using RetoMaui.Views;

namespace RetoMaui;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

			builder.Services.AddTransient<IndexViewModel>();
			builder.Services.AddTransient<HomeViewModel>();

			builder.Services.AddTransient<IndexView>();
			builder.Services.AddTransient<HomeView>();
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
