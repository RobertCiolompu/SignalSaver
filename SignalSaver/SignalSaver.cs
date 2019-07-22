using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace SignalSaver
{
    public partial class SignalSaver : Form
    {
        private SelectAction selectAction;
        private string data = "";
        private string obsoleteData = "";
        private string lastObsoleteData = "";
        private List<int> paramsList;
        OpenFileDialog ofd = new OpenFileDialog();

        public SignalSaver(SelectAction selectAction)
        {
            InitializeComponent();
            this.selectAction = selectAction; //referinta catre obiectul care trebuie
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            selectAction.serialPortRecord.DataReceived += new SerialDataReceivedEventHandler(serialport1DataReceived);
            StopRecord.Enabled = false;
            XScrollEna.Enabled = false;
            YScrollEna.Enabled = false;

        }

        private void StartRecord_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "")
            {
                try {
                    selectAction.serialPortRecord.Open();
                    RecordingStatus.Text = "Recording";
                    timer1.Start();
                    StartRecord.Enabled = false;
                    StopRecord.Enabled = true;
                    XScrollEna.Enabled = false;
                    YScrollEna.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("COM Port not selected or available. Please make sure 1 COM port is sellected from the first window.");
                }

            }
            else
                MessageBox.Show("Please give a name to the measurement!");


        }

        private void StopRecord_Click(object sender, EventArgs e)
        {
            selectAction.serialPortRecord.Close();
            RecordingStatus.Text = "Ready";
            timer1.Stop();
            StopRecord.Enabled = false;
            StartRecord.Enabled = true;
            XScrollEna.Enabled = true;
            YScrollEna.Enabled = true;
            try
            {
                string docPath = Path.GetDirectoryName(Application.ExecutablePath);
                NewChart(Path.Combine(docPath, "Measurements", textBoxName.Text + ".txt"));
            }
            catch (Exception)
            {
                MessageBox.Show("The folder named Measurements could not be found in the directory containing the executable. Create the folder and record the signal again.");
            }

        }

        private void loadSignalToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                NewChart(ofd.FileName);
                StopRecord.Enabled = false;
                StartRecord.Enabled = true;
                XScrollEna.Enabled = true;
                YScrollEna.Enabled = true;
            }
        }


        private void NewChart(string fileName)
        {
            paramsList = new List<int>();
            ReadFileValues(fileName);
            FillChart();
        }

        private void ReadFileValues(string FilePath)
        {
            try
            {
                using (StreamReader valuesReader = new StreamReader(FilePath))
                {
                    while (valuesReader.Peek() > -1)
                    {
                        paramsList.Add(int.Parse(valuesReader.ReadLine()));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                
            }
        }

        private void FillChart()
        {
            chart.Series.Clear();

            Series series = chart.Series.Add(textBoxName.Text);
            series.ChartType = SeriesChartType.Line;
            series.XValueType = ChartValueType.Int32;
            for (int i = 0; i < paramsList.Count; i++)
                series.Points.AddXY(i, paramsList[i]);
            var chartArea = chart.ChartAreas[series.ChartArea];
            series.MarkerStyle = MarkerStyle.Triangle;

            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = paramsList.Count;

            chartArea.AxisY.Minimum = -100;
            chartArea.AxisY.Maximum = 1200;

            chartArea.CursorX.AutoScroll = true;

            chart.ChartAreas[chart.Series[0].ChartArea].AxisX.ScaleView.Zoomable = true;
            chart.ChartAreas[chart.Series[0].ChartArea].AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            chart.ChartAreas[chart.Series[0].ChartArea].AxisX.ScaleView.Zoom(0, chart.Series[0].Points.Count);
            chart.ChartAreas[chart.Series[0].ChartArea].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chart.ChartAreas[chart.Series[0].ChartArea].AxisX.ScaleView.SmallScrollSize = Convert.ToInt16(chart.Series[0].Points.Count);

            chart.ChartAreas[chart.Series[0].ChartArea].AxisY.ScaleView.Zoomable = true;
            chart.ChartAreas[chart.Series[0].ChartArea].AxisY.ScaleView.SizeType = DateTimeIntervalType.Number;
            chart.ChartAreas[chart.Series[0].ChartArea].AxisY.ScaleView.Zoom(-100, 1200);
            chart.ChartAreas[chart.Series[0].ChartArea].AxisY.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chart.ChartAreas[chart.Series[0].ChartArea].AxisY.ScaleView.SmallScrollSize = 1200;

        }

        private void XScrollEna_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!string.IsNullOrWhiteSpace(textBoxX.Text) || !int.TryParse(textBoxX.Text, out parsedValue))
            {
                int positionX = 0;
                try
                {
                    int sizeX = Convert.ToInt16(textBoxX.Text);
                    chart.ChartAreas[chart.Series[0].ChartArea].AxisX.ScaleView.Zoom(positionX, sizeX);
                    chart.ChartAreas[chart.Series[0].ChartArea].AxisX.ScaleView.SmallScrollSize = Convert.ToInt16(textBoxX.Text);
                    Application.DoEvents();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
                MessageBox.Show("Please introduce a value in the X Axis Scale");
        }

        private void YScrollEna_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!string.IsNullOrWhiteSpace(textBoxY.Text) || !int.TryParse(textBoxX.Text, out parsedValue))
            {
                int positionY = 0;
                try
                { 
                int sizeY = Convert.ToInt16(textBoxY.Text);
                chart.ChartAreas[chart.Series[0].ChartArea].AxisY.ScaleView.Zoom(positionY, sizeY);
                chart.ChartAreas[chart.Series[0].ChartArea].AxisY.ScaleView.SmallScrollSize = Convert.ToInt16(textBoxY.Text);
                Application.DoEvents();
                }
                catch (Exception er)
                {
                MessageBox.Show(er.Message);
                }
            }
            else
                MessageBox.Show("Please introduce a value in the Y Axis Scale");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Measurements", textBoxName.Text + ".txt"), true))
                {
                    outputFile.WriteLine(data);
                }
            }
            catch (Exception)
            {
                selectAction.serialPortRecord.Close();
                RecordingStatus.Text = "Ready";
                timer1.Stop();
                StopRecord.Enabled = false;
                StartRecord.Enabled = true;
                XScrollEna.Enabled = true;
                YScrollEna.Enabled = true;
                MessageBox.Show("The folder named Measurements could not be found in the directory containing the executable. Create the folder and record the signal again.");

            }
        }

        private void serialport1DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                data = selectAction.serialPortRecord.ReadTo("\r\n");
            }
            catch (Exception)
            {
            }

            if (data == "\r\n" || data == "\n" || data == "\r" || data == "")
            {
                data = obsoleteData;
                obsoleteData = "";
            }
            else if (data.Contains('\r') && !data.Contains('\n'))
            {
                data = data.Split('\r')[0];
                lastObsoleteData = obsoleteData;
                obsoleteData = data.Substring(data.IndexOf('\r') + 1, data.Length - (data.IndexOf('\r') + 1));
                data = lastObsoleteData + data;
            }
            else if (data.Contains('\n') && !data.Contains('\r'))
            {
                data = data.Split('\n')[0];
                lastObsoleteData = obsoleteData;
                obsoleteData = data.Substring(data.IndexOf('\n') + 1, data.Length - (data.IndexOf('\n') + 1));
                data = lastObsoleteData + data;
            }
            else if (data.Contains("\r\n"))
            {
                data = data.Split('\r')[0];
                lastObsoleteData = obsoleteData;
                obsoleteData = data.Substring(data.IndexOf('\n') + 1, data.Length - (data.IndexOf('\n') + 1));
                data = lastObsoleteData + data;
            }

        }
        private void SignalSaver_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
