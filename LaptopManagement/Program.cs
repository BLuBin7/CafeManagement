using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopManagement
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

            var loginForm = new Login();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                if (loginForm.IsAdmin)
                {
                    Application.Run(new FrmLaptopManagement());
                }
                else
                {
                    Application.Run(new Dashboard());
                }
            }
        }
    }
}
