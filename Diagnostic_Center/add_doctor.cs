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
    public partial class add_doctor : Form
    {
         connection db = new connection();

        // SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public add_doctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();


                SqlCommand cmd = new SqlCommand("insert into doctors(name,contact,email,designation)values('" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + richTextBox3.Text + "','" + richTextBox4.Text + "')", db.sql);

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("inserted Successfully");
                }
            }

            catch
            {

            }

        }
    }
}
