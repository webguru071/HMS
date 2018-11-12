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
    public partial class Medicine_Company : Form
    {
        public string val1 { get; set; }
        string id = "";
        connection db = new connection();
        public Medicine_Company()
        {
            InitializeComponent();
            val1 = "";
            show_company();
        }

        /* Add */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("insert into medicine_company(company_name)values('"+textBox1.Text+"')",db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Company Added Sucessfully");
                    val1 = "1";
                    show_company();
                }
                else {
                    MessageBox.Show("Something Wrong","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                db.sql.Close();

            }
            catch
            { 
            
            }
        }

        void show_company()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine_company order by company_name ASC",db.sql);
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
            catch(Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }
        
        }

        /*Grid Click */
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }

            catch
            { 
            
            }
        }

        /*Update*/
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("update medicine_company set company_name='"+textBox1.Text+"' where id='"+id+"'",db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Update Sucessfull");
                    val1 = "1";
                    show_company();
                }
                else
                {
                    MessageBox.Show("Something Wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        /*Delete*/
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("Delete from medicine_company where id='" + id + "'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Delete Sucessfull");
                    val1 = "1";
                    show_company();
                }
                else
                {
                    MessageBox.Show("Something Wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.sql.Close();
            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
