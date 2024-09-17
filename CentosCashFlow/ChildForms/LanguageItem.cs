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
    public partial class LanguageItem : UserControl
    {
        public Models.Language LanguageModel { get; set; }
        public LanguageItem()
        {
            InitializeComponent();
            LanguageModel = new Models.Language();
        }

        private void LanguageItem_Load(object sender, EventArgs e)
        {
            labelLanguageName.Text = LanguageModel.Language_Name;
            labelLanguageCode.Text = LanguageModel.Language_Code;
        }

        private void btnEditing_Click(object sender, EventArgs e)
        {
            LanguageEditingForm form = new LanguageEditingForm();
            form.LanguageModel = LanguageModel;
            form.ShowDialog();
            if (form.isChanged)
            {
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }
                // Kiểm tra xem control.Parent có phải là Form
                if (control.Parent is Form && control.Parent is ManageLanguages)
                {
                    ManageLanguages f = (ManageLanguages)control.Parent;

                    f.Reload_Data(false);
                }
            }
        }

        private void btnDeleting_Click(object sender, EventArgs e)
        {
            Models.ConnectLanguage connect = new Models.ConnectLanguage();
            int kt = connect.deleteDataById(LanguageModel.Language_Code);
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
