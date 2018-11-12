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
    public partial class Lab_Inventory : Form
    {
        string id = "";
        connection db = new connection();
        public Lab_Inventory()
        {
            InitializeComponent();
            show_inventory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          try
            {
                string date = DateTime.Now.ToString("dd/MM/yyyy");
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                int c = 0;
                double quant = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd1 = new SqlCommand("select quantity from lab_inventory where  id='" + id + "'", db.sql);
                SqlDataReader read = cmd1.ExecuteReader();
                while (read.Read())
                {
                    c++;
                    quant = Convert.ToDouble(read[0].ToString());
                
                }
                double q_given=Convert.ToDouble(textBox2.Text);
                double qq=quant+q_given;
                if (c > 0)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd2 = new SqlCommand("update lab_inventory set quantity='" + qq + "',date='"+dd+"' where id='" + id + "'", db.sql);
                    int aa = cmd2.ExecuteNonQuery();
                    MessageBox.Show("Stock Added Sucessfull");
                    show_inventory();
                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("insert into lab_inventory(product_Name,quantity,date)values('" + textBox1.Text + "','" + textBox2.Text + "','"+dd+"')", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Stock Added Sucessfull");
                        show_inventory();

                    }
                    db.sql.Close();
                }
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
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    }
                    db.sql.Close();
                
            }
            catch
            { 
            
            }
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from lab_inventory where product_Name like '%"+richTextBox1.Text+"%'", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();

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
                id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch
            { 
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Doy You want to delete this record","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("delete from lab_inventory where id='" + id + "'", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Delete Sucessfull");
                        show_inventory();
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

                string date = DateTime.Now.ToString("dd/MM/yyyy");
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("update lab_inventory set product_Name='" + textBox1.Text+ "',quantity='"+textBox2.Text+"',date='"+dd+"' where id='"+id+"'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Update Sucessfull");
                    show_inventory();
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab_Inventory_Print lip = new Lab_Inventory_Print();
            lip.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reagent_relations rea = new reagent_relations();
            rea.Show();
        }
    }
}
