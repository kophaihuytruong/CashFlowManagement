using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosCashFlow.ChildForms
{
    public partial class CurrencyAddingForm : Form
    {
        public bool isChanged { get; set; }
        public CurrencyAddingForm()
        {
            InitializeComponent();
            isChanged = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCurrencyCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxCurrencyCode.Text.Length >= 3)
            {
                e.Handled = true;
            }
        }

        private void textBoxCurrencyCode_TextChanged(object sender, EventArgs e)
        {
            labelCurrencyExchangeUnit.Text = textBoxCurrencyCode.Text;
        }

        private void btnAddNewCurrency_Click(object sender, EventArgs e)
        {
            if (textBoxCurrencyCode.Text.Length != 3)
            {
                MessageBox.Show("Please enter Currency Code with 3 characters only!", "", MessageBoxButtons.OK);
            }
            else
            {
                if (textBoxCurrencyName.Text != "")
                {
                    Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
                    Models.Currency currency = new Models.Currency();
                    currency.CurrencyCode = textBoxCurrencyCode.Text;
                    currency.CurrencyName = textBoxCurrencyName.Text;
                    currency.ExchangeRateUSD = decimal.Parse(textBoxExchangeRate.Text);
                    int kt = connectCurrency.addNewItem(currency);
                    if (kt != 0)
                    {
                        MessageBox.Show("Completely adding!", "", MessageBoxButtons.OK);
                        isChanged = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cannot add!", "", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
