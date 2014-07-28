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
    public partial class Parameters : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public int nValue
        {
            get
            {
                return (Convert.ToInt32(Value.Text, 10));
            }
            set { Value.Text = value.ToString(); }
        }
        public Parameters()
        {
            InitializeComponent();
            OK.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}