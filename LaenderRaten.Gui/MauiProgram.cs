using CommunityToolkit.Maui;
using LaenderRaten.Core.ViewModels;
using LaenderRaten.Gui.Pages;
using LaenderRaten.Gui.Services;
using LaenderRaten.Lib.Interfaces;
using LaenderRaten.Lib.Models;
using LaenderRaten.Lib.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;

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
            builder.Services.AddSingleton<ILoadRepository>(new UseCountries(fullpath));
            builder.Services.AddSingleton<ISoundService>(new AudioViewModel(AudioManager.Current));
            builder.Services.AddSingleton<IAlertService>(new AlertService());

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
