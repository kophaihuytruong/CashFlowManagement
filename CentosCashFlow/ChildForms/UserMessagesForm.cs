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
    public partial class UserMessagesForm : Form
    {
        private Models.User user { get; set; }
        public UserMessagesForm()
        {
            InitializeComponent();
            user = new Models.User();
        }

        public void Load_Data()
        {
            Models.ConnectMessage connectMessage = new ConnectMessage();
            List<Models.Message> listMessages = new List<Models.Message>();
            listMessages = connectMessage.getMessagesForUser(user.Id);

            foreach (Models.Message message in listMessages)
            {
                Panel newPanel = new Panel();
                panelMessageLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Padding = new Padding(0, 0, 0, 20);

                MessageItem item = new MessageItem();
                item.message = message;
                Label label = new Label();

                label.Text = message.Timestamp.ToString("dd-MM-yyyy HH:mm");

                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Controls.Add(label);
                label.Dock = DockStyle.Fill;

                newPanel.Controls.Add(tableLayoutPanel);
                newPanel.Controls.Add(item);

                if (message.SenderID == user.Id)
                {
                    label.TextAlign = ContentAlignment.MiddleRight;
                    tableLayoutPanel.Dock = DockStyle.Right;
                    item.Dock = DockStyle.Right;

                    item.BackColor = Color.GhostWhite;
                }
                else
                {
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    tableLayoutPanel.Dock = DockStyle.Left;
                    item.Dock = DockStyle.Left;

                    item.BackColor = SystemColors.GradientInactiveCaption;
                }
            }

            panelMessageLoad.VerticalScroll.Value = panelMessageLoad.VerticalScroll.Maximum;
            panelMessageLoad.PerformLayout();
        }

        public void Reload_Data()
        {
            foreach (Control control in panelMessageLoad.Controls)
            {
                control.Dispose();
            }

            panelMessageLoad.Controls.Clear();

            Load_Data();
        }
        private void UserMessagesForm_Load(object sender, EventArgs e)
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            user = connectUsers.getUserDataByID(int.Parse(this.Tag.ToString()));

            Load_Data();
        }

        private void btnSend_display_Click(object sender, EventArgs e)
        {
            if(textBoxMessage.Text != "")
            {
                Models.Message message = new Models.Message();
                message.SenderID = user.Id;
                message.ReceiverID = 2;
                message.Content = textBoxMessage.Text;
                message.Timestamp = DateTime.Now;
                Models.ConnectMessage connectMessages = new Models.ConnectMessage();
                int kt = connectMessages.addNewMessage(message);
                if(kt != 0)
                {
                    Reload_Data();
                    textBoxMessage.Text = "";
                }
            }
        }

        private void textBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSend_display_Click(sender, e);
            }
        }
    }
}
