using PasswordManagerv1.ViewModels.Brands;
namespace PasswordManagerv1.Views.Brands;

public partial class InstagramPage : ContentPage
{
    public InstagramPage(InstagramPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}