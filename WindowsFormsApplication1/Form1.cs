using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private object Int;

        public Form1()
        {
 
            InitializeComponent();
        

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mhm = e.KeyChar;
            if(!char.IsDigit(mhm) && mhm != 8 && mhm != 8 && mhm != '.')

            {
                e.Handled = true;
            }
            
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String pirmas = textBox1.Text;
            if (Int32.Parse(pirmas) > 10000)
            {
                textBox1.Text = "10000";
            }
        }
    }


}
