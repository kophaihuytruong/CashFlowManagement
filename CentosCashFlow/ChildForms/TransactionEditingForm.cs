using CentosCashFlow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosCashFlow.ChildForms
{
    public partial class TransactionEditingForm : Form
    {
        public Models.Transaction TransModel { get; set; }
        List<Models.Category> listExpenditureItem;
        List<Models.Category> listIncomeItem;
        List<Models.Currency> listCurrencyItem;
        public Models.Settings userSettings { get; set; }

        public bool isChanged { get; set; }
        public TransactionEditingForm()
        {
            InitializeComponent();
            TransModel = null;
            userSettings = new Models.Settings();
            isChanged= false;
            listExpenditureItem = new List<Models.Category>();
            listIncomeItem = new List<Models.Category>();
        }

        private void Load_CategoryCombobox()
        {
            comboBoxCategory.Items.Clear();
            if (comboBoxTransactionType.SelectedItem.ToString().Contains("Expenditure"))
            {
                foreach (Models.Category category in listExpenditureItem)
                {
                    comboBoxCategory.Items.Add(category.CategoryName);
                }
            }
            else
            {
                foreach (Models.Category category in listIncomeItem)
                {
                    comboBoxCategory.Items.Add(category.CategoryName);
                }
            }
        }
        private void Load_CurrencyCombobox()
        {
            comboBoxCurrency.Items.Clear();
            foreach (Models.Currency item in listCurrencyItem)
            {
                comboBoxCurrency.Items.Add(item.CurrencyCode);
            }
        }
        private void TransactionEditingForm_Load(object sender, EventArgs e)
        {
            dateTimePickerCategory.MaxDate = DateTime.Now.AddMonths(3);
            if (TransModel != null)
            {
                Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
                listCurrencyItem = connectCurrency.getData();
                Load_CurrencyCombobox();
                comboBoxTransactionType.Items.Add("Income");
                comboBoxTransactionType.Items.Add("Expenditure");
                if (TransModel.TransactionType.Contains("Income"))
                {
                    comboBoxTransactionType.SelectedItem = "Income";
                }
                else
                {
                    comboBoxTransactionType.SelectedItem = "Expenditure";
                }
                Models.ConnectCategory connectCategory = new Models.ConnectCategory();
                listExpenditureItem = connectCategory.getExpenditureTypeData();
                listIncomeItem = connectCategory.getIncomeTypeData();
                Load_CategoryCombobox();

                textBoxAmount.Text = TransModel.Amount.ToString();
                dateTimePickerCategory.Value = TransModel.TransactionDate;
                richTextBoxDescription.Text = TransModel.TransactionDescription;
                comboBoxCurrency.SelectedItem = userSettings.CurrencyCode;
                comboBoxCategory.SelectedItem = TransModel.CategoryName;
                
            }
        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            if (textBoxAmount.Text != TransModel.Amount.ToString()
                || dateTimePickerCategory.Value != TransModel.TransactionDate
                || !richTextBoxDescription.Text.Contains(TransModel.TransactionDescription)
                || !userSettings.CurrencyCode.Contains(comboBoxCurrency.SelectedItem.ToString())
                || !TransModel.CategoryName.Contains(comboBoxCategory.SelectedItem.ToString())
                || !TransModel.TransactionType.Contains(comboBoxTransactionType.SelectedItem.ToString()))
            {
                if (!userSettings.CurrencyCode.Contains(comboBoxCurrency.SelectedItem.ToString()))
                {
                    Currency choosenCurrency = listCurrencyItem.Find(item => item.CurrencyCode == comboBoxCurrency.SelectedItem.ToString());
                    Currency userSettingCurrency = listCurrencyItem.Find(item => item.CurrencyCode == userSettings.CurrencyCode);
                    TransModel.Amount = userSettingCurrency.ExchangeRateUSD*(decimal.Parse(textBoxAmount.Text) / choosenCurrency.ExchangeRateUSD);
                    TransModel.TransactionDate = dateTimePickerCategory.Value;
                    TransModel.TransactionDescription = richTextBoxDescription.Text;
                    TransModel.CategoryName = comboBoxCategory.SelectedItem.ToString();
                    TransModel.TransactionType = comboBoxTransactionType.SelectedItem.ToString();

                }
                else
                {
                    TransModel.Amount = decimal.Parse(textBoxAmount.Text);
                    TransModel.TransactionDate = dateTimePickerCategory.Value;
                    TransModel.TransactionDescription = richTextBoxDescription.Text;
                    TransModel.CategoryName = comboBoxCategory.SelectedItem.ToString();
                    TransModel.TransactionType = comboBoxTransactionType.SelectedItem.ToString();
                }
                Models.ConnectTransaction connectTransaction = new Models.ConnectTransaction();

                int kt = connectTransaction.updateDataForItem(TransModel);

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

        private void comboBoxTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_CategoryCombobox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
