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
    public partial class discharge_bill : Form
    {
        connection db = new connection();
        string reg_no = "";
        int  early_paid =0 ;
        int reg=0;
        public discharge_bill(string x,string paid)
        {
            InitializeComponent();
            reg_no = x;
            reg = Convert.ToInt32(x);
            early_paid = Convert.ToInt32(paid);
             reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void discharge_bill_Load(object sender, EventArgs e)
        {
            try
            {
                header();
                // TODO: This line of code loads data into the 'DataSet9.user_cash_collection_hospital' table. You can move, or remove it, as needed.
                this.user_cash_collection_hospitalTableAdapter.Fill(this.DataSet9.user_cash_collection_hospital, reg_no);


                // TODO: This line of code loads data into the 'DataSet9.patient_info' table. You can move, or remove it, as needed.
                this.patient_infoTableAdapter.Fill(this.DataSet9.patient_info, reg);
              
                // TODO: This line of code loads data into the 'DataSet9.patient_bill' table. You can move, or remove it, as needed.
                this.patient_billTableAdapter.Fill(this.DataSet9.patient_bill, reg_no);

                ReportParameterCollection r = new ReportParameterCollection();
                r.Add(new ReportParameter("early_paid", early_paid.ToString()));

                this.reportViewer1.LocalReport.SetParameters(r);
                this.reportViewer1.RefreshReport();
            }
            catch
            { }
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
