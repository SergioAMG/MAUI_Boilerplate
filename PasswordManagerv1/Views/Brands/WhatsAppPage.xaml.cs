using PasswordManagerv1.ViewModels.Brands;
namespace PasswordManagerv1.Views.Brands;

public partial class WhatsAppPage : ContentPage
{
    public WhatsAppPage(WhatsAppPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}