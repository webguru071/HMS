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
    public partial class Anaesthesia : Form
    {
        connection db = new connection();
        public string sur { get; set; }
        public Anaesthesia()
        {
            InitializeComponent();
            sur = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sur = comboBox1.Text;
            this.Close();
        }


        void refere_doctor2()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select name from refer_doctor", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                while (read.Read())
                {
                    String name = read[0].ToString();
                    comboBox1.Items.Add(name);
                }

                db.sql.Close();
            }

            catch
            {


            }

        }

        private void Anaesthesia_Load(object sender, EventArgs e)
        {
            refere_doctor2();
        }
    }
}
