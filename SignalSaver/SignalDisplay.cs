using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;


namespace SignalSaver
{
    public partial class SignalDisplay : Form
    {
        private SelectAction selectAction;
        private string data = "";
        private string obsoleteData = "";
        private string lastObsoleteData = "";

        public SignalDisplay(SelectAction selectAction)
        {
            InitializeComponent();
            this.selectAction = selectAction;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            defineChart();
            selectAction.serialPortDisplay.DataReceived += new SerialDataReceivedEventHandler(serialport1DataReceived);
        }

        public void defineChart()
        {
            ChartDisplay.Series.Clear();

            var series = ChartDisplay.Series.Add("Signal_from_Serial");
            var chartArea = ChartDisplay.ChartAreas[series.ChartArea];

            series.ChartType = SeriesChartType.Line;
            series.XValueType = ChartValueType.Int32;
            series.Points.AddY(1100);
            series.IsValueShownAsLabel = false;
            series.MarkerStyle = MarkerStyle.Circle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                SigVal.Text = data;
                ChartDisplay.Series["Signal_from_Serial"].Points.AddY(Convert.ToInt32(data));
            }
            catch (Exception)
            {
            }

            if (ChartDisplay.Series["Signal_from_Serial"].Points.Count == 100)
                ChartDisplay.Series["Signal_from_Serial"].Points.RemoveAt(0);

        }

        private void StartDisplay_Click(object sender, EventArgs e)
        {
            ChartDisplay.Series.Clear();
            defineChart();
            try
            {
                selectAction.serialPortDisplay.Open();
                DisplayStatus.Text = "Recording";
                timer.Start();
                StartDisplay.Enabled = false;
                StopDisplay.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("COM Port not selected or available. Please make sure 1 COM port is sellected from the first window.");
            }

        }

        private void StopDisplay_Click(object sender, EventArgs e)
        {
            selectAction.serialPortDisplay.Close();
            DisplayStatus.Text = "Ready";
            timer.Stop();
            StopDisplay.Enabled = false;
            StartDisplay.Enabled = true;
            SigVal.Text = "";
        }

        private void serialport1DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = selectAction.serialPortDisplay.ReadTo("\r\n");

            if (data == "\r\n" || data == "\n" || data == "\r" || data == "")
            {
                data = obsoleteData;
                obsoleteData = "";
            }
            else if (data.Contains('\r') && !data.Contains('\n'))
            {
                data = data.Split('\r')[0];
                lastObsoleteData = obsoleteData;
                obsoleteData = data.Substring(data.IndexOf('\r')+1, data.Length - (data.IndexOf('\r') + 1));
                data = lastObsoleteData + data;
            }
            else if(data.Contains('\n') && !data.Contains('\r'))
            {
                data = data.Split('\n')[0];
                lastObsoleteData = obsoleteData;
                obsoleteData = data.Substring(data.IndexOf('\n') + 1, data.Length - (data.IndexOf('\n') + 1));
                data = lastObsoleteData + data;
            }
            else if(data.Contains("\r\n"))
            {
                data = data.Split('\r')[0];
                lastObsoleteData = obsoleteData;
                obsoleteData = data.Substring(data.IndexOf('\n') + 1, data.Length - (data.IndexOf('\n') + 1));
                data = lastObsoleteData + data;
            }

        }

        private void SignalDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
