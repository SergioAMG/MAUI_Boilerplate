using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PasswordManagerv1.Resources.Localization;

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

        [RelayCommand]
        public async Task DisplayLogoButtonPressedActionAsync(string button)
        {
            CancellationTokenSource cancellationTokenSource = new();
            await CreateGenericToast(AppResources.ButtonPressed + button).Show(cancellationTokenSource.Token);
        }

        IToast CreateGenericToast(string message)
        {
            string text = message;
            ToastDuration duration = ToastDuration.Long;
            double fontSize = 16;
            return Toast.Make(text, duration, fontSize);
        }
    }
}
