using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_CalculatorLetterGrade
{
    public partial class frmCalculateLetterGrade : Form
    {
        public frmCalculateLetterGrade()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal alphanum = Convert.ToDecimal(txtNumGrade.Text);
            char letterGrade;
            if (alphanum >= 0 && alphanum < 60) letterGrade = 'F';
            else if (alphanum >= 60 && alphanum < 70) letterGrade = 'D';
            else if (alphanum >= 70 && alphanum < 80) letterGrade = 'C';
            else if (alphanum >= 80 && alphanum < 90) letterGrade = 'B';
            else if (alphanum >= 90 && alphanum <= 100) letterGrade = 'A';
            else
            {
                MessageBox.Show("Please fill a number from 0 to 100");
                letterGrade = ' ';
            }
            txtLetterGrade.Text = letterGrade.ToString();
            txtNumGrade.Focus();
        }
    }
}
