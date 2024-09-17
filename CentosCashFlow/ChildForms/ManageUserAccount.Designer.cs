namespace CentosCashFlow.ChildForms
{
    partial class ManageUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserAccount));
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch_display = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelUserAccountsLoad = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6_display = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel2);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1124, 601);
            this.panel7.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel2.Controls.Add(this.btnSearch_display, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSearch, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1073, 35);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnSearch_display
            // 
            this.btnSearch_display.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch_display.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch_display.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSearch_display.FlatAppearance.BorderSize = 0;
            this.btnSearch_display.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearch_display.ForeColor = System.Drawing.Color.White;
            this.btnSearch_display.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_display.Image")));
            this.btnSearch_display.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_display.Location = new System.Drawing.Point(920, 0);
            this.btnSearch_display.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSearch_display.Name = "btnSearch_display";
            this.btnSearch_display.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSearch_display.Size = new System.Drawing.Size(153, 35);
            this.btnSearch_display.TabIndex = 4;
            this.btnSearch_display.Text = "Search";
            this.btnSearch_display.UseVisualStyleBackColor = false;
            this.btnSearch_display.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Lavender;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(881, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.textBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(877, 35);
            this.textBoxSearch.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.panelUserAccountsLoad);
            this.panel12.Controls.Add(this.tableLayoutPanel1);
            this.panel12.Location = new System.Drawing.Point(28, 58);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1073, 522);
            this.panel12.TabIndex = 0;
            // 
            // panelUserAccountsLoad
            // 
            this.panelUserAccountsLoad.AutoScroll = true;
            this.panelUserAccountsLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserAccountsLoad.Location = new System.Drawing.Point(0, 49);
            this.panelUserAccountsLoad.Margin = new System.Windows.Forms.Padding(0);
            this.panelUserAccountsLoad.Name = "panelUserAccountsLoad";
            this.panelUserAccountsLoad.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panelUserAccountsLoad.Size = new System.Drawing.Size(1071, 471);
            this.panelUserAccountsLoad.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6_display, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1071, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6_display
            // 
            this.label6_display.AutoSize = true;
            this.label6_display.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6_display.Font = new System.Drawing.Font("Montserrat Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_display.ForeColor = System.Drawing.Color.Black;
            this.label6_display.Location = new System.Drawing.Point(3, 0);
            this.label6_display.Name = "label6_display";
            this.label6_display.Size = new System.Drawing.Size(1065, 49);
            this.label6_display.TabIndex = 0;
            this.label6_display.Text = "user_accounts";
            this.label6_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1124, 611);
            this.Controls.Add(this.panel7);
            this.Name = "ManageUserAccount";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Text = "user_account_management";
            this.Load += new System.EventHandler(this.ManageUserAccount_Load);
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panelUserAccountsLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6_display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearch_display;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}