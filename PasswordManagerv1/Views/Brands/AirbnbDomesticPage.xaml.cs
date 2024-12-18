using PasswordManagerv1.ViewModels.Brands;
namespace PasswordManagerv1.Views.Brands;

public partial class AirbnbDomesticPage : ContentPage
{
    public AirbnbDomesticPage(AirbnbDomesticPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}