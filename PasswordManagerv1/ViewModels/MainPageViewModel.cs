using CommunityToolkit.Mvvm.Input;

namespace PasswordManagerv1.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private int counter = 0;
        public MainPageViewModel()
        {
            Title = "Main Page";
            SubTitle = "This is the main page.";
        }

        [RelayCommand]
        public async Task DisplayCounterAsync()
        {
            counter++;
            SemanticScreenReader.Announce(counter.ToString());
            await Shell.Current.CurrentPage.DisplayAlert("PasswordManagerv1", $"Button has been pressed: {counter} times.", null, "Okay");
        }
    }
}
