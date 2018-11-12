using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Diagnostic_Center
{
    public partial class print_report : Form
    {
        connection db = new connection();
        int re = 0;
        public print_report(string x)
        {
            InitializeComponent();
            re = Convert.ToInt32(x);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 120;
            pathologist();
        }

        private void print_report_Load(object sender, EventArgs e)
        {
            try
            {
                header();
                // TODO: This line of code loads data into the 'DataSet28.test_result' table. You can move, or remove it, as needed.
                this.test_resultTableAdapter.Fill(this.DataSet28.test_result, re);
                // TODO: This line of code loads data into the 'DataSet28.diagnostic_person' table. You can move, or remove it, as needed.
                this.diagnostic_personTableAdapter.Fill(this.DataSet28.diagnostic_person, re);

                this.reportViewer1.RefreshReport();
            }
            catch
            { 
            
            }
        }

        void header()
        {
            try
            {
                string name = "";
                string address = "";
                string phone = "";
                string mobile = "";
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from print_head", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    name = read[1].ToString();
                    address = read[2].ToString();
                    phone = read[3].ToString();
                    mobile = read[4].ToString();

                }
                ReportParameterCollection r = new ReportParameterCollection();
                r.Add(new ReportParameter("name", name.ToString()));
                r.Add(new ReportParameter("address", address.ToString()));
                r.Add(new ReportParameter("phone", phone.ToString()));
                r.Add(new ReportParameter("mobile", mobile.ToString()));


                this.reportViewer1.LocalReport.SetParameters(r);
                db.sql.Close();
            }
            catch
            {

            }
        }

        void pathologist()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from pathologist",db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    comboBox1.Items.Add(read[1].ToString());
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string name = "";
                string designation = "";
                try
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("select * from pathologist where pathologist='"+comboBox1.Text+"'", db.sql);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        name = read[1].ToString();
                        designation = read[2].ToString();
                    }
                    db.sql.Close();
                }
                catch
                {

                }
                ReportParameterCollection r = new ReportParameterCollection();
                r.Add(new ReportParameter("pathologist", name.ToString()));
                r.Add(new ReportParameter("designation", designation.ToString()));
                this.reportViewer1.LocalReport.SetParameters(r);
                db.sql.Close();
            }
            catch
            { 
            
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
