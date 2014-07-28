using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using KryptonForm;
using System.Drawing.Imaging;


using ComponentFactory.Krypton.Toolkit;

namespace DentalGood
{
    public partial class frmAddX : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private System.Drawing.Bitmap m_Bitmap;
        private double Zoom = 1.0;
        public frmAddX()
        {
            InitializeComponent();
            m_Bitmap = new Bitmap(2, 2);
        }
        public void startup(int a)
        {
            if (a == 1)
            {
                
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.InitialDirectory = Application.StartupPath + "\\Xrays";
                openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (DialogResult.OK == openFileDialog.ShowDialog())
                {
                    m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);

                    this.AutoScroll = true;
                    this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
                    this.Invalidate();
                    this.ShowDialog();

                }
            }
            else
            {
            }
        }

        
        /*protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }*/
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(m_Bitmap, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y, (int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom)));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);
                
                this.AutoScroll = true;
                this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
                this.Invalidate();
           
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = Application.StartupPath+"\\Xrays\\";
            saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                m_Bitmap.Save(saveFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parameters dlg = new Parameters();
            dlg.nValue = 0;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                if (Filters.Brightness(m_Bitmap, dlg.nValue))
                    this.Invalidate();
                
            }
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parameters dlg = new Parameters();
            dlg.nValue = 0;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                if (Filters.Contrast(m_Bitmap, (sbyte)dlg.nValue))
                    this.Invalidate();
               
            }
        }
    }
}