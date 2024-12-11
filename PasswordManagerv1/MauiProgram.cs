using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PasswordManagerv1.ViewModels;
using PasswordManagerv1.Views;

namespace PasswordManagerv1
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
                    fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf", "FontAwesomeBrands");
                    fonts.AddFont("Font Awesome 6 Free-Regular-400.otf", "FontAwesomeRegular");
                    fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FontAwesomeSolid");
                });
            RegisterPagesAndViewModels(builder);
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }

        public static void RegisterPagesAndViewModels(MauiAppBuilder builder)
        {
            builder.Services.AddTransient<MainPage, MainPageViewModel>();
        }
    }
}
