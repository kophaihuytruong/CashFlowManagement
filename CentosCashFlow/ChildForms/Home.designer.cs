namespace CentosCashFlow.ChildForms
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2_display = new System.Windows.Forms.Label();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddNewTransaction_display = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotalMonthExpenditure = new System.Windows.Forms.Label();
            this.labellabelTitleMonthExpenditure_display = new System.Windows.Forms.Label();
            this.labelTotalMonthIncome = new System.Windows.Forms.Label();
            this.labelTitleMonthIncome_display = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCurrentTransactions = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label8_display = new System.Windows.Forms.Label();
            this.chartMonthCashFlow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthCashFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2_display, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCurrentBalance, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.36444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.63556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2_display
            // 
            this.label2_display.AutoSize = true;
            this.label2_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2_display.ForeColor = System.Drawing.Color.Black;
            this.label2_display.Location = new System.Drawing.Point(32, 35);
            this.label2_display.Margin = new System.Windows.Forms.Padding(0);
            this.label2_display.Name = "label2_display";
            this.label2_display.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label2_display.Size = new System.Drawing.Size(828, 17);
            this.label2_display.TabIndex = 1;
            this.label2_display.Text = "Current balance";
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelCurrentBalance.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelCurrentBalance.Location = new System.Drawing.Point(32, 0);
            this.labelCurrentBalance.Margin = new System.Windows.Forms.Padding(0);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(828, 35);
            this.labelCurrentBalance.TabIndex = 0;
            this.labelCurrentBalance.Text = "10,001,129 VND";
            this.labelCurrentBalance.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewTransaction_display, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(860, 38);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnAddNewTransaction_display
            // 
            this.btnAddNewTransaction_display.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNewTransaction_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTransaction_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNewTransaction_display.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewTransaction_display.Location = new System.Drawing.Point(611, 0);
            this.btnAddNewTransaction_display.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewTransaction_display.Name = "btnAddNewTransaction_display";
            this.btnAddNewTransaction_display.Size = new System.Drawing.Size(217, 38);
            this.btnAddNewTransaction_display.TabIndex = 0;
            this.btnAddNewTransaction_display.Text = "Add new transaction";
            this.btnAddNewTransaction_display.UseVisualStyleBackColor = true;
            this.btnAddNewTransaction_display.Click += new System.EventHandler(this.btnAddNewTransaction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(0, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(457, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Income and Expenses this month";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelTotalMonthExpenditure, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labellabelTitleMonthExpenditure_display, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelTotalMonthIncome, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTitleMonthIncome_display, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(860, 75);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // labelTotalMonthExpenditure
            // 
            this.labelTotalMonthExpenditure.AutoSize = true;
            this.labelTotalMonthExpenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalMonthExpenditure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalMonthExpenditure.ForeColor = System.Drawing.Color.LightCoral;
            this.labelTotalMonthExpenditure.Location = new System.Drawing.Point(430, 37);
            this.labelTotalMonthExpenditure.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalMonthExpenditure.Name = "labelTotalMonthExpenditure";
            this.labelTotalMonthExpenditure.Padding = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.labelTotalMonthExpenditure.Size = new System.Drawing.Size(430, 38);
            this.labelTotalMonthExpenditure.TabIndex = 9;
            this.labelTotalMonthExpenditure.Text = "10,001,129 VND";
            this.labelTotalMonthExpenditure.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labellabelTitleMonthExpenditure_display
            // 
            this.labellabelTitleMonthExpenditure_display.AutoSize = true;
            this.labellabelTitleMonthExpenditure_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labellabelTitleMonthExpenditure_display.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellabelTitleMonthExpenditure_display.ForeColor = System.Drawing.Color.Black;
            this.labellabelTitleMonthExpenditure_display.Location = new System.Drawing.Point(0, 37);
            this.labellabelTitleMonthExpenditure_display.Margin = new System.Windows.Forms.Padding(0);
            this.labellabelTitleMonthExpenditure_display.Name = "labellabelTitleMonthExpenditure_display";
            this.labellabelTitleMonthExpenditure_display.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.labellabelTitleMonthExpenditure_display.Size = new System.Drawing.Size(430, 38);
            this.labellabelTitleMonthExpenditure_display.TabIndex = 8;
            this.labellabelTitleMonthExpenditure_display.Text = "Total Expenditures In This Month";
            this.labellabelTitleMonthExpenditure_display.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelTotalMonthIncome
            // 
            this.labelTotalMonthIncome.AutoSize = true;
            this.labelTotalMonthIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalMonthIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMonthIncome.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelTotalMonthIncome.Location = new System.Drawing.Point(430, 0);
            this.labelTotalMonthIncome.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalMonthIncome.Name = "labelTotalMonthIncome";
            this.labelTotalMonthIncome.Padding = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.labelTotalMonthIncome.Size = new System.Drawing.Size(430, 37);
            this.labelTotalMonthIncome.TabIndex = 7;
            this.labelTotalMonthIncome.Text = "10,001,129 VND";
            this.labelTotalMonthIncome.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelTitleMonthIncome_display
            // 
            this.labelTitleMonthIncome_display.AutoSize = true;
            this.labelTitleMonthIncome_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleMonthIncome_display.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleMonthIncome_display.ForeColor = System.Drawing.Color.Black;
            this.labelTitleMonthIncome_display.Location = new System.Drawing.Point(0, 0);
            this.labelTitleMonthIncome_display.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleMonthIncome_display.Name = "labelTitleMonthIncome_display";
            this.labelTitleMonthIncome_display.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.labelTitleMonthIncome_display.Size = new System.Drawing.Size(430, 37);
            this.labelTitleMonthIncome_display.TabIndex = 6;
            this.labelTitleMonthIncome_display.Text = "Total Income In This Month";
            this.labelTitleMonthIncome_display.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.chartMonthCashFlow);
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(36, 15, 36, 40);
            this.panel1.Size = new System.Drawing.Size(860, 1152);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelCurrentTransactions);
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(36, 505);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.panel2.Size = new System.Drawing.Size(788, 607);
            this.panel2.TabIndex = 11;
            // 
            // panelCurrentTransactions
            // 
            this.panelCurrentTransactions.AutoScroll = true;
            this.panelCurrentTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrentTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCurrentTransactions.Location = new System.Drawing.Point(0, 91);
            this.panelCurrentTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.panelCurrentTransactions.Name = "panelCurrentTransactions";
            this.panelCurrentTransactions.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.panelCurrentTransactions.Size = new System.Drawing.Size(788, 516);
            this.panelCurrentTransactions.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label8_display, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(788, 66);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label8_display
            // 
            this.label8_display.AutoSize = true;
            this.label8_display.BackColor = System.Drawing.Color.DarkViolet;
            this.label8_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8_display.ForeColor = System.Drawing.Color.White;
            this.label8_display.Location = new System.Drawing.Point(0, 0);
            this.label8_display.Margin = new System.Windows.Forms.Padding(0);
            this.label8_display.Name = "label8_display";
            this.label8_display.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.label8_display.Size = new System.Drawing.Size(788, 66);
            this.label8_display.TabIndex = 3;
            this.label8_display.Text = "Current Transactions";
            this.label8_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chartMonthCashFlow
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMonthCashFlow.ChartAreas.Add(chartArea1);
            this.chartMonthCashFlow.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chartMonthCashFlow.Legends.Add(legend1);
            this.chartMonthCashFlow.Location = new System.Drawing.Point(36, 15);
            this.chartMonthCashFlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMonthCashFlow.Name = "chartMonthCashFlow";
            this.chartMonthCashFlow.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Cash Flow";
            this.chartMonthCashFlow.Series.Add(series1);
            this.chartMonthCashFlow.Size = new System.Drawing.Size(788, 490);
            this.chartMonthCashFlow.TabIndex = 10;
            this.chartMonthCashFlow.Text = "chart1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(886, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthCashFlow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2_display;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddNewTransaction_display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelTotalMonthExpenditure;
        private System.Windows.Forms.Label labellabelTitleMonthExpenditure_display;
        private System.Windows.Forms.Label labelTotalMonthIncome;
        private System.Windows.Forms.Label labelTitleMonthIncome_display;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthCashFlow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCurrentTransactions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label8_display;
    }
}