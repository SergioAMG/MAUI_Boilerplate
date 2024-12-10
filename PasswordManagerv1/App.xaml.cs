
using PasswordManagerv1.Classes;
using System.Diagnostics;

namespace PasswordManagerv1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        /*
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new PasswordManagerWindow(new MainPage());
        }
        */
    }
}
