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
    public partial class frmViewTreat : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public frmViewTreat()
        {
            InitializeComponent();
        }
        public void start()
        {
            this.Text = "Delete Treatment";
            btnDelete.Enabled = true;
            this.ShowDialog();
           
        }
        private void RefreshData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from addtreat", Program.con);

            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvTreatment.DataSource = tb;
        }

        private void frmViewTreat_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from addtreat", Program.con);

            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvTreatment.DataSource = tb;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTreatment.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dgvTreatment.SelectedRows[0].Cells[0].Value);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                cmd.CommandText = "delete from addtreat where SSN=" + a.ToString();
                cmd.ExecuteNonQuery();

                RefreshData();
            }
        }
    }
}