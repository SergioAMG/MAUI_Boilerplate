using PasswordManagerv1.ViewModels.Brands;
namespace PasswordManagerv1.Views.Brands;

public partial class AirbnbInternationalPage : ContentPage
{
    public AirbnbInternationalPage(AirbnbInternationalPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}