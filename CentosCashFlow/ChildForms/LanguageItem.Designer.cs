namespace CentosCashFlow.ChildForms
{
    partial class LanguageItem
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
            this.btnEditing = new System.Windows.Forms.Button();
            this.btnDeleting = new System.Windows.Forms.Button();
            this.labelLanguageName = new System.Windows.Forms.Label();
            this.labelLanguageCode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransaction)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxTransaction
            // 
            this.pictureBoxTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTransaction.Image = global::CentosCashFlow.Properties.Resources.world_64;
            this.pictureBoxTransaction.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxTransaction.Name = "pictureBoxTransaction";
            this.pictureBoxTransaction.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTransaction.TabIndex = 0;
            this.pictureBoxTransaction.TabStop = false;
            this.pictureBoxTransaction.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditing, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleting, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLanguageName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLanguageCode, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(60, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 60);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnEditing
            // 
            this.btnEditing.BackColor = System.Drawing.Color.Black;
            this.btnEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnEditing.FlatAppearance.BorderSize = 0;
            this.btnEditing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditing.ForeColor = System.Drawing.Color.White;
            this.btnEditing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditing.Location = new System.Drawing.Point(350, 10);
            this.btnEditing.Margin = new System.Windows.Forms.Padding(10);
            this.btnEditing.Name = "btnEditing";
            this.btnEditing.Size = new System.Drawing.Size(80, 40);
            this.btnEditing.TabIndex = 34;
            this.btnEditing.Text = "Edit";
            this.btnEditing.UseVisualStyleBackColor = false;
            this.btnEditing.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // btnDeleting
            // 
            this.btnDeleting.BackColor = System.Drawing.Color.DeepPink;
            this.btnDeleting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDeleting.FlatAppearance.BorderSize = 0;
            this.btnDeleting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleting.ForeColor = System.Drawing.Color.White;
            this.btnDeleting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleting.Location = new System.Drawing.Point(450, 10);
            this.btnDeleting.Margin = new System.Windows.Forms.Padding(10);
            this.btnDeleting.Name = "btnDeleting";
            this.btnDeleting.Size = new System.Drawing.Size(80, 40);
            this.btnDeleting.TabIndex = 33;
            this.btnDeleting.Text = "Delete";
            this.btnDeleting.UseVisualStyleBackColor = false;
            this.btnDeleting.Click += new System.EventHandler(this.btnDeleting_Click);
            // 
            // labelLanguageName
            // 
            this.labelLanguageName.AutoSize = true;
            this.labelLanguageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLanguageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelLanguageName.ForeColor = System.Drawing.Color.Black;
            this.labelLanguageName.Location = new System.Drawing.Point(0, 0);
            this.labelLanguageName.Margin = new System.Windows.Forms.Padding(0);
            this.labelLanguageName.Name = "labelLanguageName";
            this.labelLanguageName.Size = new System.Drawing.Size(170, 60);
            this.labelLanguageName.TabIndex = 31;
            this.labelLanguageName.Text = "Vietnamese";
            this.labelLanguageName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLanguageName.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // labelLanguageCode
            // 
            this.labelLanguageCode.AutoSize = true;
            this.labelLanguageCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLanguageCode.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguageCode.Location = new System.Drawing.Point(170, 0);
            this.labelLanguageCode.Margin = new System.Windows.Forms.Padding(0);
            this.labelLanguageCode.Name = "labelLanguageCode";
            this.labelLanguageCode.Size = new System.Drawing.Size(170, 60);
            this.labelLanguageCode.TabIndex = 30;
            this.labelLanguageCode.Text = "VN";
            this.labelLanguageCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLanguageCode.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // LanguageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(600, 60);
            this.Name = "LanguageItem";
            this.Size = new System.Drawing.Size(600, 60);
            this.Load += new System.EventHandler(this.LanguageItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransaction)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxTransaction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEditing;
        private System.Windows.Forms.Button btnDeleting;
        private System.Windows.Forms.Label labelLanguageName;
        private System.Windows.Forms.Label labelLanguageCode;
    }
}
