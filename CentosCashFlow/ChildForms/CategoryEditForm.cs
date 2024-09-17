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
    public partial class CategoryEditForm : Form
    {
        Models.ConnectCategory connect = new Models.ConnectCategory();
        Models.Category category;

        public bool isChanged { get; set; }
        public CategoryEditForm()
        {
            InitializeComponent();
            isChanged= false;
        }

        private void CategoryEditForm_Load(object sender, EventArgs e)
        {
            category = connect.getDataByID(this.Tag.ToString());

            comboBoxTransactionType.Items.Clear();
            comboBoxTransactionType.Items.Add("Income");
            comboBoxTransactionType.Items.Add("Expenditure");
            
            if (category.CategoryType.Contains("Income"))
            {
                comboBoxTransactionType.SelectedItem = "Income";
            }
            else
            {
                comboBoxTransactionType.SelectedItem = "Expenditure";
            }
            
            
            textBoxCategoryID.Text = category.CategoryID;
            textBoxCategoryName.Text = category.CategoryName;
            textBoxCategoryImagePath.Text = category.CategoryImg;
        }

        private void btnSaveCategoryEditing_Click(object sender, EventArgs e)
        {
            if (category.CategoryName != textBoxCategoryName.Text
                || !category.CategoryType.Contains(comboBoxTransactionType.SelectedItem.ToString())
                || category.CategoryImg != textBoxCategoryImagePath.Text)
            {
                category.CategoryName= textBoxCategoryName.Text;
                category.CategoryType = comboBoxTransactionType.SelectedItem.ToString();
                category.CategoryImg = textBoxCategoryImagePath.Text;

                int kt = connect.updateDataForItem(category);

                if(kt != 0)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int kt = connect.deleteDataById(category.CategoryID);

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

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog df = new OpenFileDialog() { Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" })
            {
                if (df.ShowDialog() == DialogResult.OK)
                {
                    //pictureBox1.BackgroundImage = Image.FromFile(df.FileName);
                    textBoxCategoryImagePath.Text = df.FileName;
                }
            }
        }
    }
}
