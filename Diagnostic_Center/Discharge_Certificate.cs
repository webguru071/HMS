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
    public partial class Discharge_Certificate : Form
    {
        string doctor = "";
        connection db = new connection();
        public Discharge_Certificate()
        {
            InitializeComponent();
            history_set();
            show_doctor();
        }
        void history_set()
        {

            dataGridViewX1.Rows.Add(12);

            dataGridViewX1.Rows[0].Cells[0].Value = "Complain";
            dataGridViewX1.Rows[1].Cells[0].Value = "Examination";
            dataGridViewX1.Rows[2].Cells[0].Value = "Investigation";
            dataGridViewX1.Rows[3].Cells[0].Value = "Disease";
            dataGridViewX1.Rows[4].Cells[0].Value = "Operation Note";
            dataGridViewX1.Rows[5].Cells[0].Value = "Date of Operation-";
            dataGridViewX1.Rows[6].Cells[0].Value = "Time of Operation";
            dataGridViewX1.Rows[7].Cells[0].Value = "OT. No";
            dataGridViewX1.Rows[8].Cells[0].Value = "Pt. Weight";
            dataGridViewX1.Rows[9].Cells[0].Value = "Surgeon";
            dataGridViewX1.Rows[10].Cells[0].Value = "Anasthetist";
            dataGridViewX1.Rows[11].Cells[0].Value = "Assistant";
            dataGridViewX1.Rows[0].Height = 100;
            dataGridViewX1.Rows[1].Height = 100;
            dataGridViewX1.Rows[2].Height = 100;
            dataGridViewX1.Rows[4].Height = 80;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                MessageBox.Show("Patient History not  found");
            }
            else
            {
                if (comboBoxEx2.Text == "")
                {
                    MessageBox.Show("Select a Doctor");
                }

                else
                {
                    followup();
                    d_advice();
                    history();
                    Discharge_print dp = new Discharge_print(richTextBox1.Text);
                    dp.Show();
                }
            }

        }

        void followup()
        {
            try
            {
                int exe = 0;
                int id = 0; ;
                string val1 = "";
                string val2 = "";
                string val3 = "";
                string val4 = "";
                int n = 0;
                int c = dataGridView3.Rows.Count;
                db.sql.Close();
                db.sql.Open();
                for (n = 0; n <= c - 2; n++)
                {

                    val1 = dataGridView3.Rows[n].Cells[0].Value.ToString();
                    val2 = dataGridView3.Rows[n].Cells[1].Value.ToString();
                    val3 = dataGridView3.Rows[n].Cells[2].Value.ToString();
                    val4 = dataGridView3.Rows[n].Cells[3].Value.ToString();
                    id++;
                    SqlCommand cmd = new SqlCommand("insert into followup(reg_no,doctor,diagnosis,drugs_name,routine,days,b_or_a,id)values(N'" + richTextBox1.Text + "','" + doctor + "',N'" + richTextBox4.Text + "',N'" + val1 + "','" + val2 + "',N'" + val3 + "',N'" + val4 + "',N'" + id + "')", db.sql);

                    exe = cmd.ExecuteNonQuery();

                }

                if (exe > 0)
                {
                    MessageBox.Show("Data Saved Successfull");
                }
            }
            catch
            {

            }
        }
        void d_advice()
        {
            try
            {
                int n = 0;
                int exe = 0;
                int id = 0; ;
                string val1 = "";
                int c = dataGridViewX2.Rows.Count;
                db.sql.Close();
                db.sql.Open();
                for (n = 0; n <= c - 2; n++)
                {
                    val1 = dataGridViewX2.Rows[n].Cells[0].Value.ToString();
                    id++;
                    SqlCommand cmd = new SqlCommand("insert into d_advice(reg_no,advice)values(N'" + richTextBox1.Text + "',N'" + val1 + "')", db.sql);

                    exe = cmd.ExecuteNonQuery();
                }

                if (exe > 0)
                {

                }
            }
            catch
            {

            }

        }
        void history()
        {
            try
            {
                int n = 0;
                int exe = 0;
                int id = 0; ;
                string val1 = "";
                string val2 = "";
                int c = dataGridViewX1.Rows.Count;
                db.sql.Close();
                db.sql.Open();
                for (n = 0; n <= c - 1; n++)
                {
                    try
                    {
                        val1 = dataGridViewX1.Rows[n].Cells[0].Value.ToString();
                        val2 = dataGridViewX1.Rows[n].Cells[1].Value.ToString();
                    }
                    catch
                    {
                        val1 = val1 = dataGridViewX1.Rows[n].Cells[0].Value.ToString();
                        val2 = "";
                    }
                    id++;
                    SqlCommand cmd = new SqlCommand("insert into history(reg_no,title,study)values(N'" + richTextBox1.Text + "',N'" + val1 + "',N'" + val2 + "')", db.sql);

                    exe = cmd.ExecuteNonQuery();

                }

                if (exe > 0)
                {

                }
            }
            catch
            {

            }
        }

        void show_doctor()
        {
            try
            {
                int c = 0;
                string name = "";
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from doctors", db.sql);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {

                    c++;
                    name = r[1].ToString();
                    if (c > 0)
                    {
                        // comboBoxEx1.Items.Add(name);
                        comboBoxEx2.Items.Add(name);
                    }
                }

                db.sql.Close();
            }
            catch
            { }
        }

        private void comboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select name from doctors where name='" + comboBoxEx2.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    doctor = read[0].ToString();
                }
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            db.sql.Close();
            db.sql.Open();
            int c = 0;
            SqlCommand cmd = new SqlCommand("select * from patient_histroy where reg_no=N'" + richTextBox1.Text + "'", db.sql);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                c++;
                label3.Text = r[1].ToString();

            }
            if (c == 0)
            {
                label3.Text = "";
            }
            db.sql.Close();
        }
    }
}
