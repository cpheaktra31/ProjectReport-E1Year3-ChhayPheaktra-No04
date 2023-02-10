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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string cusType = txtCusType.Text;
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discPercent = 0m;

            if(cusType == "R" || cusType == "r")
            {
                if (subtotal > 0 && subtotal < 100) discPercent = 0m;
                else if (subtotal >= 100 && subtotal < 250) discPercent = 0.1m;
                else if (subtotal >= 250 && subtotal < 500) discPercent = 0.15m;
                else if (subtotal > 500) discPercent = 0.2m;
            }
            else if (cusType == "C" || cusType == "c")
            {
                if (subtotal > 0 && subtotal < 250) discPercent = 0.2m;
                else discPercent = 0.3m;
            }
            else
            {
                discPercent = 0.4m;
            }

            decimal discAmount = subtotal * discPercent;
            decimal invoiceTotal = subtotal - discAmount;

            txtDiscountPecent.Text = discPercent.ToString("P");
            txtDiscountAmount.Text = discAmount.ToString("C");
            txtTotal.Text = invoiceTotal.ToString("C");

            txtSubtotal.Focus();
        }
    }
}
