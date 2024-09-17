namespace CentosCashFlow.ChildForms
{
    partial class Overview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePickerOverview = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTotalExpenditures = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label15_display = new System.Windows.Forms.Label();
            this.chartMoneyOut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotalExpenditures = new System.Windows.Forms.Label();
            this.label11_display = new System.Windows.Forms.Label();
            this.labelExpendituresMonth_display = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTotalIncome = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label14_display = new System.Windows.Forms.Label();
            this.chartMoneyIn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.label8_display = new System.Windows.Forms.Label();
            this.labelIncomeMonth_display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyOut)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyIn)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 36);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePickerOverview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(35, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 30);
            this.panel3.TabIndex = 6;
            // 
            // dateTimePickerOverview
            // 
            this.dateTimePickerOverview.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePickerOverview.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerOverview.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePickerOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerOverview.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerOverview.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerOverview.MaximumSize = new System.Drawing.Size(210, 28);
            this.dateTimePickerOverview.MinimumSize = new System.Drawing.Size(210, 28);
            this.dateTimePickerOverview.Name = "dateTimePickerOverview";
            this.dateTimePickerOverview.Size = new System.Drawing.Size(210, 28);
            this.dateTimePickerOverview.TabIndex = 9;
            this.dateTimePickerOverview.ValueChanged += new System.EventHandler(this.dateTimePickerOverview_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTotalExpenditures);
            this.panel2.Controls.Add(this.tableLayoutPanel6);
            this.panel2.Controls.Add(this.chartMoneyOut);
            this.panel2.Controls.Add(this.tableLayoutPanel5);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panelTotalIncome);
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Controls.Add(this.chartMoneyIn);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(32, 10, 32, 32);
            this.panel2.Size = new System.Drawing.Size(823, 1711);
            this.panel2.TabIndex = 8;
            // 
            // panelTotalExpenditures
            // 
            this.panelTotalExpenditures.AutoScroll = true;
            this.panelTotalExpenditures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalExpenditures.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTotalExpenditures.Location = new System.Drawing.Point(32, 1316);
            this.panelTotalExpenditures.Margin = new System.Windows.Forms.Padding(0);
            this.panelTotalExpenditures.Name = "panelTotalExpenditures";
            this.panelTotalExpenditures.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.panelTotalExpenditures.Size = new System.Drawing.Size(759, 350);
            this.panelTotalExpenditures.TabIndex = 27;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label15_display, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(32, 1276);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(759, 40);
            this.tableLayoutPanel6.TabIndex = 26;
            // 
            // label15_display
            // 
            this.label15_display.AutoSize = true;
            this.label15_display.BackColor = System.Drawing.Color.Black;
            this.label15_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label15_display.ForeColor = System.Drawing.Color.White;
            this.label15_display.Location = new System.Drawing.Point(0, 0);
            this.label15_display.Margin = new System.Windows.Forms.Padding(0);
            this.label15_display.Name = "label15_display";
            this.label15_display.Size = new System.Drawing.Size(759, 40);
            this.label15_display.TabIndex = 1;
            this.label15_display.Text = "Expenditures list";
            this.label15_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartMoneyOut
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMoneyOut.ChartAreas.Add(chartArea1);
            this.chartMoneyOut.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chartMoneyOut.Legends.Add(legend1);
            this.chartMoneyOut.Location = new System.Drawing.Point(32, 935);
            this.chartMoneyOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMoneyOut.Name = "chartMoneyOut";
            this.chartMoneyOut.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            series1.Legend = "Legend1";
            series1.Name = "Money out";
            this.chartMoneyOut.Series.Add(series1);
            this.chartMoneyOut.Size = new System.Drawing.Size(759, 341);
            this.chartMoneyOut.TabIndex = 25;
            this.chartMoneyOut.Text = "chart2";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.LightCoral;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.labelTotalExpenditures, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label11_display, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelExpendituresMonth_display, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(32, 855);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(759, 80);
            this.tableLayoutPanel5.TabIndex = 24;
            // 
            // labelTotalExpenditures
            // 
            this.labelTotalExpenditures.AutoSize = true;
            this.labelTotalExpenditures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalExpenditures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalExpenditures.ForeColor = System.Drawing.Color.White;
            this.labelTotalExpenditures.Location = new System.Drawing.Point(382, 40);
            this.labelTotalExpenditures.Name = "labelTotalExpenditures";
            this.labelTotalExpenditures.Size = new System.Drawing.Size(374, 40);
            this.labelTotalExpenditures.TabIndex = 3;
            this.labelTotalExpenditures.Text = "15.000.000 VND";
            this.labelTotalExpenditures.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11_display
            // 
            this.label11_display.AutoSize = true;
            this.label11_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11_display.ForeColor = System.Drawing.Color.White;
            this.label11_display.Location = new System.Drawing.Point(3, 40);
            this.label11_display.Name = "label11_display";
            this.label11_display.Size = new System.Drawing.Size(373, 40);
            this.label11_display.TabIndex = 2;
            this.label11_display.Text = "Total";
            this.label11_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelExpendituresMonth_display
            // 
            this.labelExpendituresMonth_display.AutoSize = true;
            this.labelExpendituresMonth_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExpendituresMonth_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpendituresMonth_display.ForeColor = System.Drawing.Color.White;
            this.labelExpendituresMonth_display.Location = new System.Drawing.Point(3, 0);
            this.labelExpendituresMonth_display.Name = "labelExpendituresMonth_display";
            this.labelExpendituresMonth_display.Size = new System.Drawing.Size(373, 40);
            this.labelExpendituresMonth_display.TabIndex = 0;
            this.labelExpendituresMonth_display.Text = "Expenditures";
            this.labelExpendituresMonth_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(32, 821);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 34);
            this.panel1.TabIndex = 23;
            // 
            // panelTotalIncome
            // 
            this.panelTotalIncome.AutoScroll = true;
            this.panelTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTotalIncome.Location = new System.Drawing.Point(32, 471);
            this.panelTotalIncome.Margin = new System.Windows.Forms.Padding(0);
            this.panelTotalIncome.Name = "panelTotalIncome";
            this.panelTotalIncome.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.panelTotalIncome.Size = new System.Drawing.Size(759, 350);
            this.panelTotalIncome.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label14_display, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(32, 431);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(759, 40);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // label14_display
            // 
            this.label14_display.AutoSize = true;
            this.label14_display.BackColor = System.Drawing.Color.Black;
            this.label14_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14_display.ForeColor = System.Drawing.Color.White;
            this.label14_display.Location = new System.Drawing.Point(0, 0);
            this.label14_display.Margin = new System.Windows.Forms.Padding(0);
            this.label14_display.Name = "label14_display";
            this.label14_display.Size = new System.Drawing.Size(759, 40);
            this.label14_display.TabIndex = 0;
            this.label14_display.Text = "Income list";
            this.label14_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartMoneyIn
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMoneyIn.ChartAreas.Add(chartArea2);
            this.chartMoneyIn.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chartMoneyIn.Legends.Add(legend2);
            this.chartMoneyIn.Location = new System.Drawing.Point(32, 90);
            this.chartMoneyIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMoneyIn.Name = "chartMoneyIn";
            this.chartMoneyIn.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Money in";
            this.chartMoneyIn.Series.Add(series2);
            this.chartMoneyIn.Size = new System.Drawing.Size(759, 341);
            this.chartMoneyIn.TabIndex = 7;
            this.chartMoneyIn.Text = "chart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelTotalIncome, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8_display, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelIncomeMonth_display, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(32, 10);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(759, 80);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalIncome.ForeColor = System.Drawing.Color.White;
            this.labelTotalIncome.Location = new System.Drawing.Point(379, 40);
            this.labelTotalIncome.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(380, 40);
            this.labelTotalIncome.TabIndex = 3;
            this.labelTotalIncome.Text = "15.000.000 VND";
            this.labelTotalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8_display
            // 
            this.label8_display.AutoSize = true;
            this.label8_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8_display.ForeColor = System.Drawing.Color.White;
            this.label8_display.Location = new System.Drawing.Point(0, 40);
            this.label8_display.Margin = new System.Windows.Forms.Padding(0);
            this.label8_display.Name = "label8_display";
            this.label8_display.Size = new System.Drawing.Size(379, 40);
            this.label8_display.TabIndex = 2;
            this.label8_display.Text = "Total";
            this.label8_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIncomeMonth_display
            // 
            this.labelIncomeMonth_display.AutoSize = true;
            this.labelIncomeMonth_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIncomeMonth_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncomeMonth_display.ForeColor = System.Drawing.Color.White;
            this.labelIncomeMonth_display.Location = new System.Drawing.Point(0, 0);
            this.labelIncomeMonth_display.Margin = new System.Windows.Forms.Padding(0);
            this.labelIncomeMonth_display.Name = "labelIncomeMonth_display";
            this.labelIncomeMonth_display.Size = new System.Drawing.Size(379, 40);
            this.labelIncomeMonth_display.TabIndex = 0;
            this.labelIncomeMonth_display.Text = "Income";
            this.labelIncomeMonth_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(844, 840);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Overview";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Text = "overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyOut)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyIn)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoneyIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Label label8_display;
        private System.Windows.Forms.Label labelIncomeMonth_display;
        private System.Windows.Forms.Panel panelTotalExpenditures;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoneyOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelTotalExpenditures;
        private System.Windows.Forms.Label label11_display;
        private System.Windows.Forms.Label labelExpendituresMonth_display;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTotalIncome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label15_display;
        private System.Windows.Forms.Label label14_display;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePickerOverview;
    }
}