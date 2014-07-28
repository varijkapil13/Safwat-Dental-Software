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
    public partial class frmNewUser : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == txtcnfrmpass.Text)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                cmd.CommandText = "Insert Into users values(@uname,@uid,@pass,@type)";

                cmd.Parameters.AddWithValue("@uname", txtName.Text);
                cmd.Parameters.AddWithValue("@uid", txtuserid.Text);
                cmd.Parameters.AddWithValue("@pass", txtpassword.Text);
                if (rdbAdmin.Checked == true)
                {

                    cmd.Parameters.AddWithValue("@type", "admin");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@type", "guest");
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Saved");

                this.Close();
            }
            else
            {
                MessageBox.Show("Passwords do not match!Please enter the password again");
                txtpassword.Clear();
                txtcnfrmpass.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}