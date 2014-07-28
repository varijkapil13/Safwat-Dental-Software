using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;
using KryptonForm;

namespace DentalGood
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(PrintImage);
                PrintDialog pdi = new PrintDialog();
                pdi.Document = pd;
                pdi.UseEXDialog = true;
                if (pdi.ShowDialog() == DialogResult.OK)
                {

                    pd.Print();
                }
                else
                {
                    MessageBox.Show("Print Cancelled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
                

        }
        void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        public void start(int b,string PA,string Amnt,string PNam,string DNam,string Pse,string PPhone,string PAdd,string Treat,string Teeth)
        {
            int bno=b;;
           string PName=PNam, DName=DNam, Psex=Pse, PPhoneNo=PPhone, PAddress=PAdd, Treatment=Treat, Teethno=Teeth, PAge=PA, Amount=Amnt;
           /*
            frmTreatment sd = new frmTreatment();
            bno = sd.data();
            SqlDataAdapter a = new SqlDataAdapter("Select bills.BillNo,bills.PName,bills.DName,bills.PAge,bills.PSex,bills.PPhoneNo,bills.PAddress,bills.Treatment,bills.Amount,bills.Teethno from bills,addpro where bills.BillNo=" + bno, Program.con);
            DataTable t = new DataTable();
            a.Fill(t);
            
                
                PAge=Convert.ToString(t.Rows[3]);
                Amount = Convert.ToString(t.Rows[8]);
                PName=Convert.ToString(t.Rows[1]);
                DName =Convert.ToString(t.Rows[2]);
                Psex=Convert.ToString(t.Rows[4]);
                PPhoneNo=Convert.ToString(t.Rows[5]);
                PAddress=Convert.ToString(t.Rows[6]);
                Treatment=Convert.ToString(t.Rows[7]);
                Teethno=Convert.ToString(t.Rows[9]);
            */

                lblAge.Text = PAge;
                //dataGridView1.DataSource = PAge;
                
                lblAmount.Text = Amount;
                lblBillNo.Text = Convert.ToString(bno);
                
                lblDname.Text = DName;
                lblName.Text = PName;
                lblSex.Text = Psex;
                lblTeeth.Text = Teethno;
                lblTreat.Text = Treatment;
             

            
            this.ShowDialog();
        }
        private void frmPrint_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
