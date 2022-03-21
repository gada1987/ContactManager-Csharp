using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login_Register_Form form = new Login_Register_Form();

            //If the OK button in the showdialog is pressed then run else exit
            if (form.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new ProgramForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
