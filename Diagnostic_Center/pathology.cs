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
    public partial class pathology : Form
    {
        string delete_test_group = "";
        string delete_sub_test_group = "";
        string delete_result = "";
        string edit_group = "";
        string edit_test_name = "";
        string group = "";
        string sub_group = "";
        string test_name = "";
        string normal = "";
        string unit = "";
        connection db = new connection();
        public pathology(string x)
        {
            InitializeComponent();
            show_group();
            show_sub_group();
            show_list();
            show_list2();
            show_diagnostic_test();
            this.WindowState = FormWindowState.Maximized;
            richTextBox5.Text = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Give a Group Name");
                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("insert into test_group(name)values('" + richTextBox1.Text + "')", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Add Sucessfull");
                        show_group();
                        show_group_row();
                    }

                    db.sql.Close();
                }
            }
            catch
            {

            }
        }


        void show_group()
        {
            try
            {
                comboBox1.Items.Clear();
                comboBox3.Items.Clear();
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select name from test_group", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {

                    comboBox1.Items.Add(read[0].ToString());
                    comboBox3.Items.Add(read[0].ToString());
                }
                db.sql.Close();
            }
            catch
            {

            }

        }

        void show_sub_group()
        {
            try
            {
                comboBox2.Items.Clear();
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select name from sub_test_group", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {

                    comboBox2.Items.Add(read[0].ToString());
                }
                db.sql.Close();
            }
            catch
            {

            }
        }
        void show_list()
        {

            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from lab_test_list", db.sql);
                DataTable dt = new DataTable();
                dataGridView3.Rows.Clear();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView3.Rows[n].Cells[1].Value = item[2].ToString();
                    dataGridView3.Rows[n].Cells[2].Value = item[3].ToString();
                    dataGridView3.Rows[n].Cells[3].Value = item[4].ToString();
                    dataGridView3.Rows[n].Cells[4].Value = item[5].ToString();
                   
                }
                db.sql.Close();
            }
            catch
            {

            }
        }


        void show_list2()
        {

            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from lab_test_list", db.sql);
                DataTable dt = new DataTable();
                Select_test_list.Rows.Clear();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = Select_test_list.Rows.Add();
                    Select_test_list.Rows[n].Cells[0].Value = item[3].ToString();
                    Select_test_list.Rows[n].Cells[1].Value = item[1].ToString();
                    Select_test_list.Rows[n].Cells[2].Value = item[2].ToString();
                    Select_test_list.Rows[n].Cells[3].Value = item[4].ToString();
                    Select_test_list.Rows[n].Cells[4].Value = item[5].ToString();

                }
                db.sql.Close();
            }
            catch
            {

            }
        }
        void show_result()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from test_result where reg_no='" + richTextBox5.Text + "'", db.sql);
                DataTable dt = new DataTable();
                dataGridView2.Rows.Clear();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item[4].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item[6].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item[5].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = item[0].ToString();


                }
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                show_diagnostic_test();
                show_result();
            }
            catch
            { }
        }


        void show_diagnostic_test()
        {

            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from diagnostic_bill where  invoice_id=N'" + richTextBox5.Text + "'", db.sql);
                DataTable dt = new DataTable();
                dataGridView1.Rows.Clear();
                sda.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    int nn = dataGridView1.Rows.Add();
                    dataGridView1.Rows[nn].Cells[0].Value = item[1].ToString();
                   // dddddddddd.Rows[nn].Cells[0].Value = item[1].ToString();
                }
                db.sql.Close();

                string name = "";
                db.sql.Close();
                db.sql.Open();

                SqlCommand cmd = new SqlCommand("select name from diagnostic_person where id=N'" + richTextBox5.Text + "'", db.sql);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {

                    name = r[0].ToString();


                }
              //  richTextBox41.Text = name;
            }
            catch
            {

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from lab_test_list where test_name like '%" + textBox1.Text + "%'", db.sql);
                DataTable dt = new DataTable();
                Select_test_list.Rows.Clear();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = Select_test_list.Rows.Add();
                    Select_test_list.Rows[n].Cells[0].Value = item[3].ToString();
                    Select_test_list.Rows[n].Cells[1].Value = item[1].ToString();
                    Select_test_list.Rows[n].Cells[2].Value = item[2].ToString();
                    Select_test_list.Rows[n].Cells[3].Value = item[4].ToString();
                    Select_test_list.Rows[n].Cells[4].Value = item[5].ToString();

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
                if (richTextBox5.Text == "")
                {
                    MessageBox.Show("Give registration Number");
                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("insert into test_result(reg_no,group_name,sub_group,test_name,normal,result,unit)values('" + richTextBox5.Text + "','" + group + "','" + sub_group + "','" + test_name + "','" + normal + "','','" + unit + "')", db.sql);

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        //    MessageBox.Show("Add Sucessfull");
                        show_result();
                    }

                    db.sql.Close();
                }
            }
            catch
            {

            }
        }

        private void selecting_test_list_Click(object sender, EventArgs e)
        {
            try
            {
                group = Select_test_list.SelectedRows[0].Cells[1].Value.ToString();
                sub_group = Select_test_list.SelectedRows[0].Cells[2].Value.ToString();
                test_name = Select_test_list.SelectedRows[0].Cells[0].Value.ToString();
                normal = Select_test_list.SelectedRows[0].Cells[3].Value.ToString();
                unit = Select_test_list.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            try
            {
                if (richTextBox5.Text == "")
                {
                    MessageBox.Show("Registration No  and Invoice no must needed");
                }
                else
                {

                    int n = 0;

                    string val1 = "";
                    string val2 = "";

                    int c = dataGridView2.Rows.Count;

                    for (n = 0; n <= c - 2; n++)
                    {
                        int cc = 0;
                        db.sql.Close();
                        db.sql.Open();
                        val1 = dataGridView2.Rows[n].Cells[1].Value.ToString();
                        val2 = dataGridView2.Rows[n].Cells[3].Value.ToString();


                        db.sql.Close();
                        db.sql.Open();
                        SqlCommand cmd2 = new SqlCommand("update test_result set result='" + val1 + "' where id='" + val2 + "'", db.sql);
                        x = cmd2.ExecuteNonQuery();


                    }
                    if (x > 0)
                    {
                        print_report pr = new print_report(richTextBox5.Text);
                        pr.Show();
                    }

                }

            }
            catch
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            print_report2 pr2 = new print_report2(richTextBox5.Text);
            pr2.Show();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                delete_result = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            }

            catch
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from test_result where id='" + delete_result + "'", db.sql);
                int a = cmd.ExecuteNonQuery();
                show_result();
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
                if (richTextBox2.Text == "")
                {
                    MessageBox.Show("Give a Sub Group Name");
                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("insert into sub_test_group(name)values('" + richTextBox2.Text + "')", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Add Sucessfull");
                        show_sub_group();
                        showsub__group_row();
                     
                    }
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
                int c = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd1 = new SqlCommand("select test_name from lab_test_list where test_name='" + richTextBox3.Text + "' and group_name='" + comboBox1.Text + "'", db.sql);
                SqlDataReader re = cmd1.ExecuteReader();
                while (re.Read())
                {
                    c++;
                }
                if (c > 0)
                {
                    MessageBox.Show("Test Name already Added");
                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("insert into lab_test_list(group_name,sub_group,test_name,normal,unit)values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + richTextBox3.Text + "','" + richTextBox4.Text + "','" + richTextBox7.Text + "')", db.sql);

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Add Sucessfull");
                        show_list();
                    }

                    db.sql.Close();
                }
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("update lab_test_list set group_name='" + comboBox1.Text + "',sub_group='" + comboBox2.Text + "',test_name='" + richTextBox3.Text + "',normal='" + richTextBox4.Text + "',unit='" + richTextBox7.Text + "' where group_name='" + edit_group + "' and test_name='" + edit_test_name + "' ", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {

                    MessageBox.Show("Update Sucessfull", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    show_list();
                }
                db.sql.Close();
            }

            catch
            {


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from lab_test_list  where group_name='" + edit_group + "' and test_name='" + edit_test_name + "' ", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {

                    MessageBox.Show("Delete Sucessfull");
                    show_list();
                }
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            try
            {
                edit_test_name = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                edit_group = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                comboBox1.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                comboBox2.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                richTextBox3.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                richTextBox4.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
                richTextBox7.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();

            }

            catch
            {

            }
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from lab_test_list where test_name like '%" + richTextBox6.Text + "%'", db.sql);
                DataTable dt = new DataTable();
                dataGridView3.Rows.Clear();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView3.Rows[n].Cells[1].Value = item[2].ToString();
                    dataGridView3.Rows[n].Cells[2].Value = item[3].ToString();
                    dataGridView3.Rows[n].Cells[3].Value = item[4].ToString();
                    dataGridView3.Rows[n].Cells[4].Value = item[5].ToString();

                }
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from lab_test_list where group_name like '%" + comboBox3.Text + "%'", db.sql);
                DataTable dt = new DataTable();
                Select_test_list.Rows.Clear();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = Select_test_list.Rows.Add();
                    Select_test_list.Rows[n].Cells[0].Value = item[3].ToString();
                    Select_test_list.Rows[n].Cells[1].Value = item[1].ToString();
                    Select_test_list.Rows[n].Cells[2].Value = item[2].ToString();
                    Select_test_list.Rows[n].Cells[3].Value = item[4].ToString();
                    Select_test_list.Rows[n].Cells[4].Value = item[5].ToString();

                }
                db.sql.Close();
            }
            catch
            {
            }
        }

        private void selecting_test_list_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    try
                    {
                        group = Select_test_list.SelectedRows[0].Cells[1].Value.ToString();
                        sub_group = Select_test_list.SelectedRows[0].Cells[2].Value.ToString();
                        test_name = Select_test_list.SelectedRows[0].Cells[0].Value.ToString();
                        normal = Select_test_list.SelectedRows[0].Cells[3].Value.ToString();
                        unit = Select_test_list.SelectedRows[0].Cells[4].Value.ToString();
                    }
                    catch
                    {

                    }
                    
                    if (richTextBox5.Text == "")
                    {
                        MessageBox.Show("Give registration Number");
                    }
                    else
                    {
                        db.sql.Close();
                        db.sql.Open();
                        SqlCommand cmd = new SqlCommand("insert into test_result(reg_no,group_name,sub_group,test_name,normal,result,unit)values('" + richTextBox5.Text + "','" + group + "','" + sub_group + "','" + test_name + "','" + normal + "','','" + unit + "')", db.sql);

                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            //    MessageBox.Show("Add Sucessfull");
                            show_result();
                        }

                        db.sql.Close();
                    }
                }
                catch
                {

                }
            }
            if (e.KeyCode == Keys.Back)
            {
                textBox1.Focus();

            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.YellowGreen;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.PageDown)
            {
                Select_test_list.Focus();
            }
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           // Select_test_list.Focus();
        }


        void show_group_row()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from test_group",db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView4.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView4.Rows.Add();
                    dataGridView4.Rows[n].Cells[0].Value = item[1].ToString();
                }
               // 
                db.sql.Close();

            }
            catch
            { 
            
            }
        }

        void showsub__group_row()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from sub_test_group", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView5.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView5.Rows.Add();
                    dataGridView5.Rows[n].Cells[0].Value = item[1].ToString();
                }
                // 
                db.sql.Close();

            }
            catch
            {

            }
        }
        private void tabItem2_Click(object sender, EventArgs e)
        {
            show_group_row();
            showsub__group_row();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from test_group where name='" + delete_test_group + "'", db.sql);
               int a= cmd.ExecuteNonQuery();
               if (a > 0)
               {
                   MessageBox.Show("Delete Sucessfull");
                   show_group_row();
                   show_group();
                   
               }
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {
            try
            {
                delete_test_group = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            { 
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from sub_test_group where name='" + delete_sub_test_group + "'", db.sql);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Delete Sucessfull");
                    showsub__group_row();
                    show_sub_group();

                }
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void dataGridView5_Click(object sender, EventArgs e)
        {
            try
            {
                delete_sub_test_group = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
            }
        }
    }
}
