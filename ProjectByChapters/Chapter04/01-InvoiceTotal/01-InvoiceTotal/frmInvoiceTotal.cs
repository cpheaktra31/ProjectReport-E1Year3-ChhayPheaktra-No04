using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int numOfInvoice = 0;
        decimal totalOfInvoice = 0m;
        decimal invoiceAverage = 0;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discPercent = 0.25m;
            decimal discAmount = Math.Round(subtotal * discPercent, 2);
            decimal invoiceTotal = subtotal - discAmount;

            txtViewSubtotal.Text = subtotal.ToString("C");
            txtDiscountPecent.Text = discPercent.ToString("P");
            txtDiscountAmount.Text = discAmount.ToString("C");
            txtTotal.Text = invoiceTotal.ToString("C");

            numOfInvoice++;
            totalOfInvoice += invoiceTotal;
            invoiceAverage = totalOfInvoice / numOfInvoice;

            txtInvoiceNum.Text = numOfInvoice.ToString();
            txtInvoiceTotal.Text = totalOfInvoice.ToString("C");
            txtInvoiceAverage.Text = invoiceAverage.ToString("C");

            txtSubtotal.Text = "";
            txtSubtotal.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            numOfInvoice = 0;
            totalOfInvoice = 0m;
            invoiceAverage = 0m;

            txtInvoiceNum.Text = "";
            txtInvoiceTotal.Text = "";
            txtInvoiceAverage.Text = "";

            txtSubtotal.Text = "";
        }
    }
}
