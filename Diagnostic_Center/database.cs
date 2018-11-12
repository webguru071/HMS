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
    public partial class database : Form
    {
        connection db = new connection();
      
        //SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public database()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "sk" && richTextBox2.Text == "123")
            {
                button1.Visible = true;
                richTextBox1.Clear();
                richTextBox2.Clear();
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("delete from admit_bill", db.sql);
                SqlCommand cmd1 = new SqlCommand("delete from diagnostic_bill", db.sql);
                SqlCommand cmd2 = new SqlCommand("delete from diagnostic_person", db.sql);
                SqlCommand cmd3 = new SqlCommand("delete from paid_and_due", db.sql);
                SqlCommand cmd4 = new SqlCommand("delete from patient_admit", db.sql);
                SqlCommand cmd5 = new SqlCommand("delete from expense", db.sql);
                SqlCommand cmd6 = new SqlCommand("delete from due_collection", db.sql);
                SqlCommand cmd7 = new SqlCommand("delete from admission", db.sql);
                SqlCommand cmd8 = new SqlCommand("delete from hospital_due_collection", db.sql);
                SqlCommand cmd9 = new SqlCommand("delete from opd_due_collection", db.sql);
                SqlCommand cmd10 = new SqlCommand("delete from expense_title", db.sql);
                SqlCommand cmd11 = new SqlCommand("delete from medicine_selling_history", db.sql);
                SqlCommand cmd12 = new SqlCommand("delete from medicine_sells", db.sql);
                SqlCommand cmd13 = new SqlCommand("delete from anastasia", db.sql);
                SqlCommand cmd14 = new SqlCommand("delete from patient_bill", db.sql);
                SqlCommand cmd15 = new SqlCommand("delete from patient_histroy", db.sql);
                SqlCommand cmd16 = new SqlCommand("delete from referance", db.sql);
                SqlCommand cmd17 = new SqlCommand("delete from user_cash_collection", db.sql);
                SqlCommand cmd18 = new SqlCommand("delete from user_cash_collection_hospital", db.sql);
                SqlCommand cmd19 = new SqlCommand("delete from user_cash_collection_pharmacy", db.sql);
                SqlCommand cmd20 = new SqlCommand("delete from hospital_referance", db.sql);
                SqlCommand cmd21 = new SqlCommand("delete from d_advice", db.sql);
                SqlCommand cmd22 = new SqlCommand("delete from diagnosis", db.sql);
                SqlCommand cmd23 = new SqlCommand("delete from advice", db.sql);
                SqlCommand cmd24 = new SqlCommand("delete from haematology", db.sql);
                SqlCommand cmd25 = new SqlCommand("delete from pathology_report", db.sql);
                SqlCommand cmd26 = new SqlCommand("delete from patient_test", db.sql);
                SqlCommand cmd27 = new SqlCommand("delete from prescription", db.sql);
                
                SqlCommand cmd29 = new SqlCommand("delete from symptoms", db.sql);
                SqlCommand cmd30 = new SqlCommand("delete from appointment", db.sql);
                SqlCommand cmd31 = new SqlCommand("delete from test_result", db.sql);
                SqlCommand cmd32 = new SqlCommand("delete from ultrasono", db.sql);
                SqlCommand cmd33 = new SqlCommand("delete from urine_chemical", db.sql);
                SqlCommand cmd34 = new SqlCommand("delete from urine_micro", db.sql);
                SqlCommand cmd35 = new SqlCommand("delete from urine_physical", db.sql);
                SqlCommand cmd36 = new SqlCommand("delete from xray_report", db.sql);
                SqlCommand cmd37 = new SqlCommand("delete from xray2", db.sql);
                SqlCommand cmd38 = new SqlCommand("delete from followup", db.sql);
                SqlCommand cmd39 = new SqlCommand("delete from history", db.sql);
                SqlCommand cmd40 = new SqlCommand("delete from surgeon", db.sql);
                SqlCommand cmd41 = new SqlCommand("delete from opd", db.sql);
                SqlCommand cmd42 = new SqlCommand("delete from opd_bill", db.sql);
                SqlCommand cmd43 = new SqlCommand("delete from user_cash_collection_OPD", db.sql);
                int a = cmd.ExecuteNonQuery();
                int b = cmd1.ExecuteNonQuery();
                int c = cmd2.ExecuteNonQuery();
                int d = cmd3.ExecuteNonQuery();
                
                cmd5.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                cmd8.ExecuteNonQuery();
                cmd9.ExecuteNonQuery();
                cmd10.ExecuteNonQuery();
                cmd11.ExecuteNonQuery();
                cmd12.ExecuteNonQuery();
                cmd13.ExecuteNonQuery();
                cmd14.ExecuteNonQuery();
                cmd15.ExecuteNonQuery();
                cmd16.ExecuteNonQuery();
                cmd17.ExecuteNonQuery();
                cmd18.ExecuteNonQuery();
                cmd19.ExecuteNonQuery();
                cmd20.ExecuteNonQuery();
                cmd21.ExecuteNonQuery();
                cmd22.ExecuteNonQuery();
                cmd23.ExecuteNonQuery();
                cmd24.ExecuteNonQuery();
                cmd25.ExecuteNonQuery();
                cmd26.ExecuteNonQuery();
                cmd27.ExecuteNonQuery();
               
                cmd29.ExecuteNonQuery();
                cmd30.ExecuteNonQuery();
                cmd31.ExecuteNonQuery();
                cmd32.ExecuteNonQuery();
                cmd33.ExecuteNonQuery();
                cmd34.ExecuteNonQuery();
                cmd35.ExecuteNonQuery();
                cmd36.ExecuteNonQuery();
                cmd37.ExecuteNonQuery();
                cmd38.ExecuteNonQuery();
                cmd39.ExecuteNonQuery();
                cmd40.ExecuteNonQuery();
                cmd41.ExecuteNonQuery();
                cmd42.ExecuteNonQuery();
                cmd43.ExecuteNonQuery();
                   MessageBox.Show("Data Deleted Sucessfully");

                   db.sql.Close();
            }
            catch
            { 
            
            }
        }
    }
}
