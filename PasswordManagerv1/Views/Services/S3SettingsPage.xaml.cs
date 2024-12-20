using PasswordManagerv1.ViewModels.Services;
namespace PasswordManagerv1.Views.Services;

public partial class S3SettingsPage : ContentPage
{
    public S3SettingsPage(S3SettingsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}