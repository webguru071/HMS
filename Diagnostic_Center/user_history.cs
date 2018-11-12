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
    public partial class user_history : Form
    {
        connection db = new connection();
        public user_history()
        {
            InitializeComponent();
            user();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int aa = 0;
                int bb = 0;
                DialogResult r = MessageBox.Show("Do You Want to Clear This History","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    string date = dateTimePicker1.Text;
                    string dd = "";
                    DateTime d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dd = d.ToString("yyyy/MM/dd");
                    string date2 = dateTimePicker2.Text;
                    DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dd2 = d2.ToString("yyyy/MM/dd");
                    db.sql.Close();
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("delete from admit_bill", db.sql);
                    SqlCommand cmd1 = new SqlCommand("delete from diagnostic_bill where diagnostic_bill.invoice_id  IN (select reg_no from user_cash_collection where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "')", db.sql);
                    SqlCommand cmd2 = new SqlCommand("delete from diagnostic_person where diagnostic_person.id  IN (select reg_no from user_cash_collection where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "')", db.sql);
                    SqlCommand cmd3 = new SqlCommand("delete from paid_and_due where paid_and_due.invoice_no  IN (select reg_no from user_cash_collection where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "')", db.sql);

                    SqlCommand cmd6 = new SqlCommand("delete from due_collection where due_collection.reg_no  IN (select reg_no from user_cash_collection where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "')", db.sql);
                    SqlCommand cmd7 = new SqlCommand("delete from admission  where admission.reg_no  IN (select reg_no from user_cash_collection_hospital where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "')", db.sql);
                    SqlCommand cmd8 = new SqlCommand("delete from bed_bill  where bed_bill.reg_no  IN (select reg_no from user_cash_collection_hospital where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "')", db.sql);
                    SqlCommand cmd9 = new SqlCommand("delete from discharge_bill  where discharge_bill.reg_no  IN (select reg_no from user_cash_collection_hospital where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "')", db.sql);
                    SqlCommand cmd13 = new SqlCommand("delete from operation  where operation.reg_no  IN (select reg_no from user_cash_collection_hospital where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "')", db.sql);
                    SqlCommand cmd14 = new SqlCommand("delete from patient_bill  where patient_bill.reg_no  IN (select reg_no from user_cash_collection_hospital where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "')", db.sql);
                    SqlCommand cmd15 = new SqlCommand("delete from patient_histroy  where patient_histroy.reg_no  IN (select reg_no from user_cash_collection_hospital where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "')", db.sql);
                    SqlCommand cmd16 = new SqlCommand("delete from referance where referance.patient_id  IN (select reg_no from user_cash_collection where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "')", db.sql);
                    SqlCommand cmd17 = new SqlCommand("delete from user_cash_collection where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "'", db.sql);
                    SqlCommand cmd18 = new SqlCommand("delete from user_cash_collection_hospital where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "'", db.sql);
                    SqlCommand cmd19 = new SqlCommand("delete from user_cash_collection_pharmacy where user_name='" + comboBox1.Text + "' and date2 between '" + dd + "' and '" + dd2 + "'", db.sql);

                    try
                    {
                        int a = cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                    }
                    try
                    {
                        int b = cmd1.ExecuteNonQuery();
                    }
                    catch
                    { }
                    try
                    {
                        int c = cmd2.ExecuteNonQuery();
                    }
                    catch
                    { }
                    try
                    {
                        cmd3.ExecuteNonQuery();
                    }
                    catch
                    {
                    }
                    try
                    {
                        cmd16.ExecuteNonQuery();
                    }
                    catch
                    {
                    }
                    try
                    {
                        cmd6.ExecuteNonQuery();
                    }
                    catch
                    { }
                    try
                    {
                        cmd7.ExecuteNonQuery();
                    }
                    catch
                    { }
                    try
                    {
                        cmd8.ExecuteNonQuery();
                    }
                    catch
                    {
                    }
                    try
                    {
                        cmd9.ExecuteNonQuery();
                    }
                    catch
                    {
                    }
                    try
                    {
                        cmd13.ExecuteNonQuery();
                    }
                    catch
                    { }
                    try
                    {
                        cmd14.ExecuteNonQuery();
                    }
                    catch
                    {
                    }
                    try
                    {
                        cmd15.ExecuteNonQuery();
                    }
                    catch
                    { }
                    try
                    {
                       aa= cmd17.ExecuteNonQuery();
                    }
                    catch
                    { }
                    try
                    {
                        bb=cmd18.ExecuteNonQuery();
                    }
                    catch
                    { }
                    try
                    {
                        cmd19.ExecuteNonQuery();

                    }
                    catch
                    {

                    }
                    if (aa > 0 || bb > 0)
                    {
                        MessageBox.Show("Data Deleted Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("No User History Found","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    }
                    db.sql.Close();
                }

            }
            catch
            {

            }
        }


        void user()
        {
            try
            {
                comboBox1.Items.Clear();
                string x = "";
                db.sql.Close();
                db.sql.Open();
                SqlCommand cmd = new SqlCommand("select user_name from log", db.sql);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {

                    x = read[0].ToString();
                    comboBox1.Items.Add(x);
                }
              
                db.sql.Close();
            }
            catch
            { 
            
            }
        }
    }
}
