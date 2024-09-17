using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosCashFlow.ChildForms
{
    public partial class TransactionItem : UserControl
    {
        public Models.Transaction TransModel { get; set; }
        public Models.Settings userSettings { get; set; }
        public TransactionItem()
        {
            InitializeComponent();
            TransModel = new Models.Transaction();
            userSettings = new Models.Settings();
        }

        private void btnEditingTransaction_Click(object sender, EventArgs e)
        {
            TransactionEditingForm form = new TransactionEditingForm();
            form.Tag = TransModel.TransactionID;
            form.TransModel = TransModel;
            form.userSettings = userSettings;
            form.ShowDialog();
            if (form.isChanged == true)
            {
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }
                // Kiểm tra xem control.Parent có phải là Form
                if (control.Parent is Form)
                {
                    if(control.Parent is TransactionForm)
                    {
                        TransactionForm f = (TransactionForm)control.Parent;

                        f.Reload_Data();
                    }
                    if(control.Parent is Home)
                    {
                        Home f = (Home)control.Parent;

                        f.Reload_Data();
                    }
                    if (control.Parent is TransactionListView)
                    {
                        TransactionListView f = (TransactionListView)control.Parent;
                        f.isChanged = true;
                        f.Reload_Data();
                    }
                }
            }
        }

        private void TransactionItem_Load(object sender, EventArgs e)
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            userSettings = connectUsers.getUserSettingsByID(TransModel.UserID);


            labelTransactionTitle.Text = TransModel.CategoryName;
            labelDateTime.Text = TransModel.TransactionDate.ToString("d");
            if (TransModel.TransactionType.Contains("Expenditure"))
            {
                labelAmount.ForeColor = Color.LightCoral;
                labelAmount.Text = "-" + TransModel.Amount.ToString() + " " + userSettings.CurrencyCode;
            }
            else
            {
                labelAmount.ForeColor = Color.Chartreuse;
                labelAmount.Text = "+" + TransModel.Amount.ToString() + " " + userSettings.CurrencyCode;
            }

            string imagePath = TransModel.TransactionImg;

            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath));
            if (!imagePath.Contains("\\"))
            {
                imagePath = Path.Combine(projectPath, @"Resources", imagePath);
            }

            if (File.Exists(imagePath))
            {
                pictureBoxTransaction.Image = System.Drawing.Image.FromFile(imagePath);
            }
            else
            {
                pictureBoxTransaction.Image = CentosCashFlow.Properties.Resources.category_df;
            }
        }

        private void btnDeletingTransaction_Click(object sender, EventArgs e)
        {
            Models.ConnectTransaction connect = new Models.ConnectTransaction();
            int kt = connect.deleteDataById(TransModel.TransactionID);
            if (kt != 0)
            {
                MessageBox.Show("Completely deleting!", "", MessageBoxButtons.OK);
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }
                // Kiểm tra xem control.Parent có phải là Form
                if (control.Parent is Form)
                {
                    if (control.Parent is Home)
                    {
                        Home f = (Home)control.Parent;

                        f.Reload_Data();
                    }
                    if (control.Parent is TransactionForm)
                    {
                        TransactionForm f = (TransactionForm)control.Parent;

                        f.Reload_Data();
                    }
                    if (control.Parent is TransactionListView)
                    {
                        TransactionListView f = (TransactionListView)control.Parent;
                        f.isChanged = true;
                        f.Reload_Data();
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot delete!", "", MessageBoxButtons.OK);
            }
        }
    }
}
