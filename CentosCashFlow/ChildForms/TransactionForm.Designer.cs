namespace CentosCashFlow.ChildForms
{
    partial class TransactionForm
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelCurrentTransactions = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9_display = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label1_display = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.label2_display = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3_display = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePickerCategory = new System.Windows.Forms.DateTimePicker();
            this.label4_display = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label5_display = new System.Windows.Forms.Label();
            this.btnAddNewTransaction_display = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.label7_display = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.panelCurrentTransactions);
            this.panel9.Controls.Add(this.tableLayoutPanel5);
            this.panel9.Location = new System.Drawing.Point(11, 605);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.panel9.Size = new System.Drawing.Size(1017, 546);
            this.panel9.TabIndex = 2;
            // 
            // panelCurrentTransactions
            // 
            this.panelCurrentTransactions.AutoScroll = true;
            this.panelCurrentTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrentTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurrentTransactions.Location = new System.Drawing.Point(0, 61);
            this.panelCurrentTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.panelCurrentTransactions.Name = "panelCurrentTransactions";
            this.panelCurrentTransactions.Padding = new System.Windows.Forms.Padding(18, 12, 18, 20);
            this.panelCurrentTransactions.Size = new System.Drawing.Size(1017, 460);
            this.panelCurrentTransactions.TabIndex = 31;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.DarkViolet;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label9_display, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1017, 61);
            this.tableLayoutPanel5.TabIndex = 30;
            // 
            // label9_display
            // 
            this.label9_display.AutoSize = true;
            this.label9_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9_display.ForeColor = System.Drawing.Color.White;
            this.label9_display.Location = new System.Drawing.Point(3, 0);
            this.label9_display.Name = "label9_display";
            this.label9_display.Size = new System.Drawing.Size(1011, 61);
            this.label9_display.TabIndex = 0;
            this.label9_display.Text = "Current Transactions";
            this.label9_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxAmount);
            this.panel2.Controls.Add(this.label1_display);
            this.panel2.Location = new System.Drawing.Point(28, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 87);
            this.panel2.TabIndex = 0;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAmount.ForeColor = System.Drawing.Color.Black;
            this.textBoxAmount.Location = new System.Drawing.Point(177, 24);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(246, 32);
            this.textBoxAmount.TabIndex = 1;
            this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
            // 
            // label1_display
            // 
            this.label1_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1_display.AutoSize = true;
            this.label1_display.ForeColor = System.Drawing.Color.Black;
            this.label1_display.Location = new System.Drawing.Point(3, 29);
            this.label1_display.Name = "label1_display";
            this.label1_display.Size = new System.Drawing.Size(88, 26);
            this.label1_display.TabIndex = 0;
            this.label1_display.Text = "Amount";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBoxTransactionType);
            this.panel3.Controls.Add(this.label2_display);
            this.panel3.Location = new System.Drawing.Point(28, 240);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 87);
            this.panel3.TabIndex = 1;
            // 
            // comboBoxTransactionType
            // 
            this.comboBoxTransactionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransactionType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTransactionType.FormattingEnabled = true;
            this.comboBoxTransactionType.Location = new System.Drawing.Point(177, 25);
            this.comboBoxTransactionType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTransactionType.Name = "comboBoxTransactionType";
            this.comboBoxTransactionType.Size = new System.Drawing.Size(246, 34);
            this.comboBoxTransactionType.TabIndex = 1;
            this.comboBoxTransactionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransactionType_SelectedIndexChanged);
            // 
            // label2_display
            // 
            this.label2_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2_display.AutoSize = true;
            this.label2_display.ForeColor = System.Drawing.Color.Black;
            this.label2_display.Location = new System.Drawing.Point(3, 29);
            this.label2_display.Name = "label2_display";
            this.label2_display.Size = new System.Drawing.Size(171, 26);
            this.label2_display.TabIndex = 0;
            this.label2_display.Text = "Transaction type";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.comboBoxCategory);
            this.panel4.Controls.Add(this.label3_display);
            this.panel4.Location = new System.Drawing.Point(28, 350);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(444, 87);
            this.panel4.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(177, 25);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(246, 34);
            this.comboBoxCategory.TabIndex = 1;
            // 
            // label3_display
            // 
            this.label3_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3_display.AutoSize = true;
            this.label3_display.ForeColor = System.Drawing.Color.Black;
            this.label3_display.Location = new System.Drawing.Point(3, 29);
            this.label3_display.Name = "label3_display";
            this.label3_display.Size = new System.Drawing.Size(100, 26);
            this.label3_display.TabIndex = 0;
            this.label3_display.Text = "Category";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dateTimePickerCategory);
            this.panel5.Controls.Add(this.label4_display);
            this.panel5.Location = new System.Drawing.Point(28, 462);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(444, 87);
            this.panel5.TabIndex = 3;
            // 
            // dateTimePickerCategory
            // 
            this.dateTimePickerCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerCategory.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePickerCategory.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerCategory.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCategory.Location = new System.Drawing.Point(177, 29);
            this.dateTimePickerCategory.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerCategory.MaxDate = new System.DateTime(2023, 10, 30, 13, 47, 27, 0);
            this.dateTimePickerCategory.Name = "dateTimePickerCategory";
            this.dateTimePickerCategory.Size = new System.Drawing.Size(246, 32);
            this.dateTimePickerCategory.TabIndex = 1;
            this.dateTimePickerCategory.Value = new System.DateTime(2023, 10, 30, 0, 0, 0, 0);
            // 
            // label4_display
            // 
            this.label4_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4_display.AutoSize = true;
            this.label4_display.ForeColor = System.Drawing.Color.Black;
            this.label4_display.Location = new System.Drawing.Point(3, 29);
            this.label4_display.Name = "label4_display";
            this.label4_display.Size = new System.Drawing.Size(58, 26);
            this.label4_display.TabIndex = 0;
            this.label4_display.Text = "Date";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.richTextBoxDescription);
            this.panel6.Controls.Add(this.label5_display);
            this.panel6.Location = new System.Drawing.Point(502, 25);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(490, 412);
            this.panel6.TabIndex = 4;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxDescription.Location = new System.Drawing.Point(21, 34);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(448, 353);
            this.richTextBoxDescription.TabIndex = 1;
            this.richTextBoxDescription.Text = "";
            // 
            // label5_display
            // 
            this.label5_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5_display.AutoSize = true;
            this.label5_display.ForeColor = System.Drawing.Color.Black;
            this.label5_display.Location = new System.Drawing.Point(3, 0);
            this.label5_display.Name = "label5_display";
            this.label5_display.Size = new System.Drawing.Size(121, 26);
            this.label5_display.TabIndex = 0;
            this.label5_display.Text = "Description";
            // 
            // btnAddNewTransaction_display
            // 
            this.btnAddNewTransaction_display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewTransaction_display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewTransaction_display.FlatAppearance.BorderSize = 0;
            this.btnAddNewTransaction_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTransaction_display.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewTransaction_display.Location = new System.Drawing.Point(502, 462);
            this.btnAddNewTransaction_display.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewTransaction_display.Name = "btnAddNewTransaction_display";
            this.btnAddNewTransaction_display.Size = new System.Drawing.Size(490, 88);
            this.btnAddNewTransaction_display.TabIndex = 8;
            this.btnAddNewTransaction_display.Text = "Add new";
            this.btnAddNewTransaction_display.UseVisualStyleBackColor = false;
            this.btnAddNewTransaction_display.Click += new System.EventHandler(this.btnAddNewTransaction_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.comboBoxCurrency);
            this.panel8.Controls.Add(this.label7_display);
            this.panel8.Location = new System.Drawing.Point(28, 134);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(444, 87);
            this.panel8.TabIndex = 9;
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(177, 25);
            this.comboBoxCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(246, 34);
            this.comboBoxCurrency.TabIndex = 1;
            // 
            // label7_display
            // 
            this.label7_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7_display.AutoSize = true;
            this.label7_display.ForeColor = System.Drawing.Color.Black;
            this.label7_display.Location = new System.Drawing.Point(3, 29);
            this.label7_display.Name = "label7_display";
            this.label7_display.Size = new System.Drawing.Size(100, 26);
            this.label7_display.TabIndex = 0;
            this.label7_display.Text = "Currency";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.btnAddNewTransaction_display);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 582);
            this.panel1.TabIndex = 0;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1065, 1050);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TransactionForm";
            this.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.Text = "transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelCurrentTransactions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9_display;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label1_display;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxTransactionType;
        private System.Windows.Forms.Label label2_display;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label3_display;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateTimePickerCategory;
        private System.Windows.Forms.Label label4_display;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label5_display;
        private System.Windows.Forms.Button btnAddNewTransaction_display;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label label7_display;
        private System.Windows.Forms.Panel panel1;
    }
}