using CentosCashFlow.Models;
using DocumentFormat.OpenXml.Office.CustomUI;
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
    public partial class Messages : Form
    {
        private Models.User user { get; set; }
        public AccountMessageItem currentAMI;
        public int CurrentUserMessage;
        public Messages()
        {
            InitializeComponent();
            user = new Models.User();
            currentAMI = null;
            CurrentUserMessage = 0;
        }
        public void ActivateItem(int id)
        {
            if (id != 0)
            {
                DisableItem();
                if (CurrentUserMessage == id)
                {
                    currentAMI.BackColor = Color.Gainsboro;
                }
                
            }
        }
        public void DisableItem()
        {
            foreach (Control panel in panelUserAccountsLoad.Controls)
            {
                foreach (Control previousItem in panel.Controls)
                {
                    if (previousItem is AccountMessageItem)
                    {
                        AccountMessageItem accountMessageItem = (AccountMessageItem)previousItem;
                        accountMessageItem.BackColor = Color.WhiteSmoke;
                        break;
                    }
                }
            }
        }
        private void Messages_Load(object sender, EventArgs e)
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            user = connectUsers.getUserDataByID(int.Parse(this.Tag.ToString()));
            labelUserName.Tag = "0";

            Load_AccountUserMessage(false);
            Load_PanelMessages();
        }
        public void Load_AccountUserMessage(bool isSearched)
        {
            Models.ConnectMessage connectMessage = new ConnectMessage();
            List<Models.Message> listMessages = new List<Models.Message>();
            listMessages = connectMessage.getAccountMessageForAdmin();
            if (isSearched)
            {
                listMessages = connectMessage.getAccountMessageForAdminByUserName(textBoxSearch.Text);
            }
            
            foreach (Models.Message message in listMessages)
            {
                Panel newPanel = new Panel();
                panelUserAccountsLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                AccountMessageItem item = new AccountMessageItem();
                item.message = message;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }
        public void Reload_AccountUserMessage(bool isSearched)
        {
            foreach (Control control in panelUserAccountsLoad.Controls)
            {
                control.Dispose();
            }

            panelUserAccountsLoad.Controls.Clear();

            Load_AccountUserMessage(isSearched);
        }
        public void Load_PanelMessages()
        {
            if (CurrentUserMessage != 0)
            {
                Models.ConnectUsers connectUsers = new Models.ConnectUsers();
                Models.ConnectMessage connectMessage = new ConnectMessage();
                List<Models.Message> listMessages = new List<Models.Message>();
                listMessages = connectMessage.getMessagesForUser(CurrentUserMessage);
                labelUserName.Text = connectUsers.getUserNameByID(CurrentUserMessage);
                labelUserName.Tag = CurrentUserMessage.ToString();

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
            else
            {
                labelUserName.Text = "To All";
            }
        }
        public void Reload_PanelMessages()
        {
            foreach (Control control in panelMessageLoad.Controls)
            {
                control.Dispose();
            }

            panelMessageLoad.Controls.Clear();

            Load_PanelMessages();
            
        }
        public void Reload_Data()
        {
            Reload_AccountUserMessage(false);
            Reload_PanelMessages();
        }
        private void btnSend_display_Click(object sender, EventArgs e)
        {
            if (textBoxMessage.Text != "")
            {
                Models.Message message = new Models.Message();
                message.SenderID = user.Id;
                message.ReceiverID = int.Parse(labelUserName.Tag.ToString());
                message.Content = textBoxMessage.Text;
                message.Timestamp = DateTime.Now;
                Models.ConnectMessage connectMessages = new Models.ConnectMessage();
                int kt = connectMessages.addNewMessage(message);
                if (kt != 0)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            Reload_Data();
        }

        private void btnSearch_display_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text != "")
            {
                Reload_AccountUserMessage(true);
            }
        }

        private void btnSendToAll_display_Click(object sender, EventArgs e)
        {
            labelUserName.Text = "To All";
            labelUserName.Tag = "0";
            currentAMI = null;
            CurrentUserMessage = 0;
            Reload_PanelMessages();
        }
    }
}
