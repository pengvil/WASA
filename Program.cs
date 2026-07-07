using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSewageManagementSystem.Forms.Common;

namespace WaterSewageManagementSystem
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
            //Application.Run(new Forms.ServiceOfficer.ServiceOfficerDashboardForm());
            Application.Run(new LoginForm());
        }
    }
}
