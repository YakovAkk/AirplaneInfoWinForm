using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAcademyWindowsForm
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new Form1();
            mainForm.Load += OnLoaded;
            Application.Run(mainForm);
        }

        private static void OnLoaded(object sender, EventArgs e)
        {
            var mainController = new MainController(sender as Form);
            mainController.Start();
        }
    }
}
