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
namespace Diagnostic_Center
{
    public partial class medicine_bill_payment_history : Form
    {
        connection db = new connection();
        string company = "";
        public medicine_bill_payment_history(string x)
        {
            company = x;
            InitializeComponent();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void medicine_bill_payment_history_Load(object sender, EventArgs e)
        {
            header();
            string date = dateTimePicker1.Text;
            string dd = "";
            DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            dd = d.ToString("yyyy/MM/dd");
            string date2 = dateTimePicker2.Text;
            DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            string dd2 = d2.ToString("yyyy/MM/dd");
            // TODO: This line of code loads data into the 'DataSet24.purchase_medicine' table. You can move, or remove it, as needed.
            this.purchase_medicineTableAdapter.Fill(this.DataSet24.purchase_medicine, company, dd, dd2);

            this.reportViewer1.RefreshReport();
        }
        void header()
        {
            try
            {
                string date = dateTimePicker1.Text;
                string dd = "";
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                dd = d.ToString("yyyy/MM/dd");
                string date2 = dateTimePicker2.Text;
                DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                string dd2 = d2.ToString("yyyy/MM/dd");
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
                r.Add(new ReportParameter("company", company.ToString()));
                r.Add(new ReportParameter("date1", date.ToString()));
                r.Add(new ReportParameter("date2", date2.ToString()));
                this.reportViewer1.LocalReport.SetParameters(r);
                db.sql.Close();
            }
            catch
            {

            }
        }
        //date search
        private void button1_Click(object sender, EventArgs e)
        {
            header();
            string date = dateTimePicker1.Text;
            string dd = "";
            DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            dd = d.ToString("yyyy/MM/dd");
            string date2 = dateTimePicker2.Text;
            DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            string dd2 = d2.ToString("yyyy/MM/dd");
            // TODO: This line of code loads data into the 'DataSet24.purchase_medicine' table. You can move, or remove it, as needed.
            this.purchase_medicineTableAdapter.Fill(this.DataSet24.purchase_medicine, company, dd, dd2);

            this.reportViewer1.RefreshReport();
        }
        
    }
}
