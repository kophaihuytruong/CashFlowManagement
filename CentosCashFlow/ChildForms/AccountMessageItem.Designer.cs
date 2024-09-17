namespace CentosCashFlow.ChildForms
{
    partial class AccountMessageItem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.AccountMessageItem_Click);
            // 
            // pictureBoxTransaction
            // 
            this.pictureBoxTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTransaction.Image = global::CentosCashFlow.Properties.Resources.comments;
            this.pictureBoxTransaction.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxTransaction.Name = "pictureBoxTransaction";
            this.pictureBoxTransaction.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTransaction.TabIndex = 0;
            this.pictureBoxTransaction.TabStop = false;
            this.pictureBoxTransaction.Click += new System.EventHandler(this.AccountMessageItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(60, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 58);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.AccountMessageItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelMessage);
            this.panel2.Controls.Add(this.labelUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 52);
            this.panel2.TabIndex = 27;
            this.panel2.Click += new System.EventHandler(this.AccountMessageItem_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMessage.ForeColor = System.Drawing.Color.Gray;
            this.labelMessage.Location = new System.Drawing.Point(0, 25);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(937, 20);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "ContentContentContentContentContentContentContentContentContentContentContentCont" +
    "entContentContentContentContent";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMessage.Click += new System.EventHandler(this.AccountMessageItem_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelUserName.ForeColor = System.Drawing.Color.Black;
            this.labelUserName.Location = new System.Drawing.Point(0, 5);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(102, 24);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "User name";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUserName.Click += new System.EventHandler(this.AccountMessageItem_Click);
            // 
            // AccountMessageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(300, 60);
            this.Name = "AccountMessageItem";
            this.Size = new System.Drawing.Size(298, 58);
            this.Load += new System.EventHandler(this.AccountMessageItem_Load);
            this.Click += new System.EventHandler(this.AccountMessageItem_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransaction)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxTransaction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelUserName;
    }
}
