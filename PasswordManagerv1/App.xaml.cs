
using PasswordManagerv1.Classes.Managers;
using System.Diagnostics;

namespace PasswordManagerv1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new WindowManager(new AppShell());
        }
        
    }
}
