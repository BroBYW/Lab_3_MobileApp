using Microsoft.Extensions.Logging;
using lab2.ViewModels; // <-- Add this using statement

namespace lab2
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
#endif

            // --- ADD THESE LINES ---
            // Register your ViewModel and Page for Dependency Injection
            // We register them as Singletons so the same instance is used everywhere.
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();
            // -----------------------

            return builder.Build();
        }
    }
}