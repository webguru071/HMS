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
    public partial class Form2 : Form
    {
        connection db = new connection();
        string user_name = "";
        string password = "";
        string user_type = "";
       // SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\database\reception.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
            aDMINToolStripMenuItem.Visible = false;
            accountsToolStripMenuItem.Visible = false;
        }

     

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense exp = new Expense();
            exp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.andit.andimpex.com");
        }

        private void aDDTESTLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_test at = new add_test();
            at.Show();
        }

        private void dATABASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database db = new database();
            db.Show();
        }

        private void dueCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int c = 0;
                string x = "";
                login log = new login(x);
                log.ShowDialog();

                string user = log.val1;
                string pass = log.val2;
                string type = log.val3;
                if (user == "" || pass == "")
                {

                }
                else
                {
                    db.sql.Open();
                    SqlCommand cmd = new SqlCommand("select * from log where pass='" + pass + "' and user_name='" + user + "' and type='"+type+"'", db.sql);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        c++;
                    }
                    if (c > 0)
                    {
                        MessageBox.Show("Login Sucessfull");
                        if (type == "Admin")
                        { 
                        aDMINToolStripMenuItem.Visible = true;
                        accountsToolStripMenuItem.Visible = true;
                       hOSPITALToolStripMenuItem.Visible = true;
                        dIAGNOSTICToolStripMenuItem.Visible = true;
                        button2.Visible = true;
                        button1.Visible = false;
                        pHARMACYToolStripMenuItem.Visible = true;
                        lABToolStripMenuItem.Visible = true;
                        //button7.Visible = true;
                        //dOCTORToolStripMenuItem.Visible = true;
                        emergencyToolStripMenuItem.Visible = true;
                        //pRESCRIPTIONToolStripMenuItem.Visible = true;
                        //button3.Visible = true;
                        label2.Text = "User: "+user;
                        user_name = user;
                        password = pass;
                        user_type = type;
                        }
                        if (type == "Manager")
                        {
                            accountsToolStripMenuItem.Visible = true;
                            hOSPITALToolStripMenuItem.Visible = true;
                            dIAGNOSTICToolStripMenuItem.Visible = true;
                            button2.Visible = true;
                            button1.Visible = false;
                            pHARMACYToolStripMenuItem.Visible = true;
                            //lABToolStripMenuItem.Visible = true;
                            //button7.Visible = true;
                            //dOCTORToolStripMenuItem.Visible = true;
                            emergencyToolStripMenuItem.Visible = true;
                            //pRESCRIPTIONToolStripMenuItem.Visible = true;
                            //button3.Visible = true;
                            label2.Text = "User: " + user;
                            user_name = user;
                            password = pass;
                            user_type = type;
                        }
                        if (type == "Reception")
                        {

                            hOSPITALToolStripMenuItem.Visible = true;
                            dIAGNOSTICToolStripMenuItem.Visible = true;                        
                            pHARMACYToolStripMenuItem.Visible = true;
                            lABToolStripMenuItem.Visible = true;                           
                           // dOCTORToolStripMenuItem.Visible = true;
                           // pRESCRIPTIONToolStripMenuItem.Visible = true;
                           // emergencyToolStripMenuItem.Visible = true;
                            //button7.Visible = true;
                            button2.Visible = true;
                            button1.Visible = false;
                            //button3.Visible = true;
                            label2.Text = "User: " + user;
                            user_name = user;
                            password = pass;
                            user_type = type;
                        }
                        if (type == "Lab")
                        {

                           // hOSPITALToolStripMenuItem.Visible = true;
                            //dIAGNOSTICToolStripMenuItem.Visible = true;
                            //pHARMACYToolStripMenuItem.Visible = true;
                             lABToolStripMenuItem.Visible = true;                           
                          //  dOCTORToolStripMenuItem.Visible = true;
                            // pRESCRIPTIONToolStripMenuItem.Visible = true;
                          //  emergencyToolStripMenuItem.Visible = true;
                        //    button7.Visible = true;
                            button2.Visible = true;
                            button1.Visible = false;
                          //  button3.Visible = true;
                            label2.Text = "User: " + user;
                            user_name = user;
                            password = pass;
                            user_type = type;
                        }

                        if (type == "Doctor")
                        {

                            // hOSPITALToolStripMenuItem.Visible = true;
                            //dIAGNOSTICToolStripMenuItem.Visible = true;
                            //pHARMACYToolStripMenuItem.Visible = true;
                           // lABToolStripMenuItem.Visible = true;
                             //dOCTORToolStripMenuItem.Visible = true;
                             //pRESCRIPTIONToolStripMenuItem.Visible = true;
                            //  emergencyToolStripMenuItem.Visible = true;
                            //    button7.Visible = true;
                            button2.Visible = true;
                            button1.Visible = false;
                            //  button3.Visible = true;
                            label2.Text = "User: " + user;
                            user_name = user;
                            password = pass;
                            user_type = type;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Failed to Login");
                    }
                    db.sql.Close();
                }
            }
            catch
            { 
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to Logout.??","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Logout Sucessfull");
                aDMINToolStripMenuItem.Visible = false;
                accountsToolStripMenuItem.Visible = false;
                hOSPITALToolStripMenuItem.Visible = false;
                dIAGNOSTICToolStripMenuItem.Visible = false;
                pHARMACYToolStripMenuItem.Visible = false;
                lABToolStripMenuItem.Visible = false;
                emergencyToolStripMenuItem.Visible = false;
                button2.Visible = false;
              
                button1.Visible = true;
                button7.Visible = false;
                button3.Visible = false;
                dOCTORToolStripMenuItem.Visible = false;
                pRESCRIPTIONToolStripMenuItem.Visible = false;
                label2.Text = "";
            }
        }

        private void aDDROOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_room ar = new add_room();
            ar.Show();
        }

        private void pATIENTADMITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient_Admit pa = new Patient_Admit();
            pa.Show();
        }

        private void vIEWPATIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            all_patient_history aph = new all_patient_history();
            aph.Show();
        }

        private void tAKEBILLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            take_bill tb = new take_bill();
            tb.Show();
        }

        private void nEWTESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void dUEPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 re = new Form3();
            re.Show();
        }

        private void tESTHISTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient pp = new patient();
            pp.Show();
        }

        private void aDDDOCTORSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            show_doctor sd = new show_doctor();
            sd.Show();
        }

        private void vIEWDOCTORSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dailyAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daily_account da = new daily_account();
            da.Show();
        }

        private void monthlyAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            month mm = new month();
            mm.Show();
        }

        private void dueCollectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            due_collection dc = new due_collection();
            dc.Show();
        }

        private void dAILYACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daily_patient_account dpa = new daily_patient_account();
            dpa.Show();
        }

        private void mONTHLYACCOUNTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            monthly_patient_account mpa = new monthly_patient_account();
            mpa.Show();

        }

        private void dISCHARGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            discharge discharge = new discharge();
            discharge.Show();
        }

        private void dAILYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            total_accounts ta = new total_accounts();
            ta.Show();
        }

        private void mONTHLYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            total_account_monthly tam = new total_account_monthly();
            tam.Show();
        }

        private void dAILYREFERANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mONTHLYREFERANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hospital hospital = new Hospital(user_name,password,user_type);
            hospital.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Diagnostic diagnostic = new Diagnostic(user_name, password,user_type);
            diagnostic.Show();
        }

        private void dATABASECONNECTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Doctors doctor = new Doctors();
            doctor.Show();
        }

        private void aDDUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_User add_usesr = new Add_User();
            add_usesr.Show();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.F1)
                {
                    database_connection dbconnection = new database_connection();
                    dbconnection.Show();


                }
            }
            catch
            {

            }
        }

        private void bACKUPDATABASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.Show();
        }

        private void pHARMACYACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pharmacy_account pa = new pharmacy_account();
            pa.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            daily_user_cash_collection duc = new daily_user_cash_collection(user_name,password);
            duc.Show();
        }

        private void aDDDOCTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refer_doctor refer = new refer_doctor();
            refer.Show();
        }

        private void userHistoryClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_history uh = new user_history();
            uh.Show();
        }

        private void dailyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            user_Account ua = new user_Account();
            ua.Show();
        }

        private void monthlyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            User_Account_Monthly uam = new User_Account_Monthly();
            uam.Show();
        }

        private void dAILYToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            daily_reference dr = new daily_reference();
            dr.Show();
        }

        private void mONTHLYToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            monthly_referance mr = new monthly_referance();
            mr.Show();
        }

        private void dOCTORWISEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorwise_referance dr = new doctorwise_referance();
            dr.Show();
        }

        private void hOSPITALREFERANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hospital_referance hr = new hospital_referance();
            hr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Doctor_Appointment da = new Doctor_Appointment();
            da.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Lab_Management lab = new Lab_Management();
            lab.Show();
        }

        private void dBConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BD_Connection db = new BD_Connection();
            db.Show();
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.F1)
                {
                    BD_Connection db = new BD_Connection();
                     db.Show();


                }
            }
            catch
            {

            }
        }

        private void testHistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void labInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pathologistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pathologist pat = new Pathologist();
            pat.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string xxx = "001";
            Add_Employee aee = new Add_Employee(xxx);
            aee.Show();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Employee vvee = new View_Employee();
            vvee.Show();
        }

        private void salaryManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void externalAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            External_Account extra = new External_Account();
            extra.Show();
        }

        private void iPDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hospital hospital = new Hospital(user_name, password, user_type);
            hospital.Show();
        }

        private void pHARMACYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pharmacy pharma = new Pharmacy(user_name, password,user_type);
            pharma.Show();
        }

        private void dIAGNOSTICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diagnostic diagnostic = new Diagnostic(user_name, password, user_type);
            diagnostic.Show();
        }

        private void lABToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab_Management lab = new Lab_Management();
            lab.Show();
        }

        private void dOCTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor_Appointment da = new Doctor_Appointment();
            da.Show();
        }

        private void pRESCRIPTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctors doctor = new Doctors();
            doctor.Show();
        }

        private void oPDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dAILYToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Daily_Opd_Account dop = new Daily_Opd_Account();
            dop.Show();
        }

        private void mONTHLYToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Monthly_Opd_Account moa = new Monthly_Opd_Account();
            moa.Show();
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPD opd = new OPD(user_name, password, user_type);
            opd.Show();
        }

        private void patientHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opd_Patient_History opd = new Opd_Patient_History();
            opd.Show();

        }

        private void patientHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Opd_Patient_History opd = new Opd_Patient_History();
            opd.Show();
        }

        private void newPatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OPD opd = new OPD(user_name, password, user_type);
            opd.Show();
        }

        private void hOSPITALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hospital hospital = new Hospital(user_name, password, user_type);
            hospital.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            total_accounts total = new total_accounts();
            total.Show();
        }

        private void salaryManageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Salary_Manage sm = new Salary_Manage();
            sm.Show();
        }

        private void testHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Test_information ti = new Test_information();
            ti.Show();
        }

        private void labInventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Lab_Inventory lb = new Lab_Inventory();
            lb.Show();
        }

        private void surgeonAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Surgeon_Account sur = new Surgeon_Account();
            sur.Show();
        }

        private void anaestasiaAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasteasia an = new Anasteasia();
            an.Show();
        }

        private void testHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Test_information ti = new Test_information();
            ti.Show();
        }

        private void cOMPANYPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicine_Paid_History mph = new Medicine_Paid_History();
            mph.Show();
        }
    }
}
