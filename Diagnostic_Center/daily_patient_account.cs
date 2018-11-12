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
using System.Globalization;

namespace Diagnostic_Center
{
    public partial class daily_patient_account : Form
    {
        connection db = new connection();
        //SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public daily_patient_account()
        {
            InitializeComponent();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void daily_patient_account_Load(object sender, EventArgs e)
        {
            header();
            // TODO: This line of code loads data into the 'DataSet6.user_cash_collection_hospital' table. You can move, or remove it, as needed.
            this.user_cash_collection_hospitalTableAdapter.Fill(this.DataSet6.user_cash_collection_hospital,dateTimePicker1.Text);
            // TODO: This line of code loads data into the 'DataSet6.hospital_due_collection' table. You can move, or remove it, as needed.
            this.hospital_due_collectionTableAdapter.Fill(this.DataSet6.hospital_due_collection,dateTimePicker1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                header();
                // TODO: This line of code loads data into the 'DataSet6.user_cash_collection_hospital' table. You can move, or remove it, as needed.
                this.user_cash_collection_hospitalTableAdapter.Fill(this.DataSet6.user_cash_collection_hospital, dateTimePicker1.Text);
                // TODO: This line of code loads data into the 'DataSet6.hospital_due_collection' table. You can move, or remove it, as needed.
                this.hospital_due_collectionTableAdapter.Fill(this.DataSet6.hospital_due_collection, dateTimePicker1.Text);

                this.reportViewer1.RefreshReport();

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


      void hospital_account()
       {
           try
           {
               string date = DateTime.Now.ToString("dd/MM/yyyy");
               DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
               string dd = d.ToString("yyyy/MM/dd");
               db.sql.Open();
               SqlCommand cmd = new SqlCommand("select * from", db.sql);
               db.sql.Close();
           }
           catch
           { 
           
           }
        }
    }
}
