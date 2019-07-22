namespace SignalSaver
{
    partial class SignalSaver
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StartRecord = new System.Windows.Forms.Button();
            this.StopRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RecordingStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadSignalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSignalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.XScrollEna = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.YScrollEna = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // StartRecord
            // 
            this.StartRecord.Location = new System.Drawing.Point(12, 87);
            this.StartRecord.Name = "StartRecord";
            this.StartRecord.Size = new System.Drawing.Size(94, 30);
            this.StartRecord.TabIndex = 0;
            this.StartRecord.Text = "Start Recording";
            this.StartRecord.UseVisualStyleBackColor = true;
            this.StartRecord.Click += new System.EventHandler(this.StartRecord_Click);
            // 
            // StopRecord
            // 
            this.StopRecord.Location = new System.Drawing.Point(12, 123);
            this.StopRecord.Name = "StopRecord";
            this.StopRecord.Size = new System.Drawing.Size(94, 30);
            this.StopRecord.TabIndex = 2;
            this.StopRecord.Text = "Stop Recording";
            this.StopRecord.UseVisualStyleBackColor = true;
            this.StopRecord.Click += new System.EventHandler(this.StopRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recording status:";
            // 
            // RecordingStatus
            // 
            this.RecordingStatus.AutoSize = true;
            this.RecordingStatus.Location = new System.Drawing.Point(105, 169);
            this.RecordingStatus.Name = "RecordingStatus";
            this.RecordingStatus.Size = new System.Drawing.Size(38, 13);
            this.RecordingStatus.TabIndex = 5;
            this.RecordingStatus.Text = "Ready";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(169, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSignalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadSignalToolStripMenuItem
            // 
            this.loadSignalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSignalToolStripMenuItem1});
            this.loadSignalToolStripMenuItem.Name = "loadSignalToolStripMenuItem";
            this.loadSignalToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.loadSignalToolStripMenuItem.Text = "Menu";
            // 
            // loadSignalToolStripMenuItem1
            // 
            this.loadSignalToolStripMenuItem1.Name = "loadSignalToolStripMenuItem1";
            this.loadSignalToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.loadSignalToolStripMenuItem1.Text = "Load Signal";
            this.loadSignalToolStripMenuItem1.Click += new System.EventHandler(this.loadSignalToolStripMenuItem1_Click);
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(187, 45);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(999, 359);
            this.chart.TabIndex = 9;
            this.chart.Text = "chart1";
            // 
            // XScrollEna
            // 
            this.XScrollEna.Location = new System.Drawing.Point(12, 274);
            this.XScrollEna.Name = "XScrollEna";
            this.XScrollEna.Size = new System.Drawing.Size(169, 23);
            this.XScrollEna.TabIndex = 10;
            this.XScrollEna.Text = "Enable X Axis Scrollbar";
            this.XScrollEna.UseVisualStyleBackColor = true;
            this.XScrollEna.Click += new System.EventHandler(this.XScrollEna_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(84, 200);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(49, 20);
            this.textBoxX.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y Axis Scale:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "X Axis Scale:";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(84, 233);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(49, 20);
            this.textBoxY.TabIndex = 14;
            // 
            // YScrollEna
            // 
            this.YScrollEna.Location = new System.Drawing.Point(12, 303);
            this.YScrollEna.Name = "YScrollEna";
            this.YScrollEna.Size = new System.Drawing.Size(169, 23);
            this.YScrollEna.TabIndex = 15;
            this.YScrollEna.Text = "Enable Y Axis Scrollbar";
            this.YScrollEna.UseVisualStyleBackColor = true;
            this.YScrollEna.Click += new System.EventHandler(this.YScrollEna_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SignalSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 416);
            this.Controls.Add(this.YScrollEna);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.XScrollEna);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RecordingStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopRecord);
            this.Controls.Add(this.StartRecord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SignalSaver";
            this.ShowIcon = false;
            this.Text = "SignalSaver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignalSaver_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartRecord;
        private System.Windows.Forms.Button StopRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RecordingStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadSignalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSignalToolStripMenuItem1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button XScrollEna;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button YScrollEna;
        private System.Windows.Forms.Timer timer1;
    }
}

