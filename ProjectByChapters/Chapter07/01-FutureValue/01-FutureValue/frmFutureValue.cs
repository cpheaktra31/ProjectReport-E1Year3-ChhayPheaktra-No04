using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
                    int years = Convert.ToInt32(txtNumYears.Text);
                    int months = years * 12;
                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

                    decimal futureValue = this.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);

                    txtFutureValue.Text = futureValue.ToString("C");
                    txtMonthlyInvestment.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }

        public bool isValidData()
        {
            return (isPresent(txtMonthlyInvestment, "Monthly Investment") &&
                isDecimal(txtMonthlyInvestment, "Monthly Investment") &&
                isWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 100) &&
                isPresent(txtYearlyInterestRate, "Yearly Interest Rate") &&
                isDecimal(txtYearlyInterestRate, "Yearly Interest Rate") &&
                isWithinRange(txtYearlyInterestRate, "Yearly Interest Rate", 1, 20) &&
                isPresent(txtNumYears, "Number of Years") &&
                isDecimal(txtNumYears, "Number of Years") &&
                isWithinRange(txtNumYears, "Number of Years", 1, 40));
        }

        public bool isPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + "is required.", "Entry error");
                return false;
            }
            return true;
        }

        public bool isDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be decimal.", "Entry error");
                textBox.Focus();
                return false;
            }
        }

        public bool isInt32(TextBox textBox, string name)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be integer.", "Entry error");
                textBox.Focus();
                return false;
            }
        }

        public bool isWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".");
                return false;
            }
            return true;
        }
    }
}
