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
    public partial class ManageLanguages : Form
    {
        public Models.Settings userSettings { get; set; }
        public Languages.LanguageDictionary dictionary { get; set; }
        public ManageLanguages()
        {
            InitializeComponent();
            userSettings = new Models.Settings();
            dictionary = new Languages.LanguageDictionary();
        }

        private void Load_Data(bool isSearched)
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            userSettings = connectUsers.getUserSettingsByID(int.Parse(this.Tag.ToString()));
            dictionary = new Languages.LanguageDictionary(userSettings.LanguageCode);
            dictionary.SetLanguages((Control)this);

            Models.ConnectLanguage connectLanguage = new Models.ConnectLanguage();
            List<Models.Language> list = new List<Models.Language>();
            if (isSearched)
            {
                list = connectLanguage.getDataByNameOrID(textBoxSearch.Text);
            }
            else
            {
                list = connectLanguage.getData();
            }
            
            foreach (Models.Language language in list)
            {
                Panel newPanel = new Panel();
                panelLanguagesLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                LanguageItem item = new LanguageItem();
                item.LanguageModel = language;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }

        public void Reload_Data(bool isSearched)
        {
            foreach (Control control in panelLanguagesLoad.Controls)
            {
                control.Dispose();
            }

            panelLanguagesLoad.Controls.Clear();

            Load_Data(isSearched);
        }
        private void ManageLanguages_Load(object sender, EventArgs e)
        {
            Load_Data(false);
        }

        private void btnAddNewLanguage_Click(object sender, EventArgs e)
        {
            LanguageAddingForm form = new LanguageAddingForm();
            form.ShowDialog();
            if(form.isChanged)
            {
                Reload_Data(false);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                Reload_Data(true);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            Reload_Data(false);
        }
    }
}
