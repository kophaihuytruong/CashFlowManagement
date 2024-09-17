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
    public partial class Category : Form
    {
        public bool isChanged { get; set; }
        public Models.Settings userSettings { get; set; }
        public Languages.LanguageDictionary dictionary { get; set; }
        public Category()
        {
            InitializeComponent();
            isChanged= false;
            userSettings= new Models.Settings();
            dictionary = new Languages.LanguageDictionary();
        }

        private void btnIncomeAdding_Click(object sender, EventArgs e)
        {
            CategoryAddingForm form= new CategoryAddingForm();
            form.Tag = "Income";
            form.ShowDialog();
            if (form.isChanged)
            {
                Reload_Data();
            }
        }

        private void btnExpendituresAdding_Click(object sender, EventArgs e)
        {
            CategoryAddingForm form = new CategoryAddingForm();
            form.Tag = "Expenditure";
            form.ShowDialog();
            if (form.isChanged)
            {
                Reload_Data();
            }
        }

        private void Load_Data()
        {
            dictionary = new Languages.LanguageDictionary(userSettings.LanguageCode);
            dictionary.SetLanguages((Control)this);
            Models.ConnectCategory connect = new Models.ConnectCategory();
            List<Models.Category> incomeList = connect.getIncomeTypeData();
            List<Models.Category> expenditureList = connect.getExpenditureTypeData();

            foreach (Models.Category category in incomeList)
            {
                Panel newPanel = new Panel();
                panelIncomeCategoryItem.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 70;

                CategoryItem item = new CategoryItem();
                item.CategoryItem_ID = category.CategoryID;
                item.CategoryItem_Name = category.CategoryName;
                item.CategoryItem_Img = category.CategoryImg;
                item.CategoryItem_Type = category.CategoryType;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 50;
            }

            foreach (Models.Category category in expenditureList)
            {
                Panel newPanel = new Panel();
                panelExpendituresCategoryItem.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 70;

                CategoryItem item = new CategoryItem();
                item.CategoryItem_ID = category.CategoryID;
                item.CategoryItem_Name = category.CategoryName;
                item.CategoryItem_Img = category.CategoryImg;
                item.CategoryItem_Type = category.CategoryType;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 50;
            }
        }
        public void Reload_Data()
        {
            foreach (Control control in panelIncomeCategoryItem.Controls)
            {
                control.Dispose();
            }

            panelIncomeCategoryItem.Controls.Clear();

            foreach (Control control in panelExpendituresCategoryItem.Controls)
            {
                control.Dispose();
            }

            panelExpendituresCategoryItem.Controls.Clear();

            Load_Data();
        }
        private void Category_Load(object sender, EventArgs e)
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            userSettings = connectUsers.getUserSettingsByID(int.Parse(this.Tag.ToString()));
            Load_Data();   
        }
    }
}
