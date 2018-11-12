﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace Diagnostic_Center
{
    public partial class Pharmacy_Customer_History : Form
    {
        connection db = new connection();
        public Pharmacy_Customer_History()
        {
            InitializeComponent();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }

        private void Pharmacy_Customer_History_Load(object sender, EventArgs e)
        {
            header();
            string date = dateTimePicker1.Text;
            DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string dd = d.ToString("yyyy/MM/dd");
            string date2 = dateTimePicker2.Text;
            DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string dd2 = d2.ToString("yyyy/MM/dd");
            // TODO: This line of code loads data into the 'DataSet44.medicine_selling_history' table. You can move, or remove it, as needed.
            this.medicine_selling_historyTableAdapter.Fill(this.DataSet44.medicine_selling_history,dd,dd2);

            this.reportViewer1.RefreshReport();
        }

        void account()
        {


            try
            {
                double total = 0;
                double total1 = 0;
                string temp = "";
                double discount = 0;
                double paid = 0;
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                string date2 = dateTimePicker2.Text;
                DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd2 = d2.ToString("yyyy/MM/dd");
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select distinct(inv_id),total from user_cash_collection_pharmacy, medicine_selling_history  where medicine_selling_history.inv_id in(Select distinct(reg_no)from  user_cash_collection_pharmacy where date2 between '" + dd + "' and '" + dd2 + "')", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    temp = read[1].ToString();
                    try
                    {
                        total = Convert.ToDouble(temp);
                    }
                    catch
                    {
                        total = 0;
                    }
                    total1 += total;
                }
                ReportParameterCollection r = new ReportParameterCollection();
                r.Add(new ReportParameter("total", total1.ToString()));


                this.reportViewer1.LocalReport.SetParameters(r);
                db.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        void header()
        {
            try
            {
                account();
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
            header();
            string date = dateTimePicker1.Text;
            DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string dd = d.ToString("yyyy/MM/dd");
            string date2 = dateTimePicker2.Text;
            DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string dd2 = d2.ToString("yyyy/MM/dd");
            // TODO: This line of code loads data into the 'DataSet44.medicine_selling_history' table. You can move, or remove it, as needed.
            this.medicine_selling_historyTableAdapter.Fill(this.DataSet44.medicine_selling_history, dd, dd2);

            this.reportViewer1.RefreshReport();
        }

    }
}