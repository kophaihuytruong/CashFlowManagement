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
    public partial class TransactionForm : Form
    {
        List<Models.Category> listExpenditureItem;
        List<Models.Category> listIncomeItem;
        List<Models.Currency> listCurrencyItem;
        public Models.Settings userSettings { get; set; }
        public Languages.LanguageDictionary dictionary { get; set; }
        public TransactionForm()
        {
            InitializeComponent();
            listExpenditureItem = new List<Models.Category>();
            listIncomeItem = new List<Models.Category>();
            listCurrencyItem = new List<Models.Currency>();
            userSettings = new Models.Settings();
            dictionary = new Languages.LanguageDictionary();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            userSettings = connectUsers.getUserSettingsByID(int.Parse(this.Tag.ToString()));
            dictionary = new Languages.LanguageDictionary(userSettings.LanguageCode);
            dictionary.SetLanguages((Control)this);

            Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
            listCurrencyItem = connectCurrency.getData();
            Load_CurrencyCombobox();
            comboBoxCurrency.SelectedItem = userSettings.CurrencyCode;

            dateTimePickerCategory.MaxDate = DateTime.Now.AddMonths(3);
            dateTimePickerCategory.Value = DateTime.Now;
            dateTimePickerCategory.MaxDate = DateTime.Today;
            //comboBoxTransactionType.Items.Add(dictionary.getTranslatedWord("Income"));
            //comboBoxTransactionType.Items.Add(dictionary.getTranslatedWord("Expenditure"));
            comboBoxTransactionType.Items.Add("Income");
            comboBoxTransactionType.Items.Add("Expenditure");
            comboBoxTransactionType.SelectedItem = "Expenditure";
            comboBoxCategory.Items.Clear();
            ConnectCategory connect = new ConnectCategory();
            listExpenditureItem = connect.getExpenditureTypeData();
            listIncomeItem = connect.getIncomeTypeData();

            Load_CategoryCombobox();
            Load_Data();
        }
        private void Load_CurrencyCombobox()
        {
            comboBoxCurrency.Items.Clear();
            foreach (Models.Currency item in listCurrencyItem)
            {
                comboBoxCurrency.Items.Add(item.CurrencyCode);
            }
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
        public void Load_Data()
        {
            Models.ConnectTransaction connect = new Models.ConnectTransaction();
            List<Models.Transaction> list = connect.getCurrentDataByID(int.Parse(this.Tag.ToString()));

            foreach (Models.Transaction transaction in list)
            {
                Panel newPanel = new Panel();
                panelCurrentTransactions.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                TransactionItem item = new TransactionItem();
                item.TransModel = transaction;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }

        public void Reload_Data()
        {
            foreach (Control control in panelCurrentTransactions.Controls)
            {
                control.Dispose();
            }

            panelCurrentTransactions.Controls.Clear();

            Load_Data();
        }
        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != 32 && e.KeyChar !='.')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void comboBoxTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_CategoryCombobox();
        }

        private void btnAddNewTransaction_Click(object sender, EventArgs e)
        {
            Models.Transaction TransModel = new Models.Transaction();
            if (textBoxAmount.Text != ""
                && comboBoxCategory.SelectedItem.ToString() != ""
                && comboBoxTransactionType.SelectedItem.ToString() != "")
            {
                if (!userSettings.CurrencyCode.Contains(comboBoxCurrency.SelectedItem.ToString()))
                {
                    Currency choosenCurrency = listCurrencyItem.Find(item => item.CurrencyCode == comboBoxCurrency.SelectedItem.ToString());
                    Currency userSettingCurrency = listCurrencyItem.Find(item => item.CurrencyCode == userSettings.CurrencyCode);
                    TransModel.Amount = userSettingCurrency.ExchangeRateUSD * (decimal.Parse(textBoxAmount.Text) / choosenCurrency.ExchangeRateUSD);
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
                TransModel.UserID = int.Parse(this.Tag.ToString());
                Models.ConnectTransaction connectTransaction = new Models.ConnectTransaction();

                int kt = connectTransaction.addNewItem(TransModel);

                if (kt != 0)
                {
                    MessageBox.Show("Completely adding!", "", MessageBoxButtons.OK);
                    Reload_Data();
                }
                else
                {
                    MessageBox.Show("Cannot add!", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please type your change!", "", MessageBoxButtons.OK);
            }
        }
    }
}
