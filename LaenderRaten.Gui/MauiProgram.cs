using CommunityToolkit.Maui;
using LaenderRaten.Core.ViewModels;
using LaenderRaten.Gui.Pages;
using LaenderRaten.Lib.Interfaces;
using LaenderRaten.Lib.Services;
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
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            string path = FileSystem.AppDataDirectory;
            //string filename = "data.xml";
            string filename = "data.sqlite";
            string fullpath = System.IO.Path.Combine(path, filename);
            System.Diagnostics.Debug.WriteLine("Pfad:");
            System.Diagnostics.Debug.WriteLine(path);

            builder.Services.AddSingleton<IRepository>(new SqliteRepository(fullpath));


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
