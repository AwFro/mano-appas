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
        public void LeistiSkaicius(KeyPressEventArgs e)
        {
            char mhm = e.KeyChar;
            if (!Vout.Text.ToLower().Contains(',')) //ar yra kablelis
            {
                if (!char.IsDigit(mhm) && mhm != 8 && mhm != ',') e.Handled = true;
            }
            else
            {
                if (!char.IsDigit(mhm) && mhm != 8) e.Handled = true;
            }
        }
        public void skaiciuTxtDaug(TextBox boxas, float max)
        {
            String pirmas = boxas.Text;
            if (pirmas == (max).ToString()+",") boxas.Text = (max).ToString(); //jei kablelis po maximumo vertes
            if (pirmas == ",") boxas.Text = "";
            if (boxas.Text != "")
            {
                float lame = float.Parse(pirmas);
                if (lame > max)//
                {
                   boxas.Text = (max).ToString();//
                }
            }
            
            boxas.SelectionStart = boxas.Text.Length;
        }
           
    }
}
