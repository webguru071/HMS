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
    public partial class Medicine_Paid_History : Form
    {
        connection db = new connection();
            public Medicine_Paid_History()
        {
            InitializeComponent();
            load_company();
            show_all_company_purchase_history();
            show_all_company_payment_history();
        }

            //load company
            void load_company()
            {
                try
                {
                    db.sql.Close();
                    db.sql.Open();
                   
                    comboBox3.Items.Clear();
                    SqlCommand cmd = new SqlCommand("select * from medicine_company order by company_name ASC", db.sql);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                       
                        comboBox3.Items.Add(read[1].ToString());

                    }
                    db.sql.Close();
                }
                catch
                {

                }


            }

            
            private void dataGridView1_Click(object sender, EventArgs e)
            {
                
            }

            private void buttonX1_Click(object sender, EventArgs e)
            {

            }

            private void textBox3_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    double total = Convert.ToDouble(label5.Text);
                    double due = Convert.ToDouble(label10.Text);
                    double pay = Convert.ToDouble(textBox3.Text);
                    double now_due = due - pay;
                    double now_total =pay;

                }
                catch
                { 
                
                }
            }
            
            //pay button click
            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    DialogResult r = MessageBox.Show("Do You want to Pay?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        double p = Convert.ToDouble(textBox3.Text);
                        double du = Convert.ToDouble(label9.Text);
                        if (textBox3.Text == "" || p > du) { MessageBox.Show("Go , Get Some brain !!"); }
                        else
                        {
                            string date = dateTimePicker3.Text;
                            DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            string date2 = d.ToString("yyyy/MM/dd");
                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd = new SqlCommand("insert into paid_purchase(company_name,paid,date,date2) values('" + comboBox3.Text + "','" + textBox3.Text + "','" + date + "','" + date2 + "')", db.sql);
                            int a = cmd.ExecuteNonQuery();
                            if (a > 0)
                            {
                                show_selected_company_purchase_history();
                                calculate_sum();
                                show_selected_company_payment_history();
                                MessageBox.Show("Paid Sucessfull");
                                
                            }
                            db.sql.Close();
                        }
                    }
                    else
                    { 
                    
                    }

                }
                catch
                { 
                
                }
                
            }

            // Company name select
            private void comboBox3_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    if (comboBox3.Text != "")
                    {
                        show_selected_company_purchase_history();
                        calculate_sum();
                        show_selected_company_payment_history();
                    }
                    else { }
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                    label5.Text = "0";
                    label9.Text = "0";
                    label10.Text = "0";
                    show_all_company_purchase_history();
                    show_all_company_payment_history();
                }
            }

            //search by date
            private void Load_Click(object sender, EventArgs e)
            {
                if (comboBox3.Text != "")
                {
                    string date = dateTimePicker1.Text;
                    DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dateone = d.ToString("yyyy/MM/dd");
                    string date2 = dateTimePicker2.Text;
                    DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string datetwo = d2.ToString("yyyy/MM/dd");
                    //1
                    try
                    {
                        db.sql.Close();
                        db.sql.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select * from purchase_medicine where medicine_company='" + comboBox3.Text + "' and date2 between '" + dateone + "' and '" + datetwo + "' ", db.sql);
                        dataGridView1.Rows.Clear();
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        foreach (DataRow item in dt.Rows)
                        {
                            int n = dataGridView1.Rows.Add();
                            dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                            dataGridView1.Rows[n].Cells[1].Value = item[3].ToString();
                            dataGridView1.Rows[n].Cells[2].Value = item[5].ToString();
                            dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();
                            dataGridView1.Rows[n].Cells[4].Value = (Convert.ToDouble(item[5]) * Convert.ToDouble(item[4])).ToString();
                            dataGridView1.Rows[n].Cells[5].Value = item[7].ToString();


                        }
                        db.sql.Close();
                    }
                    catch {
                        show_all_company_purchase_history();
                        show_all_company_payment_history();
                    }

                    //2
                    try
                    {
                        db.sql.Close();
                        db.sql.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select * from paid_purchase where company_name = '" + comboBox3.Text + "' and date2 between '" + dateone + "' and '" + datetwo + "' order by date desc ", db.sql);
                        dataGridView2.Rows.Clear();
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        foreach (DataRow item in dt.Rows)
                        {
                            int n = dataGridView2.Rows.Add();
                            dataGridView2.Rows[n].Cells[0].Value = item[4].ToString();
                            dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                            dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();

                        }
                        db.sql.Close();
                    }
                    catch
                    {
                        show_all_company_purchase_history();
                        show_all_company_payment_history();
                    }


                }
                else {
                    MessageBox.Show("Select Company Name First");
                }
            }

            //selected company purchase
            void show_selected_company_purchase_history() {

                try 
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from purchase_medicine where medicine_company='" + comboBox3.Text + "' ", db.sql);
                    dataGridView1.Rows.Clear();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = (Convert.ToDouble(item[5]) * Convert.ToDouble(item[4])).ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[7].ToString();


                    }
                    db.sql.Close();
                }
                catch { }
            }
            
            //all company purchase
            void show_all_company_purchase_history()
            {

                try
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from purchase_medicine order by date desc ", db.sql);
                    dataGridView1.Rows.Clear();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = (Convert.ToDouble(item[5]) * Convert.ToDouble(item[4])).ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[7].ToString();


                    }
                    db.sql.Close();
                }
                catch { }
            }

            //all company payment
            void show_all_company_payment_history()
            {

                try
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from paid_purchase order by date desc ", db.sql);
                    dataGridView2.Rows.Clear();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView2.Rows.Add();
                        dataGridView2.Rows[n].Cells[0].Value = item[4].ToString();
                        dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();

                    }
                    db.sql.Close();
                }
                catch { }
            }

            //selected company payment
            void show_selected_company_payment_history()
            {

                try
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from paid_purchase where company_name = '"+comboBox3.Text+"' order by date desc ", db.sql);
                    dataGridView2.Rows.Clear();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView2.Rows.Add();
                        dataGridView2.Rows[n].Cells[0].Value = item[4].ToString();
                        dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();

                    }
                    db.sql.Close();
                }
                catch { }
            }

            //calculate sum
            void calculate_sum()
            {
                string total = "0";
                string paid = "0";
                
                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select sum(quantity*buying_price) from purchase_medicine where medicine_company = '" + comboBox3.Text + "'  ", db.sql);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {

                        total = item[0].ToString();

                    }
                    if (total == "" || total == "0")
                    {
                        label5.Text = "0";
                    }
                    else
                    {
                        label5.Text = total;
                    }

                    
                    try
                    {
                        db.sql.Close();
                        db.sql.Open();
                        SqlDataAdapter sdaah = new SqlDataAdapter("select sum(paid) from paid_purchase where company_name = '" + comboBox3.Text + "'  ", db.sql);
                        DataTable ddth = new DataTable();
                        sdaah.Fill(ddth);
                        foreach (DataRow itemmh in ddth.Rows)
                        {

                            paid = itemmh[0].ToString();

                        }
                        label10.Text = paid;
                        label9.Text = (Convert.ToDouble(total) - Convert.ToDouble(paid)).ToString();

                        db.sql.Close();
                    }
                    catch {
                        label10.Text = "0";
                        label9.Text = total;
                    }
                
            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }
            //all button
            private void button2_Click(object sender, EventArgs e)
            {
                show_all_company_purchase_history();
                show_all_company_payment_history();
            }
            
            //print purchase
            private void button3_Click(object sender, EventArgs e)
            {

            }

            //print payment
            private void button4_Click(object sender, EventArgs e)
            {

                try
                {

                    if (comboBox3.Text == "")
                    {
                        MessageBox.Show("Please  Give a Valid Company Name");
                    }
                    else
                    {
                        medicine_bill_payment_history mbph = new medicine_bill_payment_history(comboBox3.Text);
                        mbph.Show();
                    }
                }
                catch
                {
                }
            }

            
    }
}
