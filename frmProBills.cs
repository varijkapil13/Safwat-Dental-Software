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
    public partial class frmProBills : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public frmProBills()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from bills", Program.con);

            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvBills.DataSource = tb;
        }

        private void frmProBills_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from bills", Program.con);

            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvBills.DataSource = tb;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBills.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dgvBills.SelectedRows[0].Cells[0].Value);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                cmd.CommandText = "delete from bills where BillNo=" + a.ToString();
                cmd.ExecuteNonQuery();
                RefreshData();
            }
        }
    }
}