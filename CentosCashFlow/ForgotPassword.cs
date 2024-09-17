using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace CentosCashFlow
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                // Địa chỉ email người nhận
                string toEmail = textBoxPgEmail.Text;


                // Địa chỉ email người gửi
                string fromEmail = "centoscashflow@gmail.com";

                // Mật khẩu email người gửi
                string password = "Centos";

                // Nội dung email
                string subject = "Your Password";
                string body = $"Your Password is:";

                // Tạo đối tượng MailMessage
                MailMessage mail = new MailMessage(fromEmail, toEmail);
                

                // Cấu hình SmtpClient để sử dụng Gmail
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 465,
                    Credentials = new NetworkCredential(fromEmail, password),
                    EnableSsl = true,
                };

                // Gửi email
                smtpClient.Send(mail);

                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
