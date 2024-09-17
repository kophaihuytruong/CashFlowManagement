namespace CentosCashFlow.ChildForms
{
    partial class CategoryItem
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
            this.pictureBoxCategory = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditingCategory = new System.Windows.Forms.Button();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.btnDeleteCategoryItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategory)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBoxCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(50, 50);
            this.panel1.MinimumSize = new System.Drawing.Size(50, 50);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxCategory
            // 
            this.pictureBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCategory.Image = global::CentosCashFlow.Properties.Resources.icon;
            this.pictureBoxCategory.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxCategory.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxCategory.Name = "pictureBoxCategory";
            this.pictureBoxCategory.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCategory.TabIndex = 0;
            this.pictureBoxCategory.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditingCategory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCategoryName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteCategoryItem, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 50);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnEditingCategory
            // 
            this.btnEditingCategory.BackColor = System.Drawing.Color.Black;
            this.btnEditingCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditingCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnEditingCategory.FlatAppearance.BorderSize = 0;
            this.btnEditingCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditingCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditingCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditingCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditingCategory.Location = new System.Drawing.Point(135, 10);
            this.btnEditingCategory.Margin = new System.Windows.Forms.Padding(10);
            this.btnEditingCategory.Name = "btnEditingCategory";
            this.btnEditingCategory.Size = new System.Drawing.Size(42, 30);
            this.btnEditingCategory.TabIndex = 14;
            this.btnEditingCategory.Text = "Edit";
            this.btnEditingCategory.UseVisualStyleBackColor = false;
            this.btnEditingCategory.Click += new System.EventHandler(this.btnEditingCategory_Click);
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCategoryName.ForeColor = System.Drawing.Color.Black;
            this.labelCategoryName.Location = new System.Drawing.Point(0, 0);
            this.labelCategoryName.Margin = new System.Windows.Forms.Padding(0);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(125, 50);
            this.labelCategoryName.TabIndex = 5;
            this.labelCategoryName.Text = "Category name";
            this.labelCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteCategoryItem
            // 
            this.btnDeleteCategoryItem.BackColor = System.Drawing.Color.DeepPink;
            this.btnDeleteCategoryItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteCategoryItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDeleteCategoryItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategoryItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCategoryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteCategoryItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategoryItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategoryItem.Location = new System.Drawing.Point(197, 10);
            this.btnDeleteCategoryItem.Margin = new System.Windows.Forms.Padding(10);
            this.btnDeleteCategoryItem.Name = "btnDeleteCategoryItem";
            this.btnDeleteCategoryItem.Size = new System.Drawing.Size(43, 30);
            this.btnDeleteCategoryItem.TabIndex = 13;
            this.btnDeleteCategoryItem.Text = "Delete";
            this.btnDeleteCategoryItem.UseVisualStyleBackColor = false;
            this.btnDeleteCategoryItem.Click += new System.EventHandler(this.btnDeleteCategoryItem_Click);
            // 
            // CategoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(300, 50);
            this.Name = "CategoryItem";
            this.Size = new System.Drawing.Size(300, 50);
            this.Load += new System.EventHandler(this.CategoryItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategory)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Button btnDeleteCategoryItem;
        private System.Windows.Forms.Button btnEditingCategory;
    }
}
