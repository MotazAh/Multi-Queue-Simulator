
namespace MultiQueueSimulation
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomInterArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeInQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.but_ShowGraphs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerNumber,
            this.RandomInterArrival,
            this.InterArrival,
            this.ArrivalTime,
            this.Server,
            this.RandomService,
            this.ServiceTime,
            this.TimeInQueue,
            this.StartTime,
            this.EndTime});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(54, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 541);
            this.dataGridView1.TabIndex = 0;
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.HeaderText = "CustomerNumber";
            this.CustomerNumber.MinimumWidth = 6;
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.Width = 125;
            // 
            // RandomInterArrival
            // 
            this.RandomInterArrival.HeaderText = "RandomInterArrival";
            this.RandomInterArrival.MinimumWidth = 6;
            this.RandomInterArrival.Name = "RandomInterArrival";
            this.RandomInterArrival.Width = 125;
            // 
            // InterArrival
            // 
            this.InterArrival.HeaderText = "InterArrival";
            this.InterArrival.MinimumWidth = 6;
            this.InterArrival.Name = "InterArrival";
            this.InterArrival.Width = 125;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "ArrivalTime";
            this.ArrivalTime.MinimumWidth = 6;
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Width = 125;
            // 
            // Server
            // 
            this.Server.HeaderText = "Server";
            this.Server.MinimumWidth = 6;
            this.Server.Name = "Server";
            this.Server.Width = 125;
            // 
            // RandomService
            // 
            this.RandomService.HeaderText = "RandomService";
            this.RandomService.MinimumWidth = 6;
            this.RandomService.Name = "RandomService";
            this.RandomService.Width = 125;
            // 
            // ServiceTime
            // 
            this.ServiceTime.HeaderText = "ServiceTime";
            this.ServiceTime.MinimumWidth = 6;
            this.ServiceTime.Name = "ServiceTime";
            this.ServiceTime.Width = 125;
            // 
            // TimeInQueue
            // 
            this.TimeInQueue.HeaderText = "TimeInQueue";
            this.TimeInQueue.MinimumWidth = 6;
            this.TimeInQueue.Name = "TimeInQueue";
            this.TimeInQueue.Width = 125;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 125;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(597, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_ShowGraphs
            // 
            this.but_ShowGraphs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.but_ShowGraphs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_ShowGraphs.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.but_ShowGraphs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.but_ShowGraphs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.but_ShowGraphs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ShowGraphs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_ShowGraphs.Location = new System.Drawing.Point(1097, 12);
            this.but_ShowGraphs.Name = "but_ShowGraphs";
            this.but_ShowGraphs.Size = new System.Drawing.Size(260, 48);
            this.but_ShowGraphs.TabIndex = 2;
            this.but_ShowGraphs.Text = "Display Servers Graphs";
            this.but_ShowGraphs.UseVisualStyleBackColor = false;
            this.but_ShowGraphs.Click += new System.EventHandler(this.but_ShowGraphs_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1410, 619);
            this.Controls.Add(this.but_ShowGraphs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomInterArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeInQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.Button but_ShowGraphs;
    }
}