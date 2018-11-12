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
    public partial class Form3 : Form
    {
        int id;
        double amount;
        double paid;
        double total = 0;
        string Date;
        double paid2 = 0;
        double due2 = 0;
        connection db = new connection();
      //  SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public Form3()
        {
            InitializeComponent();
            show();
        }






        void show()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select id,name,contact,date,total,discount,discount_total,paid,due from diagnostic_person,paid_and_due where diagnostic_person.id=paid_and_due.invoice_no and paid_and_due.paid_date='0'", db.sql);
                DataTable dt = new DataTable();
                dataGridViewX1.Rows.Clear();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();

                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridViewX1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridViewX1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridViewX1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridViewX1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridViewX1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridViewX1.Rows[n].Cells[8].Value = item[8].ToString();

                }
            }
            catch
            { 
            
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(richTextBox1.Text);
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select id,name,contact,date,total,discount,discount_total,paid,due from diagnostic_person,paid_and_due where diagnostic_person.id=paid_and_due.invoice_no and paid_and_due.paid_date='0' and diagnostic_person.id='" + id + "'", db.sql);
                DataTable dt = new DataTable();
                dataGridViewX1.Rows.Clear();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();

                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridViewX1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridViewX1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridViewX1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridViewX1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridViewX1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridViewX1.Rows[n].Cells[8].Value = item[8].ToString();

                }


                db.sql.Close();
            }
            catch
            {
                try
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select id,name,contact,date,total,discount,discount_total,paid,due from diagnostic_person,paid_and_due where diagnostic_person.id=paid_and_due.invoice_no and paid_and_due.paid_date='0' and diagnostic_person.name like'%" + richTextBox1.Text + "%'", db.sql);
                    DataTable dt = new DataTable();
                    dataGridViewX1.Rows.Clear();
                    sda.Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridViewX1.Rows.Add();

                        dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridViewX1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridViewX1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridViewX1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridViewX1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridViewX1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridViewX1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridViewX1.Rows[n].Cells[8].Value = item[8].ToString();

                    }


                    db.sql.Close();
                }
                catch
                { 
                
                }
            }
        }

        private void dataGridViewX1_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
                amount = Convert.ToDouble(dataGridViewX1.SelectedRows[0].Cells[8].Value.ToString());
                paid = Convert.ToDouble(dataGridViewX1.SelectedRows[0].Cells[7].Value.ToString());
                total = Convert.ToDouble(dataGridViewX1.SelectedRows[0].Cells[6].Value.ToString());
                paid2 = Convert.ToDouble(dataGridViewX1.SelectedRows[0].Cells[7].Value.ToString());
                due2 = Convert.ToDouble(dataGridViewX1.SelectedRows[0].Cells[8].Value.ToString());
                Date = dataGridViewX1.SelectedRows[0].Cells[3].Value.ToString();
                label2.Text = id.ToString();
                label3.Text = amount.ToString();
            }

            catch
            { 
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "")
            {

                MessageBox.Show("Select  an Id  first...");
            }
            else
            {
               try
                {
                    double unpaid_paid = Convert.ToDouble(richTextBox2.Text);
                   double  total_paid = unpaid_paid + paid;
                   double x = 0;
                   double discount=total - total_paid;;
                    string date = DateTime.Now.ToShortDateString();
                    DateTime d = DateTime.ParseExact(date, "M/d/yyyy", CultureInfo.InvariantCulture);
                    string dd = d.ToString("dd/MM/yyyy");
                    string dd2 = d.ToString("yyyy/MM/dd");
                    if (Date == dd)
                    {
                        paid2 = total_paid;
                        due2 = 0;
                    }
                    DialogResult r = MessageBox.Show("Did You Get The Unpaid Amount Confirm Please", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        try
                        {

                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd = new SqlCommand("update paid_and_due set paid='" + paid2 + "',due='" + due2 + "', less='" + discount + "',paid_date='" + dd + "' where invoice_no='" + id + "'", db.sql);
                            SqlCommand cmd4 = new SqlCommand("update due_collection set due_paid='" + unpaid_paid + "',discount2='" + label7.Text + "',paid_date='" + dd + "',date2='" + dd2 + "' where reg_no='" + id + "'", db.sql);
                            int a=cmd.ExecuteNonQuery();
                            cmd4.ExecuteNonQuery();
                            db.sql.Close();
                            show();
                            if (a > 0)
                            {
                                MessageBox.Show("Paid Successfully....");
                                diagnostic_bill dbb = new diagnostic_bill(label2.Text);
                                dbb.Show();
                            }
                        }
                        catch { 
                        
                        }
                    }


                    else
                    {

                    }
                }
               catch
                { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                diagnostic_bill db = new diagnostic_bill(label2.Text);
                db.Show();
            }
            catch
            { 
            
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double pay=Convert.ToDouble(richTextBox2.Text);
                double due=Convert.ToDouble(label3.Text);
                double dis2=due-pay;

                label7.Text = dis2.ToString();

            }

            catch
            {
                label7.Text = "0";
            }
        }
    }
}
