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
    public partial class frmDltPat : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public frmDltPat()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from addpat", Program.con);

            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvDeletePatient.DataSource = tb;
        }

        public void start()
        {
            this.Text = "View Patients";
            btnDelete.Enabled = false;
            this.ShowDialog();
        }
        private void frmDltPat_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from addpat", Program.con);

            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvDeletePatient.DataSource = tb;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDeletePatient.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dgvDeletePatient.SelectedRows[0].Cells[0].Value);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                cmd.CommandText = "delete from addpat where SSN=" + a.ToString();
                cmd.ExecuteNonQuery();

                RefreshData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}