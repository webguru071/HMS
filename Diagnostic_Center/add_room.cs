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
    public partial class add_room : Form
    {
        connection db = new connection();
       // SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public add_room()
        {
            InitializeComponent();
            view_room();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();

                SqlCommand cmd = new SqlCommand("insert into room(bed_type,room_no,price)values('" + comboBox1.Text + "','" + richTextBox1.Text + "','" + richTextBox2.Text + "')", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Added Sucessfull");
                    view_room();
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

       void view_room()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from room ", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                }
            }
            catch
            { 
            
            }
        }

       private void dataGridView1_Click(object sender, EventArgs e)
       {
           try
           {
               string type = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
               string room = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
               string price = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
               comboBox1.Text = type;
               richTextBox1.Text = room;
               richTextBox2.Text = price;
           }
           catch
           { 
           
           }
       }

       private void button2_Click(object sender, EventArgs e)
       {
           try
           {
               DialogResult r = MessageBox.Show("Do You want to Delete this?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
               if (r == DialogResult.Yes)
               {
                   db.sql.Close();
                   db.sql.Open();
                   SqlCommand cmd = new SqlCommand("delete from room where room_no='" + richTextBox1.Text + "'", db.sql);
                   int a = cmd.ExecuteNonQuery();
                   if (a > 0)
                   {
                       MessageBox.Show("Delte Sucessfull");
                       view_room();
                   }
                   db.sql.Close();
               }

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
               SqlCommand cmd = new SqlCommand("update room set bed_type='" + comboBox1.Text + "',room_no='" + richTextBox1.Text + "',price='" + richTextBox2.Text + "' where room_no='" + richTextBox1.Text + "'", db.sql);
               int a = cmd.ExecuteNonQuery();
               if (a > 0)
               {
                   MessageBox.Show("Update Sucessfull");
                   view_room();
               }
               else
               {
                   MessageBox.Show("Update Failed.Room No can not be updated.\n Delete the item and add Again");
               }
               db.sql.Close();
           }
           catch
           { 
           
           }
       }

    }
}
