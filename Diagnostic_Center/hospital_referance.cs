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
using System.Globalization;
using Microsoft.Reporting.WinForms;
namespace Diagnostic_Center
{
    public partial class hospital_referance : Form
    {
        connection db = new connection();

        public hospital_referance()
        {
            InitializeComponent();
            load_doctor();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }


        void load_doctor()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select name from doctors", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                while (read.Read())
                {
                    String name = read[0].ToString();
                    comboBox1.Items.Add(name);
                }

                db.sql.Close();

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
        private void hospital_referance_Load(object sender, EventArgs e)
        {
            try
            {
                header();
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                string date2 = dateTimePicker2.Text;
                DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd2 = d2.ToString("yyyy/MM/dd");
                // TODO: This line of code loads data into the 'DataSet21.hospital_referance' table. You can move, or remove it, as needed.
                this.hospital_referanceTableAdapter.Fill(this.DataSet21.hospital_referance, comboBox1.Text, dd, dd2);
                this.reportViewer1.RefreshReport();
            }
            catch
            { 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                string date2 = dateTimePicker2.Text;
                DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd2 = d2.ToString("yyyy/MM/dd");
                // TODO: This line of code loads data into the 'DataSet21.hospital_referance' table. You can move, or remove it, as needed.
                this.hospital_referanceTableAdapter.Fill(this.DataSet21.hospital_referance, comboBox1.Text, dd, dd2);
                this.reportViewer1.RefreshReport();
            }
            catch
            { 
            }
        }
    }
}
