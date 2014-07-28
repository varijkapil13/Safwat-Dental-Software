using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace DentalGood
{
    public partial class frmScreenSaver : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        int a = 10, b = 10;
        public frmScreenSaver()
        {
            InitializeComponent();
        }

        public void configure(string s, int w)
        {
            label1.Text = s;
            timer1.Interval = w;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = new Point();
            p =label1.Location;
            if (p.X <= 0 || p.X > (this.Width - label1.Width))
            {
                a = a * -1;
            }
            if (p.Y <= 0 || p.Y > (this.Height - label1.Height))
            {
                b = b * -1;

            }

            p.X = p.X + a;
            p.Y = p.Y + b;
            label1.Location = p;
        }

        private void frmScreenSaver_Load(object sender, EventArgs e)
        {
            
        }
        private void frmScreenSaver_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void frmScreenSaver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}