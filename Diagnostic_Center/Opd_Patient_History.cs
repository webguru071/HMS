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
    public partial class Opd_Patient_History : Form
    {
        connection db = new connection();
        public Opd_Patient_History()
        {
            InitializeComponent();
            show();
        }

        void show()
        {
          //  try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(" SELECT   opd.[reg_no],opd.[name],opd.[contact],[gender],[age],[address],opd.[date],[time] ,[gurdian],[word],[thana],[district],[consultant],[referance] ,total,discount,paid,due FROM opd,user_cash_collection_OPD where user_cash_collection_OPD.reg_no=opd.reg_no", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                    dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
                    dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
                    dataGridView1.Rows[n].Cells[13].Value = item[13].ToString();
                    dataGridView1.Rows[n].Cells[14].Value = item[14].ToString();
                    dataGridView1.Rows[n].Cells[15].Value = item[15].ToString();
                    dataGridView1.Rows[n].Cells[16].Value = item[16].ToString();
                    dataGridView1.Rows[n].Cells[17].Value = item[17].ToString();
                }
                db.sql.Close();
            }
          /*  catch
            { 
           
            }*/
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.sql.Close();
                db.sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(" SELECT   opd.[reg_no],opd.[name],opd.[contact],[gender],[age],[address],opd.[date],[time] ,[gurdian],[word],[thana],[district],[consultant],[referance] ,total,discount,paid,due FROM opd,user_cash_collection_OPD where user_cash_collection_OPD.reg_no=opd.reg_no and opd.name Like'%" + richTextBox1.Text + "%'", db.sql);
                dataGridView1.Rows.Clear();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
                    dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
                    dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
                    dataGridView1.Rows[n].Cells[13].Value = item[13].ToString();
                    dataGridView1.Rows[n].Cells[14].Value = item[14].ToString();
                    dataGridView1.Rows[n].Cells[15].Value = item[15].ToString();
                    dataGridView1.Rows[n].Cells[16].Value = item[16].ToString();
                    dataGridView1.Rows[n].Cells[17].Value = item[17].ToString();
                }
                db.sql.Close();
                if (richTextBox1.Text == "")
                {
                    show();
                }
            }
            catch
            {
                show();
            }
        }

    }

}
