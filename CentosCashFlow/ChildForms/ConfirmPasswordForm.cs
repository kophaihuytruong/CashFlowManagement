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
    public partial class ConfirmPasswordForm : Form
    {
        public string Password { get; set; }
        public bool isValid { get; set; }
        public ConfirmPasswordForm()
        {
            InitializeComponent();
            Password = "";
            isValid = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == Password)
            {
                isValid= true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorect password!", "", MessageBoxButtons.OK);
            }
        }
    }
}
