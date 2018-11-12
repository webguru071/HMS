﻿using Microsoft.Reporting.WinForms;
using System;
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

namespace Diagnostic_Center
{
    public partial class month : Form
    {
        double due_paid = 0;
        double total = 0;
        double discount2 = 0;
        connection db = new connection();
        //SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public month()
        {
            InitializeComponent();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            profit();
            header();
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
        private void Load_Click(object sender, EventArgs e)
        {
            header();
            profit();
            try
            {
                this.reportViewer1.RefreshReport();
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                string date2 = dateTimePicker2.Text;
                DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd2 = d2.ToString("yyyy/MM/dd");
                // TODO: This line of code loads data into the 'DataSet3.paid_and_due' table. You can move, or remove it, as needed.
                this.paid_and_dueTableAdapter.Fill(this.DataSet3.paid_and_due, dd, dd2);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void profit()
        {
            string dd = "";
            string dd2 = "";
            try
            {
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dd = d.ToString("yyyy/MM/dd");
                string date2 = dateTimePicker2.Text;
                DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                 dd2 = d2.ToString("yyyy/MM/dd");
            }
            catch
            { 
            }
            double paid = 0;
            double expense = 0;
            double profit = 0;
            try
            {
                db.sql.Close();
                db.sql.Open();

                SqlCommand cmd = new SqlCommand(@"SELECT sum(paid) FROM dbo.paid_and_due,diagnostic_person
where  paid_and_due.invoice_no=diagnostic_person.id and diagnostic_person.date2 between '" + dd + "' and '" + dd2 + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {


                    paid = Convert.ToDouble(read[0].ToString());
                }

                db.sql.Close();
            }
            catch
            {

            }

            try
            {
                db.sql.Close();
                db.sql.Open();

                SqlCommand cmd = new SqlCommand("select sum(amount) from expense where date between '" + dd + "' and '" + dd2 + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    expense = Convert.ToDouble(read[0].ToString());
                }

                db.sql.Close();
            }
            catch
            {

            }



            try
            {

                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select sum(due_paid),sum(discount2) from due_collection where date2 between '" + dd + "' and '" + dd2 + "' and test_date !=paid_date", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    due_paid = Convert.ToDouble(read[0].ToString());
                    discount2 = Convert.ToDouble(read[1].ToString());
                }
            }
            catch
            {

            }


            total = paid + due_paid;
            profit = total - expense;

          
            ReportParameterCollection r = new ReportParameterCollection();
            r.Add(new ReportParameter("paid", paid.ToString()));
            r.Add(new ReportParameter("expense", expense.ToString()));
            r.Add(new ReportParameter("due_paid", due_paid.ToString()));
            r.Add(new ReportParameter("discount2", discount2.ToString()));
            r.Add(new ReportParameter("total", total.ToString()));
            r.Add(new ReportParameter("profit", profit.ToString()));
            this.reportViewer1.LocalReport.SetParameters(r);
            this.reportViewer1.RefreshReport();
        }

        private void month_Load(object sender, EventArgs e)
        {
            header();
        }
       
    }
}