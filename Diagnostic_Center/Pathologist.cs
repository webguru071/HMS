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
    public partial class Pathologist : Form
    {
        connection db = new connection();
        public Pathologist()
        {
            InitializeComponent();
            show();
        }

        void show()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select * from pathologist", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value=item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
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
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
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
                SqlCommand cmd = new SqlCommand("delete from pathologist where Id='"+textBox1.Text+"'",db.sql);
                cmd.ExecuteNonQuery();
                show();
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
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("insert into pathologist(Id,pathologist,designation)values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')", db.sql);

                int a=cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Add Sucessfull");
                    show();
                }
                else
                { 
                
                }
                db.sql.Close();
            }
            catch
            {

            }
        }
    }
}
