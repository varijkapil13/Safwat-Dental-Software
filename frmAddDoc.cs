using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;
using KryptonForm;


namespace DentalGood
{
    public partial class frmAddDoc : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        int docNo;
        public frmAddDoc()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtAdd.Clear();
            txtAge.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtQuali.Clear();
            rdbFemale.Checked = false;
            rdbMale.Checked = false;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "Insert Into adddoc values(@n,@name,@a,@s,@qua,@phn,@add)";
            docNo = CommonFunction.GetNextValue(1);
            cmd.Parameters.AddWithValue("@n", docNo);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@a", txtAge.Text);
            if (rdbMale.Checked == true)
            {
                cmd.Parameters.AddWithValue("@s", "Male");
            }
            else
            {
                cmd.Parameters.AddWithValue("@s", "Female");
            }
            cmd.Parameters.AddWithValue("@qua", txtQuali.Text);
            cmd.Parameters.AddWithValue("@phn", txtPhone.Text);
            cmd.Parameters.AddWithValue("@add", txtAdd.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Saved");
            clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}