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
    public partial class frmTreatment : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        int tno, bno, patNo, c1, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, sum = 0;
        string proce = "";
        public frmTreatment()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtAdd.Clear();
            txtAge.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtGName.Clear();
            txtTeeth.Clear();
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "Insert Into addtreat values(@tno,@pname,@teeth,@pro,@dname)";
            tno = CommonFunction.GetNextValue(5);
            cmd.Parameters.AddWithValue("@tno", tno);
            cmd.Parameters.AddWithValue("@pname", txtName.Text);
            cmd.Parameters.AddWithValue("@teeth", txtTeeth.Text);
            cmd.Parameters.AddWithValue("@dname", cbDocName.Text);
            if (rbEight.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text + "," + cmb4.Text + "," + cmb5.Text + "," + cmb6.Text + "," + cmb7.Text + "," + cmb8.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.ValueMember, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.ValueMember, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.ValueMember, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter ed = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb4.ValueMember, Program.con);
                DataTable et = new DataTable();
                ed.Fill(et);
                foreach (DataRow row in et.Rows)
                {

                    c4 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter rd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb5.ValueMember, Program.con);
                DataTable rt = new DataTable();
                rd.Fill(rt);
                foreach (DataRow row in rt.Rows)
                {

                    c5 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter td = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb6.ValueMember, Program.con);
                DataTable tt = new DataTable();
                td.Fill(tt);
                foreach (DataRow row in tt.Rows)
                {

                    c6 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter tad = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb7.ValueMember, Program.con);
                DataTable tat = new DataTable();
                tad.Fill(tat);
                foreach (DataRow row in tat.Rows)
                {

                    c7 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter taad = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb8.ValueMember, Program.con);
                DataTable taat = new DataTable();
                taad.Fill(taat);
                foreach (DataRow row in taat.Rows)
                {

                    c8 = Convert.ToInt32(row[0]);
                }

            }
            else if (rbSeven.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text + "," + cmb4.Text + "," + cmb5.Text + "," + cmb6.Text + "," + cmb7.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.ValueMember, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.ValueMember, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.ValueMember, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter ed = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb4.ValueMember, Program.con);
                DataTable et = new DataTable();
                ed.Fill(et);
                foreach (DataRow row in et.Rows)
                {

                    c4 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter rd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb5.ValueMember, Program.con);
                DataTable rt = new DataTable();
                rd.Fill(rt);
                foreach (DataRow row in rt.Rows)
                {

                    c5 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter td = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb6.ValueMember, Program.con);
                DataTable tt = new DataTable();
                td.Fill(tt);
                foreach (DataRow row in tt.Rows)
                {

                    c6 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter tad = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb7.ValueMember, Program.con);
                DataTable tat = new DataTable();
                tad.Fill(tat);
                foreach (DataRow row in tat.Rows)
                {

                    c7 = Convert.ToInt32(row[0]);
                }
            }
            else if (rbSix.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text + "," + cmb4.Text + "," + cmb5.Text + "," + cmb6.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.ValueMember, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.ValueMember, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.ValueMember, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter ed = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb4.ValueMember, Program.con);
                DataTable et = new DataTable();
                ed.Fill(et);
                foreach (DataRow row in et.Rows)
                {

                    c4 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter rd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb5.ValueMember, Program.con);
                DataTable rt = new DataTable();
                rd.Fill(rt);
                foreach (DataRow row in rt.Rows)
                {

                    c5 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter td = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb6.ValueMember, Program.con);
                DataTable tt = new DataTable();
                td.Fill(tt);
                foreach (DataRow row in tt.Rows)
                {

                    c6 = Convert.ToInt32(row[0]);
                }
            }
            else if (rbFive.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text + "," + cmb4.Text + "," + cmb5.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.ValueMember, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.ValueMember, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.ValueMember, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter ed = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb4.ValueMember, Program.con);
                DataTable et = new DataTable();
                ed.Fill(et);
                foreach (DataRow row in et.Rows)
                {

                    c4 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter rd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb5.ValueMember, Program.con);
                DataTable rt = new DataTable();
                rd.Fill(rt);
                foreach (DataRow row in rt.Rows)
                {

                    c5 = Convert.ToInt32(row[0]);
                }
            }
            else if (rbFour.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text + "," + cmb4.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.ValueMember, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.ValueMember, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.ValueMember, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter ed = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb4.ValueMember, Program.con);
                DataTable et = new DataTable();
                ed.Fill(et);
                foreach (DataRow row in et.Rows)
                {

                    c4 = Convert.ToInt32(row[0]);
                }
            }
            else if (rbThree.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.ValueMember, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.ValueMember, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.ValueMember, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
            }
            else if (rbTwo.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.ValueMember, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.ValueMember, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }

            }
            else
            {
                proce = cmb1.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.ValueMember, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
            }
            cmd.Parameters.AddWithValue("@pro", proce);
            sum = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8;

            cmd.ExecuteNonQuery();

            SqlCommand md = new SqlCommand();
            md.Connection = Program.con;
            md.CommandText = "Insert Into addpat values(@n,@name,@gname,@a,@s,@phn,@add)";
            patNo = CommonFunction.GetNextValue(2);
            md.Parameters.AddWithValue("@n", patNo);
            md.Parameters.AddWithValue("@name", txtName.Text);
            md.Parameters.AddWithValue("@gname", txtGName.Text);
            md.Parameters.AddWithValue("@a", txtAge.Text);
            if (rbMale.Checked == true)
            {
                md.Parameters.AddWithValue("@s", "Male");
            }
            else  
            {
                md.Parameters.AddWithValue("@s", "Female");
            }
            md.Parameters.AddWithValue("@phn", txtPhone.Text);
            md.Parameters.AddWithValue("@add", txtAdd.Text);
            md.ExecuteNonQuery();

            SqlCommand sd = new SqlCommand();
            sd.Connection = Program.con;
            sd.CommandText = "Insert Into bills values(@n,@name,@dname,@a,@s,@phn,@add,@pro,@amnt,@teeth)";
            bno = CommonFunction.GetNextValue(6);
            sd.Parameters.AddWithValue("@n", bno);
            sd.Parameters.AddWithValue("@name", txtName.Text);
            sd.Parameters.AddWithValue("@dname", cbDocName.Text);
            sd.Parameters.AddWithValue("@a", txtAge.Text);
            if (rbMale.Checked == true)
            {
                sd.Parameters.AddWithValue("@s", "Male");
            }
            else  
            {
                sd.Parameters.AddWithValue("@s", "Female");
            }
            sd.Parameters.AddWithValue("@phn", txtPhone.Text);
            sd.Parameters.AddWithValue("@add", txtAdd.Text);
            sd.Parameters.AddWithValue("@pro", proce);
            sd.Parameters.AddWithValue("@amnt", sum);
            sd.Parameters.AddWithValue("@teeth", txtTeeth.Text);
            sd.ExecuteNonQuery();
            MessageBox.Show("Record Saved");
            clear();
            this.Close();
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "Insert Into addtreat values(@tno,@pname,@teeth,@pro,@dname)";
            tno = CommonFunction.GetNextValue(5);
            cmd.Parameters.AddWithValue("@tno", tno);
            cmd.Parameters.AddWithValue("@pname", txtName.Text);
            cmd.Parameters.AddWithValue("@teeth", txtTeeth.Text);
            cmd.Parameters.AddWithValue("@dname", cbDocName.Text);
            if (rbEight.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text + "," + cmb4.Text + "," + cmb5.Text + "," + cmb6.Text + "," + cmb7.Text + "," + cmb8.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.SelectedValue, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.SelectedValue, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.SelectedValue, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter ed = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb4.SelectedValue, Program.con);
                DataTable et = new DataTable();
                ed.Fill(et);
                foreach (DataRow row in et.Rows)
                {

                    c4 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter rd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb5.SelectedValue, Program.con);
                DataTable rt = new DataTable();
                rd.Fill(rt);
                foreach (DataRow row in rt.Rows)
                {

                    c5 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter td = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb6.SelectedValue, Program.con);
                DataTable tt = new DataTable();
                td.Fill(tt);
                foreach (DataRow row in tt.Rows)
                {

                    c6 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter tad = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb7.SelectedValue, Program.con);
                DataTable tat = new DataTable();
                tad.Fill(tat);
                foreach (DataRow row in tat.Rows)
                {

                    c7 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter taad = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb8.SelectedValue, Program.con);
                DataTable taat = new DataTable();
                taad.Fill(taat);
                foreach (DataRow row in taat.Rows)
                {

                    c8 = Convert.ToInt32(row[0]);
                }

            }
            else if (rbSeven.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text + "," + cmb4.Text + "," + cmb5.Text + "," + cmb6.Text + "," + cmb7.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.SelectedValue, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.SelectedValue, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.SelectedValue, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter ed = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb4.SelectedValue, Program.con);
                DataTable et = new DataTable();
                ed.Fill(et);
                foreach (DataRow row in et.Rows)
                {

                    c4 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter rd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb5.SelectedValue, Program.con);
                DataTable rt = new DataTable();
                rd.Fill(rt);
                foreach (DataRow row in rt.Rows)
                {

                    c5 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter td = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb6.SelectedValue, Program.con);
                DataTable tt = new DataTable();
                td.Fill(tt);
                foreach (DataRow row in tt.Rows)
                {

                    c6 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter tad = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb7.SelectedValue, Program.con);
                DataTable tat = new DataTable();
                tad.Fill(tat);
                foreach (DataRow row in tat.Rows)
                {

                    c7 = Convert.ToInt32(row[0]);
                }
            }
            else if (rbSix.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text + "," + cmb4.Text + "," + cmb5.Text + "," + cmb6.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.SelectedValue, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.SelectedValue, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.SelectedValue, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter ed = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb4.SelectedValue, Program.con);
                DataTable et = new DataTable();
                ed.Fill(et);
                foreach (DataRow row in et.Rows)
                {

                    c4 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter rd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb5.SelectedValue, Program.con);
                DataTable rt = new DataTable();
                rd.Fill(rt);
                foreach (DataRow row in rt.Rows)
                {

                    c5 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter td = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb6.SelectedValue, Program.con);
                DataTable tt = new DataTable();
                td.Fill(tt);
                foreach (DataRow row in tt.Rows)
                {

                    c6 = Convert.ToInt32(row[0]);
                }
            }
            else if (rbFive.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text + "," + cmb4.Text + "," + cmb5.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.SelectedValue, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.SelectedValue, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.SelectedValue, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter ed = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb4.SelectedValue, Program.con);
                DataTable et = new DataTable();
                ed.Fill(et);
                foreach (DataRow row in et.Rows)
                {

                    c4 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter rd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb5.SelectedValue, Program.con);
                DataTable rt = new DataTable();
                rd.Fill(rt);
                foreach (DataRow row in rt.Rows)
                {

                    c5 = Convert.ToInt32(row[0]);
                }
            }
            else if (rbFour.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text + "," + cmb4.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.SelectedValue, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.SelectedValue, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.SelectedValue, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter ed = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb4.SelectedValue, Program.con);
                DataTable et = new DataTable();
                ed.Fill(et);
                foreach (DataRow row in et.Rows)
                {

                    c4 = Convert.ToInt32(row[0]);
                }
            }
            else if (rbThree.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text + "," + cmb3.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.SelectedValue, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.SelectedValue, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter wd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb3.SelectedValue, Program.con);
                DataTable wt = new DataTable();
                wd.Fill(wt);
                foreach (DataRow row in wt.Rows)
                {

                    c3 = Convert.ToInt32(row[0]);
                }
            }
            else if (rbTwo.Checked == true)
            {
                proce = cmb1.Text + "," + cmb2.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.SelectedValue, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
                SqlDataAdapter qd = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb2.SelectedValue, Program.con);
                DataTable qt = new DataTable();
                qd.Fill(qt);
                foreach (DataRow row in qt.Rows)
                {

                    c2 = Convert.ToInt32(row[0]);
                }

            }
            else
            {
                proce = cmb1.Text;
                SqlDataAdapter d = new SqlDataAdapter("Select Amount from addpro where SSN=" + cmb1.SelectedValue, Program.con);
                DataTable t = new DataTable();
                d.Fill(t);
                foreach (DataRow row in t.Rows)
                {

                    c1 = Convert.ToInt32(row[0]);
                }
            }
            cmd.Parameters.AddWithValue("@pro", proce);
            sum = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8;

            cmd.ExecuteNonQuery();

            SqlCommand md = new SqlCommand();
            md.Connection = Program.con;
            md.CommandText = "Insert Into addpat values(@n,@name,@gname,@a,@s,@phn,@add)";
            patNo = CommonFunction.GetNextValue(2);
            md.Parameters.AddWithValue("@n", patNo);
            md.Parameters.AddWithValue("@name", txtName.Text);
            md.Parameters.AddWithValue("@gname", txtGName.Text);
            md.Parameters.AddWithValue("@a", txtAge.Text);
            if (rbMale.Checked == true)
            {
                md.Parameters.AddWithValue("@s", "Male");
            }
            else 
            {
                md.Parameters.AddWithValue("@s", "Female");
            }
            md.Parameters.AddWithValue("@phn", txtPhone.Text);
            md.Parameters.AddWithValue("@add", txtAdd.Text);
            md.ExecuteNonQuery();

            SqlCommand sd = new SqlCommand();
            sd.Connection = Program.con;
            sd.CommandText = "Insert Into bills values(@n,@name,@dname,@a,@s,@phn,@add,@pro,@amnt,@teeth)";
            bno = CommonFunction.GetNextValue(6);
            sd.Parameters.AddWithValue("@n", bno);
            sd.Parameters.AddWithValue("@name", txtName.Text);
            sd.Parameters.AddWithValue("@dname", cbDocName.Text);
            sd.Parameters.AddWithValue("@a", txtAge.Text);
            if (rbMale.Checked == true)
            {
                sd.Parameters.AddWithValue("@s", "Male");
            }
            else 
            {
                sd.Parameters.AddWithValue("@s", "Female");
            }
            sd.Parameters.AddWithValue("@phn", txtPhone.Text);
            sd.Parameters.AddWithValue("@add", txtAdd.Text);
            sd.Parameters.AddWithValue("@pro", proce);
            sd.Parameters.AddWithValue("@amnt", sum);
            sd.Parameters.AddWithValue("@teeth", txtTeeth.Text);
            sd.ExecuteNonQuery();
            DialogResult s;
            clear();
            s=MessageBox.Show("Record Saved.Proceeed to bill?","Record Saved",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           
            if (s == DialogResult.Yes)
            {
                string PName = "", DName = "", Psex = "", PPhoneNo = "", PAddress = "", Treatment = "", Teethno = "", PAge = "", Amount = "";


                SqlDataAdapter a = new SqlDataAdapter("Select bills.BillNo,bills.PName,bills.DName,bills.PAge,bills.PSex,bills.PPhoneNo,bills.PAddress,bills.Treatment,bills.Amount,bills.Teethno from bills where bills.BillNo=" + bno, Program.con);
               

                DataTable t = new DataTable();
                a.Fill(t);
                foreach (DataRow row in t.Rows)
                {
                    PAge = row["PAge"].ToString();
                    Amount = row["Amount"].ToString();
                    PName = row["PName"].ToString();
                    DName = row["DName"].ToString();
                    Psex = row["PSex"].ToString();
                    PPhoneNo = row["PPhoneNo"].ToString();
                    PAddress = row["PAddress"].ToString();
                    Treatment = row["Treatment"].ToString();
                    Teethno = row["Teethno"].ToString();
                
                }

               frmPrint sa=new frmPrint();
               sa.start(bno, PAge, Amount, PName, DName, Psex, PPhoneNo, PAddress, Treatment, Teethno);
               this.Close();
            }
           
            
            
            
            
        }
        public int data()
        {
            return bno;
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a = (int)e.KeyChar;
            if (a != 8)
            {
                if (a < 48 || a > 57)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a = (int)e.KeyChar;
            if (a != 8)
            {
                if (a < 48 || a > 57)
                {
                    e.Handled = true;
                }
            }
        }

        private void rbTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTwo.Checked == true)
            {
                cmb2.Enabled = true;
            }
            else
            {
                cmb2.Enabled = false;
            }
        }

        private void rbThree_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThree.Checked == true)
            {

                cmb2.Enabled = true;
                cmb3.Enabled = true;
            }
            else
            {
                cmb2.Enabled = false;
                cmb3.Enabled = false;
            }
        }

        private void rbFour_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFour.Checked == true)
            {
                cmb2.Enabled = true;
                cmb3.Enabled = true;
                cmb4.Enabled = true;
            }
            else
            {
                cmb3.Enabled = false;
                cmb2.Enabled = false;
                cmb4.Enabled = false;
            }
        }

        private void rbFive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFive.Checked == true)
            {
                cmb2.Enabled = true;
                cmb3.Enabled = true;
                cmb4.Enabled = true;
                cmb5.Enabled = true;
            }
            else
            {
                cmb5.Enabled = false;
                cmb4.Enabled = false;
                cmb3.Enabled = false;
                cmb2.Enabled = false;
            }
        }

        private void rbSix_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSix.Checked == true)
            {
                cmb5.Enabled = true;
                cmb4.Enabled = true;
                cmb3.Enabled = true;
                cmb2.Enabled = true;
                cmb6.Enabled = true;
            }
            else
            {
                cmb2.Enabled = false;
                cmb3.Enabled = false;
                cmb4.Enabled = false;
                cmb5.Enabled = false;
                cmb6.Enabled = false;
            }
        }

        private void rbSeven_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSeven.Checked == true)
            {
                cmb6.Enabled = true;
                cmb5.Enabled = true;
                cmb4.Enabled = true;
                cmb3.Enabled = true;
                cmb2.Enabled = true;
                cmb7.Enabled = true;
            }
            else
            {
                cmb7.Enabled = false;
                cmb6.Enabled = false;
                cmb5.Enabled = false;
                cmb4.Enabled = false;
                cmb3.Enabled = false;
                cmb2.Enabled = false;
            }
        }

        private void rbEight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEight.Checked == true)
            {
                cmb8.Enabled = true;
                cmb7.Enabled = true;
                cmb6.Enabled = true;
                cmb5.Enabled = true;
                cmb4.Enabled = true;
                cmb3.Enabled = true;
                cmb2.Enabled = true;
            }
            else
            {
                cmb2.Enabled = false;
                cmb3.Enabled = false;
                cmb4.Enabled = false;
                cmb5.Enabled = false;
                cmb6.Enabled = false;
                cmb7.Enabled = false;
                cmb8.Enabled = false;
            }
        }

        private void frmTreatment_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from adddoc", Program.con);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            cbDocName.DataSource = tb;
            cbDocName.DisplayMember = "DName";
            cbDocName.ValueMember = "SSN";

            SqlDataAdapter ap = new SqlDataAdapter("select * from addpro", Program.con);
            DataTable t = new DataTable();
            ap.Fill(t);
            cmb1.DataSource = t;
            cmb1.DisplayMember = "ProcedureName";
            cmb1.ValueMember = "SSN";
            SqlDataAdapter qqap = new SqlDataAdapter("select * from addpro", Program.con);
            DataTable qqt = new DataTable();
            qqap.Fill(qqt);

            cmb2.DataSource = qqt;
            cmb2.DisplayMember = "ProcedureName";
            cmb2.ValueMember = "SSN";
            SqlDataAdapter qap = new SqlDataAdapter("select * from addpro", Program.con);
            DataTable qt = new DataTable();
            qap.Fill(qt);

            cmb3.DataSource = qt;
            cmb3.DisplayMember = "ProcedureName";
            cmb3.ValueMember = "SSN";
            SqlDataAdapter saap = new SqlDataAdapter("select * from addpro", Program.con);
            DataTable sat = new DataTable();
            saap.Fill(sat);

            cmb4.DataSource = sat;
            cmb4.DisplayMember = "ProcedureName";
            cmb4.ValueMember = "SSN";
            SqlDataAdapter asap = new SqlDataAdapter("select * from addpro", Program.con);
            DataTable ast = new DataTable();
            asap.Fill(ast);

            cmb5.DataSource = ast;
            cmb5.DisplayMember = "ProcedureName";
            cmb5.ValueMember = "SSN";
            SqlDataAdapter ssap = new SqlDataAdapter("select * from addpro", Program.con);
            DataTable sst = new DataTable();
            ssap.Fill(sst);

            cmb6.DataSource = t;
            cmb6.DisplayMember = "ProcedureName";
            cmb6.ValueMember = "SSN";

            SqlDataAdapter sap = new SqlDataAdapter("select * from addpro", Program.con);
            DataTable st = new DataTable();
            sap.Fill(st);

            cmb7.DataSource = st;
            cmb7.DisplayMember = "ProcedureName";
            cmb7.ValueMember = "SSN";
            SqlDataAdapter aap = new SqlDataAdapter("select * from addpro", Program.con);
            DataTable at = new DataTable();
            aap.Fill(at);

            cmb8.DataSource = at;
            cmb8.DisplayMember = "ProcedureName";
            cmb8.ValueMember = "SSN";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                cmb2.Enabled = false;
            }
        }


       

    }
}