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
    public partial class token : Form
    {
        string reg_no = "";
        connection db = new connection();
        public token(string r)
        {
            
        
            InitializeComponent();
            reg_no = r;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void token_Load(object sender, EventArgs e)
        {
            header();
            string name = "notfound";
            string date = "notfound";
            string doctor = "notfound";
            string fees = "notfound";
            string address = "notfound";
            string age = "notfound";
            string sex = "notfound";
            string weight = "notfound";
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from appointment where reg_no='" + reg_no + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    name = read[1].ToString();
                    date = read[6].ToString();
                    doctor = read[7].ToString();
                    fees = read[8].ToString();
                    address = read[2].ToString();
                    age = read[3].ToString();
                    sex = read[4].ToString();
                    weight = read[9].ToString();

                }
            }
            catch
            {
            }
            ReportParameterCollection r = new ReportParameterCollection();
            r.Add(new ReportParameter("reg_no", reg_no));
            r.Add(new ReportParameter("name", name));
            r.Add(new ReportParameter("doctor", doctor));
            r.Add(new ReportParameter("date", date));
            r.Add(new ReportParameter("fees", fees));
            r.Add(new ReportParameter("address", address));
            r.Add(new ReportParameter("age", age));
            r.Add(new ReportParameter("sex", sex));
            r.Add(new ReportParameter("weight", weight));
            this.reportViewer1.LocalReport.SetParameters(r);
            db.sql.Close();
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
                r.Add(new ReportParameter("name2", name.ToString()));
                r.Add(new ReportParameter("address2", address.ToString()));
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
