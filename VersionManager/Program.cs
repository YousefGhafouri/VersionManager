using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VersionManager.Utilities;

namespace VersionManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VersionManager.Utilities.AppConfig.UseSSL = ConfigurationManager.AppSettings.Get("UseSSL").ToInteger() == 1;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmVersionManager());
        }
    }
}
