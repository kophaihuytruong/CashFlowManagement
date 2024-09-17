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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            //
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
        }
        private void Reset_Login()
        {
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            //textBoxEmail.Text = "Huy5512@gmail.com";
            //textBoxPassword.Text = "Huy12445";

            //textBoxEmail.Text = "Thu2123@gmail.com";
            //textBoxPassword.Text = "admin";
            if (textBoxEmail.Text == "")
            {
                this.errorProvider1.SetError(textBoxEmail, "Username is required");
            }
            if (textBoxPassword.Text == "")
            {
                this.errorProvider2.SetError(textBoxPassword, "Password is required");
            }
            else
            {
                string email = textBoxEmail.Text;
                string password = textBoxPassword.Text;
                Models.ConnectUsers connect = new Models.ConnectUsers();
                Models.User user = connect.Login(email, password);
                if (user is null || user.Id == 0)
                {
                    MessageBox.Show("Email or password is incorrect!", "", MessageBoxButtons.OK);
                }
                else
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.user = user;
                    menu.ShowDialog();
                    if (menu.isClosing)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Show();
                        Reset_Login();
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            this.Hide();
            forgotPassword.ShowDialog();
        }
    }
}
