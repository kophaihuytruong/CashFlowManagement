namespace CentosCashFlow.ChildForms
{
    partial class TransactionItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxTransaction = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditingTransaction = new System.Windows.Forms.Button();
            this.btnDeletingTransaction = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelTransactionTitle = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransaction)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBoxTransaction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(60, 60);
            this.panel1.MinimumSize = new System.Drawing.Size(60, 60);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxTransaction
            // 
            this.pictureBoxTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTransaction.Image = global::CentosCashFlow.Properties.Resources.file;
            this.pictureBoxTransaction.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxTransaction.Name = "pictureBoxTransaction";
            this.pictureBoxTransaction.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTransaction.TabIndex = 0;
            this.pictureBoxTransaction.TabStop = false;
            this.pictureBoxTransaction.Click += new System.EventHandler(this.btnEditingTransaction_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditingTransaction, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeletingTransaction, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAmount, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(60, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 58);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnEditingTransaction
            // 
            this.btnEditingTransaction.BackColor = System.Drawing.Color.Black;
            this.btnEditingTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditingTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnEditingTransaction.FlatAppearance.BorderSize = 0;
            this.btnEditingTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditingTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditingTransaction.ForeColor = System.Drawing.Color.White;
            this.btnEditingTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditingTransaction.Location = new System.Drawing.Point(334, 10);
            this.btnEditingTransaction.Margin = new System.Windows.Forms.Padding(10);
            this.btnEditingTransaction.Name = "btnEditingTransaction";
            this.btnEditingTransaction.Size = new System.Drawing.Size(80, 38);
            this.btnEditingTransaction.TabIndex = 27;
            this.btnEditingTransaction.Text = "Edit";
            this.btnEditingTransaction.UseVisualStyleBackColor = false;
            this.btnEditingTransaction.Click += new System.EventHandler(this.btnEditingTransaction_Click);
            // 
            // btnDeletingTransaction
            // 
            this.btnDeletingTransaction.BackColor = System.Drawing.Color.DeepPink;
            this.btnDeletingTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeletingTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDeletingTransaction.FlatAppearance.BorderSize = 0;
            this.btnDeletingTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletingTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeletingTransaction.ForeColor = System.Drawing.Color.White;
            this.btnDeletingTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletingTransaction.Location = new System.Drawing.Point(434, 10);
            this.btnDeletingTransaction.Margin = new System.Windows.Forms.Padding(10);
            this.btnDeletingTransaction.Name = "btnDeletingTransaction";
            this.btnDeletingTransaction.Size = new System.Drawing.Size(80, 38);
            this.btnDeletingTransaction.TabIndex = 26;
            this.btnDeletingTransaction.Text = "Delete";
            this.btnDeletingTransaction.UseVisualStyleBackColor = false;
            this.btnDeletingTransaction.Click += new System.EventHandler(this.btnDeletingTransaction_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelDateTime);
            this.panel2.Controls.Add(this.labelTransactionTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 52);
            this.panel2.TabIndex = 22;
            this.panel2.Click += new System.EventHandler(this.btnEditingTransaction_Click);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDateTime.ForeColor = System.Drawing.Color.Black;
            this.labelDateTime.Location = new System.Drawing.Point(0, 25);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(82, 20);
            this.labelDateTime.TabIndex = 5;
            this.labelDateTime.Text = "Date time";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTransactionTitle
            // 
            this.labelTransactionTitle.AutoSize = true;
            this.labelTransactionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelTransactionTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTransactionTitle.Location = new System.Drawing.Point(0, 5);
            this.labelTransactionTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTransactionTitle.Name = "labelTransactionTitle";
            this.labelTransactionTitle.Size = new System.Drawing.Size(148, 24);
            this.labelTransactionTitle.TabIndex = 4;
            this.labelTransactionTitle.Text = "Transaction type";
            this.labelTransactionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(162, 0);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(162, 58);
            this.labelAmount.TabIndex = 18;
            this.labelAmount.Text = "10,000,000 VND";
            this.labelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAmount.Click += new System.EventHandler(this.btnEditingTransaction_Click);
            // 
            // TransactionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(500, 60);
            this.Name = "TransactionItem";
            this.Size = new System.Drawing.Size(584, 58);
            this.Load += new System.EventHandler(this.TransactionItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransaction)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxTransaction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEditingTransaction;
        private System.Windows.Forms.Button btnDeletingTransaction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelTransactionTitle;
        private System.Windows.Forms.Label labelAmount;
    }
}
