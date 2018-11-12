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
    public partial class View_Employee : Form
    {
        connection db = new connection();
        public View_Employee()
        {
            InitializeComponent();
        }


        void show_all()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("", db.sql);
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        private void View_Employee_Load(object sender, EventArgs e)
        {
           
              
          
            dataGridView1.RowTemplate.MinimumHeight = 60;
            // TODO: This line of code loads data into the 'databaseDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.databaseDataSet.employee);

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string x = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Add_Employee add = new Add_Employee(x);
                add.Show();
            }
            catch
            { 
            
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string x = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Print_Employee_Info pei = new Print_Employee_Info(x);
                pei.Show();
            }
            catch
            {

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string x = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult r = MessageBox.Show("Do You want to delete this Employee","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    db.sql.Close();
                    db.sql.Open();

                    SqlCommand cmd = new SqlCommand("delete from employee where employee_id='"+x+"'",db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Delete SucessFull");

                        dataGridView1.RowTemplate.MinimumHeight = 60;
                        // TODO: This line of code loads data into the 'databaseDataSet.employee' table. You can move, or remove it, as needed.
                        this.employeeTableAdapter.Fill(this.databaseDataSet.employee);
                    }
                    db.sql.Close();
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print_all_Employee pall = new Print_all_Employee();
            pall.Show();
        }
    }
}
