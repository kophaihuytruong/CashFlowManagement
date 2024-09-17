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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CentosCashFlow.ChildForms
{
    public partial class LanguageAddingForm : Form
    {
        public bool isChanged { get; set; }
        public LanguageAddingForm()
        {
            InitializeComponent();
            isChanged = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewLanguage_Click(object sender, EventArgs e)
        {
            if(textBoxLanguageCode.Text.Length != 2)
            {
                MessageBox.Show("Please enter Language Code with 2 characters only!", "", MessageBoxButtons.OK);
            }
            else
            {
                if(textBoxLanguageName.Text != "")
                {
                    Models.ConnectLanguage connectLanguage = new Models.ConnectLanguage();
                    Models.Language language = new Models.Language();
                    language.Language_Code = textBoxLanguageCode.Text;
                    language.Language_Name = textBoxLanguageName.Text;
                    int kt = connectLanguage.addNewItem(language);
                    if (kt != 0)
                    {
                        //MessageBox.Show("Completely adding!", "", MessageBoxButtons.OK);
                        isChanged = true;
                        NewLaguages newLaguages = new NewLaguages();
                        newLaguages.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cannot add!", "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void textBoxLanguageCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxLanguageCode.Text.Length >= 2)
            {
                e.Handled = true;
            }
        }
    }
}
