using PasswordManagerv1.Views.Forms;
using PasswordManagerv1.Classes.Managers;
using System.Diagnostics;

namespace PasswordManagerv1
{
    public partial class App : Application
    {
        public static string ImageServerPath { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-.net-maui/common/uikitimages/";

        public App()
        {
            InitializeComponent();
        }


        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new WindowManager(new LoginPage());
        }

    }
}
