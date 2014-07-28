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
    public partial class frmViewUsers : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public frmViewUsers()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from users", Program.con);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            dgvUsers.DataSource = tb;
        }
        private void frmViewUsers_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from users", Program.con);

            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvUsers.DataSource = tb;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                String a = Convert.ToString(dgvUsers.SelectedRows[0].Cells[1].Value);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                cmd.CommandText = "delete from users where userid =@userid";
                try
                {

                    cmd.Parameters.AddWithValue("@userid", a);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                }
                finally
                {
                }
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