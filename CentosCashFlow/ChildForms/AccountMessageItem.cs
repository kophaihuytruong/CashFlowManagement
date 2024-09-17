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
    public partial class AccountMessageItem : UserControl
    {
        public Models.Message message { get; set; }
        public bool isSelected { get; set; }
        public AccountMessageItem()
        {
            InitializeComponent();
            message = new Models.Message();
            isSelected= false;
        }
        private void AccountMessageItem_Load(object sender, EventArgs e)
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            if (connectUsers.isAdmin(message.SenderID))
            {
                labelUserName.Text = connectUsers.getUserNameByID(message.ReceiverID);
                labelMessage.Text = "You: " + message.Content;
                labelMessage.Font = new Font(labelMessage.Font, FontStyle.Regular);
                labelMessage.ForeColor = Color.Gray;
            }
            else
            {
                labelUserName.Text = connectUsers.getUserNameByID(message.SenderID);
                labelMessage.Text = message.Content;
                labelMessage.Font = new Font(labelMessage.Font, FontStyle.Bold);
                labelMessage.ForeColor = Color.Black;
            }

        }

        private void AccountMessageItem_Click(object sender, EventArgs e)
        {
            Control control = (Control)this;
            while (control.Parent != null && !(control.Parent is Form))
            {
                control = control.Parent;
            }
            // Kiểm tra xem control.Parent có phải là Form
            if (control.Parent is Form && control.Parent is Messages)
            {
                Messages f = (Messages)control.Parent;
                Models.ConnectUsers connectUsers = new Models.ConnectUsers();
                f.currentAMI = this;
                if (connectUsers.isAdmin(message.SenderID))
                {
                    f.CurrentUserMessage = message.ReceiverID;
                    f.ActivateItem(message.ReceiverID);
                }
                else
                {
                    f.CurrentUserMessage = message.SenderID;
                    f.ActivateItem(message.SenderID);
                }

                f.Reload_PanelMessages();
            }
        }
    }
}
