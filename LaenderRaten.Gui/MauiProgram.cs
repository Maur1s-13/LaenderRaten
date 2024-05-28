using LaenderRaten.Core.ViewModels;
using LaenderRaten.Gui.Pages;
using Microsoft.Extensions.Logging;

namespace LaenderRaten.Gui
{
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

#if DEBUG
    		builder.Logging.AddDebug();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddSingleton<AddCountryViewModel>();
            builder.Services.AddSingleton<AddCountry>();
#endif

            return builder.Build();
        }
    }
}
