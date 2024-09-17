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
    public partial class CategoryAddingForm : Form
    {
        public bool isChanged { get; set; }
        public CategoryAddingForm()
        {
            InitializeComponent();
            isChanged = false;
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog df = new OpenFileDialog() { Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" })
            {
                if (df.ShowDialog() == DialogResult.OK)
                {
                    //pictureBox1.BackgroundImage = Image.FromFile(df.FileName);
                    textBoxCategoryImgPath.Text = df.FileName;
                }
            }
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            if(textBoxCategoryID.Text != "" && textBoxCategoryName.Text != "")
            {
                Models.Category category = new Models.Category();
                category.CategoryID = textBoxCategoryID.Text;
                category.CategoryName = textBoxCategoryName.Text;
                category.CategoryType = comboBoxCategoryType.SelectedItem.ToString();
                category.CategoryImg = textBoxCategoryImgPath.Text;

                Models.ConnectCategory connect = new Models.ConnectCategory();
                
                int kt = connect.addNewItem(category);

                if (kt != 0)
                {
                    if (MessageBox.Show("Completely adding!", "", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        isChanged = true;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cannot add!", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please enter complete information!", "", MessageBoxButtons.OK);
            }
        }

        private void CategoryAddingForm_Load(object sender, EventArgs e)
        {
            comboBoxCategoryType.Items.Clear();
            comboBoxCategoryType.Items.Add("Income");
            comboBoxCategoryType.Items.Add("Expenditure");
            comboBoxCategoryType.SelectedItem = this.Tag.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
