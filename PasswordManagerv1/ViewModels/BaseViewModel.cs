using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PasswordManagerv1.ViewModels
{
    public partial class BaseViewModel: ObservableObject
    {
        //[NotifyPropertyChangedFor(nameof(LinkedProperty))]
        [ObservableProperty]
        private string? _title;
        [ObservableProperty]
        private string? _subTitle;

        [RelayCommand]
        public async Task BackAsync() => await Shell.Current.GoToAsync("..");
    }
}
