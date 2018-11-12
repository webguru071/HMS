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
    public partial class Reagent_Relation : Form
    {
        connection db = new connection();
        string test_id = "";
        string reagent_id = "";
        public Reagent_Relation()
        {
            InitializeComponent();
            show_relation();
        }

        void show_relation()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select test_id,name,reagent_id,product_name,decrease_amount from reagent_decrease,lab_inventory,diagnostic_list where reagent_decrease.test_id=diagnostic_list.id and reagent_decrease.reagent_id=lab_inventory.id", db.sql);
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
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
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
                test_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                reagent_id = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            { 
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do you want to Delete This","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("delete from reagent_decrease where test_id='" + test_id + "' and reagent_id='" + reagent_id + "'", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Delete Sucessfull");
                        show_relation();
                    }
                    db.sql.Close();
                }
                else
                { 
                
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
                SqlCommand cmd = new SqlCommand("update reagent_decrease set decrease_amount='"+textBox1.Text+"' where test_id='"+test_id+"' and reagent_id='"+reagent_id+"'",db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Update Sucessfull");
                    show_relation();
                }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

    }
}
