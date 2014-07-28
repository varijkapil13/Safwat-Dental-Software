using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using System.IO;
using KryptonForm;

namespace DentalGood
{
    public partial class frmDataSource : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public frmDataSource()
        {
            InitializeComponent();
        }

        private void frmDataSource_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + "\\DBConfig.CFG";
            FileStream fs = new FileStream(filename, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            string constr;

            if (cmbAuthentication.SelectedIndex == 0)
            {
                constr = "Server=" + txtServer.Text + ";database=dental;trusted_connection=yes";

            }
            else
            {
                constr = "Server=" + txtServer.Text + ";database=dental;uid=" + txtUserID.Text + ";Password=" + txtPass.Text;
            }

            sw.WriteLine(constr);

            sw.Close();
            fs.Close();

            MessageBox.Show("Application is now configured for database connectivity");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 1)
            {
                txtPass.Enabled = true;
                txtUserID.Enabled = true;
            }
            else
            {
                txtPass.Enabled = false;
                txtUserID.Enabled = false;
            }
        }
    }
}