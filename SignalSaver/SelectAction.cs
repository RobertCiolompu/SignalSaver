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

namespace SignalSaver
{
    public partial class SelectAction : Form
    {
        private SignalSaver signalSaver;
        
        private SignalDisplay signalDisplay;
        string[] myPorts = new string[24];
        public SerialPort serialPortDisplay = new SerialPort();
        public SerialPort serialPortRecord = new SerialPort();

        public SelectAction()
        {
            InitializeComponent();
            signalSaver = new SignalSaver(this);
            signalSaver.Hide();
            signalDisplay = new SignalDisplay(this);
            signalDisplay.Hide();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void DisplaySignalBtn_Click(object sender, EventArgs e)
        {
            signalDisplay.Show();
        }

        private void RecordSignalBtn_Click(object sender, EventArgs e)
        {
            signalSaver.Show();
        }

        private void ScanPorts_Click(object sender, EventArgs e)
        {
            PortsList.Items.Clear();
            myPorts = SerialPort.GetPortNames();
            PortsList.Items.AddRange(myPorts);
            int i = PortsList.Items.Count;
            i = i - i;

            try
            {
                PortsList.SelectedIndex = i;
                serialPortRecord.PortName = PortsList.SelectedItem.ToString();
                serialPortRecord.BaudRate = 9600;
                serialPortDisplay.PortName = PortsList.SelectedItem.ToString();
                serialPortDisplay.BaudRate = 9600;
            }
            catch (Exception)
            {
                MessageBox.Show("COM port not detected", "Warning !!!", MessageBoxButtons.OK);
                PortsList.Items.Clear();
            }

        }

        private void SelectAction_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                serialPortDisplay.Close();
                serialPortRecord.Close();
            }
            catch (Exception)
            { }
            Application.Exit();
        }
    }
}
