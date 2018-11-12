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
using System.IO;

namespace Diagnostic_Center
{
    public partial class Add_Employee : Form
    {
        Image im;
        connection db = new connection();
       
        public Add_Employee(string x)
        {
            InitializeComponent();
            textBox1.Text = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                if (od.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(od.FileName);

                }
            }
            catch
            
            {
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("insert into employee(employee_id,name,f_name,m_name,gender,birth_date,post_code,thana,zela,city,phone,nid,job_post,department,salary,additional,joining_date,image)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + dateTimePicker2.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox5.Text + "','" + textBox10.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + dateTimePicker1.Text+ "',@image)", db.sql);
                cmd.Parameters.AddWithValue("@Image", save());
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Information Saved Sucessfull");
                }
                db.sql.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    
        public byte[] save()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms,pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }


        void show_employee()
        {
            try
            {
                int cc = 0;
                string a = "";
                string b = "";
                string c = "";
                string d = "";
                string ee = "";
                string f= "";
                string g = "";
                string h = "";
                string i = "";
                string j = "";
                string k = "";
                string l = "";
                string m = "";
                string n = "";
                string o = "";
                string p = "";
                string q = "";

               
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from employee where employee_id='"+textBox1.Text+"'",db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cc++;
                    a = read[0].ToString();
                    b = read[1].ToString();
                    c = read[2].ToString();
                    d = read[3].ToString();
                    ee = read[4].ToString();
                    f = read[5].ToString();
                    g = read[6].ToString();
                    h = read[7].ToString();
                    i = read[8].ToString();
                    j = read[9].ToString();
                    k = read[10].ToString();
                    l = read[11].ToString();
                    m = read[12].ToString();
                    n = read[13].ToString();
                    o = read[14].ToString();
                    p = read[15].ToString();
                    q = read[16].ToString();
                    MemoryStream ms = new MemoryStream((byte[])read[17]);
                    im = Image.FromStream(ms);

                }
               
                if (cc > 0)
                {
                   // textBox1.Text = a;
                    textBox2.Text = b;
                    textBox3.Text = c;
                    textBox4.Text = d;
                    comboBox1.Text = ee;
                    dateTimePicker2.Text = f;
                    textBox6.Text = g;
                    textBox7.Text = h;
                    textBox8.Text = i;
                    textBox9.Text = j;
                    textBox5.Text = k;
                    textBox10.Text = l;
                    textBox12.Text = m;
                    textBox13.Text = n;
                    textBox14.Text = o;
                    textBox15.Text = p;
                    dateTimePicker1.Text = q;


                    pictureBox1.Image = im;
                    db.sql.Close();
                }
                else
                {
                   // textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    comboBox1.Text = "";
                    dateTimePicker2.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox5.Text = "";
                    textBox10.Text = "";
                    textBox12.Text = "";
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    dateTimePicker1.Text = "";


                    pictureBox1.Image = null;
                    db.sql.Close();
                }
            }
            catch
            { }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            show_employee();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("update employee set name='" + textBox2.Text + "',f_name='" + textBox3.Text + "',m_name='" + textBox4.Text + "',gender='" + comboBox1.Text + "',birth_date='" + dateTimePicker2.Text + "',post_code='" + textBox6.Text + "',thana='" + textBox7.Text + "',zela='" + textBox8.Text + "',city='" + textBox9.Text + "',phone='" + textBox5.Text + "',nid='" + textBox10.Text + "',job_post='" + textBox12.Text + "',department='" + textBox13.Text + "',salary='" + textBox14.Text + "',additional='" + textBox15.Text + "',joining_date='" + dateTimePicker1.Text+ "',image=@image where employee_id='"+textBox1.Text+"'", db.sql);
                cmd.Parameters.AddWithValue("@image", save());
              
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Update Sucessfull");
                    show_employee();
                }
            }
            catch
            { 
            
            }
            db.sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Print_Employee_Info pei = new Print_Employee_Info(textBox1.Text);
                pei.Show();
            }
            catch
            { 
            
            }
        }
    }
}
