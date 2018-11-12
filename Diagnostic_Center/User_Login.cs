using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostic_Center
{
    public partial class User_Login : Form
    {
        public string val1 { get; set; }
        public string val2 { get; set; }

        public User_Login(string val)
        {
            InitializeComponent();
            val1 = "";
            val2 = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            val1 = textBox1.Text;
            val2 = textBox2.Text;
            this.Close();
        }
    }
}
