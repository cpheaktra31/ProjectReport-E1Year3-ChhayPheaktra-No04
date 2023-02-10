using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_StudentPopulation
{
    public partial class frmStudentPopulation : Form
    {
        public frmStudentPopulation()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double stuNow = Convert.ToDouble(txtStuNumNow.Text);
            double agr = Convert.ToDouble(txtAGR.Text);
            int numYear = Convert.ToInt32(txtNumYear.Text);
            double stuNumProjected = 0;
            stuNumProjected = stuNow * Math.Pow((1 + agr), numYear);
            // x = x1 * (1+r)^t
            txtStuNumProjected.Text = stuNumProjected.ToString("N0");
            txtStuNumNow.Focus();
        }
    }
}
