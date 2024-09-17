using System;
using System.Collections;
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
    public partial class Account : Form
    {
        Models.User user { get; set; }
        public Languages.LanguageDictionary dictionary { get; set; }
        public Account()
        {
            InitializeComponent();
            user= new Models.User();
            dictionary = new Languages.LanguageDictionary();
        }

        private void linkLabelChangingPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangingPasswordForm form = new ChangingPasswordForm();
            form.ShowDialog();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "",
                  MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConfirmPasswordForm form = new ConfirmPasswordForm();
                form.Password = user.Password;
                form.ShowDialog();
                if (form.isValid)
                {
                    Models.ConnectUsers connect = new Models.ConnectUsers();
                    int kt = connect.deleteAccountByID(user.Id);
                    if(kt != 0)
                    {
                        Control control = (Control)this;
                        while (control.Parent != null && !(control.Parent is Form))
                        {
                            control = control.Parent;
                        }
                        // Kiểm tra xem control.Parent có phải là Form
                        if (control.Parent is Form && control.Parent is Menu)
                        {
                            Menu f = (Menu)control.Parent;
                            f.isClosing = false;
                            f.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete this account!", "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            ChildForms.AccountEditingForm form = new ChildForms.AccountEditingForm();
            form.Tag = this.Tag;
            form.user = this.user;
            form.ShowDialog();
            if (form.isChanged)
            {
                Load_Data();
            }
        }
        private void Load_Data()
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            user = connectUsers.getUserDataByID(int.Parse(this.Tag.ToString()));
            dictionary = new Languages.LanguageDictionary(user.UserSettings.LanguageCode);
            dictionary.SetLanguages((Control)this);
            labelBalance.Text = user.AvailableMoney.ToString();
            labelAccountName.Text = user.Name;
            labelAccountEmail.Text = user.Email;
        }
        private void Account_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnLogOutAccount_display_Click(object sender, EventArgs e)
        {
            Control control = (Control)this;
            while (control.Parent != null && !(control.Parent is Form))
            {
                control = control.Parent;
            }
            // Kiểm tra xem control.Parent có phải là Form
            if (control.Parent is Form && control.Parent is Menu)
            {
                Menu f = (Menu)control.Parent;
                f.isClosing = false;
                f.Close();
            }

        }
    }
}
