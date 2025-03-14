using Domain.Interfaces;
using Infraestructure.Services;
using Microsoft.Extensions.Logging;
using RetoMaui.Helpers;
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
            })
            .UseMauiMaps();

        builder.Services.AddTransient<ISecureStorageService, SecureStorageService>();


        builder.Services.AddTransient<IndexViewModel>();
        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<BiometricsFunctionViewModel>();
        builder.Services.AddTransient<MapsViewModel>();

        builder.Services.AddTransient<IndexView>();
        builder.Services.AddTransient<HomeView>();
        builder.Services.AddTransient<BiometricsFunctionView>();
        builder.Services.AddTransient<MapsView>();

        builder.Services.AddSingleton<LanguageResourceManager>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
