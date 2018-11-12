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
    public partial class daily_reference : Form
    {
        connection db = new connection();
        public daily_reference()
        {
            InitializeComponent();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void daily_reference_Load(object sender, EventArgs e)
        {
            try
            {
                header();
                // TODO: This line of code loads data into the 'DataSet11.referance' table. You can move, or remove it, as needed.
                this.referanceTableAdapter.Fill(this.DataSet11.referance, dateTimePicker1.Text);
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
                string name = "Unknown";
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DataSet11.referance' table. You can move, or remove it, as needed.
                this.referanceTableAdapter.Fill(this.DataSet11.referance, dateTimePicker1.Text);
                this.reportViewer1.RefreshReport();
            }
            catch
            { 
            
            }
        }
    }
}
