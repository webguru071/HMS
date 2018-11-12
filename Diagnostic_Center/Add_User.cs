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
     
    public partial class Add_User : Form
    {
        string user_name_update = "";
        string password_update = "";
        connection db = new connection();
        string user_id = "";
        public Add_User()
        {
            InitializeComponent();
            show_user();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("insert into log(type,user_name,pass)values('"+comboBox1.Text+"','"+textBox1.Text+"','"+textBox2.Text+"')",db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Added Sucessfull");
                    show_user();
                }
                db.sql.Close();

            }
            catch
            { 
            
            }
        }



        void show_user()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from log",db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
             
                foreach(DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[1].ToString();
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
                user_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                user_name_update=dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                password_update = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
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
                SqlCommand cmd = new SqlCommand("update log set type='"+comboBox1.Text+"',user_name='"+textBox1.Text+"',pass='"+textBox2.Text+"' where Id='"+user_id+"'",db.sql);
                SqlCommand cmd2 = new SqlCommand("update user_cash_collection set user_name='" + textBox1.Text + "',password='" + textBox2.Text + "' where user_name='" + user_name_update + "' and password='"+password_update+"'", db.sql);
                SqlCommand cmd3 = new SqlCommand("update user_cash_collection_hospital set user_name='" + textBox1.Text + "',password='" + textBox2.Text + "' where user_name='" + user_name_update + "' and password='" + password_update + "'", db.sql);
                SqlCommand cmd4 = new SqlCommand("update user_cash_collection_pharmacy set user_name='" + textBox1.Text + "',password='" + textBox2.Text + "' where user_name='" + user_name_update + "' and password='" + password_update + "'", db.sql);
                SqlCommand cmd5 = new SqlCommand("update user_cash_collection_OPD set user_name='" + textBox1.Text + "',password='" + textBox2.Text + "' where user_name='" + user_name_update + "' and password='" + password_update + "'", db.sql);
                SqlCommand cmd6 = new SqlCommand("update hospital_due_collection set user_name='" + textBox1.Text + "',password='" + textBox2.Text + "' where user_name='" + user_name_update + "' and password='" + password_update + "'", db.sql);
                SqlCommand cmd7 = new SqlCommand("update opd_due_collection set user_name='" + textBox1.Text + "',password='" + textBox2.Text + "' where user_name='" + user_name_update + "' and password='" + password_update + "'", db.sql);
                int a = cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                if (a > 0)
                {

                    MessageBox.Show("Update Sucessfull");
                    show_user();
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
                DialogResult r = MessageBox.Show("Do You Want to Delete This Account..???","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("delete from log where Id='" + user_id + "'", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Delete Sucessfull");
                        show_user();
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
