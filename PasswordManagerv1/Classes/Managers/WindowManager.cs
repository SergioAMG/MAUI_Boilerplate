using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerv1.Classes.Managers
{
    public class WindowManager : Window
    {
        public WindowManager() : base (){ }
        public WindowManager(Page page) : base(page) { }

        protected override void OnCreated()
        {
            Console.WriteLine("### WindowManager: OnCreated event.");
        }
        protected override void OnActivated()
        {
            Console.WriteLine("### WindowManager: OnActivated event.");
        }
        protected override void OnDeactivated()
        {
            Console.WriteLine("### WindowManager: OnDeactivated event.");
        }
        protected override void OnStopped()
        {
            Console.WriteLine("### WindowManager: OnStopped event.");
        }
        protected override void OnResumed()
        {
            Console.WriteLine("### WindowManager: OnResumed event.");
        }
        protected override void OnDestroying()
        {
            Console.WriteLine("### WindowManager: OnDestroying event.");
        }
    }
}
