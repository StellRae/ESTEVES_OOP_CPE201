using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTEVES_OOP_CPE201
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
            // instantiate the Form1 class from the Activity_Midterm1 namespace
            Application.Run(new Activity_Midterm1.Form1());
        }
    }
}
