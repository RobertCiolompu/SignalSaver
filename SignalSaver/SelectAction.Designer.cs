namespace SignalSaver
{
    partial class SelectAction
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
            this.DisplaySignalBtn = new System.Windows.Forms.Button();
            this.RecordSignalBtn = new System.Windows.Forms.Button();
            this.PortsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BaudRate = new System.Windows.Forms.TextBox();
            this.ScanCOMPorts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplaySignalBtn
            // 
            this.DisplaySignalBtn.Location = new System.Drawing.Point(236, 34);
            this.DisplaySignalBtn.Name = "DisplaySignalBtn";
            this.DisplaySignalBtn.Size = new System.Drawing.Size(124, 58);
            this.DisplaySignalBtn.TabIndex = 0;
            this.DisplaySignalBtn.Text = "Display Signal";
            this.DisplaySignalBtn.UseVisualStyleBackColor = true;
            this.DisplaySignalBtn.Click += new System.EventHandler(this.DisplaySignalBtn_Click);
            // 
            // RecordSignalBtn
            // 
            this.RecordSignalBtn.Location = new System.Drawing.Point(236, 135);
            this.RecordSignalBtn.Name = "RecordSignalBtn";
            this.RecordSignalBtn.Size = new System.Drawing.Size(124, 60);
            this.RecordSignalBtn.TabIndex = 1;
            this.RecordSignalBtn.Text = "Record Signal";
            this.RecordSignalBtn.UseVisualStyleBackColor = true;
            this.RecordSignalBtn.Click += new System.EventHandler(this.RecordSignalBtn_Click);
            // 
            // PortsList
            // 
            this.PortsList.FormattingEnabled = true;
            this.PortsList.Location = new System.Drawing.Point(128, 34);
            this.PortsList.Name = "PortsList";
            this.PortsList.Size = new System.Drawing.Size(70, 69);
            this.PortsList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Set Baudrate:";
            // 
            // BaudRate
            // 
            this.BaudRate.Location = new System.Drawing.Point(101, 156);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(79, 20);
            this.BaudRate.TabIndex = 5;
            this.BaudRate.Text = "9600";
            // 
            // ScanCOMPorts
            // 
            this.ScanCOMPorts.Location = new System.Drawing.Point(23, 34);
            this.ScanCOMPorts.Name = "ScanCOMPorts";
            this.ScanCOMPorts.Size = new System.Drawing.Size(88, 23);
            this.ScanCOMPorts.TabIndex = 6;
            this.ScanCOMPorts.Text = "ScanCOMPorts";
            this.ScanCOMPorts.UseVisualStyleBackColor = true;
            this.ScanCOMPorts.Click += new System.EventHandler(this.ScanPorts_Click);
            // 
            // SelectAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 217);
            this.Controls.Add(this.ScanCOMPorts);
            this.Controls.Add(this.BaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortsList);
            this.Controls.Add(this.RecordSignalBtn);
            this.Controls.Add(this.DisplaySignalBtn);
            this.Name = "SelectAction";
            this.ShowIcon = false;
            this.Text = "SelectAction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectAction_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplaySignalBtn;
        private System.Windows.Forms.Button RecordSignalBtn;
        private System.Windows.Forms.ListBox PortsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BaudRate;
        private System.Windows.Forms.Button ScanCOMPorts;
    }
}