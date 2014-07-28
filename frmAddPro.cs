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
    public partial class frmAddPro : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        int pno;
        public frmAddPro()
        {
            InitializeComponent();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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
            cmd.CommandText = "Insert Into addpro values(@pno,@name,@amnt,@med)";
            pno = CommonFunction.GetNextValue(3);
            cmd.Parameters.AddWithValue("@pno", pno);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@amnt", txtAmount.Text);
            cmd.Parameters.AddWithValue("@med", txtMedicine.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Saved");
            txtAmount.Clear();
            txtMedicine.Clear();
            txtName.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}