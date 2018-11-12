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
    public partial class add_medicine : Form
    {
        int id = 0;
        string delete_purchase_id = "";
        connection db = new connection();
        public string val1 { get; set; }
        public add_medicine(int x)
        {
            InitializeComponent();
            val1 = "";
            id_generate();
            view_medicine();
            load_company();
            load_category();
            view_purchase();
        }

        /* New ID Button Click*/
        private void button5_Click(object sender, EventArgs e)
        {
            id_generate();
        }
        private void add_medicine_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {       
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                int quantity_new;
                int quantity_2 = 0;
                int quantity_1 = 0;
                int c = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd4 = new SqlCommand("select * from medicine_pharmacy where name='" + richTextBox1.Text + "' and catagory = '" + comboBox1.Text + "' ", db.sql);
                SqlDataReader read1 = cmd4.ExecuteReader();
                while (read1.Read())
                {
                    c++;
                    quantity_1 = Convert.ToInt32(read1[4]);

                }

                quantity_2 = Convert.ToInt32(richTextBox3.Text);
                quantity_new = quantity_1 + quantity_2;

                if (c > 0)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("update medicine_pharmacy set quantity='" + quantity_new + "',price='" + richTextBox2.Text + "' where name='" + richTextBox1.Text + "' and catagory = '" + comboBox1.Text + "' ", db.sql);
                   
                   
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {

                        int oldq = 0;
                        int newq = Convert.ToInt32(richTextBox3.Text);
                        int quant=0;
                        int count = 0;
                        db.sql.Close();
                        db.sql.Open();
                        SqlCommand cmdread = new SqlCommand("select  * from purchase_medicine where medicine_id='"+richTextBox9.Text+"' and date='"+date+"'",db.sql);
                        SqlDataReader read = cmdread.ExecuteReader();
                        while (read.Read())
                        {
                            oldq=Convert.ToInt32(read[4].ToString());
                            count++;
                        }
                        quant = newq + oldq;
                        if (count > 0)
                        {
                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd1 = new SqlCommand("update purchase_medicine set quantity='" +quant+ "' where medicine_id='" + richTextBox9.Text + "' and date='" + date + "'", db.sql);
                            cmd1.ExecuteNonQuery();
                        }
                        else
                        {
                            db.sql.Close();
                            db.sql.Open();
                            SqlCommand cmd2 = new SqlCommand("insert into purchase_medicine(medicine_company,medicine_id,Name,quantity,buying_price,selling_price,date,date2)values('" + comboBox2.Text + "','" + richTextBox9.Text + "','" + richTextBox1.Text + "','" + richTextBox3.Text + "','" + richTextBox6.Text + "','" + richTextBox2.Text + "','" + date + "','" + dd + "')", db.sql);
                            cmd2.ExecuteNonQuery();
                        }
                        MessageBox.Show("Update Sucessfull");
                        val1 = "1";
                        view_medicine();
                        view_purchase();

                    }
                }
                else
                {
                    db.sql.Close();
                    db.sql.Open();

                    SqlCommand cmd = new SqlCommand("insert into medicine_pharmacy(company,id,catagory,name,price,quantity,date,buing_price)values('" +comboBox2.Text+ "','"+richTextBox9.Text+"','" + comboBox1.Text + "','" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + richTextBox3.Text + "','" + dateTimePicker1.Text + "','"+richTextBox6.Text+"')", db.sql);
                    SqlCommand cmd1 = new SqlCommand("insert into purchase_medicine(medicine_company,medicine_id,Name,quantity,buying_price,selling_price,date,date2)values('" + comboBox2.Text + "','" + richTextBox9.Text + "','" + richTextBox1.Text + "','" + richTextBox3.Text + "','"+richTextBox6.Text+"','"+richTextBox2.Text+"','"+date+"','"+dd+"')", db.sql);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Insert Sucessfull");
                        view_medicine();
                       
                        val1 = "1";
                        id_generate();
                        view_purchase();
                    }
                }



                db.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            id_generate();
        }

        void view_medicine()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine_pharmacy ", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    int due =Convert.ToInt32( dataGridView1.Rows[n].Cells[3].Value.ToString());
                    if (due <=20)
                    {
                        dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        
                    }
                }
            }
            catch
            {

            }
        }

        void view_purchase()
        {
            try
            {
                string dat = dateTimePicker1.Text;
                SqlDataAdapter sda = new SqlDataAdapter("select * from purchase_medicine where date='"+dat+"' ", db.sql);
                dataGridView2.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item[3].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item[5].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = item[6].ToString();
                    dataGridView2.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView2.Rows[n].Cells[5].Value = item[7].ToString();
                    dataGridView2.Rows[n].Cells[6].Value = item[0].ToString();
                   
                }
            }
            catch
            {

            }

            try
            {
                int i = 0;
                int nn = dataGridView2.Rows.Count;

                double total_buy = 0;
                double total_sell = 0;
                for (i = 0; i < nn; i++)
                {
                    double total = 0;
                    double selling = 0;
                    double quantity = 0;
                    total = Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value.ToString());
                    selling = Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value.ToString());
                    quantity = Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value.ToString());
                    total_buy += total * quantity;
                    total_sell += selling * quantity;
                }
                label18.Text = total_buy.ToString();
                label19.Text = total_sell.ToString();
                Double profit = total_sell - total_buy;
                label22.Text = profit.ToString();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do You want to Delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("delete from medicine_pharmacy where id='" + richTextBox9.Text + "'", db.sql);
                    SqlCommand cmd1 = new SqlCommand("delete from purchase_medicine where medicine_id='" + richTextBox9.Text + "'", db.sql);
                    cmd1.ExecuteNonQuery();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Delete Sucessfull");
                        val1 = "1";
                        
                        view_medicine();
                        view_purchase();
                        id_generate();
                    }
                    db.sql.Close();
                }

            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("update medicine_pharmacy set catagory='" + comboBox1.Text + "',name='" + richTextBox1.Text + "',price='" + richTextBox2.Text + "',quantity='" + richTextBox3.Text + "',company='"+comboBox2.Text+"',buing_price='"+richTextBox6.Text+"' where id='" + richTextBox9.Text + "'", db.sql);
               
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Update Sucessfull");
                    val1 = "1";
                    
                }
                else
                {
                    MessageBox.Show(" Delete the item and add Again");
                }
                db.sql.Close();
            }
            catch
            {

            }

            try
            {
                int q0 =Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                int q1 = Convert.ToInt32(richTextBox3.Text);
                int qold = 0;
                int qnew = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmdr = new SqlCommand("select quantity from purchase_medicine where medicine_id='"+richTextBox9.Text+"'",db.sql);
                SqlDataReader read = cmdr.ExecuteReader();
                while (read.Read())
                {

                    qold = Convert.ToInt32(read[0]);
                }
                if (q0 < q1)
                {
                    qnew = qold + (q1 - q0);
                }
                else if (q0> q1)
                {
                    qnew = qold - (q0-q1);
                }
                else if (q0==q1)
                {
                    qnew = qold;
                }
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd1 = new SqlCommand("update purchase_medicine set medicine_company='" + comboBox2.Text + "',medicine_id='" + richTextBox9.Text + "',Name='" + richTextBox1.Text + "',quantity='" + qnew + "',buying_price='" + richTextBox6.Text + "',selling_price='" + richTextBox2.Text + "' where medicine_id='" + richTextBox9.Text + "' and date='" + dateTimePicker1.Text + "'", db.sql);
                cmd1.ExecuteNonQuery();
            }
            catch
            { 
            
            }
            view_medicine();
            view_purchase();
            id_generate();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                string catagory = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string price = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string quantity = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
               // string date = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboBox1.Text = catagory;
                richTextBox1.Text = name;
                richTextBox2.Text = price;
                richTextBox3.Text = quantity;
                richTextBox6.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                richTextBox9.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
               // dateTimePicker1.Text = date;
                db.sql.Close();
            }
            catch
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from medicine_pharmacy where name like'%" + richTextBox4.Text + "%' ", db.sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    int due = Convert.ToInt32(dataGridView1.Rows[n].Cells[3].Value.ToString());
                    if (due <= 20)
                    {
                        dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {

                    }
                }
                db.sql.Close();

            }
            catch
            {


            }
        }

        private void richTextBox4_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Print_Medicine_Stock pm = new Print_Medicine_Stock();
            pm.Show();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                Medicine_Company mc = new Medicine_Company();
                mc.ShowDialog();
                String return_value = "";
              return_value= mc.val1;
              if (return_value == "1")
              {
                  load_company();
              }
            }
            catch
            { 
            
            }
        }

        /* Combobox 2,3 Company Name load */
        void load_company()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                SqlCommand cmd = new SqlCommand("select * from medicine_company order by company_name ASC",db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    comboBox2.Items.Add(read[1].ToString());
                    comboBox3.Items.Add(read[1].ToString());
                
                }
                db.sql.Close();
            }
            catch
            { 
            
            }


        }

        /* ID Generate */
        void id_generate()
        {
            try
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                richTextBox3.Text = "";
                richTextBox9.Clear();
                richTextBox6.Clear();

                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select max(id) from medicine_pharmacy", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    id = Convert.ToInt32(read[0]);
                    if (id.ToString() == "") { id = 0; }
                    richTextBox9.Text = (id + 1).ToString();
                }
                db.sql.Close();
            }
            catch
            {

            }

        }

        private void add_medicine_Load_1(object sender, EventArgs e)
        {
            view_purchase();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                string date = dateTimePicker2.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                string date2 = dateTimePicker3.Text;
                DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd2 = d2.ToString("yyyy/MM/dd");
                string dat = dateTimePicker1.Text;
                SqlDataAdapter sda = new SqlDataAdapter("select * from purchase_medicine where date2 between '"+dd+"' and '"+dd2+"' ", db.sql);
                dataGridView2.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item[3].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item[5].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = item[6].ToString();
                    dataGridView2.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView2.Rows[n].Cells[5].Value = item[7].ToString();
                    dataGridView2.Rows[n].Cells[6].Value = item[0].ToString();

                }
            }
            catch
            {

            }
            try
            {
                int i = 0;
                int nn = dataGridView2.Rows.Count;
               
                double total_buy = 0;
                double total_sell = 0;
                for (i = 0; i < nn; i++)
                {
                     double total = 0;
                     double selling = 0;
                     double quantity = 0;
                    total = Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value.ToString());
                    selling = Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value.ToString());
                    quantity = Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value.ToString());
                    total_buy += total * quantity;
                    total_sell += selling * quantity;
                }
                label18.Text = total_buy.ToString();
                label19.Text = total_sell.ToString();
                Double profit = total_sell - total_buy;
                label22.Text = profit.ToString();
            }
            catch
            {

            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                delete_purchase_id = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch
            { 
            
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do You want to Delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    db.sql.Close();
                    db.sql.Open();
                    
                    SqlCommand cmd = new SqlCommand("delete from purchase_medicine where id='" +delete_purchase_id+ "'", db.sql);
                   
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Delete Sucessfull");
                        val1 = "1";

                        view_medicine();
                        view_purchase();
                        id_generate();
                    }
                    db.sql.Close();
                }

            }
            catch
            {

            }
        }

        void individual_purchase()
        {

            try
            {
              
                double total = 0;
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select sum(buying_price*quantity) from purchase_medicine where medicine_company='"+comboBox3.Text+"' and date='"+dateTimePicker1.Text+"'",db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    total = Convert.ToDouble(read[0].ToString());
                }
                richTextBox5.Text = total.ToString();
                
                db.sql.Close();
            }
            catch
            { 
            
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            individual_purchase();
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total =Convert.ToDouble(richTextBox5.Text) ;
                double paid = Convert.ToDouble(richTextBox7.Text);
                double due = total - paid;
                richTextBox8.Text = due.ToString();

            }
            catch
            { 
            
           }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                string date = dateTimePicker1.Text;
                DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dd = d.ToString("yyyy/MM/dd");
                int id = 0;
                int c = 0;
                db.sql.Close();
                db.sql.Open();

                SqlCommand cmd1 = new SqlCommand("select count(id) from paid_purchase where date='"+dateTimePicker1.Text+"'", db.sql);
                SqlDataReader read = cmd1.ExecuteReader();
                while (read.Read())
                {
                   c=Convert.ToInt32(read[0].ToString());
                
                }
                id = c + 1;
                db.sql.Close();
                String sDate = DateTime.Now.ToString();
                DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

                String dy = datevalue.Day.ToString();
                String mn = datevalue.Month.ToString();
                String yy = datevalue.Year.ToString();
                string memo_no = yy + mn + dy+id;
                db.sql.Close();
                db.sql.Open();

                SqlCommand cmd = new SqlCommand("insert into paid_purchase(memo_no,total,paid,due,date,date2,company_name)values('" + memo_no + "','" + richTextBox5.Text + "','" + richTextBox7.Text + "','" + richTextBox8.Text + "','" + date + "','" + dd + "','" + comboBox3.Text+ "')", db.sql);

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {

                    MessageBox.Show("Paid Sucessfull");
                }

                db.sql.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            Print_Purchase_List ppl = new Print_Purchase_List();
            ppl.Show();
        }

        /* Add New Category */
        private void buttonX7_Click(object sender, EventArgs e)
        {
            try
            {
                medicine_category_crud mc = new medicine_category_crud();
                mc.ShowDialog();
                String return_value = "";
                return_value = mc.val1;
                if (return_value == "1")
                {
                    load_category();
                }
            }
            catch
            {

            }
        }

        /* Combobox 2,3 Company Name load */
        void load_category()
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                comboBox1.Items.Clear();
                SqlCommand cmd = new SqlCommand("select * from medicine_category order by category_name ASC", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    comboBox1.Items.Add(read[1].ToString());

                }
                db.sql.Close();
            }
            catch
            {

            }


        }
        //Medicine_Paid_History
        private void button6_Click(object sender, EventArgs e)
        {
            Medicine_Paid_History mph = new Medicine_Paid_History();
            mph.Show();
        }

        

    }
}
