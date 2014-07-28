using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.Configuration;
using KryptonForm;
using ComponentFactory.Krypton.Toolkit;

namespace DentalGood
{
    public partial class frmBillPrint : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public frmBillPrint()
        {
            InitializeComponent();
        }
        public void reportview(CrystalReport1 objReport)
        {
            
            crystalReportViewer1.ReportSource = objReport;
            this.ShowDialog();
        }
    }
}