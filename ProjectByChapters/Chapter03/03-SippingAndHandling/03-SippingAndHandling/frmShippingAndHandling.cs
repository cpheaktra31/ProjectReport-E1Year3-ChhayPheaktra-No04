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
            string cusType = Convert.ToString(txtCustomerType.Text);
            decimal salesTax = 0m;
            if (cusType == "P" || cusType == "p") salesTax = 0m;
            else if (cusType == "N" || cusType == "n") salesTax = 0.07m;
            else
            {
                clear();
                orderTotal = 0m;
                MessageBox.Show("Customer Type should be P or N");
            }

            decimal shippingCost = orderTotal * salesTax;
            decimal grandTotal = orderTotal + shippingCost;

            txtShippingCosts.Text = shippingCost.ToString("C");
            txtSalesTax.Text = salesTax.ToString("P");
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
