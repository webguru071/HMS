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
    public partial class Prescription : Form
    {
        connection db = new connection();
        string id;
        int re;
        public Prescription(string x)
        {
            InitializeComponent();
            id = x;
            re = Convert.ToInt32(x);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            var setup = this.reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.reportViewer1.SetPageSettings(setup);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

       
        private void Prescription_Load(object sender, EventArgs e)
        {
            try
            {
                header();
                // TODO: This line of code loads data into the 'DataSet22.prescription' table. You can move, or remove it, as needed.
                this.prescriptionTableAdapter.Fill(this.DataSet22.prescription, id);
                // TODO: This line of code loads data into the 'DataSet22.appointment' table. You can move, or remove it, as needed.
                this.appointmentTableAdapter.Fill(this.DataSet22.appointment, re);
                // TODO: This line of code loads data into the 'DataSet22.diagnosis' table. You can move, or remove it, as needed.
                this.diagnosisTableAdapter.Fill(this.DataSet22.diagnosis, id);
                // TODO: This line of code loads data into the 'DataSet22.patient_test' table. You can move, or remove it, as needed.
                this.patient_testTableAdapter.Fill(this.DataSet22.patient_test, id);
                // TODO: This line of code loads data into the 'DataSet22.symptoms' table. You can move, or remove it, as needed.
                this.symptomsTableAdapter.Fill(this.DataSet22.symptoms, re);


                string advice = "not found";
                string days = "";
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from advice where reg_no='" + id + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    advice = read[1].ToString();

                    days = read[2].ToString();
                }

                ReportParameterCollection r = new ReportParameterCollection();
                r.Add(new ReportParameter("advice", advice));
                r.Add(new ReportParameter("days", days));
                this.reportViewer1.LocalReport.SetParameters(r);
                this.reportViewer1.RefreshReport();

                db.sql.Close();
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
    }
}
