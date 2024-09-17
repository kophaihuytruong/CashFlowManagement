using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using CentosCashFlow.Models;
using System.Runtime.Remoting.Contexts;

namespace CentosCashFlow.ChildForms
{
    public partial class CategoryItem : UserControl
    {
        public string CategoryItem_ID { get; set; }
        public string CategoryItem_Name { get; set; }
        public string CategoryItem_Img { get; set; }
        public string CategoryItem_Type { get; set; }

        public CategoryItem()
        {
            InitializeComponent();
            CategoryItem_ID = "";
            CategoryItem_Name = "";
            CategoryItem_Img = "";
            CategoryItem_Type = "Income";
        }
        private void btnEditingCategory_Click(object sender, EventArgs e)
        {
            CategoryEditForm form = new CategoryEditForm();
            form.Tag = CategoryItem_ID;
            form.ShowDialog();
            if(form.isChanged == true)
            {
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }
                // Kiểm tra xem control.Parent có phải là Form
                if (control.Parent is Form && control.Parent is Category)
                {
                    Category f = (Category)control.Parent;

                    f.Reload_Data();
                }
            }
        }

        private void CategoryItem_Load(object sender, EventArgs e)
        {
            labelCategoryName.Text = CategoryItem_Name;

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

        private void btnDeleteCategoryItem_Click(object sender, EventArgs e)
        {
            Models.ConnectCategory connect = new Models.ConnectCategory();
            int kt = connect.deleteDataById(CategoryItem_ID);
            if (kt != 0)
            {
                MessageBox.Show("Completely deleting!", "", MessageBoxButtons.OK);
                Panel panel = (Panel)this.Parent;
                Panel ParentPanel = (Panel)panel.Parent;
                panel.Controls.Remove(this);
                this.Dispose();
                ParentPanel.Controls.Remove(panel);
                panel.Dispose();
            }
            else
            {
                MessageBox.Show("Cannot delete!", "", MessageBoxButtons.OK);
            }
        }
    }
}
