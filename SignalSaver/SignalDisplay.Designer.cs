namespace SignalSaver
{
    partial class SignalDisplay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartDisplay = new System.Windows.Forms.Button();
            this.StopDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SigVal = new System.Windows.Forms.TextBox();
            this.DisplayStatus = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartDisplay
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartDisplay.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartDisplay.Legends.Add(legend1);
            this.ChartDisplay.Location = new System.Drawing.Point(126, 25);
            this.ChartDisplay.Name = "ChartDisplay";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Signal_from_Serial";
            this.ChartDisplay.Series.Add(series1);
            this.ChartDisplay.Size = new System.Drawing.Size(1027, 402);
            this.ChartDisplay.TabIndex = 0;
            this.ChartDisplay.Text = "chart1";
            // 
            // StartDisplay
            // 
            this.StartDisplay.Location = new System.Drawing.Point(14, 25);
            this.StartDisplay.Name = "StartDisplay";
            this.StartDisplay.Size = new System.Drawing.Size(71, 46);
            this.StartDisplay.TabIndex = 1;
            this.StartDisplay.Text = "Start";
            this.StartDisplay.UseVisualStyleBackColor = true;
            this.StartDisplay.Click += new System.EventHandler(this.StartDisplay_Click);
            // 
            // StopDisplay
            // 
            this.StopDisplay.Location = new System.Drawing.Point(14, 77);
            this.StopDisplay.Name = "StopDisplay";
            this.StopDisplay.Size = new System.Drawing.Size(71, 46);
            this.StopDisplay.TabIndex = 2;
            this.StopDisplay.Text = "Stop";
            this.StopDisplay.UseVisualStyleBackColor = true;
            this.StopDisplay.Click += new System.EventHandler(this.StopDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recording status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Signal Value:";
            // 
            // SigVal
            // 
            this.SigVal.Location = new System.Drawing.Point(12, 177);
            this.SigVal.Name = "SigVal";
            this.SigVal.Size = new System.Drawing.Size(89, 20);
            this.SigVal.TabIndex = 7;
            // 
            // DisplayStatus
            // 
            this.DisplayStatus.AutoSize = true;
            this.DisplayStatus.Location = new System.Drawing.Point(11, 254);
            this.DisplayStatus.Name = "DisplayStatus";
            this.DisplayStatus.Size = new System.Drawing.Size(38, 13);
            this.DisplayStatus.TabIndex = 8;
            this.DisplayStatus.Text = "Ready";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SignalDisplay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1176, 439);
            this.Controls.Add(this.DisplayStatus);
            this.Controls.Add(this.SigVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopDisplay);
            this.Controls.Add(this.StartDisplay);
            this.Controls.Add(this.ChartDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignalDisplay";
            this.ShowIcon = false;
            this.Text = "SignalDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignalDisplay_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDisplay;
        private System.Windows.Forms.Button StartDisplay;
        private System.Windows.Forms.Button StopDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SigVal;
        private System.Windows.Forms.Label DisplayStatus;
        private System.Windows.Forms.Timer timer;
    }
}