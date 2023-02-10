using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_TelephoneNumber
{
    public partial class frmTelephoneNumber : Form
    {
        public frmTelephoneNumber()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string alpha = txtAlphaNum.Text.ToLower();
            char[] alphaArray = alpha.ToCharArray();
            
            //var map =
            //{
                //1: ['a',' b','c'],
                //2: ['d',' e','f'],
            //}

            char num;
            string res = "";
            foreach (char c in alphaArray)
            {
                if (c == 'a' || c == 'b' || c == 'b') num = '2';
                else if (c == 'd' || c == 'e' || c == 'f') num = '3';
                else if (c == 'g' || c == 'h' || c == 'i') num = '4';
                else if (c == 'j' || c == 'k' || c == 'l') num = '5';
                else if (c == 'm' || c == 'n' || c == 'o') num = '6';
                else if (c == 'p' || c == 'q' || c == 'r' || c == 's') num = '7';
                else if (c == 't' || c == 'u' || c == 'v') num = '8';
                else if (c == 'w' || c == 'x' || c == 'y') num = '9';
                else num = c;
                
                res = res + num;
            }
            txtNum.Text = res;
        }
    }
}
