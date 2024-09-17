namespace CentosCashFlow.ChildForms
{
    partial class UserMessagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMessagesForm));
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelMessageLoad = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSend_display = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.panelMessageLoad);
            this.panel12.Controls.Add(this.panel2);
            this.panel12.Controls.Add(this.tableLayoutPanel1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(20, 20);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1326, 726);
            this.panel12.TabIndex = 1;
            // 
            // panelMessageLoad
            // 
            this.panelMessageLoad.AutoScroll = true;
            this.panelMessageLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMessageLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessageLoad.Location = new System.Drawing.Point(0, 35);
            this.panelMessageLoad.Margin = new System.Windows.Forms.Padding(0);
            this.panelMessageLoad.Name = "panelMessageLoad";
            this.panelMessageLoad.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panelMessageLoad.Size = new System.Drawing.Size(1324, 647);
            this.panelMessageLoad.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 682);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1324, 42);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.Controls.Add(this.btnSend_display, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxMessage, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1324, 42);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnSend_display
            // 
            this.btnSend_display.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSend_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend_display.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSend_display.FlatAppearance.BorderSize = 0;
            this.btnSend_display.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSend_display.ForeColor = System.Drawing.Color.White;
            this.btnSend_display.Image = ((System.Drawing.Image)(resources.GetObject("btnSend_display.Image")));
            this.btnSend_display.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend_display.Location = new System.Drawing.Point(1188, 0);
            this.btnSend_display.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSend_display.Name = "btnSend_display";
            this.btnSend_display.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSend_display.Size = new System.Drawing.Size(136, 42);
            this.btnSend_display.TabIndex = 6;
            this.btnSend_display.Text = "Send";
            this.btnSend_display.UseVisualStyleBackColor = false;
            this.btnSend_display.Click += new System.EventHandler(this.btnSend_display_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMessage.Location = new System.Drawing.Point(0, 0);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(1180, 42);
            this.textBoxMessage.TabIndex = 0;
            this.textBoxMessage.Enter += new System.EventHandler(this.btnSend_display_Click);
            this.textBoxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMessage_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelUserName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1324, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserName.Font = new System.Drawing.Font("Montserrat Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.Black;
            this.labelUserName.Location = new System.Drawing.Point(3, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(1318, 35);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "admin_accounts";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 766);
            this.Controls.Add(this.panel12);
            this.Name = "UserMessagesForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "UserMessagesForm";
            this.Load += new System.EventHandler(this.UserMessagesForm_Load);
            this.panel12.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panelMessageLoad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSend_display;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelUserName;
    }
}