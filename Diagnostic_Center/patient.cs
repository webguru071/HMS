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
    public partial class patient : Form
    {
        connection db = new connection();
        //SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public patient()
        {
            InitializeComponent();
            show2();
        }


        void show2()
        {

            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select id,diagnostic_person.name,contact,date,total,discount,discount_total,paid,paid_and_due.due,less,paid_and_due.paid_date,due_paid from diagnostic_person,paid_and_due,due_collection where diagnostic_person.id=paid_and_due.invoice_no and diagnostic_person.id=due_collection.reg_no", db.sql);
                DataTable dt = new DataTable();
                dataGridViewX1.Rows.Clear();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();

                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridViewX1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridViewX1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridViewX1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridViewX1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridViewX1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridViewX1.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridViewX1.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridViewX1.Rows[n].Cells[10].Value = item[10].ToString();
                    dataGridViewX1.Rows[n].Cells[11].Value = item[11].ToString();
                    string due_check = dataGridViewX1.Rows[n].Cells[8].Value.ToString();
                    string paid = dataGridViewX1.Rows[n].Cells[7].Value.ToString();
                    string due_paid = dataGridViewX1.Rows[n].Cells[11].Value.ToString();
                    string date1 = dataGridViewX1.Rows[n].Cells[3].Value.ToString();
                    string date2 = dataGridViewX1.Rows[n].Cells[10].Value.ToString();
                    double a = Convert.ToDouble(paid);
                    double b = Convert.ToDouble(due_paid);
                    double c = a + b;

                    if (due_paid != "0")
                    {
                        dataGridViewX1.Rows[n].Cells[8].Value = "0";
                      //  dataGridViewX1.Rows[n].Cells[7].Value = c.ToString();
                     
                    }
                    if (due_paid != "0" && date1 !=date2)
                    {

                        dataGridViewX1.Rows[n].Cells[7].Value = c.ToString();

                    }
                    if (due_check == "0" && due_paid == "0")
                    {
                        dataGridViewX1.Rows[n].Cells[10].Value = "No Due";
                    }
                  
                }


                db.sql.Close();
            }
           catch
            { 
           
            }
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(richTextBox1.Text);
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select id,diagnostic_person.name,contact,date,total,discount,discount_total,paid,paid_and_due.due,less,paid_and_due.paid_date,due_paid from diagnostic_person,paid_and_due,due_collection where diagnostic_person.id=paid_and_due.invoice_no and diagnostic_person.id=due_collection.reg_no and diagnostic_person.id='" + id + "'", db.sql);
                DataTable dt = new DataTable();
                dataGridViewX1.Rows.Clear();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewX1.Rows.Add();

                    dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridViewX1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridViewX1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridViewX1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridViewX1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridViewX1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridViewX1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridViewX1.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridViewX1.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridViewX1.Rows[n].Cells[10].Value = item[10].ToString();
                    dataGridViewX1.Rows[n].Cells[11].Value = item[11].ToString();
                    string due_check = dataGridViewX1.Rows[n].Cells[8].Value.ToString();
                    string paid = dataGridViewX1.Rows[n].Cells[7].Value.ToString();
                    string due_paid = dataGridViewX1.Rows[n].Cells[11].Value.ToString();
                    string date1 = dataGridViewX1.Rows[n].Cells[3].Value.ToString();
                    string date2 = dataGridViewX1.Rows[n].Cells[10].Value.ToString();
                    double a = Convert.ToDouble(paid);
                    double b = Convert.ToDouble(due_paid);
                    double c = a + b;

                    if (due_paid != "0")
                    {
                        dataGridViewX1.Rows[n].Cells[8].Value = "0";
                        //  dataGridViewX1.Rows[n].Cells[7].Value = c.ToString();

                    }
                    if (due_paid != "0" && date1 != date2)
                    {

                        dataGridViewX1.Rows[n].Cells[7].Value = c.ToString();

                    }
                    if (due_check == "0" && due_paid == "0")
                    {
                        dataGridViewX1.Rows[n].Cells[10].Value = "No Due";
                    }
                }


                db.sql.Close();
            }
            catch
            {
                try
                {
                    db.sql.Close();
                    db.sql.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select id,diagnostic_person.name,contact,date,total,discount,discount_total,paid,paid_and_due.due,less,paid_and_due.paid_date,due_paid from diagnostic_person,paid_and_due,due_collection where diagnostic_person.id=paid_and_due.invoice_no and diagnostic_person.id=due_collection.reg_no and diagnostic_person.name like'%" + richTextBox1.Text + "%'", db.sql);
                    DataTable dt = new DataTable();
                    dataGridViewX1.Rows.Clear();
                    sda.Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridViewX1.Rows.Add();

                        dataGridViewX1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridViewX1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridViewX1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridViewX1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridViewX1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridViewX1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridViewX1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridViewX1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridViewX1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridViewX1.Rows[n].Cells[9].Value = item[9].ToString();
                        dataGridViewX1.Rows[n].Cells[10].Value = item[10].ToString();
                        dataGridViewX1.Rows[n].Cells[11].Value = item[11].ToString();
                        string due_check = dataGridViewX1.Rows[n].Cells[8].Value.ToString();
                        string paid = dataGridViewX1.Rows[n].Cells[7].Value.ToString();
                        string due_paid = dataGridViewX1.Rows[n].Cells[11].Value.ToString();
                        string date1 = dataGridViewX1.Rows[n].Cells[3].Value.ToString();
                        string date2 = dataGridViewX1.Rows[n].Cells[10].Value.ToString();
                        double a = Convert.ToDouble(paid);
                        double b = Convert.ToDouble(due_paid);
                        double c = a + b;

                        if (due_paid != "0")
                        {
                            dataGridViewX1.Rows[n].Cells[8].Value = "0";
                            //  dataGridViewX1.Rows[n].Cells[7].Value = c.ToString();

                        }
                        if (due_paid != "0" && date1 != date2)
                        {

                            dataGridViewX1.Rows[n].Cells[7].Value = c.ToString();

                        }
                        if (due_check == "0" && due_paid == "0")
                        {
                            dataGridViewX1.Rows[n].Cells[10].Value = "No Due";
                        }
                    }


                    db.sql.Close();
                }
                catch
                { 
                
                }
                // show();
            }
            finally
            {
               // show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                diagnostic_bill db = new diagnostic_bill(label2.Text);
                db.Show();
            }
            catch
            { 
            
            }
        }

        private void dataGridViewX1_Click(object sender, EventArgs e)
        {
            try
            {
               string id =(dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
               label2.Text = id;
                
            }

            catch
            {

            }
        }
    }
}
