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
    public partial class take_bill : Form
    {
        connection db = new connection();
       // SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public take_bill()
        {
            InitializeComponent();
            current_patient();
        }
        void current_patient()
        {

            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from admission", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[8].ToString();
                }
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                richTextBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            { 
            
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string name = "";
                string date = "";
                string bt = "";
                string cost = "";
                // string fees = "";

                db.sql.Close();
                db.sql.Open();

                SqlCommand cmd = new SqlCommand("select date,room,price from admission where reg_no='" + richTextBox1.Text + "'", db.sql);
               SqlDataReader r = cmd.ExecuteReader();
               while (r.Read())
               {

                   
                   date = r[0].ToString();
                
                   bt = r[1].ToString();
                   cost =r[2].ToString();
               }
               label89.Text = date;
             
               label91.Text = cost.ToString();
               label92.Text = bt;
               string x = label89.Text;

               DateTime admit = DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture);


               DateTime today = DateTime.ParseExact(dateTimePicker1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
               var totaldays = (today - admit).TotalDays;
               if (totaldays == 0)
               {
                   richTextBox25.Text = "1";
               }
               else
               {
                   richTextBox25.Text = totaldays.ToString();
               }

               db.sql.Close();
            }
            catch
            {
                label94.Text = "0";
                label96.Text = "0";
                label95.Text = "0";
                richTextBox25.Text = "";
            }
            show_operation_bill();
        }

        private void richTextBox25_TextChanged(object sender, EventArgs e)
        {
            bill_calculate();
        }
        void bill_calculate()
        {
            int paid = 0;
            int due = 0;
            try
            {

                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select sum(amount) from bed_bill where reg_no='" + richTextBox1.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    paid = Convert.ToInt32(read[0].ToString());

                }
                label95.Text = paid.ToString();
                db.sql.Close();
            }
            catch
            {
                label95.Text = "0";
            }
            try
            {


                int day = Convert.ToInt32(richTextBox25.Text);
                int cost = Convert.ToInt32(label91.Text);
                int t_paid = Convert.ToInt32(label95.Text);
                int total = day * cost;
                due = total - t_paid;
                label94.Text = total.ToString();
                label96.Text = due.ToString();
                if (label96.Text == "0")
                {
                    button14.Enabled = false;
                }
                else
                {
                    button14.Enabled = true;
                }

            }
            catch
            {
                label94.Text = "0";
                label96.Text = "0";
            }
        
        }
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                string date = DateTime.Now.ToString("dd/MM/yyyy");
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                if (richTextBox26.Text == "")
                {
                    MessageBox.Show("Give an Amount");
                }
                else
                { 
                 DialogResult r = MessageBox.Show("Did you get the Bill.?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (r == DialogResult.Yes)
                 {
                     int total = Convert.ToInt32(label94.Text);
                     int paid = Convert.ToInt32(label95.Text);
                     int cdue = Convert.ToInt32(label96.Text);
                     int pay = Convert.ToInt32(richTextBox26.Text);
                     int total_paid = paid + pay;
                     int due = total - total_paid;
                     int days = Convert.ToInt32(richTextBox25.Text);
                     if (pay > cdue)
                     {
                         MessageBox.Show("Paying amount can not be larger than Due amount");
                     }
                     else
                     {
                         db.sql.Close();
                         db.sql.Open();
                         SqlCommand cmd = new SqlCommand("insert into bed_bill(reg_no,amount,date,date2)values('" + richTextBox1.Text + "','" + richTextBox26.Text + "','" + date + "','" + dd + "')", db.sql);
                         int a = cmd.ExecuteNonQuery();
                         if (a > 0)
                         {
                             MessageBox.Show("Bill Taken Sucessfully");
                             bill_calculate();
                         }
                         db.sql.Close();
                     
                     }

                 }
                }
            }
            catch
            { 
            
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {

                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Please  Give a Valid Registration Number");
                }
                else
                {
                    DialogResult r = MessageBox.Show("Did you get the amount?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (richTextBox3.Text == "")
                        {
                            MessageBox.Show("Give a valid amount");
                        }
                        else
                        {
                            string date = dateTimePicker2.Text;
                            DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            string dd = d.ToString("yyyy/MM/dd");
                            db.sql.Close();
                            db.sql.Open();
                            int total = Convert.ToInt32(richTextBox28.Text);


                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd2 = new SqlCommand("insert into operation(reg_no,total_bill,paid,date,date2)values('" + richTextBox1.Text + "','" + total + "','" + richTextBox3.Text + "','" + date + "','" + dd + "')", db.sql);
                            int a = cmd2.ExecuteNonQuery();
                            if (a > 0)
                            {
                                MessageBox.Show("Paid Sucessfull");

                            }

                            db.sql.Close();
                        }
                    }
                }
            }
            catch
            {

            }
        }
        void show_operation_bill()
        {

            try
            {
                int c = 0;
                string x = "";
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select total_bill from operation where reg_no='" + richTextBox1.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    x = read[0].ToString();
                    c++;
                }
                if (c > 0)
                {
                    richTextBox28.Text = x;
                }
                else
                {
                    richTextBox28.Clear();
                }
                db.sql.Close();
            }

            catch
            {
                richTextBox28.Clear();
            }
        }
    }
}
