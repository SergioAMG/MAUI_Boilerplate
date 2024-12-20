using PasswordManagerv1.ViewModels.Services;
namespace PasswordManagerv1.Views.Services;

public partial class WhatsAppPage : ContentPage
{
    public WhatsAppPage(WhatsAppPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}