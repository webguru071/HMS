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
    public partial class Expense : Form
    {
        connection db = new connection();
        string edit_delete_date = "";
      //  SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public Expense()
        {
            InitializeComponent();
            show();
            show_bill_list();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    int c = 0;
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd1 = new SqlCommand("select * from expense_title where title=N'" + richTextBox1.Text + "'",db.sql);
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
                db.sql.Close();
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");

                double amount=Convert.ToDouble(richTextBox2.Text);
                //**************************id generate**********************
                 int idd = 0;
            int new_id = 0;
            db.sql.Close();
            db.sql.Open();
            try
            {
                SqlCommand cmd1 = new SqlCommand("select max(id) from expense where date='"+dd+"'", db.sql);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    idd = Convert.ToInt32(rd[0].ToString());
                }
            }
            catch
            { 
            
            }
            new_id = idd + 1;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("insert into expense(id,title,amount,date)values(N'"+new_id+"',N'" + richTextBox1.Text + "','" + amount + "','" + dd + "')", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Add Sucess full");
                    show();
                    show_bill_list();
                }
                else
                {
                    MessageBox.Show("Failed to  save data");
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        void insert_title()
        {

            int idd = 0;
            int new_id = 0;
            db.sql.Close();
            db.sql.Open();
            try
            {
                SqlCommand cmd1 = new SqlCommand("select max(id) from expense_title", db.sql);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    idd = Convert.ToInt32(rd[0].ToString());
                }
            }
            catch
            { 
            
            }
            new_id = idd + 1;
            db.sql.Close();
            db.sql.Open();
            SqlCommand cmd = new SqlCommand("insert into expense_title(id,title)values('"+new_id+"',N'"+richTextBox1.Text+"')",db.sql);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("New Expense Title added");
            }
            db.sql.Close();
        
        }
        void check_title()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from expense_title where title like N'%" + richTextBox1.Text + "%'", db.sql);
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
        void show()
        {
            try
            {
                string date = dateTimePicker2.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
          
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from expense where date='"+dd+"'", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[0].ToString();

                }
                db.sql.Close();

            }
            catch
            { 
            
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Print_Expense pe = new Print_Expense();
                pe.Show();
            }
            catch
            { 
            
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                string title = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string amount = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string id = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                edit_delete_date = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                label5.Text = id;
                richTextBox1.Text = title;
                richTextBox2.Text = amount;
            }
            catch
            { 
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from expense where id='" + label5.Text + "' and date='" + edit_delete_date + "'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Delete Sucessfull");
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                   double amount=Convert.ToDouble(richTextBox2.Text);
                   db.sql.Close();
                db.sql.Open();
                
                SqlCommand cmd = new SqlCommand("Update expense set title= N'" + richTextBox1.Text + "',amount=N'" + amount + "' where id='" + label5.Text + "' and date='"+edit_delete_date+"'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                  //  MessageBox.Show(edit_delete_date);
                    MessageBox.Show("Update Sucessfull");
                    show();
                }
                else
                {
                    MessageBox.Show("failed");
                
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
                richTextBox1.Text = dataGridView6.SelectedRows[0].Cells[1].Value.ToString();
                richTextBox2.Text = dataGridView6.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch
            { 
            
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string date = dateTimePicker2.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from expense where date='"+dd+"'", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[0].ToString();

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
                check_title();
            }
            catch
            { 
            
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Expense_List el = new Expense_List();
                el.Show();
            }
            catch
            { 
            }
        }
    }
}
