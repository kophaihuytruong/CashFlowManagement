namespace CentosCashFlow.ChildForms
{
    partial class Settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSave_display = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCurrencyUnit_display = new System.Windows.Forms.Label();
            this.labelTimeFormat_display = new System.Windows.Forms.Label();
            this.btnExport_display = new System.Windows.Forms.Button();
            this.labelLanguages_display = new System.Windows.Forms.Label();
            this.cbbLanguages = new System.Windows.Forms.ComboBox();
            this.cbbTimeFormat = new System.Windows.Forms.ComboBox();
            this.cbbCurrencyUnit = new System.Windows.Forms.ComboBox();
            this.cbbExport = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 390);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(702, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 390);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(60, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 390);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 128);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 38);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSave_display);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(469, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 38);
            this.panel5.TabIndex = 0;
            // 
            // btnSave_display
            // 
            this.btnSave_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave_display.Enabled = false;
            this.btnSave_display.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave_display.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSave_display.Location = new System.Drawing.Point(0, 0);
            this.btnSave_display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave_display.Name = "btnSave_display";
            this.btnSave_display.Size = new System.Drawing.Size(173, 38);
            this.btnSave_display.TabIndex = 0;
            this.btnSave_display.Text = "save";
            this.btnSave_display.UseVisualStyleBackColor = true;
            this.btnSave_display.Click += new System.EventHandler(this.btnSave_display_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelCurrencyUnit_display, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTimeFormat_display, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExport_display, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelLanguages_display, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbLanguages, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbTimeFormat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbbCurrencyUnit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbbExport, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 128);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelCurrencyUnit_display
            // 
            this.labelCurrencyUnit_display.AutoSize = true;
            this.labelCurrencyUnit_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrencyUnit_display.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelCurrencyUnit_display.ForeColor = System.Drawing.Color.Black;
            this.labelCurrencyUnit_display.Location = new System.Drawing.Point(3, 64);
            this.labelCurrencyUnit_display.Name = "labelCurrencyUnit_display";
            this.labelCurrencyUnit_display.Size = new System.Drawing.Size(315, 32);
            this.labelCurrencyUnit_display.TabIndex = 4;
            this.labelCurrencyUnit_display.Text = "currency_unit";
            this.labelCurrencyUnit_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTimeFormat_display
            // 
            this.labelTimeFormat_display.AutoSize = true;
            this.labelTimeFormat_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeFormat_display.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTimeFormat_display.ForeColor = System.Drawing.Color.Black;
            this.labelTimeFormat_display.Location = new System.Drawing.Point(3, 32);
            this.labelTimeFormat_display.Name = "labelTimeFormat_display";
            this.labelTimeFormat_display.Size = new System.Drawing.Size(315, 32);
            this.labelTimeFormat_display.TabIndex = 2;
            this.labelTimeFormat_display.Text = "time_format";
            this.labelTimeFormat_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExport_display
            // 
            this.btnExport_display.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExport_display.ForeColor = System.Drawing.Color.Black;
            this.btnExport_display.Location = new System.Drawing.Point(321, 96);
            this.btnExport_display.Margin = new System.Windows.Forms.Padding(0);
            this.btnExport_display.Name = "btnExport_display";
            this.btnExport_display.Size = new System.Drawing.Size(145, 30);
            this.btnExport_display.TabIndex = 13;
            this.btnExport_display.Text = "export";
            this.btnExport_display.UseVisualStyleBackColor = true;
            this.btnExport_display.Click += new System.EventHandler(this.btnExport_display_Click);
            // 
            // labelLanguages_display
            // 
            this.labelLanguages_display.AutoSize = true;
            this.labelLanguages_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLanguages_display.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelLanguages_display.ForeColor = System.Drawing.Color.Black;
            this.labelLanguages_display.Location = new System.Drawing.Point(3, 0);
            this.labelLanguages_display.Name = "labelLanguages_display";
            this.labelLanguages_display.Size = new System.Drawing.Size(315, 32);
            this.labelLanguages_display.TabIndex = 0;
            this.labelLanguages_display.Text = "languages";
            this.labelLanguages_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbLanguages
            // 
            this.cbbLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLanguages.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cbbLanguages.ForeColor = System.Drawing.Color.Black;
            this.cbbLanguages.FormattingEnabled = true;
            this.cbbLanguages.ItemHeight = 30;
            this.cbbLanguages.Location = new System.Drawing.Point(324, 2);
            this.cbbLanguages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLanguages.Name = "cbbLanguages";
            this.cbbLanguages.Size = new System.Drawing.Size(315, 38);
            this.cbbLanguages.Sorted = true;
            this.cbbLanguages.TabIndex = 9;
            this.cbbLanguages.SelectedValueChanged += new System.EventHandler(this.cbbOverviewDisplayMode_SelectedValueChanged);
            // 
            // cbbTimeFormat
            // 
            this.cbbTimeFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTimeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimeFormat.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cbbTimeFormat.ForeColor = System.Drawing.Color.Black;
            this.cbbTimeFormat.FormattingEnabled = true;
            this.cbbTimeFormat.Location = new System.Drawing.Point(324, 34);
            this.cbbTimeFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTimeFormat.Name = "cbbTimeFormat";
            this.cbbTimeFormat.Size = new System.Drawing.Size(315, 38);
            this.cbbTimeFormat.Sorted = true;
            this.cbbTimeFormat.TabIndex = 10;
            this.cbbTimeFormat.SelectedValueChanged += new System.EventHandler(this.cbbOverviewDisplayMode_SelectedValueChanged);
            // 
            // cbbCurrencyUnit
            // 
            this.cbbCurrencyUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbCurrencyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCurrencyUnit.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cbbCurrencyUnit.ForeColor = System.Drawing.Color.Black;
            this.cbbCurrencyUnit.FormattingEnabled = true;
            this.cbbCurrencyUnit.Location = new System.Drawing.Point(324, 66);
            this.cbbCurrencyUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCurrencyUnit.Name = "cbbCurrencyUnit";
            this.cbbCurrencyUnit.Size = new System.Drawing.Size(315, 38);
            this.cbbCurrencyUnit.Sorted = true;
            this.cbbCurrencyUnit.TabIndex = 11;
            this.cbbCurrencyUnit.SelectedValueChanged += new System.EventHandler(this.cbbOverviewDisplayMode_SelectedValueChanged);
            // 
            // cbbExport
            // 
            this.cbbExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbExport.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cbbExport.ForeColor = System.Drawing.Color.Black;
            this.cbbExport.FormattingEnabled = true;
            this.cbbExport.ItemHeight = 30;
            this.cbbExport.Location = new System.Drawing.Point(3, 98);
            this.cbbExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbExport.Name = "cbbExport";
            this.cbbExport.Size = new System.Drawing.Size(315, 38);
            this.cbbExport.Sorted = true;
            this.cbbExport.TabIndex = 14;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 390);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCurrencyUnit_display;
        private System.Windows.Forms.Label labelTimeFormat_display;
        private System.Windows.Forms.Label labelLanguages_display;
        private System.Windows.Forms.ComboBox cbbLanguages;
        private System.Windows.Forms.ComboBox cbbTimeFormat;
        private System.Windows.Forms.ComboBox cbbCurrencyUnit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSave_display;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbbExport;
        private System.Windows.Forms.Button btnExport_display;
    }
}