using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
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
            DbHelper.ReadSettings();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmBase());
        }
    }
}
