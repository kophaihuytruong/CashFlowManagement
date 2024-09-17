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
    public partial class Paybook : Form
    {
        public Paybook()
        {
            InitializeComponent();
        }

        private void Paybook_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                Panel newPanel = new Panel();
                panelPaidDebts.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                DebtItem item = new DebtItem();

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
            for (int i = 0; i < 3; i++)
            {
                Panel newPanel = new Panel();
                panelUnpaidDebts.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                DebtItem item = new DebtItem();

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
            for (int i = 0; i < 3; i++)
            {
                Panel newPanel = new Panel();
                panelRepaidLoans.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                LoanItem item = new LoanItem();

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
            for (int i = 0; i < 3; i++)
            {
                Panel newPanel = new Panel();
                panelOutstandingLoans.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                LoanItem item = new LoanItem();

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }

        private void btnAddingFriendAccount_Click(object sender, EventArgs e)
        {
            FriendAccountAddingForm form = new FriendAccountAddingForm();
            form.ShowDialog();
        }
    }
}
