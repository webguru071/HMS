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
    public partial class Pharmacy : Form
    {
        string user_name = "";
        string password = "";
        int id;
       
        int quantity_old=0;
        string name_sells;
        string pharmacy_due_name = "";
        int quant_sells=0;
        double already_paid = 0;
        connection db = new connection();
        String user_type = "";
        public Pharmacy(string x,string y,string type)
        {
            InitializeComponent();

            /* Functions */
            show_due();             //initially Show all due in Datagrid 3
            view_medicine();        // View Running Stock in Datagrid 1
            medicine_catagory();    // Combobox 1 Category Loaded initially
            clear_field();          // Clear all field
 
            /* Get-Set */
            user_name = x;          
            password= y;
            user_type = type;
        }

        /*================================================================================================================================
                                                          PHARMACY PART
        ==================================================================================================================================*/
        /* Tab Control Click */
        private void tabControl1_Click(object sender, EventArgs e)
        {
            show_due();
        }

        /* Pharmacy load */
        private void Pharmacy_Load(object sender, EventArgs e)
        {
            view_medicine();
        }

        /* New Button Click */
        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                clear_field();
            }
            catch
            {

            }
        }

        /* ID Change */
        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string name = "";
                string age = "";
                string gender = "";
                string contact = "";
                string ttt = "";
                string discount = "";
                string paid = "";
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from medicine_selling_history where inv_id='" + richTextBox7.Text + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    name = read[2].ToString();
                    age = read[3].ToString();
                    gender = read[4].ToString();
                    contact = read[5].ToString();
                    ttt = read[7].ToString();
                    discount = read[6].ToString();
                    paid = read[8].ToString();
                }
                richTextBox4.Text = name;
                richTextBox5.Text = age;
                comboBox2.Text = gender;
                richTextBox2.Text = contact;
                label23.Text = ttt;
                richTextBox9.Text = discount;
                richTextBox6.Text = paid;
                db.sql.Close();
                view_sells();
            }
            catch
            {

            }
        }

        /* Clear Field Function*/
        private void clear_field()
        {
            try
            {
                inv_id_generate();
                dataGridView2.Rows.Clear();
                label13.Text = "";
                label19.Text = "";
                label26.Text = "";
                richTextBox3.Text = "";
                richTextBox4.Text = "";
                richTextBox5.Text = "";
                richTextBox6.Text = "";
                label28.Text = "";
                label23.Text = "";
                richTextBox9.Text = "";
                label24.Text = "";
                richTextBox11.Text = "";
                comboBox2.Text = "";



            }
            catch
            {

            }
        }

        /* ID Generate*/
        void inv_id_generate()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select max(inv_id) from medicine_sells", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    id = Convert.ToInt32(read[0]);

                }

                richTextBox7.Text = (id + 1).ToString();
                db.sql.Close();
            }
            catch
            {

            }

        }

        /* View Medicine Stock 'Datagrid 1' */
        void view_medicine()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine_pharmacy ", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();

                }
                db.sql.Close();
            }
             catch
             {

             }
        }
        
        /* Medicine Stock Click */
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {


                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string price = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string quantity = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


                label13.Text = name;
                label19.Text = price;
                richTextBox11.Text = quantity;
                label26.Text = quantity;

            }
            catch
            {

            }
        }

        /* Medicine Category Load In Combobox 1*/
        void medicine_catagory()
        {
            try
            {
                comboBox1.Items.Clear();
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select catagory from medicine_pharmacy", db.sql);
                SqlDataReader read = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (read.Read())
                {
                    comboBox1.Items.Add(read[0].ToString());
                }
                comboBox1.Items.Add("ALL");
                db.sql.Close();

            }
            catch
            {


            }

        }
        
        /* Category Change */
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "ALL")
            {
                view_medicine();
            }
            else
            {
                try
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from medicine_pharmacy where catagory='" + comboBox1.Text + "'", db.sql);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.Rows.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();

                    }
                    db.sql.Close();

                }
                catch
                {


                }
            }
        }

        /* Medicine Search */
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine_pharmacy where name like'%" + richTextBox1.Text + "%'", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();

                }
                db.sql.Close();

            }
            catch
            {


            }
        }

        /* ADD Button Click */
        private void button1_Click(object sender, EventArgs e)
        {
           try
            {

                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                if (richTextBox7.Text == "")
                {
                    MessageBox.Show("Enter Invoice Id");
                }
                if (richTextBox4.Text == "")
                {
                    MessageBox.Show("Enter Name..");
                }
                else if (label13.Text == "")
                {
                    MessageBox.Show("Select any Medicine");
                }
                else
                {
                       db.sql.Close();
                        db.sql.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select * from medicine_sells where inv_id = '" + richTextBox7.Text + "' and name = '" + label13.Text + "' ", db.sql);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            int quannt = 0;
                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd000 = new SqlCommand("select quantity from medicine_sells where inv_id = '" + richTextBox7.Text + "' and name = '" + label13.Text + "'", db.sql);
                            SqlDataReader read = cmd000.ExecuteReader();
                            while (read.Read())
                            {
                                quannt = Convert.ToInt32(read[0]);


                            }
                            int quantitynn = Convert.ToInt32(richTextBox11.Text);

                            int qqqq = quannt - quantitynn;

                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd00 = new SqlCommand("update medicine_sells set quantity = '" + quantitynn + "' where inv_id = '" + richTextBox7.Text + "' and name = '" + label13.Text + "'", db.sql);
                            cmd00.ExecuteNonQuery();
                            db.sql.Close();
                            int quantity_oldd = 0;
                            db.sql.Open();
                            SqlCommand cmd111 = new SqlCommand("select quantity from medicine_pharmacy where name='" + label13.Text + "' ", db.sql);
                            SqlDataReader read1 = cmd111.ExecuteReader();
                            while (read1.Read())
                            {
                                quantity_oldd = Convert.ToInt32(read1[0]);


                            }
                            int q_up = quantity_oldd + qqqq;
                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd22 = new SqlCommand("update medicine_pharmacy set quantity='" + q_up + "' where name='" + label13.Text + "'", db.sql);
                            cmd22.ExecuteNonQuery();
                            db.sql.Close();
                            view_medicine();
                            view_sells();
                            count_sum();
                        }


                        else
                        {
                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd1 = new SqlCommand("select quantity from medicine_pharmacy where name='" + label13.Text + "' ", db.sql);
                            SqlDataReader read1 = cmd1.ExecuteReader();
                            while (read1.Read())
                            {
                                quantity_old = Convert.ToInt32(read1[0]);


                            }
                            int quantity_new = Convert.ToInt32(richTextBox11.Text);
                            if (quantity_old >= quantity_new)
                            {
                                int quantity_update = quantity_old - quantity_new;
                                db.sql.Close();
                                db.sql.Open();

                                SqlCommand cmd2 = new SqlCommand("update medicine_pharmacy set quantity='" + quantity_update + "' where name='" + label13.Text + "'", db.sql);
                                cmd2.ExecuteNonQuery();
                                db.sql.Close();
                                db.sql.Open();
                                double bpp = 0;
                                //fetch sp bp
                                SqlCommand cmd12 = new SqlCommand("select buing_price from medicine_pharmacy where name='" + label13.Text + "' ", db.sql);
                                SqlDataReader read12 = cmd12.ExecuteReader();
                                while (read12.Read())
                                {
                                    bpp = Convert.ToDouble(read12[0]);



                                }
                                db.sql.Close();
                                db.sql.Open();
                                SqlCommand cmd = new SqlCommand("insert into medicine_sells(inv_id,name,quantity,price,date,date2,bp)values('" + richTextBox7.Text + "','" + label13.Text + "','" + richTextBox11.Text + "','" + label19.Text + "','"+date+"','"+dd+"','"+bpp+"')", db.sql);
                                cmd.ExecuteNonQuery();

                                db.sql.Close();
                            }
                            else
                            {
                                MessageBox.Show("STOCK LOW !!");
                            }

                            db.sql.Close();
                            view_medicine();
                            view_sells();
                            count_sum();

                        }
                
              
                    }
                    quant_sells = 0;
                    name_sells = "";
                }
            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* Count Sum */
        void count_sum()
        {
            try
            {
                int match = Convert.ToInt32(richTextBox7.Text);
                db.sql.Close();
                db.sql.Open();
                double x = 0;
                SqlCommand cmd = new SqlCommand("select sum(price*quantity) from medicine_sells where inv_id='" + match + "'", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    x = Convert.ToDouble(read[0].ToString());

                }
                db.sql.Close();
                label23.Text = x.ToString();

                if (label23.Text != "")
                {
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
                else
                {
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
            }


            catch {
                label23.Text = "0";
            }

        }

        /* View Sells Function  'Datagrid 2' */
        void view_sells()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine_sells where inv_id = '" + richTextBox7.Text + "'  ", db.sql);
                dataGridView2.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item[3].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();

                }
            }
            catch
            {

            }
        }
 
        /* Medicine bill TextChanged */
        private void label23_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(label23.Text);
                label28.Text = x.ToString();
            }
            catch
            {

            }
        }

        /* Discount TextChanged */
        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                discount();
            }
            catch
            {
            }
        }
        
        /* Discount Functon */
        void discount()
        {


            try
            {
                if (richTextBox9.Text == "0")
                {

                    label24.Text = "0";
                    label28.Text = label23.Text;
                    richTextBox6.Text = label23.Text;
                }
                else
                {
                    double sum = Convert.ToDouble(label23.Text);
                    double discount = Convert.ToDouble(richTextBox9.Text);
                    double total = sum - discount;

                    label28.Text = total.ToString();
                    richTextBox6.Text = total.ToString();
                }
            }
            catch
            {

            }

        }

        /* Net Total Textcahnged */
        private void label28_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int total = Convert.ToInt32(label28.Text);
                richTextBox6.Text = total.ToString();
            }
            catch
            {

            }
        }

        /* Paid Text Changed */
        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double total = Convert.ToDouble(label28.Text);
                Double disc = Convert.ToDouble(richTextBox6.Text);
                Double due = total - disc;
                label24.Text = due.ToString();
            }
            catch
            {
            }
        }

        /* Selected Medicine List Click 'Datagrid 2' */
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();

                name_sells = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                quant_sells = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[2].Value);


                string price = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                string quantity = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();


                label13.Text = name_sells;
                label19.Text = price;
                richTextBox11.Text = quantity;
                label26.Text = "";




                db.sql.Close();
            }
            catch
            {

            }
        }

        /* Remove Button click */
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity_2 = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd2 = new SqlCommand("select quantity from medicine_pharmacy where name='" + name_sells + "' ", db.sql);
                SqlDataReader read1 = cmd2.ExecuteReader();
                while (read1.Read())
                {
                    quantity_2 = Convert.ToInt32(read1[0]);


                }
                db.sql.Close();

                int quantity_up = quantity_2 + quant_sells;

             
                db.sql.Open();
                SqlCommand cmd3 = new SqlCommand("update medicine_pharmacy set quantity='" + quantity_up + "' where name='" + name_sells + "'", db.sql);
               int x= cmd3.ExecuteNonQuery();
                db.sql.Close();
              
                quant_sells = 0;
                if (x > 0)
                {
                    if (name_sells == "")
                    {
                        MessageBox.Show("Select madicine name to remove");
                    }
                    else
                    {
                        db.sql.Open();
                        SqlCommand cmd = new SqlCommand("delete from medicine_sells where name='" + name_sells + "' and inv_id ='" + richTextBox7.Text + "'", db.sql);
                        int a = cmd.ExecuteNonQuery();
                        name_sells = "";
                    }
                    
                }
                    db.sql.Close();
                  
                   

            }
            catch
            {

            }
            view_medicine();
            view_sells();
            count_sum();
        }

        /* save button click */
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                int c = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd1 = new SqlCommand("select * from medicine_selling_history where inv_id='" + richTextBox7.Text + "'", db.sql);
                SqlDataReader read = cmd1.ExecuteReader();
                while (read.Read())
                {
                    c++;
                }
                if (c > 0)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd2 = new SqlCommand("update medicine_selling_history set discount='" + richTextBox9.Text + "', total='" + label23.Text + "',paid='" + richTextBox6.Text + "',due='" + label24.Text + "' where inv_id='" + richTextBox7.Text+ "'", db.sql);
                    SqlCommand cmddd = new SqlCommand("update user_cash_collection_pharmacy set paid='" + richTextBox6.Text + "' where reg_no='" + richTextBox7.Text + "'", db.sql);
                    cmd2.ExecuteNonQuery();
                    cmddd.ExecuteNonQuery();
                    pharmacy_bill pb = new pharmacy_bill(richTextBox7.Text);
                    pb.Show();
                    db.sql.Close();
                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();

                    SqlCommand cmd = new SqlCommand("insert into medicine_selling_history (inv_id,reg_id,name,age,gender,contact,discount,total,paid,due,date,date2)values('" + richTextBox7.Text + "','" + richTextBox3.Text + "','" + richTextBox4.Text + "','" + richTextBox5.Text + "','" + comboBox2.Text + "','" + richTextBox2.Text + "','" + richTextBox9.Text + "','" + label23.Text + "','" + richTextBox6.Text + "','" + label24.Text + "','" + dateTimePicker1.Text + "','"+dd+"')", db.sql);
                    SqlCommand cmdddd = new SqlCommand("insert into user_cash_collection_pharmacy(user_name,password,reg_no,name,paid,date,date2) values('" + user_name + "','" + password + "','" + richTextBox7.Text + "','" + richTextBox4.Text + "','" + richTextBox6.Text + "','" + date + "','"+dd+"')", db.sql);
                    cmdddd.ExecuteNonQuery();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Selling Successfull");
                        pharmacy_bill pb = new pharmacy_bill(richTextBox7.Text);
                        pb.Show();
                        //clear_field();

                    }
                    db.sql.Close();
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /* Print button Click */
        private void button3_Click(object sender, EventArgs e)
        {
            pharmacy_bill pb = new pharmacy_bill(richTextBox7.Text);
            pb.Show();
        }

        /* Add Medicine Button Click */
        private void button5_Click(object sender, EventArgs e)
        {
            string x = "";
            add_medicine am = new add_medicine(0);
            am.ShowDialog();
            x = am.val1;
        
            if (x == "1")
            {
                view_medicine();
            }
        }

        /* Hospital ID insert */
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            int c = 0;
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select * from patient_histroy where reg_no='" + richTextBox3.Text + "'", db.sql);
                SqlDataReader re = cmd.ExecuteReader();
                while (re.Read())
                {
                    c++;
                    richTextBox4.Text = re[1].ToString();
                    richTextBox2.Text = re[2].ToString();
                    comboBox2.Text = re[3].ToString();
                    richTextBox5.Text = re[4].ToString();


                }
                if (c == 0)
                {


                    richTextBox2.Text = "";
                    comboBox2.Text = "";
                    richTextBox5.Text = "";
                    richTextBox4.Text = "";

                }
                db.sql.Close();
            }
            catch
            {
            }
        }

        /* Sells History Button Click */
        private void button7_Click(object sender, EventArgs e)
        {
            Medicine_Cells_History msell = new Medicine_Cells_History();
            msell.Show();
        }

        /* Patient History Button Click */
        private void button8_Click(object sender, EventArgs e)
        {
            Pharmacy_Customer_History pch = new Pharmacy_Customer_History();
            pch.Show();
        }

        /* Purchase Button Click */
        private void button10_Click(object sender, EventArgs e)
        {
            Purchase_Medicine pm = new Purchase_Medicine();
            pm.Show();
        }

        /* Delete Button Click */
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do You Want to delete this", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int old = 0;
                    int a = 0;
                    int new_quantity = 0;
                    if (user_type == "Admin")
                    {
                        db.sql.Close();
                        db.sql.Open();
                        int n = 0;
                        int i = 0;
                        n = dataGridView2.Rows.Count;
                        for (i = 0; i < n; i++)
                        {
                            string m_name = dataGridView2.Rows[i].Cells[0].Value.ToString();
                            int q = Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value.ToString());
                            SqlCommand cmd111 = new SqlCommand("select quantity from medicine_pharmacy where name='" + m_name + "' ", db.sql);
                            SqlDataReader read1 = cmd111.ExecuteReader();
                            while (read1.Read())
                            {
                                old = Convert.ToInt32(read1[0]);


                            }
                            new_quantity = old + q;
                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd = new SqlCommand("update medicine_pharmacy set quantity='" + new_quantity + "' where name='" + m_name + "'", db.sql);
                            a = cmd.ExecuteNonQuery();

                        }
                        if (a > 0)
                        {
                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd2 = new SqlCommand("delete from medicine_selling_history where inv_id='" + richTextBox7.Text + "'", db.sql);
                            SqlCommand cmd3 = new SqlCommand("delete from user_cash_collection_pharmacy where reg_no='" + richTextBox7.Text + "'", db.sql);
                            SqlCommand cmd1 = new SqlCommand("delete from medicine_sells where inv_id='" + richTextBox7.Text + "'", db.sql);
                            cmd1.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            cmd3.ExecuteNonQuery();
                        }



                        if (a > 0)
                        {
                            MessageBox.Show("Deleted Sucessfully");
                            view_medicine();
                            clear_field();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Only Admin Can Delete");
                    }
                    db.sql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /*================================================================================================================================
                                                         RECEIVE DUE PART
         =================================================================================================================================*/

        /* Show Due Function 'Datagrid 3' */
        private void show_due()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine_selling_history", db.sql);
                dataGridView3.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView3.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView3.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView3.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView3.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView3.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView3.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView3.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView3.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridView3.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridView3.Rows[n].Cells[10].Value = item[10].ToString();
                    string due = dataGridView3.Rows[n].Cells[9].Value.ToString();
                    if (due == "0")
                    {

                    }
                    else
                    {
                        dataGridView3.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView3.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
                db.sql.Close();
            }
            catch
            {

            }


        }
        
        /* Search in Due List */
        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine_selling_history where inv_id like '%" + richTextBox12.Text + "%' or name like'%" + richTextBox12.Text + "%'", db.sql);
                dataGridView3.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView3.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView3.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView3.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView3.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView3.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView3.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView3.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView3.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridView3.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridView3.Rows[n].Cells[10].Value = item[10].ToString();
                    string due = dataGridView3.Rows[n].Cells[9].Value.ToString();
                    if (due == "0")
                    {

                    }
                    else
                    {
                        dataGridView3.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView3.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            catch
            {

            }
        }
        
        /* Due List Click 'Datagrid 3' */
        private void dataGridView3_Click(object sender, EventArgs e)
        {
            try
            {
                label39.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                label41.Text = dataGridView3.SelectedRows[0].Cells[9].Value.ToString();
                richTextBox8.Text = dataGridView3.SelectedRows[0].Cells[9].Value.ToString();
                pharmacy_due_name = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                already_paid = Convert.ToDouble(dataGridView3.SelectedRows[0].Cells[8].Value.ToString());
            }
            catch
            { }
        }

        /* Get Paid Button Click */
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                double total = Convert.ToDouble(label41.Text);
                string date1 = dataGridView3.SelectedRows[0].Cells[10].Value.ToString();
                string date2 = dateTimePicker2.Text;
                string date = DateTime.Now.ToString("dd/MM/yyyy");
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                if (label41.Text == richTextBox8.Text)
                {
                    if (total > 0)
                    {
                        double now_paing = Convert.ToDouble(richTextBox8.Text);
                        double total_paid = now_paing + already_paid;

                        db.sql.Close();
                        db.sql.Open();
                        SqlCommand cmd2 = new SqlCommand("update medicine_selling_history set paid='" + total_paid + "',due='0' where inv_id='" + label39.Text + "'", db.sql);
                        SqlCommand cmdddd = new SqlCommand("insert into user_cash_collection_pharmacy(user_name,password,reg_no,name,paid,date,date2) values('" + user_name + "','" + password + "','" + label39.Text + "','" + pharmacy_due_name + "','" + richTextBox8.Text + "','" + date + "','" + dd + "')", db.sql);
                        SqlCommand cmddd = new SqlCommand("update user_cash_collection_pharmacy set paid='" + total_paid + "'  where reg_no='" + label39.Text + "'", db.sql);
                        if (date1 == date2)
                        {

                            cmddd.ExecuteNonQuery();
                        }
                        else
                        {

                            cmdddd.ExecuteNonQuery();
                        }
                        int a = cmd2.ExecuteNonQuery();
                        if (a > 0)
                        {

                            MessageBox.Show("Bill Taken Sucessfull");
                            Pharmacy_Due_Print pd = new Pharmacy_Due_Print(label39.Text, richTextBox8.Text, user_name);
                            pd.Show();
                            show_due();
                            label39.Text = "";
                            label41.Text = "";
                            richTextBox8.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Choose a due amount");
                    }
                }
                else
                {
                    MessageBox.Show("You have to  pay all Due amount");
                }
            }

            catch
            {

            }
        }
        
        



    }
}
