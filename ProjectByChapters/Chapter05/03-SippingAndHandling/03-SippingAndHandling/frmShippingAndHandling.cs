using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_SippingAndHandling
{
    public partial class frmShippingAndHandling : Form
    {
        public frmShippingAndHandling()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal orderTotal = Convert.ToDecimal(txtOrderTotal.Text);
            decimal shippingCost = 0m;
            string cusType = txtCustomerType.Text;
            if (cusType == "P" || cusType == "p") shippingCost = 0m;
            else if (cusType == "N" || cusType == "n")
            {
                if (orderTotal > 5000) shippingCost = 20m;
                else if (orderTotal > 1000) shippingCost = 10m;
                else if (orderTotal > 500) shippingCost = 8m;
                else if (orderTotal > 25) shippingCost = 5m;
                else shippingCost = 0m;
            }
            else
            {
                clear();
                orderTotal = 0m;
                MessageBox.Show("Customer Type should be P or N");
            }

            decimal salesTax = orderTotal * 0.07m;
            decimal grandTotal = orderTotal + shippingCost + salesTax;

            txtShippingCosts.Text = shippingCost.ToString("C");
            txtSalesTax.Text = salesTax.ToString("C");
            txtGrandTotal.Text = grandTotal.ToString("C");

            txtCustomerType.Focus();
        }

        void clear()
        {
            txtOrderTotal.Text = "";
            txtCustomerType.Text = "";
            txtShippingCosts.Text = "";
            txtSalesTax.Text = "";
            txtGrandTotal.Text = "";
        }
    }
}
