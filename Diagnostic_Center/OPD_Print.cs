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
    public partial class OPD_Print : Form
    {
        connection db = new connection();
        string r = "";
        int reg = 0;
        public OPD_Print(string x)
        {
            InitializeComponent();
            r = x;
            reg = Convert.ToInt32(x);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void OPD_Print_Load(object sender, EventArgs e)
        {
            header();
            // TODO: This line of code loads data into the 'DataSet36.user_cash_collection_OPD' table. You can move, or remove it, as needed.
            this.user_cash_collection_OPDTableAdapter.Fill(this.DataSet36.user_cash_collection_OPD,r);
            // TODO: This line of code loads data into the 'DataSet36.opd' table. You can move, or remove it, as needed.
            this.opdTableAdapter.Fill(this.DataSet36.opd,reg);
            // TODO: This line of code loads data into the 'DataSet36.opd_bill' table. You can move, or remove it, as needed.
            this.opd_billTableAdapter.Fill(this.DataSet36.opd_bill,r);
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
