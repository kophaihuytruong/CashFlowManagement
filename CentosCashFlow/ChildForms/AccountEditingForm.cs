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
    public partial class AccountEditingForm : Form
    {
        public bool isChanged { get; set; }
        public User user { get; set; }
        public AccountEditingForm()
        {
            InitializeComponent();
            isChanged = false;
            user= new User();
        }

        private void AccountEditingForm_Load(object sender, EventArgs e)
        {
            textBoxBalance.Text = user.AvailableMoney.ToString();
            textBoxAccountName.Text = user.Name;
            textBoxEmail.Text = user.Email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            if(textBoxBalance.Text != user.AvailableMoney.ToString()
                || textBoxAccountName.Text != user.Name
                || textBoxEmail.Text != user.Email)
            {
                Models.ConnectUsers connectUsers = new Models.ConnectUsers();
                user.AvailableMoney = decimal.Parse(textBoxBalance.Text);
                user.Name = textBoxAccountName.Text;
                user.Email = textBoxEmail.Text;
                int kt = connectUsers.updateInfoFor(user);

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
        }

        private void textBoxBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != 32 && e.KeyChar != '.')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
    }
}
