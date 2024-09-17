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
    public partial class NewAdminAccountAddingForm : Form
    {
        public bool isChanged { get; set; }
        public NewAdminAccountAddingForm()
        {
            InitializeComponent();
            isChanged = false;
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            Models.ConnectUsers account = new Models.ConnectUsers();
            if (textBoxAccountName.Text != ""
                && textBoxEmail.Text != ""
                && textBoxPassword.Text != "")
            {
                if(textBoxPassword.Text == textBoxConfirmPassword.Text)
                {
                    string sql = "EXEC InsertUser " +
                        "@name = N'" + textBoxAccountName.Text + "', " +
                        "@email = '" + textBoxEmail.Text + "', " +
                        "@password = N'" + textBoxPassword.Text + "', " +
                        "@role = N'Admin' ";
                    DbContext dbContext = new DbContext();
                    int kt = dbContext.ExcuteNonQuery(sql);

                    if (kt != 0)
                    {
                        MessageBox.Show("Completely adding!", "", MessageBoxButtons.OK);
                        isChanged = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cannot add!", "", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Please type correct confirm password!", "", MessageBoxButtons.OK);
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
    }
}
