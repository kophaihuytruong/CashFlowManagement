using CentosCashFlow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosCashFlow.ChildForms
{
    public partial class LanguageEditingForm : Form
    {
        public Models.Language LanguageModel { get; set; }
        public bool isChanged { get; set; }
        public LanguageEditingForm()
        {
            InitializeComponent();
            LanguageModel = new Models.Language();
            isChanged= false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEditing_Click(object sender, EventArgs e)
        {
            if (textBoxLanguageName.Text != LanguageModel.Language_Name)
            {
                Models.ConnectLanguage connectLanguage = new Models.ConnectLanguage();
                LanguageModel.Language_Name = textBoxLanguageName.Text;
                int kt = connectLanguage.updateDataForItem(LanguageModel);
                if (kt != 0)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Models.ConnectLanguage connectLanguage = new Models.ConnectLanguage();
            int kt = connectLanguage.deleteDataById(LanguageModel.Language_Code);

            if (kt != 0)
            {
                if (MessageBox.Show("Completely deleting!", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    isChanged = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Cannot delete!", "", MessageBoxButtons.OK);
            }
        }

        private void LanguageEditingForm_Load(object sender, EventArgs e)
        {
            textBoxLanguageCode.Text = LanguageModel.Language_Code;
            textBoxLanguageName.Text = LanguageModel.Language_Name;
        }
    }
}
