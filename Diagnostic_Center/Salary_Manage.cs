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
    public partial class Salary_Manage : Form
    {
        string sid = "";
        Image im;
        connection db=new connection();
        public Salary_Manage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            show_employee();
            show_salary();
        }


        void show_employee()
        {
            try
            {
                double ss = 0;
                double xtra = 0;
                int cc = 0;
                string a = "";
                string b = "";
                string c = "";
                string d = "";
                string ee = "";
                string f = "";
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
                SqlCommand cmd = new SqlCommand("select * from employee where employee_id='" + textBox1.Text + "'", db.sql);
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

                    textBox14.Text = o;
                    textBox15.Text = p;

                   

                    pictureBox1.Image = im;
                    db.sql.Close();
                     ss = Convert.ToDouble(o);
                    xtra=Convert.ToDouble(p);
                    double sum = ss + xtra;
                    textBox3.Text = sum.ToString();
                }
                else
                {
                    // textBox1.Text = "";
                    textBox2.Text = "";
                   
                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox3.Text = "";

                    pictureBox1.Image = null;
                    db.sql.Close();
                }
            }
            catch
            { }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text == "")
                {
                    textBox4.Text = "0";
                  
                }
                double a =Convert.ToDouble(textBox4.Text);
                double b = Convert.ToDouble(textBox3.Text);
                double c = b - a;
                textBox5.Text = c.ToString();
              
            }
            catch
            { 
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("insert into salary(employee_id,name,basic_salary,additional,total,minimize,net_total,month,year,date)values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox14.Text+"','"+textBox15.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+comboBox1.Text+"','"+comboBox2.Text+"','"+dateTimePicker1.Text+"')",db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Saved Sucessfull");
                    show_salary();
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        void show_salary()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from salary where employee_id='"+textBox1.Text+"'", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach(DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();

                }
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
                sid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox14.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox15.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
             
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
                SqlCommand cmd = new SqlCommand("update salary set minimize='" +textBox4.Text+ "',net_total='" + textBox5.Text + "',month='" + comboBox1.Text + "',year='" + comboBox2.Text + "' where id='"+sid+"'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Update Sucessfull");
                    show_salary();
                }
                db.sql.Close();

            }
            catch
            { 
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salary sss = new Salary();
            sss.Show();
        }
    }
}
