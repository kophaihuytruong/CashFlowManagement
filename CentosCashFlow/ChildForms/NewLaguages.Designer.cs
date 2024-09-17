namespace CentosCashFlow.ChildForms
{
    partial class NewLaguages
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
            this.btnAddNewLanguage = new System.Windows.Forms.Button();
            this.NewLanguages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NewLanguages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewLanguage
            // 
            this.btnAddNewLanguage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewLanguage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddNewLanguage.FlatAppearance.BorderSize = 0;
            this.btnAddNewLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewLanguage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewLanguage.Location = new System.Drawing.Point(0, 446);
            this.btnAddNewLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewLanguage.Name = "btnAddNewLanguage";
            this.btnAddNewLanguage.Size = new System.Drawing.Size(663, 102);
            this.btnAddNewLanguage.TabIndex = 11;
            this.btnAddNewLanguage.Text = "Add";
            this.btnAddNewLanguage.UseVisualStyleBackColor = false;
            this.btnAddNewLanguage.Click += new System.EventHandler(this.btnAddNewLanguage_Click);
            // 
            // NewLanguages
            // 
            this.NewLanguages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewLanguages.Location = new System.Drawing.Point(0, 0);
            this.NewLanguages.Name = "NewLanguages";
            this.NewLanguages.RowHeadersWidth = 62;
            this.NewLanguages.RowTemplate.Height = 28;
            this.NewLanguages.Size = new System.Drawing.Size(663, 548);
            this.NewLanguages.TabIndex = 10;
            this.NewLanguages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewLanguages_CellContentClick);
            // 
            // NewLaguages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 548);
            this.Controls.Add(this.btnAddNewLanguage);
            this.Controls.Add(this.NewLanguages);
            this.Name = "NewLaguages";
            this.Text = "NewLaguages";
            ((System.ComponentModel.ISupportInitialize)(this.NewLanguages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewLanguage;
        private System.Windows.Forms.DataGridView NewLanguages;
    }
}