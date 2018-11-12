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
    public partial class monthly_patient_account : Form
    {
        connection db = new connection();
        public monthly_patient_account()
        {
            InitializeComponent();
             this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
             reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void monthly_patient_account_Load(object sender, EventArgs e)
        {
            header();
            this.reportViewer1.RefreshReport();
            string date = dateTimePicker1.Text;
            DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string dd = d.ToString("yyyy/MM/dd");
            string date2 = dateTimePicker2.Text;
            DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string dd2 = d2.ToString("yyyy/MM/dd");
            // TODO: This line of code loads data into the 'DataSet7.user_cash_collection_hospital' table. You can move, or remove it, as needed.
            this.user_cash_collection_hospitalTableAdapter.Fill(this.DataSet7.user_cash_collection_hospital,dd,dd2);
            // TODO: This line of code loads data into the 'DataSet7.hospital_due_collection' table. You can move, or remove it, as needed.
            this.hospital_due_collectionTableAdapter.Fill(this.DataSet7.hospital_due_collection,dd,dd2);

            ReportParameterCollection r = new ReportParameterCollection();
            r.Add(new ReportParameter("date", date.ToString()));
            r.Add(new ReportParameter("date2", date2.ToString()));

            this.reportViewer1.LocalReport.SetParameters(r);
            this.reportViewer1.RefreshReport();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                header();
                this.reportViewer1.RefreshReport();
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                string date2 = dateTimePicker2.Text;
                DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd2 = d2.ToString("yyyy/MM/dd");
                // TODO: This line of code loads data into the 'DataSet7.user_cash_collection_hospital' table. You can move, or remove it, as needed.
                this.user_cash_collection_hospitalTableAdapter.Fill(this.DataSet7.user_cash_collection_hospital, dd, dd2);
                // TODO: This line of code loads data into the 'DataSet7.hospital_due_collection' table. You can move, or remove it, as needed.
                this.hospital_due_collectionTableAdapter.Fill(this.DataSet7.hospital_due_collection, dd, dd2);

                ReportParameterCollection r = new ReportParameterCollection();
                r.Add(new ReportParameter("date", date.ToString()));
                r.Add(new ReportParameter("date2", date2.ToString()));

                this.reportViewer1.LocalReport.SetParameters(r);
                this.reportViewer1.RefreshReport();
            }
            catch
            { }
        }
    }
}
