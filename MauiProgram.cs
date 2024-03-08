using CommunityToolkit.Maui;
using MauiSample.ViewModels;
using MauiSample.Views;
using Microsoft.Extensions.Logging;

namespace MauiSample;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddTransient<MainPage, MainViewModel>();
        builder.Services.AddTransient<ControlView, ControlViewModel>();

//        builder.Services.Register();

        return builder.Build();
    }
}