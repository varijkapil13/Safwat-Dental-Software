using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;
using DentalGood;

namespace KryptonForm
{
    public partial class frmMain : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void kryptonRibbon_SelectedTabChanged(object sender, EventArgs e)
        {

        }

        private void kryptonRibbonGroup1_DialogBoxLauncherClick(object sender, EventArgs e)
        {

        }
        protected void addDoc_Click(object sender, System.EventArgs e)
        {
            frmAddDoc newMDIChild = new frmAddDoc();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
        protected void addpat_Click(object sender, System.EventArgs e)
        {
            frmAddPat newMDIChild = new frmAddPat();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
        protected void addpro_Click(object sender, System.EventArgs e)
        {
            frmAddPro newMDIChild = new frmAddPro();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        protected void addx_Click(object sender, System.EventArgs e)
        {
            frmAddX newMDIChild = new frmAddX();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        protected void newapp_Click(object sender, System.EventArgs e)
        {
            frmNewApp newMDIChild = new frmNewApp();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        protected void newuser_Click(object sender, System.EventArgs e)
        {
            frmNewUser newMDIChild = new frmNewUser();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
        protected void treat_Click(object sender, System.EventArgs e)
        {
            frmTreatment newMDIChild = new frmTreatment();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void radRibbonBarGroup4_Click(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            frmTreatment newMDIChild = new frmTreatment();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void btnIdle_Click(object sender, EventArgs e)
        {
            frmScreenSaver sc = new frmScreenSaver();
            sc.ShowDialog();
        }

        private void btnViewTreat_Click(object sender, EventArgs e)
        {
            frmViewTreat vb = new frmViewTreat();
            vb.ShowDialog();
        }

        private void btnProBills_Click(object sender, EventArgs e)
        {
            frmProBills cn = new frmProBills();
            cn.ShowDialog();
        }

        private void btnViewApp_Click(object sender, EventArgs e)
        {
            frmViewApp z = new frmViewApp();
            z.ShowDialog();


        }

        private void btnDltApp_Click(object sender, EventArgs e)
        {
            frmViewApp x = new frmViewApp();
            x.start();

        }

        private void btnViewPat_Click(object sender, EventArgs e)
        {
            frmDltPat dl = new frmDltPat();
            dl.start();
        }

        private void btnDltPat_Click(object sender, EventArgs e)
        {
            frmDltPat d = new frmDltPat();
            d.ShowDialog();
            

        }

        private void btnViewx_Click(object sender, EventArgs e)
        {
            frmAddX sa = new frmAddX();
            sa.startup(1);

        }

        private void btnDltx_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\Xrays");

        }

        private void btnViewPro_Click(object sender, EventArgs e)
        {
            frmViewPro a = new frmViewPro();
            a.ShowDialog();

        }

        private void btnDltPro_Click(object sender, EventArgs e)
        {
            frmViewPro a = new frmViewPro();
            a.start();
        }

        private void btnViewDoc_Click(object sender, EventArgs e)
        {
            frmViewDoc a = new frmViewDoc();
            a.ShowDialog();
        }

        private void btnDltDoc_Click(object sender, EventArgs e)
        {
            frmViewDoc a = new frmViewDoc();
            a.start();
        }

        private void btnConfigData_Click(object sender, EventArgs e)
        {
            frmDataSource s = new frmDataSource();
            s.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 sa = new AboutBox1();
            sa.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            bool b = obj.startLogin();
            if (b == true)
            {
                if (obj.UserType == "admin")
                {
                    btnAbout.Enabled = true;
                    btnAddDoc.Enabled = true;
                    btnAddPat.Enabled = true;
                    btnAddPro.Enabled = true;
                    btnAddx.Enabled = true;
                    
                    btnDltApp.Enabled = true;
                    btnDltDoc.Enabled = true;
                    btnDltPat.Enabled = true;
                    btnDltPro.Enabled = true;
                    btnDltTreat.Enabled = true;
                    btnDltx.Enabled = true;
                    btnIdle.Enabled = true;
                    btnLogout.Enabled = true;


                    btnNewApp.Enabled = true;
                    btnNewTreat.Enabled = true;
                    btnNewUser.Enabled = true;
                    btnProBills.Enabled = true;

                    btnViewApp.Enabled = true;
                    btnViewDoc.Enabled = true;
                    btnViewPat.Enabled = true;
                    btnViewPro.Enabled = true;
                    btnViewTreat.Enabled = true;
                    btnViewx.Enabled = true;
                    btnLogin.Enabled = false;
                    btnViewUser.Enabled = true;
                }
                else
                {
                    btnLogin.Enabled = false;
                    btnViewApp.Enabled = true;
                    btnLogout.Enabled = true;
                    btnViewDoc.Enabled = true;
                    btnViewPat.Enabled = true;
                    btnViewPro.Enabled = true;
                    btnViewTreat.Enabled = true;
                    
                   
                }
            }



        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult s;
            s = MessageBox.Show("Are you sure you want to exit the software?","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (s == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnAddDoc.Enabled = false;
            btnAddPat.Enabled = false;
            btnAddPro.Enabled = false;
            btnAddx.Enabled = false;
            btnDltApp.Enabled = false;
            btnDltDoc.Enabled = false;
            btnDltPat.Enabled = false;
            btnDltPro.Enabled = false;
            btnDltTreat.Enabled = false;
            btnDltx.Enabled = false;
            btnIdle.Enabled = false;
            btnLogout.Enabled = false;
            btnNewApp.Enabled = false;
            btnNewTreat.Enabled = false;
            btnNewUser.Enabled = false;
            btnProBills.Enabled = false;
            btnViewApp.Enabled = false;
            btnViewDoc.Enabled = false;
            btnViewPat.Enabled = false;
            btnViewPro.Enabled = false;
            btnViewTreat.Enabled = false;
            btnViewx.Enabled = false;
            btnLogin.Enabled = true;
            btnViewUser.Enabled = false;
        }

        private void btnDltTreat_Click(object sender, EventArgs e)
        {
            frmViewTreat z = new frmViewTreat();
            z.start();
        }

        private void kryptonRibbonGroupButton4_Click(object sender, EventArgs e)
        {
            frmViewUsers ass=new frmViewUsers();
            ass.ShowDialog();
        }

        private void btnConfigApTh_Click(object sender, EventArgs e)
        {
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAboutDev_Click(object sender, EventArgs e)
        {
            frmAboutDev sf = new frmAboutDev();
            sf.ShowDialog();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            frmHelp sf = new frmHelp();
            sf.ShowDialog();
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }
    }
}