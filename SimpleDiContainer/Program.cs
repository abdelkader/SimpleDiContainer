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

            // Configurer le conteneur DI
            var container = new SimpleDiContainer();
            container.Register<IUserRepository, UserRepository>();
            container.Register<IUserService, UserService>();

            // Créer et afficher la forme
            var form = container.Resolve<MainForm>();
            Application.Run(form);
        }
    }
}
