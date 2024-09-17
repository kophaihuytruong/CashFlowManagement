using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace CentosCashFlow
{
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát", "",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Đóng form
                e.Cancel = true;
                //
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            if (textBox_FullName.Text == "")
            {
                this.errorProvider1.SetError(textBox_FullName, "Fullname is required");
            }
            if (textBox_RgEmail.Text == "")
            {
                this.errorProvider2.SetError(textBox_RgEmail, "Email is required");
            }
            if (textbox_RgPassword.Text == "")
            {
                this.errorProvider2.SetError(textbox_RgPassword, "Password is required");
            }
            if (textBox_ConfirmPassword.Text == "")
            {
                this.errorProvider2.SetError(textBox_ConfirmPassword, "Confirm Password is required");
            }
            else
            {
                string name = textBox_FullName.Text;
                string email = textBox_RgEmail.Text;
                string password = textbox_RgPassword.Text;
                Models.ConnectUsers connect = new Models.ConnectUsers();
                int rs = connect.Register(name, email, password);
                if (rs == 0)
                {
                    MessageBox.Show("Cannot Register!!");
                }
                else if (rs != 0)
                {
                    MessageBox.Show("Register success");
                    Login login = new Login();
                    this.Hide();
                    login.ShowDialog();
                }

            }
        }
        //
        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
