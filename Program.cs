using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DentalGood;
using ComponentFactory.Krypton.Toolkit;

namespace KryptonForm
{
    static class Program
    {
        public static SqlConnection con = new SqlConnection();
        public static bool Connected;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string filename = Application.StartupPath + "\\DBConfig.CFG";


            bool b = File.Exists(filename);

            if (b == true)
            {

                FileStream FS = new FileStream(filename, FileMode.Open);
                StreamReader sr = new StreamReader(FS);

                try
                {
                    con.ConnectionString = sr.ReadLine();
                    sr.Close();
                    FS.Close();
                    con.Open();
                    Connected = true;
                }
                catch (Exception)
                {
                    DialogResult s;
                    s=MessageBox.Show("Application is not properly configured for database connectivity!! Please Visit 'Options' tab and then click 'configure Database' option to make the software fuction properly.","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Connected = false;
                }
            }
            else
            {
                MessageBox.Show("Application is not properly configured for database connectivity!! Please Visit 'Options' tab and then click 'configure Database' option to make the software fuction properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connected = false;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}