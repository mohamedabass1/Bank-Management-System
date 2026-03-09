using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            clsGolobalCurrentUser.Permissions = -1;
            Application.Run(new frmLogin());

        }
    }
}
