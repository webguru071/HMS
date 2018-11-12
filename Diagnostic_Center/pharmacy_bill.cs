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
    public partial class pharmacy_bill : Form
    {
        connection db = new connection();
        string reg = "";
        int regg = 0;
        public pharmacy_bill(string x)
        {
            InitializeComponent();
            reg = x;
            regg = Convert.ToInt32(x);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void pharmacy_bill_Load(object sender, EventArgs e)
        {
            try
            {
                header();
                // TODO: This line of code loads data into the 'DataSet15.user_cash_collection_pharmacy' table. You can move, or remove it, as needed.
                this.user_cash_collection_pharmacyTableAdapter.Fill(this.DataSet15.user_cash_collection_pharmacy, reg);
                // TODO: This line of code loads data into the 'DataSet15.medicine_selling_history' table. You can move, or remove it, as needed.
                this.medicine_selling_historyTableAdapter.Fill(this.DataSet15.medicine_selling_history, reg);
                // TODO: This line of code loads data into the 'DataSet15.medicine_sells' table. You can move, or remove it, as needed.
                this.medicine_sellsTableAdapter.Fill(this.DataSet15.medicine_sells, regg);

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
