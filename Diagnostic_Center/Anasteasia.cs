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
using Microsoft.Reporting.WinForms;
using System.Globalization;
namespace Diagnostic_Center
{
    public partial class Anasteasia : Form
    {
        connection db=new connection();
        public Anasteasia()
        {
            InitializeComponent();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
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

   

        private void Anasteasia_Load(object sender, EventArgs e)
        {
            try
            {
                header();
                string date = dateTimePicker1.Text;
                string dd = "";
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dd = d.ToString("yyyy/MM/dd");
                string date2 = dateTimePicker2.Text;
                DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd2 = d2.ToString("yyyy/MM/dd");
                // TODO: This line of code loads data into the 'DataSet43.anastasia' table. You can move, or remove it, as needed.
                this.anastasiaTableAdapter.Fill(this.DataSet43.anastasia,dd,dd2);

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
                header();
                string date = dateTimePicker1.Text;
                string dd = "";
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dd = d.ToString("yyyy/MM/dd");
                string date2 = dateTimePicker2.Text;
                DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd2 = d2.ToString("yyyy/MM/dd");
                // TODO: This line of code loads data into the 'DataSet43.anastasia' table. You can move, or remove it, as needed.
                this.anastasiaTableAdapter.Fill(this.DataSet43.anastasia, dd, dd2);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
            }
        }
    }
}
