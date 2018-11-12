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
    public partial class Doctor_Appointment : Form
    {
        string reg = "";
        connection db = new connection();
        public Doctor_Appointment()
        {
            InitializeComponent();
            show_appointment();
            show_doctor();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                int count = 0;
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                db.sql.Close();
                db.sql.Open();
                SqlCommand comand = new SqlCommand("select * from appointment where reg_no='" + richTextBox1.Text + "' and date='" + dd + "'", db.sql);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                if (count > 0)
                {
                    MessageBox.Show("Appointment already Taken");
                }
                else
                {
                    try
                    {

                        if (richTextBox1.Text == "" || richTextBox2.Text == "" || richTextBox3.Text == "" || richTextBox4.Text == "" || comboBoxEx3.Text == "" || dateTimePicker1.Text == "" || comboBoxEx1.Text == "" || richTextBox6.Text == "")
                        {
                            MessageBox.Show("Provide all the information");
                        }
                        else
                        {
                            DialogResult r = MessageBox.Show("Do you want to save it ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (r == DialogResult.Yes)
                            {
                                int fees = Convert.ToInt32(richTextBox6.Text);
                                db.sql.Close();
                                db.sql.Open();
                                int c = 0;
                                SqlCommand check = new SqlCommand("select reg_no from appointment where reg_no='" + richTextBox1.Text + "'", db.sql);
                                SqlDataReader read = check.ExecuteReader();
                                while (read.Read())
                                {
                                    c++;
                                }
                           
                                //**************************id generate**********************
                                int idd = 0;
                                int new_id = 0;
                                db.sql.Close();
                                db.sql.Open();
                                try
                                {
                                    SqlCommand cmd1 = new SqlCommand("select max(id) from appointment where date='" + dd + "' and doctor='" + comboBoxEx1.Text+ "'", db.sql);
                                    SqlDataReader rd = cmd1.ExecuteReader();
                                    while (rd.Read())
                                    {
                                        idd = Convert.ToInt32(rd[0].ToString());
                                    }
                                }
                                catch
                                {

                                }
                                new_id = idd + 1;
                                db.sql.Close();
                                db.sql.Open();
                                SqlCommand cmd = new SqlCommand("insert into appointment(reg_no,name,address,age,sex,referance,date,doctor,fees,weight,id)values(N'" + richTextBox1.Text + "',N'" + richTextBox2.Text + "',N'" + richTextBox3.Text + "',N'" + richTextBox4.Text + "',N'" + comboBoxEx3.Text + "',N'" + richTextBox5.Text + "',N'" + dd + "',N'" + comboBoxEx1.Text + "',N'" + fees + "',N'" + richTextBox47.Text + "','"+new_id+"')", db.sql);
                                SqlCommand cmd2 = new SqlCommand("insert into symptoms(reg_no)values('" + richTextBox1.Text + "')", db.sql);
                                SqlCommand cmd3 = new SqlCommand("insert into patient_test(reg_no)values('" + richTextBox1.Text + "')", db.sql);
                                SqlCommand cmd4 = new SqlCommand("insert into advice(reg_no)values('" + richTextBox1.Text + "')", db.sql);
                                SqlCommand cmd5 = new SqlCommand("insert into diagnosis(reg_no)values('" + richTextBox1.Text + "')", db.sql);
                              

                              
                             
                                    if (c > 0)
                                    {

                                    }
                                    else
                                    {
                                       x = cmd.ExecuteNonQuery();
                                        cmd2.ExecuteNonQuery();
                                        cmd3.ExecuteNonQuery();
                                        cmd4.ExecuteNonQuery();
                                        cmd5.ExecuteNonQuery();
                                    }

                             
                                if (x > 0)
                                {
                                    MessageBox.Show("Data Inserted Successfully");
                                }
                                else
                                {
                                    MessageBox.Show("Data not Inserted");
                                }
                                db.sql.Close();
                                show_appointment();
                            }
                            else
                            {

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch
            {

            }
        }

        void show_appointment()
        {
            try
            {
                string date = DateTime.Now.ToString("dd/MM/yyyy");
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");

                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from appointment where date='" + dd + "'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();
                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX1.Rows[n].Cells[2].Value = item[7].ToString();
                    dataGridViewX1.Rows[n].Cells[3].Value = date;
                    dataGridViewX1.Rows[n].Cells[4].Value = item[10].ToString();

                }
                db.sql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int count = 0;
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                db.sql.Close();
                db.sql.Open();
                SqlCommand comand = new SqlCommand("select * from appointment where reg_no='" + richTextBox1.Text + "' and date='" + dd + "'", db.sql);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                if (count > 0)
                {
                    MessageBox.Show("Appointment already Taken");
                }
                else
                {
                    try
                    {

                        if (richTextBox1.Text == "" || richTextBox2.Text == "" || richTextBox3.Text == "" || richTextBox4.Text == "" || comboBoxEx3.Text == "" || dateTimePicker1.Text == "" || comboBoxEx1.Text == "" || richTextBox6.Text == "")
                        {
                            MessageBox.Show("Provide all the information");
                        }
                        else
                        {
                            DialogResult r = MessageBox.Show("Do you want to save it ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (r == DialogResult.Yes)
                            {
                                int fees = Convert.ToInt32(richTextBox6.Text);
                                db.sql.Close();
                                db.sql.Open();
                                int c = 0;
                                SqlCommand check = new SqlCommand("select reg_no from symptoms where reg_no='" + richTextBox1.Text + "'", db.sql);
                                SqlDataReader read = check.ExecuteReader();
                                while (read.Read())
                                {
                                    c++;
                                }

                                db.sql.Close();
                                db.sql.Open();
                                SqlCommand cmd = new SqlCommand("insert into appointment(reg_no,name,address,age,sex,referance,date,doctor,fees,weight)values(N'" + richTextBox1.Text + "',N'" + richTextBox2.Text + "',N'" + richTextBox3.Text + "',N'" + richTextBox4.Text + "',N'" + comboBoxEx3.Text + "',N'" + richTextBox5.Text + "',N'" + dd + "',N'" + comboBoxEx1.Text + "',N'" + fees + "',N'" + richTextBox47.Text + "')", db.sql);
                                SqlCommand cmd2 = new SqlCommand("insert into symptoms(reg_no)values('" + richTextBox1.Text + "')", db.sql);
                                SqlCommand cmd3 = new SqlCommand("insert into patient_test(reg_no)values('" + richTextBox1.Text + "')", db.sql);
                                SqlCommand cmd4 = new SqlCommand("insert into advice(reg_no)values('" + richTextBox1.Text + "')", db.sql);
                                SqlCommand cmd5 = new SqlCommand("insert into diagnosis(reg_no)values('" + richTextBox1.Text + "')", db.sql);
                                int x = cmd.ExecuteNonQuery();



                                if (c > 0)
                                {

                                }
                                else
                                {

                                    cmd2.ExecuteNonQuery();
                                    cmd3.ExecuteNonQuery();
                                    cmd4.ExecuteNonQuery();
                                    cmd5.ExecuteNonQuery();
                                }


                                if (x > 0)
                                {
                                    MessageBox.Show("Data Inserted Successfully");
                                    token token = new token(richTextBox1.Text);
                                    token.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Data not Inserted");
                                }
                                db.sql.Close();
                                show_appointment();
                            }
                            else
                            {

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch
            {

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            token token = new token(richTextBox1.Text);
            token.Show();
        }
        void show_doctor()
        {
            try
            {
                int c = 0;
                string name = "";
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from refer_doctor", db.sql);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {

                    c++;
                    name = r[1].ToString();
                    if (c > 0)
                    {
                        comboBoxEx1.Items.Add(name);
                        comboBoxEx2.Items.Add(name);
                      
                    }
                }

                db.sql.Close();
            }
            catch
            { }
        }

        private void comboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string date = dateTimePicker2.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");

                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from appointment where date='" + dd + "' and doctor='" + comboBoxEx2.Text+ "' ", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();
                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX1.Rows[n].Cells[2].Value = item[7].ToString();
                    dataGridViewX1.Rows[n].Cells[3].Value = date;
                    dataGridViewX1.Rows[n].Cells[4].Value = item[10].ToString();

                }
                db.sql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                string date = dateTimePicker2.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");

                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from appointment where  date='" + dd + "' ", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();
                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX1.Rows[n].Cells[2].Value = item[7].ToString();
                    dataGridViewX1.Rows[n].Cells[3].Value = date;
                    dataGridViewX1.Rows[n].Cells[4].Value = item[10].ToString();

                }
                db.sql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string date = dateTimePicker2.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");

                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from appointment where  name like'%" + richTextBox7.Text + "%'and date='"+dd+"' ", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();
                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX1.Rows[n].Cells[2].Value = item[7].ToString();
                    dataGridViewX1.Rows[n].Cells[3].Value = date;
                    dataGridViewX1.Rows[n].Cells[4].Value = item[10].ToString();

                }
                db.sql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                db.sql.Close();
                db.sql.Open();
                int c = 0;
                SqlCommand cmd = new SqlCommand("select max(reg_no) from appointment", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    x = Convert.ToInt32(read[0].ToString());
                    c++;
                }

                if (c > 0)
                {
                    richTextBox1.Text = (x + 1).ToString();
                    richTextBox2.Clear();
                    richTextBox3.Clear();
                    richTextBox4.Clear();
                    comboBoxEx3.Text = "";
                    richTextBox5.Clear();
                    comboBoxEx1.Text = "";
                    richTextBox6.Clear();
                }
                else
                {
                    richTextBox1.Text = "1";
                }
                db.sql.Close();
            }
            catch
            {
                richTextBox1.Text = "1";
            }
        }

        void id_generate()
        {
            try
            {
                int x = 0;
                db.sql.Close();
                db.sql.Open();
                int c = 0;
                SqlCommand cmd = new SqlCommand("select max(reg_no) from appointment", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    x = Convert.ToInt32(read[0].ToString());
                    c++;
                }

                if (c > 0)
                {
                    richTextBox1.Text = (x + 1).ToString();
                    richTextBox2.Clear();
                    richTextBox3.Clear();
                    richTextBox4.Clear();
                    comboBoxEx3.Text = "";
                    richTextBox5.Clear();
                    comboBoxEx1.Text = "";
                    richTextBox6.Clear();
                }
                else
                {
                    richTextBox1.Text = "1";
                }
                db.sql.Close();
            }
            catch
            {
                richTextBox1.Text = "1";
            }
        
        }
        private void dataGridViewX1_Click(object sender, EventArgs e)
        {
            try
            {
                int c = 0;
                 reg = dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString();
                string doctor = dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString();
                string date = dataGridViewX1.SelectedRows[0].Cells[3].Value.ToString();
                string fees = "";
                string age = "";
                string sex = "";
                string weight = "";
                string referance = "";
                string address="";
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from appointment where reg_no='"+reg+"'",db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    c++;
                   
                    age=read[3].ToString();
                    sex=read[4].ToString();
                    weight=read[9].ToString();
                    referance=read[5].ToString();
                    address=read[2].ToString();
                    fees = read[8].ToString();
                    
                }
                if (c > 0)
                {
                   
                    comboBoxEx1.Text = doctor;
                  
                    richTextBox1.Text = reg;
                    richTextBox2.Text = name;
                    richTextBox6.Text = fees;
                    richTextBox3.Text = address;
                    richTextBox4.Text = age;
                    comboBoxEx3.Text = sex;
                    richTextBox47.Text = weight;
                    richTextBox5.Text = referance;
                    dateTimePicker1.Text = date;
                   
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
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("update appointment set name='" + richTextBox2.Text + "',address='" + richTextBox3.Text + "',age='" + richTextBox4.Text + "',sex='" + comboBoxEx3.Text + "',doctor='" + comboBoxEx1.Text + "',fees='" + richTextBox6.Text + "',date='" +dd+ "',weight='" + richTextBox47.Text + "',referance='" + richTextBox5.Text+ "' where reg_no='"+reg+"'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Update Sucessfull");
                    show_appointment();
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {int a =0;
                db.sql.Close();
                db.sql.Open();
                DialogResult r = MessageBox.Show("Do You want to delete this..??","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                if (r == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete from appointment where reg_no='" + richTextBox1.Text+ "'", db.sql);
                    SqlCommand cmd1 = new SqlCommand("delete from symptoms where reg_no='" + richTextBox1.Text + "'", db.sql);
                    SqlCommand cmd2= new SqlCommand("delete from patient_test where reg_no='" + richTextBox1.Text + "'", db.sql);
                    SqlCommand cmd3= new SqlCommand("delete from advice where reg_no='" + richTextBox1.Text + "'", db.sql);
                    SqlCommand cmd4 = new SqlCommand("delete from diagnosis where reg_no='" + richTextBox1.Text + "'", db.sql);

                    try
                    {
                         a = cmd.ExecuteNonQuery();
                    }
                    catch
                    { 
                    }
                    try
                    {
                        cmd1.ExecuteNonQuery();
                    }
                    catch
                    { }
                    try
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    catch
                    { }
                    try
                    {
                        cmd3.ExecuteNonQuery();
                    }
                    catch
                    { }
                    try
                    {
                        cmd4.ExecuteNonQuery();
                    }
                    catch
                    { }
                    if (a > 0)
                    {
                        MessageBox.Show("Delete Sucessfull");
                        show_appointment();
                    }
                    db.sql.Close();
                }
            }
            catch
            { 
            
            }
        }

        private void Doctor_Appointment_Load(object sender, EventArgs e)
        {
            id_generate();
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int c = 0;
                string fees ="";
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from refer_doctor where name='" + comboBoxEx1.Text + "'", db.sql);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {

                    c++;
                    fees =r[5].ToString();
                }
                if (c > 0)
                {
                    richTextBox6.Text = fees.ToString();
                }
                else
                {
                    richTextBox6.Clear();
                }
                db.sql.Close();
            }
            catch
            { }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int c= 0;
                string name = "";
                string address = "";
                string sex = "";
                string age = "";
                string weight = "";
                string referance = "";
                string doctor = "";
                string fees = "";
               

                db.sql.Close();
                db.sql.Open();

                SqlCommand cmd = new SqlCommand("select * from appointment where reg_no='" + richTextBox1.Text+ "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    c++;
                     name =read[1].ToString();
                     address = read[2].ToString();
                     sex =read[4].ToString();
                     age = read[3].ToString();
                     weight =read[9].ToString();
                     referance =read[5].ToString();
                     doctor = read[7].ToString();
                     fees = read[8].ToString();
                }
                if (c > 0)
                {
                    richTextBox2.Text = name;
                    richTextBox3.Text = address;
                    richTextBox4.Text = age;
                    comboBoxEx3.Text = sex;
                    richTextBox47.Text = weight;
                    richTextBox5.Text = referance;
                    comboBoxEx1.Text = doctor;
                    richTextBox6.Text = fees;
                }
                else
                {
                    richTextBox2.Text = "";
                    richTextBox3.Text = "";
                    richTextBox4.Text = "";
                    comboBoxEx3.Text = "";
                    richTextBox47.Text = "";
                    richTextBox5.Text = "";
                    comboBoxEx1.Text = "";
                    richTextBox6.Text = "";
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }
    }
}
