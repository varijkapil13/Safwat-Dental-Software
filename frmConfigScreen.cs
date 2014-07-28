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
    public partial class frmConfigScreen : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        string q = "Dr.Safwat's Dental Clinic";
        int a = 100;
        public frmConfigScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Incorrect format for text.Please enter some value for the text");
            }
            else
            {

                q = textBox1.Text;
                a = Convert.ToInt32(comboBox1.Text);
                frmScreenSaver sd = new frmScreenSaver();
                sd.configure(q, a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}