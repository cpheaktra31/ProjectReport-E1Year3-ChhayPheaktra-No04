using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_CustomerPayment
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lstCreditCardType.Items.Add("Visa");
            lstCreditCardType.Items.Add("Mastercard");
            lstCreditCardType.Items.Add("American Express");
            lstCreditCardType.SelectedIndex = 0;

            string[] months =
            {
                "Select a month...","January","February","March","April","May","June","July",
                "August","September","October","November","December"
            };

            foreach (string month in months)
            {
                cboExpirationMonth.Items.Add(month);
            }
            cboExpirationMonth.SelectedIndex = 0;

            int year = DateTime.Today.Year;
            int endYear = year + 8;

            cboExpirationYear.Items.Add("Select a year...");
            while (endYear > year)
            {
                cboExpirationYear.Items.Add(year);
                year++;
            }
            cboExpirationYear.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.SaveData();
            }
        }

        private bool IsValidData()
        {
            if (rdoCreditCard.Checked)
            {
                if (lstCreditCardType.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card type.", "Entry error");
                    lstCreditCardType.Focus();
                    return false;
                }
                if (txtCardNumber.Text == "")
                {
                    MessageBox.Show("You must enter a card number.", "Entry error");
                    txtCardNumber.Focus();
                    return false;
                }
                if (cboExpirationMonth.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a month.", "Entry error");
                    cboExpirationMonth.Focus();
                    return false;
                }
                if (cboExpirationYear.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a year.", "Entry error");
                    cboExpirationYear.Focus();
                    return false;
                }
            }
            return true;
        }

        private void SaveData()
        {
            string msg = null;
            if (rdoCreditCard.Checked == true)
            {
                msg += "Charg to credit card. \n";
                msg += "\n";
                msg += "Card type: " + lstCreditCardType.Text + "\n";
                msg += "Card number: " + txtCardNumber.Text + "\n";
                msg += "Expiration date: " + cboExpirationMonth.Text + "/" + cboExpirationYear.Text + "\n";
            }
            else
            {
                msg += "Send bill to customer. \n";
                msg += "\n";
            }

            bool isDefaultBilling = chkDefault.Checked;
            msg += "Default billing " + isDefaultBilling;

            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }

        private void rdoCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreditCard.Checked)
                EnableControls();
            else
                DisableControls();
        }

        private void EnableControls()
        {
            lstCreditCardType.Enabled = true;
            txtCardNumber.Enabled = true;
            cboExpirationMonth.Enabled = true;
            cboExpirationYear.Enabled = true;
        }

        private void DisableControls()
        {
            lstCreditCardType.Enabled = false;
            txtCardNumber.Enabled = false;
            cboExpirationMonth.Enabled = false;
            cboExpirationYear.Enabled = false;
        }
    }
}
