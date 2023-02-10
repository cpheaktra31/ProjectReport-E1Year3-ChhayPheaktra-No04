using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_StudentPopulation_For
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

            double tmp = 1;
            for (int i=0; i<numYear; i++)
            {
            double a = 1 + agr;
                tmp = tmp * a;
            }
            double stuNumProjected = stuNow * tmp;

            txtStuNumProjected.Text = stuNumProjected.ToString("N0");
            txtStuNumNow.Focus();
        }
    }
}
