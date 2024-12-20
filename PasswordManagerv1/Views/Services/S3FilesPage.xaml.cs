using PasswordManagerv1.ViewModels.Services;
namespace PasswordManagerv1.Views.Services;

public partial class S3FilesPage : ContentPage
{
    public S3FilesPage(S3FilesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}