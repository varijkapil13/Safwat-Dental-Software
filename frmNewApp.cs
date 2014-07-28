using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using KryptonForm;

namespace DentalGood
{
    public partial class frmNewApp : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        int apno;
        public frmNewApp()
        {
            InitializeComponent();
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a = (int)e.KeyChar;
            if (a != 8)
            {
                if (a < 48 || a > 57)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a = (int)e.KeyChar;
            if (a != 8)
            {
                if (a < 48 || a > 57)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnSaveApp_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;

            cmd.CommandText = "Insert addapp values(@apno,@name,@age,@sex,@phn,@apdate,@aptym)";
            apno = CommonFunction.GetNextValue(4);
            cmd.Parameters.AddWithValue("@apno", apno);
            cmd.Parameters.AddWithValue("@apdate", dtpDate.Text);
            cmd.Parameters.AddWithValue("@aptym", dtpTime.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            if (rbMale.Checked == true)
            {
                cmd.Parameters.AddWithValue("@sex", "Male");
            }
            else
            {
                cmd.Parameters.AddWithValue("@sex", "Female");
            }
            cmd.Parameters.AddWithValue("@phn", txtPhone.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Saved");
            txtAge.Clear();
            txtName.Clear();
            txtPhone.Clear();
            rbFemale.Checked = false;
            rbMale.Checked = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}