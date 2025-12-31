using SimpleDiContainer.Data;
using SimpleDiContainer.Services;
using System;
using System.Windows.Forms;

namespace SimpleDiContainer
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = new DI.SimpleDiContainer();
            container.Register<IUserRepository, UserRepository>();
            container.Register<IUserService, UserService>();

            
            var form = container.Resolve<MainForm>();
            Application.Run(form);
        }
    }
}
