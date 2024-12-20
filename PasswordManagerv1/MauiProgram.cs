using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PasswordManagerv1.ViewModels;
using PasswordManagerv1.ViewModels.Services;
using PasswordManagerv1.Views;
using PasswordManagerv1.Views.Services;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.Toolkit.Hosting;

namespace PasswordManagerv1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .ConfigureSyncfusionCore()
                .ConfigureSyncfusionToolkit()
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Medium.ttf", "Roboto-Medium");
                    fonts.AddFont("Roboto-Regular.ttf", "Roboto-Regular");
                    fonts.AddFont("UIFontIcons.ttf", "FontIcons");
                    fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf", "FontAwesomeBrands");
                    fonts.AddFont("Font Awesome 6 Free-Regular-400.otf", "FontAwesomeRegular");
                    fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FontAwesomeSolid");
                });
            //Register Syncfusion license https://help.syncfusion.com/common/essential-studio/licensing/how-to-generate
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
            RegisterPagesAndViewModels(builder);
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }

        public static void RegisterPagesAndViewModels(MauiAppBuilder builder)
        {
            builder.Services.AddTransient<FacebookPage, FacebookPageViewModel>();
            builder.Services.AddTransient<InstagramPage, InstagramPageViewModel>();
            builder.Services.AddTransient<WhatsAppPage, WhatsAppPageViewModel>();

            builder.Services.AddTransient<S3FilesPage, S3FilesPageViewModel>();
            builder.Services.AddTransient<S3SettingsPage, S3SettingsPageViewModel>();

            //builder.Services.AddTransient<MainPage, MainPageViewModel>();
        }
    }
}
