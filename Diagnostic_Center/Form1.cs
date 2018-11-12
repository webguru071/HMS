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
    public partial class Form1 : Form
    {
        string x = "";
        string y = "";
        string z = "";
        double price;
        int delete_id;
        string delete_name = "";
        int id;
        string user_name = "";
        connection db = new connection();
        // SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {

            InitializeComponent();
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            list();
            id_generate();
            
         
            // show_daily_status();
        }

        void list()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_list", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();
                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX1.Rows[n].Cells[2].Value = item[2].ToString();

                }
                db.sql.Close();

            }
            catch
            {


            }

        }

        void id_generate()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select max(id) from diagnostic_person", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    id = Convert.ToInt32(read[0]);
                    label9.Text = (id + 1).ToString();
                }
                db.sql.Close();
            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Enter Name..");
                }


                else if (label11.Text == "")
                {
                    MessageBox.Show("Select a Item");
                }
                else if (comboBox2.Text == "")
                {
                    MessageBox.Show("Select Gender");
                }


                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Select  Referad Doctor");
                }
                else
                {
                    int c = 0;
                    int cc = 0;
                    int match = Convert.ToInt32(label9.Text);
                    string date = dateTimePicker1.Text;
                    DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dd = d.ToString("yyyy/MM/dd");
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("select * from diagnostic_person where id='" + match + "' and name='" + richTextBox1.Text + "' and contact='" + richTextBox2.Text + "'", db.sql);
                    SqlDataReader re = cmd.ExecuteReader();
                    while (re.Read())
                    {
                        c++;
                    }
                    if (c > 0)
                    {
                        //  MessageBox.Show("fgjfj");
                        db.sql.Close();
                        db.sql.Open();
                        SqlCommand cmd4 = new SqlCommand("select * from diagnostic_bill where invoice_id='" + match + "' and test_name='" + y + "'", db.sql);
                        SqlDataReader rd = cmd4.ExecuteReader();
                        while (rd.Read())
                        {
                            cc++;
                        }
                        if (cc > 0)
                        {
                            MessageBox.Show("item already added");
                        }
                        else
                        {
                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd3 = new SqlCommand("insert into diagnostic_bill(invoice_id,test_name,price,date)values('" + match + "','" + y + "','" + price + "','" + date + "')", db.sql);

                            cmd3.ExecuteNonQuery();
                            show_bill();
                            discount();
                        }
                    }
                    else
                    {
                        db.sql.Close();
                        db.sql.Open();
                        SqlCommand cmd1 = new SqlCommand("insert into diagnostic_person(id,name,contact,address,date,gender,age,referdoctor,date2,others_id)values('" + match + "','" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + richTextBox3.Text + "','" + date + "','" + comboBox2.Text + "','" + richTextBox7.Text + "','" + richTextBox10.Text + "','" + dd + "','" + richTextBox6.Text + "')", db.sql);
                        SqlCommand cmd2 = new SqlCommand("insert into diagnostic_bill(invoice_id,test_name,price,date)values('" + match + "','" + y + "','" + price + "','" + date + "')", db.sql);
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        show_bill();
                        count_sum();
                        discount();
                    }

                    db.sql.Close();
                }
            }

            catch
            {

            }
        }

        void show_bill()
        {
            try
            {

                int d = Convert.ToInt32(label9.Text);
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_bill where invoice_id='" + d + "'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX2.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX2.Rows.Add();
                    dataGridViewX2.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX2.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX2.Rows[n].Cells[2].Value = item[2].ToString();

                }

                db.sql.Close();
                count_sum();
            }

            catch
            {

            }


        }

        void count_sum()
        {
            try
            {
                int match = Convert.ToInt32(label9.Text);
                db.sql.Close();
                db.sql.Open();
                double x = 0;
                SqlCommand cmd = new SqlCommand("select sum(price) from diagnostic_bill where invoice_id='" + match + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    x = Convert.ToDouble(read[0].ToString());

                }
                db.sql.Close();
                label13.Text = x.ToString();

                if (label13.Text != "")
                {
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
                else
                {
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
            }


            catch { }

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_list where name like'%" + richTextBox4.Text + "%'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();
                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX1.Rows[n].Cells[2].Value = item[2].ToString();

                }
                db.sql.Close();

            }
            catch
            {


            }
        }

        private void dataGridViewX1_Click(object sender, EventArgs e)
        {
            try
            {
                x = dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString();
                label11.Text = x;
                y = dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString();
                z = dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString();
                price = Convert.ToDouble(z);
            }

            catch
            {

            }
        }

        private void dataGridViewX2_Click(object sender, EventArgs e)
        {
            try
            {
                delete_id = Convert.ToInt32(dataGridViewX2.SelectedRows[0].Cells[0].Value.ToString());
                delete_name = dataGridViewX2.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from diagnostic_bill where invoice_id='" + delete_id + "' and test_name='" + delete_name + "'", db.sql);
                cmd.ExecuteNonQuery();
                db.sql.Close();
                show_bill();

                cal();
                discount();
            }

            catch
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox5.Text == "")
            {
                MessageBox.Show("You Have to pay Some Amount");
            }

            else
            {
                //  try
                {
                    string date = dateTimePicker1.Text;
                    DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dd = d.ToString("yyyy/MM/dd");
                    DialogResult r = MessageBox.Show("Do You Want to save  this data....??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        int c = 0;
                        string paid_date = "0";
                        int match = Convert.ToInt32(label9.Text);
                        double total = Convert.ToDouble(label13.Text);
                        double paid = Convert.ToDouble(richTextBox5.Text);
                        double due = Convert.ToDouble(label15.Text);
                        double discount = Convert.ToDouble(richTextBox9.Text);
                        double discount_total = Convert.ToDouble(label22.Text);
                        if (due == 0)
                        {
                            paid_date = date;
                        }
                        db.sql.Close();
                        db.sql.Open();
                        SqlCommand cmd1 = new SqlCommand("select * from paid_and_due where invoice_no='" + match + "'", db.sql);
                        SqlDataReader read = cmd1.ExecuteReader();
                        while (read.Read())
                        {
                            c++;

                        }
                        if (c > 0)
                        {
                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd2 = new SqlCommand("update paid_and_due set total='" + total + "', paid='" + paid + "',due='" + due + "',discount='" + discount + "',discount_total='" + discount_total + "',paid_date='" + paid_date + "'  where invoice_no='" + match + "'", db.sql);
                            SqlCommand cmd4 = new SqlCommand("update due_collection set due='" + due + "' where reg_no='" + match + "'", db.sql);
                            SqlCommand cmde = new SqlCommand("update referance set name='" + comboBox1.Text + "',patient_name='" + richTextBox1.Text + "',date='" + date + "',bill='" + label13.Text + "',date2='" + dd + "',after_discount='" + label22.Text + "' where patient_id='" + label9.Text + "'", db.sql);
                            SqlCommand cmdd = new SqlCommand("update diagnostic_person set referdoctor='" + comboBox1.Text + "' where id='" + label9.Text + "'", db.sql);
                            cmd2.ExecuteNonQuery();

                            int x = cmde.ExecuteNonQuery();

                            cmd4.ExecuteNonQuery();
                            cmdd.ExecuteNonQuery();
                            button5.Enabled = true;
                            diagnostic_bill dbb = new diagnostic_bill(label9.Text);
                            show_daily_status();
                            dbb.Show();

                        }
                        else
                        {
                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd = new SqlCommand("insert into paid_and_due(invoice_no,total,paid,due,discount,discount_total,paid_date,date2)values('" + match + "','" + total + "','" + paid + "','" + due + "','" + discount + "','" + discount_total + "','" + paid_date + "','" + dd + "')", db.sql);
                            SqlCommand cmdd = new SqlCommand("insert into due_collection(reg_no,name,due,test_date)values('" + match + "','" + richTextBox1.Text + "','" + due + "','" + date + "')", db.sql);
                            SqlCommand cmddd = new SqlCommand("insert into referance(name,patient_id,patient_name,date,bill,date2,after_discount) values('" + comboBox1.Text + "','" + label9.Text + "','" + richTextBox1.Text + "','" + date + "','" + label13.Text + "','" + dd + "','" + label22.Text + "')", db.sql);
                            cmd.ExecuteNonQuery();
                            cmdd.ExecuteNonQuery();
                            cmddd.ExecuteNonQuery();
                            db.sql.Close();
                            button5.Enabled = true;
                            button4.Enabled = false;
                            diagnostic_bill dbb = new diagnostic_bill(label9.Text);
                            show_daily_status();
                            dbb.Show();
                        }
                    }
                }

                /*  catch
                   {
                       MessageBox.Show("Give a valid Paing Amount","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                   }*/
            }

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

            cal();
        }
        void cal()
        {

            try
            {
                if (richTextBox5.Text == "")
                {
                    label15.Text = "";
                }
                else
                {
                    double total = Convert.ToDouble(label22.Text);
                    double paid = Convert.ToDouble(richTextBox5.Text);


                    double due = total - paid;
                    label15.Text = due.ToString();
                }
            }
            catch
            {

            }

        }

        private void label13_TextChanged(object sender, EventArgs e)
        {
            richTextBox5.Text = label13.Text;
            label22.Text = label13.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do You Want to Abort this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int match = Convert.ToInt32(label9.Text);
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("delete from diagnostic_bill where invoice_id='" + match + "'", db.sql);
                    SqlCommand cmd1 = new SqlCommand("delete from diagnostic_person where id='" + match + "'", db.sql);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    show_daily_status();
                    dataGridViewX2.Rows.Clear();
                    label13.Text = "";
                    richTextBox1.Text = "";
                    richTextBox2.Text = "";
                    richTextBox3.Text = "";
                    comboBox2.Text = "";
                    richTextBox7.Text = "";

                    comboBox1.Text = "";
                    richTextBox10.Text = "";
                    label22.Text = "";
                    richTextBox9.Text = "0";
                    button3.Enabled = false;
                    button4.Enabled = false;
                    db.sql.Close();
                }
                else
                {

                }
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                id_generate();
                dataGridViewX2.Rows.Clear();
                label13.Text = "";
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                richTextBox3.Text = "";
                comboBox2.Text = "";
                richTextBox7.Text = "";

                comboBox1.Text = "";
                richTextBox10.Text = "";
                label22.Text = "";
                richTextBox9.Text = "0";
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            catch
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                refere_doctor();
                show_daily_status();
            }
            catch
            {
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

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from doctors where name='" + comboBox1.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                // comboBox1.Items.Clear();
                while (read.Read())
                {
                    String name = read[1].ToString();
                    String desig = read[2].ToString();
                    richTextBox10.Text = name + "," + desig;
                    // refere_doctor();
                }

                db.sql.Close();
            }

            catch
            {


            }
        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                discount();
            }
            catch
            {
            }
        }

        void discount()
        {

            /*  try
              {
                  if (richTextBox9.Text == "")
                  {

                      label15.Text = "0";
                      label22.Text = label13.Text;
                      richTextBox5.Text = label13.Text;
                  }
                  else
                  {
                      double total = Convert.ToDouble(label13.Text);
                      double discount = Convert.ToDouble(String.Concat(richTextBox9.Text.Where(Char.IsDigit)));
                      if (discount > 25 && label18.Text=="")
                      { MessageBox.Show("You do not have permission");
                       richTextBox9.Text ="0";
                       label22.Text = label13.Text;
                       richTextBox5.Text = label13.Text;
                      }
                      else
                      {
                          double persent = total * (discount / 100);
                          double cal_discount = total - persent;

                          double subtotal = Math.Ceiling(cal_discount);
                          label22.Text = subtotal.ToString();

                          richTextBox5.Text = subtotal.ToString();
                      }
                  }
              }
              catch
              {
                
              }*/

            try
            {
                if (richTextBox9.Text == "")
                {

                    label15.Text = "0";
                    richTextBox5.Text = label13.Text;
                }
                else
                {
                    double total = Convert.ToDouble(label13.Text);
                    double discount = Convert.ToDouble(richTextBox9.Text);
                    double due = total - discount;
                    label22.Text = due.ToString(); ;
                    richTextBox5.Text = due.ToString();
                }
            }
            catch
            {

            }

        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.F1)
                {
                    add_test at = new add_test();
                    at.Show();


                }
            }
            catch
            {

            }
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                list();
            }
            else
            {
                try
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_list where type='" + comboBox3.Text + "'", db.sql);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewX1.Rows.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridViewX1.Rows.Add();
                        dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridViewX1.Rows[n].Cells[2].Value = item[2].ToString();

                    }
                    db.sql.Close();

                }
                catch
                {


                }
            }
        }


        void show_daily_status()
        {
            try
            {
                string number = "";
                string total = "";
                string paid = "";
                string due = "";

                string date = dateTimePicker1.Text;

                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select  count(invoice_no),sum(total) ,sum(paid),sum(due) from diagnostic_person,paid_and_due where paid_and_due.invoice_no=diagnostic_person.id and date='" + date + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    number = read[0].ToString();
                    total = read[1].ToString();
                    paid = read[2].ToString();
                    due = read[3].ToString();

                }

                label26.Text = number;
                label27.Text = total;
                label29.Text = paid;
                label31.Text = due;
                db.sql.Close();
            }
            catch
            {

            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int c = 0;
            string x = "";
            login log = new login(x);
            log.ShowDialog();

            string user = log.val1;
            string pass = log.val2;
            if (user == "" || pass == "")
            {

            }
            else
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from log where pass='" + pass + "' and user_name='" + user + "'", db.sql);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    c++;
                }
                if (c > 0)
                {
                    MessageBox.Show("Login Sucessfull");
                    label18.Text = "admin";
                    richTextBox11.Visible = true;
                    button6.Visible = true;
                    button7.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to Login");
                }
                db.sql.Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox11.Visible = false;
            button6.Visible = false;
            button7.Visible = true;
        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label9.Text = richTextBox11.Text;

                int d = Convert.ToInt32(richTextBox11.Text);
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_bill where invoice_id='" + d + "'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX2.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX2.Rows.Add();
                    dataGridViewX2.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX2.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX2.Rows[n].Cells[2].Value = item[2].ToString();

                }

                db.sql.Close();


            }

            catch
            {
                dataGridViewX2.Rows.Clear();
            }


            int sum = 0;
            for (int i = 0; i < dataGridViewX2.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridViewX2.Rows[i].Cells[2].Value);
            }
            label13.Text = sum.ToString();
            count_sum();
            discount();
            patient_info_load();
        }


        void patient_info_load()
        {
            int c = 0;
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from diagnostic_person where id='" + richTextBox11.Text + "'", db.sql);
                SqlDataReader re = cmd.ExecuteReader();
                while (re.Read())
                {
                    c++;
                    richTextBox1.Text = re[1].ToString();
                    richTextBox2.Text = re[2].ToString();
                    comboBox2.Text = re[6].ToString();
                    richTextBox7.Text = re[7].ToString();
                    richTextBox3.Text = re[3].ToString();
                    comboBox1.Text = re[9].ToString();
                }
                if (c == 0)
                {

                    richTextBox1.Text = "";
                    richTextBox2.Text = "";
                    comboBox2.Text = "";
                    richTextBox7.Text = "";
                    richTextBox3.Text = "";
                    comboBox1.Text = "";
                }
                db.sql.Close();
            }
            catch
            {
            }

        }

    }
}
