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
    public partial class UserAccountEditingForm : Form
    {
        public Models.UserAccountInfo user { get; set; }
        public bool isChanged { get; set; }
        public UserAccountEditingForm()
        {
            InitializeComponent();
            user = new Models.UserAccountInfo();
            isChanged= false;
        }

        private void UserAccountEditingForm_Load(object sender, EventArgs e)
        {
            textBoxName.Text = user.UserName;
            textBoxEmail.Text = user.Email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != user.UserName || textBoxEmail.Text != user.Email)
            {
                user.UserName = textBoxName.Text;
                user.Email = textBoxEmail.Text;
                Models.ConnectUsers connectUsers = new Models.ConnectUsers();
                int kt = connectUsers.updateUserAccountInfo(user);
                if (kt != 0)
                {
                    if (MessageBox.Show("Completely updating!", "", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        isChanged = true;
                        this.Close();
                    }
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
            if (MessageBox.Show("Are you sure you want to delete this account?", "",
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
                    int kt = connect.deleteAccountByID(user.Id);
                    if (kt != 0)
                    {
                        isChanged = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete this account!", "", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
