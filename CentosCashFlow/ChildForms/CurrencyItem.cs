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
    public partial class CurrencyItem : UserControl
    {
        public Models.Currency currency { get; set; }
        public CurrencyItem()
        {
            InitializeComponent();
            currency= new Models.Currency();
        }

        private void CurrencyItem_Load(object sender, EventArgs e)
        {
            labelCurrencyName.Text = currency.CurrencyName;
            labelCurrencyCode.Text = currency.CurrencyCode;
            labelExchangeRate.Text = currency.ExchangeRateUSD.ToString();
        }

        private void btnEditing_Click(object sender, EventArgs e)
        {
            CurrencyEditingForm form = new CurrencyEditingForm();
            form.currency = currency;
            form.ShowDialog();
            if (form.isChanged)
            {
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }
                // Kiểm tra xem control.Parent có phải là Form
                if (control.Parent is Form && control.Parent is ManageCurrencies)
                {
                    ManageCurrencies f = (ManageCurrencies)control.Parent;

                    f.Reload_Data(false);
                }
            }
        }

        private void btnDeleting_Click(object sender, EventArgs e)
        {
            Models.ConnectCurrency connect = new Models.ConnectCurrency();
            int kt = connect.deleteDataById(currency.CurrencyCode);
            if (kt != 0)
            {
                MessageBox.Show("Completely deleting!", "", MessageBoxButtons.OK);
                Panel panel = (Panel)this.Parent;
                Panel ParentPanel = (Panel)panel.Parent;
                panel.Controls.Remove(this);
                this.Dispose();
                ParentPanel.Controls.Remove(panel);
                panel.Dispose();
            }
            else
            {
                MessageBox.Show("Cannot delete!", "", MessageBoxButtons.OK);
            }
        }
    }
}
