using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosCashFlow.ChildForms
{
    public partial class Wide : UserControl
    {
        public string CategoryItem_Name { get; set; }
        public string CategoryItem_Img { get; set; }
        public string CategoryItem_Type { get; set; }
        public decimal TotalMoney { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public Models.Settings userSettings { get; set; }
        public Wide()
        {
            InitializeComponent();
            CategoryItem_Name = "None";
            CategoryItem_Img= "category_df.png";
            CategoryItem_Type = "Income";
            TotalMoney = 0;
            userSettings = new Models.Settings();
        }

        private void Wide_Load(object sender, EventArgs e)
        {
            labelName.Text = CategoryItem_Name;
            if (CategoryItem_Type == "Expenditure")
            {
                labelAmount.ForeColor = Color.LightCoral;
                labelAmount.Text = "-" + TotalMoney.ToString() + " " + userSettings.CurrencyCode;
            }
            else
            {
                labelAmount.ForeColor = Color.Chartreuse;
                labelAmount.Text = "+" + TotalMoney.ToString() + " " + userSettings.CurrencyCode;
            }

            string imagePath = CategoryItem_Img;
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath));
            if (!CategoryItem_Img.Contains("\\"))
            {
                imagePath = Path.Combine(projectPath, @"Resources", CategoryItem_Img);
            }

            if (File.Exists(imagePath))
            {
                pictureBoxCategory.Image = System.Drawing.Image.FromFile(imagePath);
            }
            else
            {
                pictureBoxCategory.Image = CentosCashFlow.Properties.Resources.category_df;
            }
        }

        private void labelAmount_Click(object sender, EventArgs e)
        {
            TransactionListView form = new TransactionListView();
            form.userSettings = userSettings;
            form.CategoryItem_Name = CategoryItem_Name;
            form.month = month;
            form.year = year;

            form.ShowDialog();
            if(form.isChanged)
            {
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }
                // Kiểm tra xem control.Parent có phải là Form
                if (control.Parent is Form && control.Parent is Overview)
                {
                    Overview f = (Overview)control.Parent;

                    f.Reload_Data();
                }
            }
        }
    }
}
