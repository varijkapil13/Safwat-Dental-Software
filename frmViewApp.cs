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
    public partial class frmViewApp : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private void RefreshData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from addapp", Program.con);

            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvApp.DataSource = tb;
        }
        public frmViewApp()
        {
            InitializeComponent();
        }
        public void start()
        {
            this.Text = "Delete Appointment";
            btnDelete.Enabled = true;
            this.ShowDialog();

        }

        private void frmViewApp_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from addapp", Program.con);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            dgvApp.DataSource = tb;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvApp.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dgvApp.SelectedRows[0].Cells[0].Value);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                cmd.CommandText = "delete from addapp where AppNo=" + a.ToString();
                cmd.ExecuteNonQuery();

                RefreshData();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}