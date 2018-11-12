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
    public partial class discharge : Form
    {
        connection db = new connection();
       // SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        string bill_title = "";
        string bill = "";
        string bill_id = "";
        string select_delete = "";
        public discharge()
        {
            InitializeComponent();
            show_bill_list();
            refere_doctor();
        }

        void show_bill_list()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from bill_list", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                   
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("insert into patient_bill(reg_no,bill_title,bill,bill_id)values('" + richTextBox1.Text + "','" + bill_title + "','" + bill + "','" + bill_id + "')", db.sql);
                int a=cmd.ExecuteNonQuery();
                
                show_bill();
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                bill_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                bill_title = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                bill = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch
            { 
            
            }
        }
        void show_bill()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from patient_bill where reg_no='" + richTextBox1.Text + "'", db.sql);
                dataGridView2.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item[2].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = item[3].ToString();
                }
                db.sql.Close();
            }
           catch
            { 
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();

                db.sql.Open();

                SqlCommand cmd = new SqlCommand("delete from patient_bill where reg_no='" + richTextBox1.Text + "' and bill_id='" + select_delete + "'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Delete Sucessfull");
                    show_bill();
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
                select_delete = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch
            { 
            
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from patient_histroy where reg_no='" + richTextBox1.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    richTextBox2.Text = read[1].ToString();



                }
                db.sql.Close();
               
               
            }
            catch
            { 
            
            }
            show_bill();
            bed_bill();
            show_operation_bill();
            diagnostic_bill();
            total_cash_paid();
            
            if (richTextBox1.Text == "")
            {
                label23.Text = "0";
                label20.Text = "0";
                label18.Text = "0";
            }
        }


        void bed_bill()
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

                SqlCommand cmd = new SqlCommand("select date,room,price from patient_histroy where reg_no='" + richTextBox1.Text + "'", db.sql);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {


                    date = r[0].ToString();

                    bt = r[1].ToString();
                    cost = r[2].ToString();
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
        }
        void refere_doctor()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select name from doctors", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                while (read.Read())
                {
                    String name = read[0].ToString();
                    comboBox1.Items.Add(name);
                }

                db.sql.Close();
            }

            catch
            {


            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                int sum = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
                }
                label13.Text = sum.ToString();
                label22.Text = sum.ToString();
            }
            catch
            { 
            
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int exe = 0;
                int id = 0; ;
                string val1 = "";
                string val2 = "";
                string val3 = "";
                string val4 = "";
                int n = 0;
                int c = dataGridView2.Rows.Count;
                db.sql.Close();
                db.sql.Open();
                for (n = 0; n <= c - 1; n++)
                {
                  
                    val3 = dataGridView2.Rows[n].Cells[2].Value.ToString();
                    val4 = dataGridView2.Rows[n].Cells[3].Value.ToString();

                    SqlCommand cmd = new SqlCommand("update patient_bill set bill='" + val3 + "' where reg_no='" + richTextBox1.Text + "' and bill_id='" + val4 + "'", db.sql);
                    exe = cmd.ExecuteNonQuery();

                }
                db.sql.Close();
            }
            catch
            { 
            
            }

            try
            {
               int aa = Convert.ToInt32(label15.Text);
               int b = Convert.ToInt32(richTextBox5.Text);

               if (richTextBox5.Text == "")
               {
                   MessageBox.Show("Give a valid amount");
               }
               else
               {

                   if (b != aa)
                   {
                       MessageBox.Show("You have to pay the current due amount");
                   }
                   else
                   {   
                       string date = dateTimePicker1.Text;
                       DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                       string dd = d.ToString("yyyy/MM/dd");
                       db.sql.Close();
                       db.sql.Open();
                       SqlCommand cmd2 = new SqlCommand("delete from discharge_bill where reg_no='" + richTextBox1.Text + "'", db.sql);
                       cmd2.ExecuteNonQuery();
                       db.sql.Close();
                       db.sql.Open();
                       SqlCommand cmd = new SqlCommand("insert into discharge_bill(reg_no,total,discount,paid,date,date2)values('" + richTextBox1.Text + "','" + label13.Text + "','" + richTextBox9.Text + "','" + richTextBox5.Text + "','" + date + "','" + dd + "')", db.sql);
                       int a = cmd.ExecuteNonQuery();
                       if (a > 0)
                       {
                           MessageBox.Show("Bill taken Sucessfully");
                           discharge_bill dbb = new discharge_bill(richTextBox1.Text, label8.Text);
                           dbb.Show();
                       }
                       else
                       {
                           MessageBox.Show("Not Paid");
                       }
                       db.sql.Close();
                   }
               }
            }
            catch
            { 
            
            }
        }

        private void richTextBox25_TextChanged(object sender, EventArgs e)
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
                   
                }
                else
                {
                    
                }

            }
            catch
            {
                label94.Text = "0";
                label96.Text = "0";
            }
        
        }

        void show_operation_bill()
        {
           
            int c = 0;
            string y = "0";
            try
            {



                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select sum(paid) from operation where reg_no='" + richTextBox1.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                   
                    y = read[0].ToString();
                    c++;
                }

                if (y == "")
                {
                    label6.Text ="0";
                }
                else
                {
                 
                    label6.Text = y;
                }




                db.sql.Close();
            }
                 
            catch
            {
                label6.Text = "0";
            }
            
            try
            {


                string x = "0";
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
                    label5.Text = x;
                   
                }
                else
                {
                  
                    label5.Text = "0";
                }
                db.sql.Close();
            }

            catch
            {
                label5.Text = "0";
            }
        }
        void total_cash_paid()
        {
            try
            {
                int bed = Convert.ToInt32(label95.Text);
                int operation = Convert.ToInt32(label6.Text);
                int diagnostic = Convert.ToInt32(label20.Text);
               
                int total = bed + operation+diagnostic;
                label8.Text = total.ToString();
                label10.Text = total.ToString();
            }
            catch
            {
                label8.Text = "0";
                label10.Text = "0";
            }
        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                int b = 0;
                int c = 0;
                int y = 0;
                int x = 0;
                int due = 0;
                a = Convert.ToInt32(label13.Text);
                b = Convert.ToInt32(richTextBox9.Text);
                c = a - b;
                label22.Text = c.ToString();
                x = Convert.ToInt32(label22.Text);
                y = Convert.ToInt32(label10.Text);
                due = x - y;
                label15.Text = due.ToString();
               

            }
            catch
            {

            }
        }

        private void label22_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                int b = 0;
                int c = 0;
                int y = 0;
                int x = 0;
                int due = 0;
                a = Convert.ToInt32(label13.Text);
                b = Convert.ToInt32(richTextBox9.Text);
                c = a - b;
                label22.Text = c.ToString();
                x = Convert.ToInt32(label22.Text);
                y = Convert.ToInt32(label10.Text);
                due = x - y;
                label15.Text = due.ToString();


            }
            catch
            {

            }
        }

        //**************************
        void diagnostic_bill()
        {
            int total = 0;
            int paid = 0;
            int due = 0;
            int due_paid = 0;
            int less = 0;
            int net_bill = 0;
            int net_paid = 0;
            int  net_due=0;
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select sum(discount_total),sum(paid),sum(less) from paid_and_due,diagnostic_person where paid_and_due.invoice_no=diagnostic_person.id and diagnostic_person.others_id='" + richTextBox1.Text + "' ", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    total = Convert.ToInt32(read[0]);
                    paid = Convert.ToInt32(read[1]);
                    less = Convert.ToInt32(read[2]);
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
                SqlCommand cmd1 = new SqlCommand("select sum(due),sum(due_paid) from due_collection,diagnostic_person where due_collection.reg_no=diagnostic_person.id and due_collection.test_date!=due_collection.paid_date and diagnostic_person.others_id='" + richTextBox1.Text + "' ", db.sql);
                SqlDataReader read1 = cmd1.ExecuteReader();
                while (read1.Read())
                {
                    due = Convert.ToInt32(read1[0]);
                    due_paid = Convert.ToInt32(read1[1]);
                  
                }
                net_bill = total - less;
                net_paid = paid + (due_paid);
                net_due = net_bill - net_paid;
                label23.Text = net_bill.ToString();
                label20.Text = net_paid.ToString();
                label18.Text = net_due.ToString();
                db.sql.Close();
            }
            catch
            {
                //label23.Text = "0";
               // label20.Text = "0";
               // label18.Text = "0";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                discharge_bill db = new discharge_bill(richTextBox1.Text, label8.Text);
                db.Show();
            }
            catch
            { 
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                DialogResult r = MessageBox.Show("Do You Want To Discharge This Patient ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete from admission where reg_no='" + richTextBox1.Text + "'", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Discharge Sucessfull");
                    }
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }
    }
}
