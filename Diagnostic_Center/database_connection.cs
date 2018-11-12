using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostic_Center
{
    public partial class database_connection : Form
    {
        public database_connection()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config;
                config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string connection = string.Format("Data Source={0}; Initial Catalog={1}; User Id={2}; Password={3}", comboBox1.Text, richTextBox13.Text, richTextBox12.Text, richTextBox11.Text);


                /*
          
                 config.ConnectionStrings.ConnectionStrings["connection"].ConnectionString = connection;
                 config.ConnectionStrings.ConnectionStrings["connection"].ProviderName = "System.Data.SqlClient";
                 config.Save(ConfigurationSaveMode.Modified);*/


                config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.ConnectionStrings.ConnectionStrings["connection"].ConnectionString = connection;
                config.ConnectionStrings.ConnectionStrings["connection"].ProviderName = "System.Data.SqlClient";
                // MessageBox.Show(Properties.Settings.Default.hmsConnectionString);
                Properties.Settings.Default.connection = connection;
                Properties.Settings.Default.Save();
                config.Save(ConfigurationSaveMode.Modified);
                MessageBox.Show("Saved Sucessfull Restart The application");
            }
            catch
            {
            }
        }
    }
}
