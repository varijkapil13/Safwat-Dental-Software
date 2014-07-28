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
    public partial class frmViewPro : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public frmViewPro()
        {
            InitializeComponent();
        }

        public void start()
        {
            this.Text = "Delete Procedures";
            btnDelete.Enabled = true;
            this.ShowDialog();
            
        }
        private void RefreshData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from addpro", Program.con);

            DataTable tb = new DataTable();
            adp.Fill(tb);
            dgvProcedures.DataSource = tb;
        }
        private void frmViewPro_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from addpro", Program.con);

            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvProcedures.DataSource = tb;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProcedures.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dgvProcedures.SelectedRows[0].Cells[0].Value);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                cmd.CommandText = "delete from addpro where SSN=" + a.ToString();
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