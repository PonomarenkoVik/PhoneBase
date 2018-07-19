using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelbaseModel;
using TelbaseModel.TelbaseClasses;

namespace TelBaseUI
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
            var form = new MainForm(InitConnectionString());
            var model = new TelbaseEntity();
            var presenter = new Presenter(form, model);
            Application.Run(form);
        }

        private static SqlConnectionStringBuilder InitConnectionString()
        {          
            SqlConnectionStringBuilder conString = new SqlConnectionStringBuilder();
            conString.DataSource = "5.248.50.32,2501";
            conString.InitialCatalog = "Telbase_2";
            conString.IntegratedSecurity = false;
            conString.UserID = "user2";
            conString.Password = "ctvtqrf55556";
            conString.Pooling = true;
            return conString;
        }
    }
}
