using CentosCashFlow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosCashFlow.ChildForms
{
    public partial class TransactionAddingChildForm : Form
    {
        List<Models.Category> listExpenditureItem;
        List<Models.Category> listIncomeItem;
        List<Models.Currency> listCurrencyItem;
        public Models.Settings userSettings { get; set; }

        public bool isChanged { get; set; }
        public TransactionAddingChildForm()
        {
            InitializeComponent();
            listExpenditureItem= new List<Models.Category>();
            listIncomeItem= new List<Models.Category>();
            listCurrencyItem = new List<Models.Currency>();
            userSettings = new Models.Settings();
            isChanged= false;
        }

        private void TransactionAddingChildForm_Load(object sender, EventArgs e)
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            userSettings = connectUsers.getUserSettingsByID(int.Parse(this.Tag.ToString()));

            Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
            listCurrencyItem = connectCurrency.getData();
            Load_CurrencyCombobox();
            comboBoxCurrency.SelectedItem = userSettings.CurrencyCode;

            dateTimePickerCategory.MaxDate = DateTime.Now.AddMonths(3);
            dateTimePickerCategory.Value = DateTime.Now;
            dateTimePickerCategory.MaxDate = DateTime.Today;
            comboBoxTransactionType.Items.Clear();
            comboBoxTransactionType.Items.Add("Income");
            comboBoxTransactionType.Items.Add("Expenditure");
            comboBoxTransactionType.SelectedItem = "Expenditure";
            comboBoxCategory.Items.Clear();
            ConnectCategory connect = new ConnectCategory();

            listExpenditureItem = connect.getExpenditureTypeData();
            listIncomeItem = connect.getIncomeTypeData();

            Load_CategoryCombobox();
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
        private void comboBoxTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_CategoryCombobox();
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            int count = 0;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != 32 && e.KeyChar != '.')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
            if(e.KeyChar == '.')
            {
                count++;
                if(count >= 2)
                {
                    e.Handled = true;
                }
            }
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
                    isChanged= true;
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
