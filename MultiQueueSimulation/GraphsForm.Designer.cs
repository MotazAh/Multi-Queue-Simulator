
namespace MultiQueueSimulation
{
    partial class GraphsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_ServerBusyTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox_ServerId = new System.Windows.Forms.ComboBox();
            this.label_ServerID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ServerBusyTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_ServerBusyTime
            // 
            this.chart_ServerBusyTime.BackColor = System.Drawing.Color.Black;
            this.chart_ServerBusyTime.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.White;
            this.chart_ServerBusyTime.ChartAreas.Add(chartArea2);
            this.chart_ServerBusyTime.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart_ServerBusyTime.Legends.Add(legend2);
            this.chart_ServerBusyTime.Location = new System.Drawing.Point(0, 0);
            this.chart_ServerBusyTime.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.chart_ServerBusyTime.Name = "chart_ServerBusyTime";
            this.chart_ServerBusyTime.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BackSecondaryColor = System.Drawing.Color.Honeydew;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.BorderWidth = 0;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.YellowGreen;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValuesPerPoint = 5;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart_ServerBusyTime.Series.Add(series2);
            this.chart_ServerBusyTime.Size = new System.Drawing.Size(1161, 322);
            this.chart_ServerBusyTime.TabIndex = 0;
            this.chart_ServerBusyTime.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "Server <> Schedule";
            this.chart_ServerBusyTime.Titles.Add(title2);
            // 
            // comboBox_ServerId
            // 
            this.comboBox_ServerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ServerId.FormattingEnabled = true;
            this.comboBox_ServerId.Location = new System.Drawing.Point(1065, 319);
            this.comboBox_ServerId.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.comboBox_ServerId.MaximumSize = new System.Drawing.Size(200, 0);
            this.comboBox_ServerId.Name = "comboBox_ServerId";
            this.comboBox_ServerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_ServerId.Size = new System.Drawing.Size(88, 24);
            this.comboBox_ServerId.TabIndex = 1;
            this.comboBox_ServerId.SelectedIndexChanged += new System.EventHandler(this.comboBox_ServerId_SelectedIndexChanged);
            // 
            // label_ServerID
            // 
            this.label_ServerID.AutoSize = true;
            this.label_ServerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ServerID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_ServerID.Location = new System.Drawing.Point(948, 323);
            this.label_ServerID.Name = "label_ServerID";
            this.label_ServerID.Size = new System.Drawing.Size(85, 20);
            this.label_ServerID.TabIndex = 2;
            this.label_ServerID.Text = "Server ID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chart_ServerBusyTime);
            this.panel1.Controls.Add(this.comboBox_ServerId);
            this.panel1.Controls.Add(this.label_ServerID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 420);
            this.panel1.TabIndex = 3;
            // 
            // GraphsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1165, 420);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GraphsForm";
            this.Text = "Graphs";
            ((System.ComponentModel.ISupportInitialize)(this.chart_ServerBusyTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ServerBusyTime;
        private System.Windows.Forms.ComboBox comboBox_ServerId;
        private System.Windows.Forms.Label label_ServerID;
        private System.Windows.Forms.Panel panel1;
    }
}