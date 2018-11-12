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
    public partial class Expense_List : Form
    {
        connection db = new connection();
        string id = "";
        public Expense_List()
        {
            InitializeComponent();
            show_bill_list();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int c = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd1 = new SqlCommand("select * from expense_title where title=N'" + richTextBox1.Text + "'", db.sql);
                SqlDataReader read = cmd1.ExecuteReader();
                while (read.Read())
                {

                    c++;
                }

                if (c > 0)
                {

                }
                else
                {
                    insert_title();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void insert_title()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("insert into expense_title(id,title,amount)values(N'" + richTextBox3.Text + "',N'" + richTextBox1.Text + "',N'" + richTextBox2.Text + "')", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("New Expense Title added");
                    show_bill_list();
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        void show_bill_list()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from expense_title", db.sql);
                dataGridView6.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView6.Rows.Add();
                    dataGridView6.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView6.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView6.Rows[n].Cells[2].Value = item[2].ToString();

                }
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void dataGridView6_Click(object sender, EventArgs e)
        {
            try
            {
                id = richTextBox3.Text = dataGridView6.SelectedRows[0].Cells[0].Value.ToString();
                richTextBox3.Text = dataGridView6.SelectedRows[0].Cells[0].Value.ToString();
                richTextBox1.Text = dataGridView6.SelectedRows[0].Cells[1].Value.ToString();
                richTextBox2.Text = dataGridView6.SelectedRows[0].Cells[2].Value.ToString();
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
                SqlCommand cmd = new SqlCommand("update expense_title set id=N'"+richTextBox3.Text+"',title=N'"+richTextBox1.Text+"',amount=N'"+richTextBox2.Text+"' where id=N'"+id+"'",db.sql);
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do You want to delete this","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("delete from expense_title where id='" + id + "'", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Deleted Sucessfull");
                        show_bill_list();
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
