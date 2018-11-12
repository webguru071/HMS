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
    public partial class Daily_userc_cash_collection_summarry : Form
    {
        connection db = new connection();
        string user = "";
        string pass = "";
        public Daily_userc_cash_collection_summarry(string x, string y)
        {
            InitializeComponent();
            user = x;
            pass = y;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Daily_userc_cash_collection_summarry_Load(object sender, EventArgs e)
        {
          
            header();
            ReportParameterCollection r = new ReportParameterCollection();
            r.Add(new ReportParameter("user", user.ToString()));

            this.reportViewer1.LocalReport.SetParameters(r);
            // TODO: This line of code loads data into the 'DataSet17.user_cash_collection' table. You can move, or remove it, as needed.
            this.user_cash_collectionTableAdapter.Fill(this.DataSet17.user_cash_collection, user, pass, dateTimePicker1.Text);
            // TODO: This line of code loads data into the 'DataSet17.user_cash_collection_hospital' table. You can move, or remove it, as needed.
            this.user_cash_collection_hospitalTableAdapter.Fill(this.DataSet17.user_cash_collection_hospital, user, pass, dateTimePicker1.Text);
            // TODO: This line of code loads data into the 'DataSet17.user_cash_collection_OPD' table. You can move, or remove it, as needed.
            this.user_cash_collection_OPDTableAdapter.Fill(this.DataSet17.user_cash_collection_OPD, user, pass, dateTimePicker1.Text);
            // TODO: This line of code loads data into the 'DataSet17.user_cash_collection_pharmacy' table. You can move, or remove it, as needed.
            this.user_cash_collection_pharmacyTableAdapter.Fill(this.DataSet17.user_cash_collection_pharmacy, user, pass, dateTimePicker1.Text);
            // TODO: This line of code loads data into the 'DataSet17.hospital_due_collection' table. You can move, or remove it, as needed.
            this.hospital_due_collectionTableAdapter.Fill(this.DataSet17.hospital_due_collection, user, pass, dateTimePicker1.Text);
            // TODO: This line of code loads data into the 'DataSet17.opd_due_collection' table. You can move, or remove it, as needed.
            this.opd_due_collectionTableAdapter.Fill(this.DataSet17.opd_due_collection, user, pass, dateTimePicker1.Text);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            header();
            ReportParameterCollection r = new ReportParameterCollection();
            r.Add(new ReportParameter("user", user.ToString()));

            this.reportViewer1.LocalReport.SetParameters(r);
            // TODO: This line of code loads data into the 'DataSet17.user_cash_collection' table. You can move, or remove it, as needed.
            this.user_cash_collectionTableAdapter.Fill(this.DataSet17.user_cash_collection, user, pass, dateTimePicker1.Text);
            // TODO: This line of code loads data into the 'DataSet17.user_cash_collection_hospital' table. You can move, or remove it, as needed.
            this.user_cash_collection_hospitalTableAdapter.Fill(this.DataSet17.user_cash_collection_hospital, user, pass, dateTimePicker1.Text);
            // TODO: This line of code loads data into the 'DataSet17.user_cash_collection_OPD' table. You can move, or remove it, as needed.
            this.user_cash_collection_OPDTableAdapter.Fill(this.DataSet17.user_cash_collection_OPD, user, pass, dateTimePicker1.Text);
            // TODO: This line of code loads data into the 'DataSet17.user_cash_collection_pharmacy' table. You can move, or remove it, as needed.
            this.user_cash_collection_pharmacyTableAdapter.Fill(this.DataSet17.user_cash_collection_pharmacy, user, pass, dateTimePicker1.Text);
            // TODO: This line of code loads data into the 'DataSet17.hospital_due_collection' table. You can move, or remove it, as needed.
            this.hospital_due_collectionTableAdapter.Fill(this.DataSet17.hospital_due_collection, user, pass, dateTimePicker1.Text);
            // TODO: This line of code loads data into the 'DataSet17.opd_due_collection' table. You can move, or remove it, as needed.
            this.opd_due_collectionTableAdapter.Fill(this.DataSet17.opd_due_collection, user, pass, dateTimePicker1.Text);
            this.reportViewer1.RefreshReport();
        }

    }
}
