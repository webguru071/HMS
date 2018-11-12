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
    public partial class Patient_Admit : Form
    {
        string update_time = "";
        connection db = new connection();
       // SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public Patient_Admit()
        {
            InitializeComponent();
            view_room();
            id_generate();
            current_patient();
        }
        void view_room()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select distinct bed_type,room_no,room.price from room,admission where room.room_no not in ( select room from admission)", db.sql);
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
            }
            catch
            {

            }
        }

        void current_patient()
        {

            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from admission", db.sql);
                dataGridView2.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach(DataRow item in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = item[5].ToString();
                    dataGridView2.Rows[n].Cells[4].Value = item[8].ToString();
                    dataGridView2.Rows[n].Cells[5].Value = item[6].ToString();
                    dataGridView2.Rows[n].Cells[6].Value = item[7].ToString();
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
                int x = 0;
                db.sql.Close();
                db.sql.Open();
                int c = 0;
                SqlCommand cmd = new SqlCommand("select max(reg_no) from patient_histroy", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    x = Convert.ToInt32(read[0].ToString());
                    c++;
                }

                if (c > 0)
                {
                    label8.Text = (x + 1).ToString();
                    richTextBox1.Clear();
                    richTextBox2.Clear();
                    richTextBox3.Clear();
                    label12.Text = "";
                    comboBox2.Text = "";
                    richTextBox5.Clear();
                    label6.Text = "";
                    richTextBox7.Clear();
                }
                else
                {
                    label8.Text = "1";
                }
                db.sql.Close();
            }
            catch
            {
                label8.Text = "1";
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                label6.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                label12.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            { 
            
            }
        }
        void id_generate()
        {
            int id = 0;
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select max(reg_no) from patient_histroy", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    id = Convert.ToInt32(read[0]);
                    label8.Text = (id + 1).ToString();
                }
                db.sql.Close();
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (label8.Text == "" || richTextBox1.Text == "" || richTextBox3.Text == "" || dateTimePicker1.Text == "" || label12.Text == "")
                {
                    MessageBox.Show("Give Reg no,Patient Name,admit date,and select room");
                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("insert into admission(reg_no,name,contact,gender,age,address,date,time,room,price,gurdian,word,thana,district)values('" + label8.Text + "','" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + comboBox2.Text + "','" + richTextBox7.Text + "','" + richTextBox3.Text + "','" + dateTimePicker1.Text + "','" + dateTimeInput1.Text + "','" + label12.Text + "','" + label6.Text + "','" + richTextBox10.Text + "','" + richTextBox4.Text + "','" + richTextBox8.Text + "','" + richTextBox9.Text + "')", db.sql);
                    SqlCommand cmd1 = new SqlCommand("insert into patient_histroy(reg_no,name,contact,gender,age,address,date,time,room,price,gurdian,word,thana,district)values('" + label8.Text + "','" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + comboBox2.Text + "','" + richTextBox7.Text + "','" + richTextBox3.Text + "','" + dateTimePicker1.Text + "','" + dateTimeInput1.Text + "','" + label12.Text + "','" + label6.Text + "','" + richTextBox10.Text + "','" + richTextBox4.Text + "','" + richTextBox8.Text + "','" + richTextBox9.Text + "')", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    int b = cmd1.ExecuteNonQuery();
                    if (a > 0 && b > 0)
                    {
                        MessageBox.Show("Admission Complete");
                        view_room();
                        current_patient();
                    }
                    else
                    {
                        MessageBox.Show("Admission Failed");
                    
                    }
                    db.sql.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void richTextBox6_Click(object sender, EventArgs e)
        {
            richTextBox6.Clear();
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (richTextBox6.Text == "" || richTextBox6.Text == "Search Here...")
                {

                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from admission", db.sql);
                    dataGridView2.Rows.Clear();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView2.Rows.Add();
                        dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView2.Rows[n].Cells[3].Value = item[5].ToString();
                        dataGridView2.Rows[n].Cells[4].Value = item[8].ToString();
                    }
                    db.sql.Close();
                   
                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from admission where name like '%" + richTextBox6.Text + "%' or reg_no like '%" + richTextBox6.Text + "%' or room like '%" + richTextBox6.Text + "%'", db.sql);
                    dataGridView2.Rows.Clear();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView2.Rows.Add();
                        dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView2.Rows[n].Cells[3].Value = item[5].ToString();
                        dataGridView2.Rows[n].Cells[4].Value = item[8].ToString();
                    }
                    db.sql.Close();
                }
            }
            catch
            {

            }
        }

        private void richTextBox6_Leave(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                label8.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from admission where reg_no='" + label8.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    richTextBox1.Text = read[1].ToString();
                    richTextBox2.Text = read[2].ToString();
                    comboBox2.Text = read[3].ToString();
                    richTextBox7.Text = read[4].ToString();
                    richTextBox3.Text = read[5].ToString();
                  string date = read[6].ToString();
                   update_time = read[7].ToString();

                    DateTime convert = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dateTimePicker1.Text = convert.ToString();
                    label12.Text = read[8].ToString();
                    label6.Text = read[9].ToString();
                    richTextBox10.Text = read[10].ToString();
                    richTextBox4.Text = read[11].ToString();
                    richTextBox8.Text = read[12].ToString();
                    richTextBox9.Text = read[13].ToString();
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
                DialogResult r = MessageBox.Show("Do You want to Update this Records ..?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("update admission set name='" + richTextBox1.Text + "',contact='" + richTextBox2.Text + "',gender='" + comboBox2.Text + "',age='" + richTextBox7.Text + "',address='" + richTextBox3.Text + "',date='" + dateTimePicker1.Text + "',time='" + update_time + "',room='" + label12.Text + "',price='" + label6.Text + "',gurdian='" + richTextBox10.Text + "',word='" + richTextBox4.Text + "',thana='" + richTextBox8.Text + "',district='" + richTextBox9.Text + "' where reg_no='" + label8.Text + "'", db.sql);
                    SqlCommand cmd1 = new SqlCommand("update patient_histroy set name='" + richTextBox1.Text + "',contact='" + richTextBox2.Text + "',gender='" + comboBox2.Text + "',age='" + richTextBox7.Text + "',address='" + richTextBox3.Text + "',date='" + dateTimePicker1.Text + "',time='" + update_time + "',room='" + label12.Text + "',price='" + label6.Text + "',gurdian='" + richTextBox10.Text + "',word='" + richTextBox4.Text + "',thana='" + richTextBox8.Text + "',district='" + richTextBox9.Text + "' where reg_no='" + label8.Text + "'", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    int b = cmd1.ExecuteNonQuery();
                    if (a > 0 && b > 0)
                    {
                        MessageBox.Show("Update Sucessfull");
                        view_room();

                        current_patient();

                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }
                    db.sql.Close();
                }

            }
            catch
            { 
            }
        }

        private void dateTimeInput1_TextChanged(object sender, EventArgs e)
        {
            update_time = dateTimeInput1.Text;
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // print print = new print();
            admission_form ad = new admission_form(label8.Text);
            ad.Show();
        }
    }
}
