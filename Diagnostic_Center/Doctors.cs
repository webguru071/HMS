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
using System.Text.RegularExpressions;
using System.Globalization;
namespace Diagnostic_Center
{
    public partial class Doctors : Form
    {
        int delete_drugs = 0;
        int delete_test = 0;
        string test_id = "";
        string doctor;
        string drugs_name;
        connection db = new connection();
        string reg_no;
        public Doctors()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            string formattedDate = DateTime.Now.ToString();
            dateTimePicker1.Text = formattedDate;
            //  dateTimeInput1.Text = formattedDate;
             show_appointment();
            show_drugs();
            show_test_name();
            show_doctor();
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine where name like '%" + richTextBox6.Text + "%'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX2.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX2.Rows.Add();
                    dataGridViewX2.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX2.Rows[n].Cells[1].Value = item[1].ToString();


                }
                db.sql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        //********************************************************************************************************************
        void show_drugs()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX2.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX2.Rows.Add();
                    dataGridViewX2.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX2.Rows[n].Cells[1].Value = item[1].ToString();


                }
                db.sql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //****************************************************************

        void show_test_name()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_list", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX3.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX3.Rows.Add();
                    dataGridViewX3.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX3.Rows[n].Cells[1].Value = item[1].ToString();

                }
                db.sql.Close();
            }
            catch
            { }

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {


            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_list where name like'%" + richTextBox7.Text + "%'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX3.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX3.Rows.Add();
                    dataGridViewX3.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX3.Rows[n].Cells[1].Value = item[1].ToString();


                }
                db.sql.Close();
            }
            catch
            {

            }

           /* int i = 0;
            int c = dataGridViewX3.Rows.Count;
            for (i = 0; i <c-1; i++)
            {
                string x = dataGridViewX3.Rows[i].Cells[1].Value.ToString();
                string input = x;
                string pattern = richTextBox7.Text;
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

                if (regex.IsMatch(input))
                {
                    DataGridViewRow rowToSelect = this.dataGridViewX3.Rows[i];

                    rowToSelect.Selected = true;



                    rowToSelect.Cells[0].Selected = true;

                    this.dataGridViewX3.CurrentCell = rowToSelect.Cells[0];

                    this.dataGridViewX3.BeginEdit(true);
                }
                    
                else
                {
                   
                }
              
            }
           DataGridViewRow rowToSelect = this.dataGridViewX3.Rows[5];

            rowToSelect.Selected = true;



            rowToSelect.Cells[0].Selected = true;

            this.dataGridViewX3.CurrentCell = rowToSelect.Cells[0];

            this.dataGridViewX3.BeginEdit(true);*/
        }
        //**********************************************************************************************************************
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int exe = 0;
                int id = 0; ;
                string val1 = "";
                string val2 = "";
                string val3 = "";
                string val4 = "";
                string val5 = "";
                string days_bac = (richTextBox17.Text) + " " + comboBox3.Text;
                int n = 0;
                int c = dataGridView3.Rows.Count;
                db.sql.Close();
                db.sql.Open();
                for (n = 0; n <= c - 1; n++)
                {
                    val1 = dataGridView3.Rows[n].Cells[0].Value.ToString();
                    val2 = dataGridView3.Rows[n].Cells[1].Value.ToString();
                    val3 = dataGridView3.Rows[n].Cells[2].Value.ToString();
                    val4 = dataGridView3.Rows[n].Cells[3].Value.ToString();
                    val5 = dataGridView3.Rows[n].Cells[4].Value.ToString();
                    id = Convert.ToInt32(dataGridView3.Rows[n].Cells[5].Value.ToString());
                    SqlCommand cmd = new SqlCommand("update prescription set drugs_name=N'" + val1 + "',qt=N'" + val2 + "', routine=N'" + val3 + "',days=N'" + val4 + "',b_or_a=N'" + val5 + "' where id='" + id + "'", db.sql);

                    exe = cmd.ExecuteNonQuery();

                }
                if (exe > 0)
                {

                }
                update_symptoms();
                update_diagnosis();
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd2 = new SqlCommand("update advice set advice=N'" + richTextBox12.Text + "',days=N'" + days_bac+ "' where reg_no='" + richTextBox1.Text + "'", db.sql);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfull");
                db.sql.Close();
                Prescription po = new Prescription(richTextBox1.Text);
                po.Show();

            }
            catch
            {

            }
        }

        void update_symptoms()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("update symptoms set symptoms='" + richTextBox8.Text + "' where reg_no='" + richTextBox1.Text + "'", db.sql);
                cmd.ExecuteNonQuery();
                db.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void update_diagnosis()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("update diagnosis set diagnosis='" + richTextBox13.Text + "' where reg_no='" + richTextBox1.Text + "'", db.sql);
                cmd.ExecuteNonQuery();
                db.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        //*************************************************************************************************
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text == "" || richTextBox2.Text == "" || richTextBox4.Text == "")
                {
                    MessageBox.Show("Please give Patient Information");
                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();

                    SqlCommand cmd = new SqlCommand("insert into prescription(reg_no,doctors_name,drugs_name)values(N'" + richTextBox1.Text + "',N'" + doctor + "',N'" + drugs_name + "')", db.sql);
                    cmd.ExecuteNonQuery();
                    db.sql.Close();
                    show_prescription();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//*******************************************************************************************************************************


        void show_prescription()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select drugs_name,qt,routine,days,b_or_a,id from prescription where reg_no='" + richTextBox1.Text + "'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //  dataGridView3.DataSource = y;
                dataGridView3.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView3.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView3.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView3.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView3.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView3.Rows[n].Cells[5].Value = item[5].ToString();
                }
                db.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                int d = 0;
                show_prescription();
                show_patient_test();
                show_symptoms();
                show_advice();
                show_diagnosis();
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from appointment where reg_no=N'" + richTextBox1.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    d++;
                    string name = read[1].ToString();
                    string address = read[2].ToString();
                    string age = read[3].ToString();
                    string sex = read[4].ToString();
                    string referance = read[5].ToString();
                    string date = read[6].ToString();
                    DateTime convert = DateTime.ParseExact(date, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                    string dd = convert.ToString("dd/MM/yyyy");
                    doctor = read[7].ToString();
                    richTextBox2.Text = name;
                    richTextBox3.Text = address;
                    richTextBox4.Text = age;
                    comboBoxEx3.Text = sex;
                    richTextBox5.Text = referance;
                    dateTimeInput1.Text = dd.ToString();

                }
                if (d == 0)
                {

                    richTextBox2.Text = "";
                    richTextBox3.Text = "";
                    richTextBox4.Text = "";
                    comboBoxEx3.Text = "";
                    richTextBox5.Text = "";
                    dateTimeInput1.Text = "";
                }

                db.sql.Close();

            }
            catch
            {

            }
        }
        //***************************************************************************************************

        void show_patient_test()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from patient_test where reg_no='" + richTextBox1.Text + "'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[2].ToString();
                    string x = dataGridView1.Rows[n].Cells[1].Value.ToString();
                    if (x == "")
                    {
                        dataGridView1.Rows[n].Visible = false;
                    }
                }
            }
            catch
            {

            }
        }
        //********************************************************************************************************


        void show_symptoms()
        {
            try
            {
                string symptoms = "";
                int x = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from symptoms where reg_no='" + richTextBox1.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    symptoms = read[1].ToString();

                    x++;
                }
                if (x > 0)
                {
                    richTextBox8.Text = symptoms;
                }
                else
                {
                    richTextBox8.Text = "";
                }

                db.sql.Close();
            }
            catch
            {

            }

        }


        void show_advice()
        {


            try
            {
                string advice = "";
                string days = "";
                int x = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from advice where reg_no='" + richTextBox1.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    advice = read[1].ToString();
                    days = read[2].ToString();
                    x++;
                }
                if (x > 0)
                {
                    richTextBox12.Text = advice;
                    richTextBox17.Text = days;
                }
                else
                {
                    richTextBox12.Text = "";
                }

                db.sql.Close();
            }
            catch
            {

            }

        }


        void show_diagnosis()
        {


            try
            {
                string diagnosis = "";
                int x = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from diagnosis where reg_no='" + richTextBox1.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    diagnosis = read[1].ToString();

                    x++;
                }
                if (x > 0)
                {
                    richTextBox13.Text = diagnosis;
                }
                else
                {
                    richTextBox13.Text = "";
                }

                db.sql.Close();
            }
            catch
            {

            }

        }

        private void dataGridViewX2_Click(object sender, EventArgs e)
        {
            try
            {
                drugs_name = dataGridViewX2.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            try
            {
                delete_drugs = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[5].Value.ToString());
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from prescription where id='" + delete_drugs + "'", db.sql);
                cmd.ExecuteNonQuery();
                db.sql.Close();
                show_prescription();
            }
            catch
            {
            }
        }

        private void dataGridViewX3_Click(object sender, EventArgs e)
        {
            try
            {
                test_id = dataGridViewX3.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text == "")
                {

                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("insert into patient_test(reg_no,test_name)values('" + richTextBox1.Text + "','" + test_id + "')", db.sql);
                    cmd.ExecuteNonQuery();
                    db.sql.Close();
                    show_patient_test();
                }
            }
            catch
            {
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                delete_test = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from patient_test where Id='" + delete_test + "'", db.sql);
                cmd.ExecuteNonQuery();
                show_patient_test();
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
                int exe = 0;
                int id = 0; ;
                string val1 = "";
                string val2 = "";
                string val3 = "";
                string val4 = "";
                string val5 = "";
                int n = 0;
                string days_bac = (richTextBox17.Text) + " " + comboBox3.Text;
                int c = dataGridView3.Rows.Count;
                db.sql.Close();
                db.sql.Open();
                for (n = 0; n <= c - 1; n++)
                {
                    val1 = dataGridView3.Rows[n].Cells[0].Value.ToString();
                    val2 = dataGridView3.Rows[n].Cells[1].Value.ToString();
                    val3 = dataGridView3.Rows[n].Cells[2].Value.ToString();
                    val4 = dataGridView3.Rows[n].Cells[3].Value.ToString();
                    val5 = dataGridView3.Rows[n].Cells[4].Value.ToString();
                    id = Convert.ToInt32(dataGridView3.Rows[n].Cells[5].Value.ToString());
                    SqlCommand cmd = new SqlCommand("update prescription set drugs_name=N'" + val1 + "',qt=N'" + val2 + "', routine=N'" + val3 + "',days=N'" + val4 + "',b_or_a=N'" + val5 + "' where id='" + id + "'", db.sql);

                    exe = cmd.ExecuteNonQuery();

                }
                if (exe > 0)
                {

                }
                update_symptoms();
                update_diagnosis();
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd2 = new SqlCommand("update advice set advice=N'" + richTextBox12.Text + "',days=N'" + days_bac + "' where reg_no='" + richTextBox1.Text + "'", db.sql);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfull");
                db.sql.Close();
                // prescription_two po = new prescription_two(richTextBox1.Text);
                // po.Show();

            }
            catch
            {

            }
        }
       //************************************************


        void show_drugs2()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();


                }
                db.sql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void tabItem2_Click(object sender, EventArgs e)
        {
            try
            {
                show_drugs2();

            }
            catch
            { 
            
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                label14.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

            }
            catch
            {

            }
        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine Where name  like'%" + richTextBox11.Text + "%'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();


                }
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from medicine where id='" + label14.Text + "'", db.sql);
                cmd.ExecuteNonQuery();
                show_drugs2();
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string med = comboBox1.Text + "-" + richTextBox9.Text + "-" + richTextBox10.Text;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("insert into medicine(name)values('" + med + "')", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Save Sucessfull");
                    show_drugs2();
                }
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void tabItem3_Click(object sender, EventArgs e)
        {
            show_test_name2();
        }


        void show_test_name2()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_list", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX4.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX4.Rows.Add();
                    dataGridViewX4.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX4.Rows[n].Cells[1].Value = item[3].ToString();
                    dataGridViewX4.Rows[n].Cells[2].Value = item[1].ToString();
                    dataGridViewX4.Rows[n].Cells[3].Value = item[2].ToString();
                }
                db.sql.Close();
            }
            catch
            { }

        }

        private void dataGridViewX4_Click(object sender, EventArgs e)
        {
            try
            {
                test_id = dataGridViewX4.SelectedRows[0].Cells[0].Value.ToString();
                richTextBox16.Text = dataGridViewX4.SelectedRows[0].Cells[0].Value.ToString();
                comboBox2.Text = dataGridViewX4.SelectedRows[0].Cells[1].Value.ToString();
                richTextBox14.Text = dataGridViewX4.SelectedRows[0].Cells[2].Value.ToString();
                richTextBox15.Text = dataGridViewX4.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch
            {
            }
        }

        private void richTextBox26_TextChanged(object sender, EventArgs e)
        {
            try
            {

                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_list where name like'%" + richTextBox26.Text + "%' or id like '%" + richTextBox26.Text + "%'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX4.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX4.Rows.Add();
                    dataGridViewX4.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX4.Rows[n].Cells[1].Value = item[3].ToString();
                    dataGridViewX4.Rows[n].Cells[2].Value = item[1].ToString();
                    dataGridViewX4.Rows[n].Cells[3].Value = item[2].ToString();
                }
                db.sql.Close();
            }

            catch
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                double p = Convert.ToDouble(richTextBox15.Text);
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("insert into diagnostic_list(id,name,price,type)values('" + richTextBox16.Text+ "','" + richTextBox14.Text + "','" + p + "','" + comboBox2.Text + "')", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {

                    MessageBox.Show("Saved Sucessfully");
                    show_test_name();
                }
                db.sql.Close();

            }
            catch
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("update diagnostic_list set type='" + comboBox2.Text + "',name='" + richTextBox14.Text + "',price='" + richTextBox15.Text + "' where id='" + richTextBox16.Text + "'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Update Sucessfull");
                    show_test_name2();
                }
                db.sql.Close();
            }
            catch
            {
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do You Want to Delete The Test Name??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("delete from diagnostic_list where id='" + richTextBox16.Text + "'", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Delete Sucessfull");
                        show_test_name2();
                    }
                    db.sql.Close();
                }
            }
            catch
            {

            }
        }

        private void richTextBox26_Click(object sender, EventArgs e)
        {
            richTextBox26.Clear();
        }

        void show_appointment()
        {
            try
            {
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from appointment where date='" + dd + "'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();
                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();


                }
                db.sql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewX1_Click(object sender, EventArgs e)
        {
            try
            {
                reg_no = dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString();
                richTextBox1.Text = reg_no;
                show_details();
                show_prescription();
                show_patient_test();
                show_symptoms();
                show_advice();
                show_diagnosis();
            }
            catch
            {

            }
        }
        void show_details()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from appointment where reg_no=N'" + reg_no + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    string name = read[1].ToString();
                    string address = read[2].ToString();
                    string age = read[3].ToString();
                    string sex = read[4].ToString();
                    string referance = read[5].ToString();
                    string date = read[6].ToString();
                    DateTime convert = DateTime.ParseExact(date, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                    string dd = convert.ToString("dd/MM/yyyy");
                    doctor = read[7].ToString();
                    richTextBox2.Text = name;
                    richTextBox3.Text = address;
                    richTextBox4.Text = age;
                    comboBoxEx3.Text = sex;
                    richTextBox5.Text = referance;
                    dateTimeInput1.Text = date;


                }

                db.sql.Close();
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
                        comboBoxEx1.Items.Add(name);
                        

                    }
                }

                db.sql.Close();
            }
            catch
            { }
        }

        private void comboBoxEx1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from appointment where date='" + dd + "' and doctor='" + comboBoxEx1.Text + "'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewX1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();
                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();


                }
                db.sql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tabItem4_Click(object sender, EventArgs e)
        {
            View_Appointment va = new View_Appointment();
            va.Show();
        }
    }
}
