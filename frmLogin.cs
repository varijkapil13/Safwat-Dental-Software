using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using KryptonForm;
using ComponentFactory.Krypton.Toolkit;

namespace DentalGood
{
    
    public partial class frmLogin : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        bool retvalue;
        DataTable tb = new DataTable();
        public string UserType;
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool startLogin()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * From Users", Program.con);
            adp.Fill(tb);

            this.ShowDialog();
            return (retvalue);

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            if ((txtPass.Text.Length == 0) || (txtUserName.Text.Length == 0))
            {
                btnLogin.Enabled = false;


            }
            else
            {
                btnLogin.Enabled = true;

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if ((txtPass.Text.Length == 0) || (txtUserName.Text.Length == 0))
            {
                btnLogin.Enabled = false;


            }
            else
            {
                btnLogin.Enabled = true;

            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in tb.Rows)
            {
                if (row[1].ToString() == txtUserName.Text && row[2].ToString() == txtPass.Text)
                {
                    UserType = row[3].ToString();

                    retvalue = true;
                    break;
                }
            }

            if (retvalue == true)
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("User ID or password incorrect!");
            }
        }
    }
}