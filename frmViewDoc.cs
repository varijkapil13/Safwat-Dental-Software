using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using KryptonForm;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace DentalGood
{
    public partial class frmViewDoc : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public frmViewDoc()
        {
            InitializeComponent();
        }
        public void start()
        {
            this.Text = "Delete Doctors";
            btnDelete.Enabled = true;
            this.ShowDialog();

        }
        private void RefreshData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from adddoc", Program.con);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            dgvDoctors.DataSource = tb;
        }


        private void n_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells[0].Value);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                cmd.CommandText = "delete from adddoc where SSN=" + a.ToString();
                cmd.ExecuteNonQuery();
                RefreshData();
            }
        }

        private void frmViewDoc_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from adddoc", Program.con);

            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvDoctors.DataSource = tb;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}