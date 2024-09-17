using CentosCashFlow.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CentosCashFlow.ChildForms
{
    public partial class Overview : Form
    {
        DbContext dbContext = new DbContext();
        public Models.Settings userSettings { get; set; }
        public Languages.LanguageDictionary dictionary { get; set; }
        public Overview()
        {
            InitializeComponent();
            userSettings= new Models.Settings();
            dictionary = new Languages.LanguageDictionary();
        }

        public void Load_Data()
        {
            ConnectUsers connectUsers = new ConnectUsers();
            userSettings = connectUsers.getUserSettingsByID(int.Parse(this.Tag.ToString()));
            int month = dateTimePickerOverview.Value.Month;
            int year = dateTimePickerOverview.Value.Year;
            dictionary = new Languages.LanguageDictionary(userSettings.LanguageCode);
            dictionary.SetLanguages((Control)this);
            labelIncomeMonth_display.Text = dictionary.getTranslatedWord("Incomes in") + " " + dateTimePickerOverview.Value.ToString("MM/yyyy");
            labelExpendituresMonth_display.Text = dictionary.getTranslatedWord("Expenditures in") + " " + dateTimePickerOverview.Value.ToString("MM/yyyy");

            string sql = "SELECT " +
                "c.Category_Img, " +
                "c.Category_Name, " +
                "SUM(t.Amount) AS TotalMoneyIn " +
                "FROM Categories AS c " +
                "JOIN Transactions AS t ON c.ID = t.Category_ID " +
                "WHERE t.Transaction_Type = 'Income' " +
                "AND YEAR(t.Transaction_Date) = '"+year+"' " +
                "AND MONTH(t.Transaction_Date) = '"+month+"' " +
                "AND t.User_ID = '" + int.Parse(this.Tag.ToString()) + "' " +
                "GROUP BY c.Category_Img, c.Category_Name " +
                "ORDER BY TotalMoneyIn ASC;";
            DataTable dt = dbContext.getDatatable(sql);
            decimal totalMoneyIn = 0;
            if (dt.Rows.Count > 0)
            {
                chartMoneyIn.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chartMoneyIn.Series["Money in"]["DrawingStyle"] = "Default";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chartMoneyIn.Series["Money in"].Points.AddXY(dt.Rows[i]["Category_Name"], dt.Rows[i]["TotalMoneyIn"]);

                    Panel newPanel = new Panel();
                    panelTotalIncome.Controls.Add(newPanel);
                    newPanel.Dock = DockStyle.Top;
                    newPanel.Height = 80;

                    Wide wide = new Wide();
                    wide.CategoryItem_Img = dt.Rows[i]["Category_Img"].ToString();
                    wide.CategoryItem_Name = dt.Rows[i]["Category_Name"].ToString();
                    wide.CategoryItem_Type = "Income";
                    wide.TotalMoney = decimal.Parse(dt.Rows[i]["TotalMoneyIn"].ToString());
                    wide.userSettings = userSettings;
                    wide.month = month;
                    wide.year = year;
                    totalMoneyIn += wide.TotalMoney;
                    newPanel.Controls.Add(wide);
                    wide.Dock = DockStyle.Top;
                    wide.Height = 60;
                }

            }
            sql = "SELECT " +
                "c.Category_Img, " +
                "c.Category_Name, " +
                "SUM(t.Amount) AS TotalMoneyOut " +
                "FROM Categories AS c " +
                "JOIN Transactions AS t ON c.ID = t.Category_ID " +
                "WHERE t.Transaction_Type = 'Expenditure' " +
                "AND YEAR(t.Transaction_Date) = '" + year + "' " +
                "AND MONTH(t.Transaction_Date) = '" + month + "' " +
                "AND t.User_ID = '" + int.Parse(this.Tag.ToString()) + "' " +
                "GROUP BY c.Category_Img, c.Category_Name " +
                "ORDER BY TotalMoneyOut ASC;";
            dt = dbContext.getDatatable(sql);
            decimal totalMoneyOut = 0;
            if (dt.Rows.Count > 0)
            {
                chartMoneyOut.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chartMoneyOut.Series["Money out"]["DrawingStyle"] = "Default";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chartMoneyOut.Series["Money out"].Points.AddXY(dt.Rows[i]["Category_Name"], dt.Rows[i]["TotalMoneyOut"]);

                    Panel newPanel = new Panel();
                    panelTotalExpenditures.Controls.Add(newPanel);
                    newPanel.Dock = DockStyle.Top;
                    newPanel.Height = 80;

                    Wide wide = new Wide();
                    wide.CategoryItem_Img = dt.Rows[i]["Category_Img"].ToString();
                    wide.CategoryItem_Name = dt.Rows[i]["Category_Name"].ToString();
                    wide.CategoryItem_Type = "Expenditure";
                    wide.TotalMoney = decimal.Parse(dt.Rows[i]["TotalMoneyOut"].ToString());
                    wide.userSettings = userSettings;
                    wide.month = month;
                    wide.year = year;
                    totalMoneyOut += wide.TotalMoney;
                    newPanel.Controls.Add(wide);
                    wide.Dock = DockStyle.Top;
                    wide.Height = 60;
                }
            }
            labelTotalIncome.Text = "+" + totalMoneyIn.ToString() + " " + userSettings.CurrencyCode;
            labelTotalExpenditures.Text = "-" + totalMoneyOut.ToString() + " " + userSettings.CurrencyCode;

            
        }
        private void Overview_Load(object sender, EventArgs e)
        {
            dateTimePickerOverview.CustomFormat = "MM/yyyy";
            dateTimePickerOverview.Format = DateTimePickerFormat.Custom;
            dateTimePickerOverview.MaxDate = DateTime.Now.AddMonths(3);
            dateTimePickerOverview.Value = DateTime.Now;
            dateTimePickerOverview.MaxDate = DateTime.Today;
        }

        public void Reload_Data()
        {
            chartMoneyIn.Series["Money in"].Points.Clear();
            chartMoneyOut.Series["Money out"].Points.Clear();
            foreach (Control control in panelTotalIncome.Controls)
            {
                control.Dispose();
            }

            panelTotalIncome.Controls.Clear();

            foreach (Control control in panelTotalExpenditures.Controls)
            {
                control.Dispose();
            }

            panelTotalExpenditures.Controls.Clear();

            Load_Data();
        }
        private void dateTimePickerOverview_ValueChanged(object sender, EventArgs e)
        {
            Reload_Data();
        }
    }
}
