using PasswordManagerv1.ViewModels.Brands;
namespace PasswordManagerv1.Views.Brands;

public partial class FacebookPage : ContentPage
{
    public FacebookPage(FacebookPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}