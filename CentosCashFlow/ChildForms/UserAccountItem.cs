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
    public partial class UserAccountItem : UserControl
    {
        public Models.UserAccountInfo user { get; set; }
        public UserAccountItem()
        {
            InitializeComponent();
            user= new Models.UserAccountInfo();
        }

        private void btnEditingUserAccount_Click(object sender, EventArgs e)
        {
            UserAccountEditingForm form = new UserAccountEditingForm();
            form.user = user;
            form.Tag = this.Tag;
            form.ShowDialog();
            if (form.isChanged)
            {
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }
                // Kiểm tra xem control.Parent có phải là Form
                if (control.Parent is Form)
                {
                    if (control.Parent is ManageUserAccount)
                    {
                        ManageUserAccount f = (ManageUserAccount)control.Parent;

                        f.Reload_Data(false);
                    }
                    if (control.Parent is ManageAdminAccounts)
                    {
                        ManageAdminAccounts f = (ManageAdminAccounts)control.Parent;

                        f.Reload_Data(false);
                    }
                }
            }
        }

        private void UserAccountItem_Load(object sender, EventArgs e)
        {
            labelUserName.Text = user.UserName;
            labelUserEmail.Text = user.Email;
            if(user.Status == "Disable")
            {
                btnDisableUserAccount.Text = "Active";
            }
            if(user.Status == "Active")
            {
                btnDisableUserAccount.Text = "Disable";
            }
        }

        private void btnDisableUserAccount_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to change this account?", "",
                  MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Models.ConnectUsers connectUsers = new Models.ConnectUsers();
                string password = connectUsers.getUserPasswordByID(int.Parse(this.Tag.ToString()));
                ConfirmPasswordForm form = new ConfirmPasswordForm();
                form.Password = password;
                form.ShowDialog();
                if (form.isValid)
                {
                    Models.ConnectUsers connect = new Models.ConnectUsers();
                    if(user.Status == "Active")
                    {
                        int kt = connect.disableAccountByID(user.Id);
                        if (kt != 0)
                        {
                            Control control = (Control)this;
                            while (control.Parent != null && !(control.Parent is Form))
                            {
                                control = control.Parent;
                            }
                            // Kiểm tra xem control.Parent có phải là Form
                            if (control.Parent is ManageUserAccount)
                            {
                                ManageUserAccount f = (ManageUserAccount)control.Parent;

                                f.Reload_Data(false);

                            }
                            if (control.Parent is ManageAdminAccounts)
                            {
                                ManageAdminAccounts f = (ManageAdminAccounts)control.Parent;

                                f.Reload_Data(false);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot disable this account!", "", MessageBoxButtons.OK);
                        }
                    }
                    if (user.Status == "Disable")
                    {
                        int kt = connect.UnlockAccountByID(user.Id);
                        if (kt != 0)
                        {
                            Control control = (Control)this;
                            while (control.Parent != null && !(control.Parent is Form))
                            {
                                control = control.Parent;
                            }
                            // Kiểm tra xem control.Parent có phải là Form
                            if (control.Parent is ManageUserAccount)
                            {
                                ManageUserAccount f = (ManageUserAccount)control.Parent;

                                f.Reload_Data(false);

                            }
                            if (control.Parent is ManageAdminAccounts)
                            {
                                ManageAdminAccounts f = (ManageAdminAccounts)control.Parent;

                                f.Reload_Data(false);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot disable this account!", "", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }
    }
}
