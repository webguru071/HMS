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
namespace Diagnostic_Center
{
    public partial class add_test : Form
    {
        int i= 0;

        System.Timers.Timer t;
        connection db = new connection();
     //   SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public add_test()
        {
            InitializeComponent();
            list();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text == "" || richTextBox2.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Test name,Category,and price needed","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
                }
                else
                {
                    double price = Convert.ToDouble(richTextBox2.Text);
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("insert into diagnostic_list(id,name,price,type)values('" + richTextBox4.Text+ "','" + richTextBox1.Text + "','" + price + "','" + comboBox1.Text + "')", db.sql);
                    int s = cmd.ExecuteNonQuery();
                    if (s > 0)
                    {
                        //label4.Text = "Success fully inserted";
                       // timer1.Enabled = true;
                        MessageBox.Show("Added Sucessfull");
                        list();
                    }
                    db.sql.Close();
                }

            }

            catch
            { 
            
            }

           
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i >5)
            {
                label4.Text = "";
                timer1.Enabled = false;
            }
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
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[2].ToString();

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
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string type = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string price = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                richTextBox1.Text = name;
                richTextBox2.Text = price;
                comboBox1.Text = type;
                label6.Text = id;
                richTextBox4.Text = id;
            }
            catch
            { 
            
            }
        }

        private void richTextBox3_Enter(object sender, EventArgs e)
        {
            richTextBox3.Clear();
        }

        private void richTextBox3_Leave(object sender, EventArgs e)
        {
            richTextBox3.Text="Search here......";

            
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox3.Text != "Search here......")
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_list where name like'%" + richTextBox3.Text + "%' or id like '%" + richTextBox3.Text + "%'", db.sql);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.Rows.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[2].ToString();

                    }
                    db.sql.Close();
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
                SqlCommand cmd = new SqlCommand("update diagnostic_list set id='" + richTextBox4.Text+ "', name='" + richTextBox1.Text + "',price='" + richTextBox2.Text + "',type='" + comboBox1.Text + "' where id='" + label6.Text + "'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Update Sucessfully");
                   
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
                SqlCommand cmd1 = new SqlCommand("update reagent_decrease set test_id='" + richTextBox4.Text + "' where test_id='" + label6.Text + "'", db.sql);
                int b = cmd1.ExecuteNonQuery();
                if (b> 0)
                {
                 //   MessageBox.Show("Update Sucessfull");
                   
                }
                db.sql.Close();
            }
            catch
            {

            }

           richTextBox4.Clear();
           richTextBox1.Clear();
           richTextBox2.Clear();
           comboBox1.Text = "";
           label6.Text = "";
           list();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do You want to delete this", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("delete from diagnostic_list where id='" + label6.Text + "'", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Dele Ducessfull");
                        list();

                    }
                    db.sql.Close();

                }
            }
            catch
            { 
            
            }
        }

     }
}
