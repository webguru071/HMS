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
    public partial class refer_doctor : Form
    {
        string update_id = "";
        connection db = new connection();
        public refer_doctor()
        {
            InitializeComponent();
            show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();


                SqlCommand cmd = new SqlCommand("insert into refer_doctor(id,name,contact,email,designation,fees)values('" + richTextBox5.Text + "','" + richTextBox4.Text + "','" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + richTextBox3.Text + "','" + richTextBox6.Text+ "')", db.sql);

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("inserted Successfully");
                    show();
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
                SqlCommand cmd = new SqlCommand("update refer_doctor set id='" + richTextBox5.Text + "', name='" + richTextBox4.Text + "',contact='" + richTextBox1.Text + "',email='" + richTextBox2.Text + "',designation='" + richTextBox3.Text + "',fees='" + richTextBox6.Text+ "' where id='" + update_id + "'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Update Sucessfull");
                    show();

                }
                else
                {
                    MessageBox.Show("Failed");
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
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from refer_doctor where id='" + update_id + "'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Delete Sucessfull");
                    show();
                }

                else
                {

                    MessageBox.Show("Failed To delete Data");
                }

                db.sql.Close();
            }

            catch
            {
            }
        }
        void show()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from refer_doctor ", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX1.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();
                    dataGridViewX1.Rows[n].Cells[4].Value = items[0].ToString();
                    dataGridViewX1.Rows[n].Cells[0].Value = items[1].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = items[3].ToString();
                    dataGridViewX1.Rows[n].Cells[2].Value = items[4].ToString();
                    dataGridViewX1.Rows[n].Cells[3].Value = items[2].ToString();
                    dataGridViewX1.Rows[n].Cells[5].Value = items[5].ToString();

                }
            }

            catch
            {

            }

        }

        private void dataGridViewX1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridViewX1.SelectedRows[0].Cells[4].Value.ToString();
                string name = dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString();
                string contact = dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString();
                string email = dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString();
                string des = dataGridViewX1.SelectedRows[0].Cells[3].Value.ToString();
                string fees = dataGridViewX1.SelectedRows[0].Cells[5].Value.ToString();
                update_id = id;
                richTextBox5.Text = id;
                richTextBox4.Text = name;
                richTextBox1.Text = contact;
                richTextBox2.Text = email;
                richTextBox3.Text = des;
                richTextBox6.Text = fees.ToString();
            }
            catch
            {

            }
        }
    }
}
