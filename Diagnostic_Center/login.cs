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
    public partial class login : Form
    {

         public string val1 { get; set; }
        public string val2 { get; set; }
        public string val3 { get; set; }
        public login(string val)
        {
            InitializeComponent();
            val1 = "";
            val2 = "";
            val3 = "";
            this.AcceptButton = button1;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            val1 = textBox1.Text;
            val2 =textBox2.Text;
            val3 = comboBox1.Text;
            this.Close();
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            cbo.Focus();
            cbo.DroppedDown = true;
        }
    }
}
