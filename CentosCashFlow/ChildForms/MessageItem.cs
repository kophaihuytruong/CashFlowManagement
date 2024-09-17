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
    public partial class MessageItem : UserControl
    {
        public Models.Message message { get; set; }
        public MessageItem()
        {
            InitializeComponent();
            message = new Models.Message();
        }

        private void MessageItem_Load(object sender, EventArgs e)
        {
            labelMessage.Text = message.Content;
        }
    }
}
