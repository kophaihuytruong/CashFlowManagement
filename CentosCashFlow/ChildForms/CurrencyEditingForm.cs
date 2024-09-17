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
    public partial class CurrencyEditingForm : Form
    {
        public Models.Currency currency { get; set; }
        public bool isChanged { get; set; }
        public CurrencyEditingForm()
        {
            InitializeComponent();
            currency= new Models.Currency();
            isChanged=false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CurrencyEditingForm_Load(object sender, EventArgs e)
        {
            textBoxCurrencyCode.Text = currency.CurrencyCode;
            textBoxCurrencyName.Text = currency.CurrencyName;
            textBoxExchangeRate.Text = currency.ExchangeRateUSD.ToString();
            labelCurrencyExchangeUnit.Text = currency.CurrencyCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxCurrencyName.Text != currency.CurrencyName
                || textBoxExchangeRate.Text != currency.ExchangeRateUSD.ToString())
            {
                Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
                currency.CurrencyName = textBoxCurrencyName.Text;
                currency.ExchangeRateUSD = decimal.Parse(textBoxExchangeRate.Text);
                int kt = connectCurrency.updateDataForItem(currency);
                if (kt != 0)
                {
                    MessageBox.Show("Completely updating!", "", MessageBoxButtons.OK);
                    isChanged = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot update!", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please type your change!", "", MessageBoxButtons.OK);
            }
        }

        private void btnDeleting_Click(object sender, EventArgs e)
        {
            Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
            int kt = connectCurrency.deleteDataById(currency.CurrencyCode);

            if (kt != 0)
            {
                MessageBox.Show("Completely deleting!", "", MessageBoxButtons.OK);
                isChanged = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cannot delete!", "", MessageBoxButtons.OK);
            }
        }
    }
}
