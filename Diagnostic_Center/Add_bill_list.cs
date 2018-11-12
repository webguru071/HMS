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
    public partial class Add_bill_list : Form
    {
        string id = "";
        connection db = new connection();
        public Add_bill_list()
        {
            InitializeComponent();
            show_bill_list();
        }

        void show_bill_list()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from bill_list", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();

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
                SqlCommand cmd = new SqlCommand("insert into bill_list(bill_name,rate)values('"+richTextBox1.Text+"','"+richTextBox2.Text+"')",db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Adding Sucessfull");
                    show_bill_list();
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
                richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                richTextBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
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
                SqlCommand cmd = new SqlCommand("update bill_list set bill_name='"+richTextBox1.Text+"',rate='"+richTextBox2.Text+"' where Id='"+id+"'",db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Update Sucessfull");
                    show_bill_list();
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
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from bill_list where Id='" + id + "'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Delete Sucessfull");
                    show_bill_list();
                }
                db.sql.Close();
            }
            catch
            {

            }
        }
    }
}
