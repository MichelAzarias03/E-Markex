using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
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

            //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("fr");
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("fr");

            Application.Run(new FrmParent());
        }
    }
}
