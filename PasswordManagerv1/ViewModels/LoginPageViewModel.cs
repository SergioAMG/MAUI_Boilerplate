using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PasswordManagerv1.ViewModels;
using Syncfusion.Maui.DataForm;
using System.ComponentModel.DataAnnotations;

namespace PasswordManagerv1.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        public ContactsInfo ContactsInfo { get; set; }

        public LoginPageViewModel()
        {
            ContactsInfo = new ContactsInfo();
        }

        [RelayCommand]
        public void Login(SfDataForm form)
        {
            bool isValid = form.Validate();
            string login = ContactsInfo.Email;

            if (isValid)
                Application.Current.MainPage = new AppShell();
        }
    }

    public class ContactsInfo
    {
        public ContactsInfo()
        {
            this.Email = string.Empty;
            this.Password = string.Empty;
        }

        [Display(Name = "Email")]
        [DataFormDisplayOptions(ColumnSpan = 3)]
        [EmailAddress(ErrorMessage = "Enter your email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the password")]
        [DataFormDisplayOptions(ColumnSpan = 3)]
        public string Password { get; set; }
    }
}
