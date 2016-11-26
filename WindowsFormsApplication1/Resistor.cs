using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1
    {
        private void action_Click(object sender, EventArgs e)
        {
            MessageBox.Show("D");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox a = combo4;
            comboChangedDo(a);
        }
        private void comboBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            ComboBox a = combo4;
            comboDrawDo(e, a);
    }
        private void comboBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox a = combo2;
            comboDrawDo(e, a);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox a = combo2;
            comboChangedDo(a);
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox a = combo3;
            comboChangedDo(a);
        }
        private void comboBox3_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox a = combo3;
            comboDrawDo(e, a);
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox a = combo5;
            comboChangedDo(a);
        }
        private void comboBox4_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox a = combo5;
            comboDrawDo(e, a);
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox a = combo1;
            comboChangedDo(a);
        }
        private void comboBox5_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox a = combo1;
            comboDrawDo(e, a);
        }

        private void comboDrawDo(System.Windows.Forms.DrawItemEventArgs e, ComboBox comboBox)
        {
            // http://www.dhirajranka.com/2012/01/set-combobox-item-color/
            if (e.Index < 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                return;
            }

            Rectangle SizeRect = new Rectangle(2, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);
            Brush ComboBrush = Brushes.Black;

            e.DrawBackground();
            e.DrawFocusRectangle();

            Color CurrentColor = Color.Red;
            if (e.Index == 0)
            {
                CurrentColor = Color.Black;
                ComboBrush = Brushes.White;
            }
            else if (e.Index == 1) CurrentColor = Color.Brown;
            else if (e.Index == 2) CurrentColor = Color.Red;
            else if (e.Index == 3) CurrentColor = Color.Orange;
            else if (e.Index == 4) CurrentColor = Color.Yellow;
            else if (e.Index == 5) CurrentColor = Color.Green;
            else if (e.Index == 6) CurrentColor = Color.Blue;
            else if (e.Index == 7) CurrentColor = Color.Violet;
            else if (e.Index == 8) CurrentColor = Color.Gray;
            else if (e.Index == 9) CurrentColor = Color.White;


            e.Graphics.DrawRectangle(new Pen(CurrentColor), SizeRect);
            e.Graphics.FillRectangle(new SolidBrush(CurrentColor), SizeRect);

            e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), comboBox.Font, ComboBrush, e.Bounds.X, e.Bounds.Y);

        }
        private void comboChangedDo(ComboBox comboBox)
        {
            this.ActiveControl = null;
            comboBox.ForeColor = Color.Black;
            if (comboBox.Text == "Black")
            {
                comboBox.BackColor = Color.Black;
                comboBox.ForeColor = Color.White;
            }
            else if (comboBox.Text == "Brown") comboBox.BackColor = Color.Brown;
            else if (comboBox.Text == "Red") comboBox.BackColor = Color.Red;
            else if (comboBox.Text == "Orange") comboBox.BackColor = Color.Orange;
            else if (comboBox.Text == "Yellow") comboBox.BackColor = Color.Yellow;
            else if (comboBox.Text == "Green") comboBox.BackColor = Color.Green;
            else if (comboBox.Text == "Blue") comboBox.BackColor = Color.Blue;
            else if (comboBox.Text == "Violet") comboBox.BackColor = Color.Violet;
            else if (comboBox.Text == "Gray") comboBox.BackColor = Color.Gray;
            else if (comboBox.Text == "White") comboBox.BackColor = Color.White;

            FindR();
        }

        private void band5_CheckedChanged(object sender, EventArgs e)
        {
            if (band5.Checked)
            {
                combo5.Visible = true;
                combo1.Location = new Point(12, 79);
                combo2.Location = new Point(12, 52);
                combo3.Location = new Point(468, 35);
                combo4.Location = new Point(468, 78);
                //  combo5.Location = new Point(7 , 25);
                band4Pic.Visible = false;
                band5Pic.Visible = true;
            }
            else
            {
                combo5.Visible = false;
                combo1.Location = new Point(91, 147);
                combo2.Location = new Point(199, 147);
                combo3.Location = new Point(311, 147);
                combo4.Location = new Point(421, 147);
                band4Pic.Visible = true;
                band5Pic.Visible = false;
            }
        }

        private void FindR()
        {
            String text, simbolis="";
            if (band5.Checked) text = (combo1.SelectedIndex).ToString() + (combo2.SelectedIndex).ToString() + (combo5.SelectedIndex).ToString();
            else text = (combo1.SelectedIndex).ToString() + (combo2.SelectedIndex).ToString();
            double ats = (double.Parse(text)) * (Math.Pow(10.00, (double)combo3.SelectedIndex));
            if (ats >= 1000000) {
                simbolis = " M";
                ats = ats / 1000000;
            }
            else if (ats >= 1000)
            {
                simbolis = " K";
                ats = ats / 1000;
            }
            varza.Text = (ats).ToString() +  simbolis+ "Ω ± " + (combo4.SelectedIndex).ToString() + "%";            
            
        }


    } //done
}

/* 
combo1 91, 147
combo2 199, 147
combo3 311, 147
combo 4 421, 147

    5band 
*/