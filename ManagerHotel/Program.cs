using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.ModelConfiguration;
using System.Configuration;

namespace ManagerHotel
{
    static class Program
    {
        public static string cn;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_manageHotel());
        }
    }
}
