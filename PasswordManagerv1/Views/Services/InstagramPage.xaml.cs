using PasswordManagerv1.ViewModels.Services;
namespace PasswordManagerv1.Views.Services;

public partial class InstagramPage : ContentPage
{
    public InstagramPage(InstagramPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}