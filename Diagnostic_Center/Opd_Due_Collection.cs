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
    public partial class Opd_Due_Collection : Form
    {
        string due_date = "";
        connection db = new connection();
        string user_name = "";
        string password = "";
        string user_type = "";
        public Opd_Due_Collection(string user, string pass, string type)
        {
            InitializeComponent();
            show_due_list();
            user_name = user;
            password = pass;
            user_type = type;
        }

        void show_due_list()
        {
            try
            {
                int a = 0;
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from user_cash_collection_OPD where due>'" + a + "' and due_paid=0", db.sql);
                dataGridView8.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView8.Rows.Add();
                    dataGridView8.Rows[n].Cells[0].Value = item[2].ToString();
                    dataGridView8.Rows[n].Cells[1].Value = item[3].ToString();
                    dataGridView8.Rows[n].Cells[2].Value = item[4].ToString();
                    dataGridView8.Rows[n].Cells[3].Value = item[5].ToString();
                    dataGridView8.Rows[n].Cells[4].Value = item[6].ToString();
                    dataGridView8.Rows[n].Cells[5].Value = item[7].ToString();
                    dataGridView8.Rows[n].Cells[6].Value = item[8].ToString();

                }
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void dataGridView8_Click(object sender, EventArgs e)
        {
            try
            {
                due_date = dataGridView8.SelectedRows[0].Cells[6].Value.ToString();
                label84.Text = dataGridView8.SelectedRows[0].Cells[0].Value.ToString();
                label86.Text = dataGridView8.SelectedRows[0].Cells[5].Value.ToString();
                richTextBox22.Text = dataGridView8.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch
            { 
            
            }
            }

        private void richTextBox22_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(label86.Text);
                double b = Convert.ToDouble(richTextBox22.Text);
                double c = a - b;
                label57.Text = c.ToString();
            }
            catch
            {

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                string date =dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                DialogResult r = MessageBox.Show("Did you get the due amount", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    db.sql.Close();
                    db.sql.Open();


                    SqlCommand cmd = new SqlCommand("insert into opd_due_collection(reg_no,due_paid,discount2,date,date2,user_name,password)values('" + label84.Text + "','" + richTextBox22.Text + "','" + label57.Text + "','" + date + "','" + dd + "','"+user_name+"','"+password+"')", db.sql);
                    SqlCommand cmd2 = new SqlCommand("update user_cash_collection_OPD set due_paid='" + richTextBox22.Text + "' where reg_no='" + label84.Text + "'", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Due collected Sucessfully");
                        Opd_Due_Collection_Print due = new Opd_Due_Collection_Print(label84.Text, richTextBox22.Text, user_name);
                        due.Show();
                        show_due_list();
                    }

                    db.sql.Close();
                }

            }
            catch
            {

            }
        }
        /* OPD DUE SEARCH OPTION */
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select [reg_no],[name],[total],[discount],((total-discount-due)+due_paid),(due-due_paid),date from user_cash_collection_OPD where due>'" + a + "' and type='OPD Bill' and due_paid<due and(name like'%" + richTextBox1.Text + "%' or reg_no like'%" + richTextBox1.Text + "%') ", db.sql);
                dataGridView8.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView8.Rows.Add();
                    dataGridView8.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView8.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView8.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView8.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView8.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView8.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView8.Rows[n].Cells[6].Value = item[6].ToString();

                }
                db.sql.Close();
            }
            catch
            {

            }
        }


    }
}
