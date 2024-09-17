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
    public partial class TransactionListView : Form
    {
        public string CategoryItem_Name { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public Models.Settings userSettings { get; set; }
        public bool isChanged { get; set; }
        DbContext dbContext = new DbContext();
        public TransactionListView()
        {
            InitializeComponent();
            CategoryItem_Name = "";
            userSettings = new Models.Settings();
            month = 1;
            year = 2023;
            isChanged = false;
        }
        private void Load_Data()
        {
            string sql = "SELECT " +
                "t.ID, " +
                "c.Category_Img, " +
                "c.Category_Name, " +
                "t.Amount, " +
                "t.Transaction_Date, " +
                "t.Transaction_Description, " +
                "t.Transaction_Type " +
                "FROM Categories AS c " +
                "JOIN Transactions AS t ON c.ID = t.Category_ID " +
                "WHERE c.Category_Name = N'" + CategoryItem_Name + "' " +
                "AND YEAR(t.Transaction_Date) = '" + year + "' " +
                "AND MONTH(t.Transaction_Date) = '" + month + "' " +
                "AND t.User_ID = '" + userSettings.UserID + "' " +
                "ORDER BY t.Transaction_Date DESC;";
            DataTable dt = dbContext.getDatatable(sql);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Panel newPanel = new Panel();
                    this.Controls.Add(newPanel);
                    newPanel.Dock = DockStyle.Top;
                    newPanel.Height = 70;

                    TransactionItem item = new TransactionItem();
                    item.TransModel.TransactionID = int.Parse(dt.Rows[i]["ID"].ToString());
                    item.TransModel.UserID = userSettings.UserID;
                    item.TransModel.CategoryName = CategoryItem_Name;
                    item.TransModel.TransactionType = dt.Rows[i]["Transaction_Type"].ToString();
                    item.TransModel.Amount = decimal.Parse(dt.Rows[i]["Amount"].ToString());
                    item.TransModel.TransactionDate = DateTime.Parse(dt.Rows[i]["Transaction_Date"].ToString());
                    item.TransModel.TransactionDescription = dt.Rows[i]["Transaction_Description"].ToString();
                    item.TransModel.TransactionImg = dt.Rows[i]["Category_Img"].ToString();
                    item.userSettings = userSettings;

                    newPanel.Controls.Add(item);
                    item.Dock = DockStyle.Top;
                    item.Height = 60;
                }
            }
        }
        public void Reload_Data()
        {
            foreach (Control control in this.Controls)
            {
                control.Dispose();
            }

            this.Controls.Clear();
            Load_Data();
        }
        private void TransactionListView_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
