using PasswordManagerv1.ViewModels.Services;
namespace PasswordManagerv1.Views.Services;

public partial class FacebookPage : ContentPage
{
    public FacebookPage(FacebookPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}