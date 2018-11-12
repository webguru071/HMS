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
    public partial class Admission_receipt_Print : Form
    {
        connection db = new connection();
        int reg = 0;
        string r = "";
        public Admission_receipt_Print(string x)
        {
            InitializeComponent();
            r = x;
            reg = Convert.ToInt32(x);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Admission_receipt_Print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet10.admission' table. You can move, or remove it, as needed.
            this.admissionTableAdapter.Fill(this.DataSet10.admission,reg);
            header();
            // TODO: This line of code loads data into the 'DataSet10.user_cash_collection_hospital' table. You can move, or remove it, as needed.
            this.user_cash_collection_hospitalTableAdapter.Fill(this.DataSet10.user_cash_collection_hospital,r);

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

    }
}
