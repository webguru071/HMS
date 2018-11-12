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
    public partial class reagent_relations : Form
    {
        connection db = new connection();
        string test_id = "";
        string reagent_id = "";
        public reagent_relations()
        {
            InitializeComponent();
            list();
            show_inventory();
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
                

                }
                db.sql.Close();

            }
            catch
            {


            }

        }
        void show_inventory()
        {
            try
            {

                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from lab_inventory", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    

                }
                db.sql.Close();

            }
            catch
            {

            }

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_list where id like'" + richTextBox4.Text + "%' or name like'%" + richTextBox4.Text + "%'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();
                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                   

                }
                db.sql.Close();

            }
            catch
            {


            }
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from lab_inventory where product_Name like '%" + richTextBox5.Text + "%'", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                   

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
                test_id = dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString();
              
                richTextBox1.Text = dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            { 
            
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            reagent_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            richTextBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int c = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select test_id,reagent_id from reagent_decrease where test_id='"+test_id+"' and reagent_id='"+reagent_id+"'",db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    c++;
                }
                if (c > 0)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd1 = new SqlCommand("update reagent_decrease set decrease_amount='" + richTextBox3.Text+ "' where test_id='"+test_id+"' and reagent_id='"+reagent_id+"'", db.sql);
                    int a = cmd1.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Decrease Amount Update Sucessfull");
                    }
                    
                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd2 = new SqlCommand("insert into reagent_decrease(test_id,reagent_id,decrease_amount)values('" + test_id + "','" + reagent_id + "','" + richTextBox3.Text + "')", db.sql);
                    int b = cmd2.ExecuteNonQuery();
                    if (b > 0)
                    {
                        MessageBox.Show("Relation Complete");
                    }
                  
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reagent_Relation rea = new Reagent_Relation();
            rea.Show();
        }
    }
}
