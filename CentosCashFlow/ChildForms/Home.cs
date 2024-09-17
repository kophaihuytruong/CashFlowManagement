using CentosCashFlow.Models;
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
    public partial class Home : Form
    {
        public Models.User user { get; set; }
        public Languages.LanguageDictionary dictionary { get; set; }
        public Home()
        {
            InitializeComponent();
            user = new Models.User();
            dictionary = new Languages.LanguageDictionary();
        }

        public void Load_Data()
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            user = connectUsers.getUserDataByID(int.Parse(this.Tag.ToString()));

            Models.ConnectTransaction connectTransaction = new Models.ConnectTransaction();
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            List<Models.Transaction> listCurrrentMonth = connectTransaction.getMonthDataByID(int.Parse(this.Tag.ToString()), month, year);

            labelCurrentBalance.Text = user.AvailableMoney.ToString() + " " + user.UserSettings.CurrencyCode;
            decimal totalIncomes = 0;
            decimal totalEnpenditures = 0;
            foreach (Models.Transaction transaction in listCurrrentMonth)
            {
                if (transaction.TransactionType.Contains("Income"))
                {
                    totalIncomes += transaction.Amount;
                }
                else
                {
                    totalEnpenditures += transaction.Amount;
                }
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
            labelTotalMonthIncome.Text = "+" + totalIncomes.ToString() + " " + user.UserSettings.CurrencyCode;
            labelTotalMonthExpenditure.Text = "-" + totalEnpenditures.ToString() + " " + user.UserSettings.CurrencyCode;

            chartMonthCashFlow.ChartAreas["ChartArea1"].AxisX.Title = "This month";
            chartMonthCashFlow.ChartAreas["ChartArea1"].AxisY.Title = user.UserSettings.CurrencyCode;
            chartMonthCashFlow.ChartAreas["ChartArea1"].AxisY.Interval = 1;
            chartMonthCashFlow.Series["Cash Flow"]["DrawingStyle"] = "Default";

            chartMonthCashFlow.Series["Cash Flow"].Points.AddXY("Incomes", totalIncomes);
            chartMonthCashFlow.Series["Cash Flow"].Points.AddXY("Expenditures", totalEnpenditures);

            dictionary = new Languages.LanguageDictionary(user.UserSettings.LanguageCode);
            dictionary.SetLanguages((Control)this);
        }

        public void Reload_Data()
        {
            chartMonthCashFlow.Series["Cash Flow"].Points.Clear();

            foreach (Control control in panelCurrentTransactions.Controls)
            {
                control.Dispose();
            }

            panelCurrentTransactions.Controls.Clear();

            Load_Data();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            Load_Data();
            
        }
        private void btnAddNewTransaction_Click(object sender, EventArgs e)
        {
            TransactionAddingChildForm form = new TransactionAddingChildForm();
            form.Tag= this.Tag;
            form.ShowDialog();
            if (form.isChanged)
            {
                Reload_Data();
            }
        }
    }
}
