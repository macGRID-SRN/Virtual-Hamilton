using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPlotter
{

    public partial class Form1 : Form
    {
        private SerialPort serialPort1;
        public BlobData CameraData;
        public static Form1 Instance;
        delegate void SetChartCallback(BlobData data);
        private int index = 0;

        public struct BlobData
        {
            public Blob Blob1;
            public Blob Blob2;
            public Blob Blob3;
            public Blob Blob4;
        }

        public struct Blob
        {
            public int X;
            public int Y;
            public int Size;
        }
        public async void UpdateGUI()
        {

        }

        public Form1()
        {
            InitializeComponent();
            Form1.Instance = this;
            Console.WriteLine("Start");

            BlobData CameraData = new BlobData();
            serialPort1 = new SerialPort();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);


        }

        private void UpdateChart(BlobData data)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.chartXY.InvokeRequired)
            {
                SetChartCallback d = new SetChartCallback(UpdateChart);
                this.Invoke(d, new object[] { data });
            }
            else
            {

                if (this.chartXY.Series["Blob1"].Points.Count < 10)
                {
                    this.chartXY.Series["Blob1"].Points.AddXY(data.Blob1.X, data.Blob1.Y);
                    this.chartXY.Series["Blob1"].MarkerSize = 2 * data.Blob1.Size;
                    this.chartXY.Series["Blob2"].Points.AddXY(data.Blob2.X, data.Blob2.Y);
                    this.chartXY.Series["Blob2"].MarkerSize = 2 * data.Blob2.Size;
                    this.chartXY.Series["Blob3"].Points.AddXY(data.Blob3.X, data.Blob3.Y);
                    this.chartXY.Series["Blob3"].MarkerSize = 2 * data.Blob3.Size;
                    this.chartXY.Series["Blob4"].Points.AddXY(data.Blob4.X, data.Blob4.Y);
                    this.chartXY.Series["Blob4"].MarkerSize = 2 * data.Blob4.Size;
                }
                else
                {
                    this.chartXY.Series["Blob1"].Points[index].SetValueXY(data.Blob1.X, data.Blob1.Y);
                    this.chartXY.Series["Blob1"].MarkerSize = 2 * data.Blob1.Size;
                    this.chartXY.Series["Blob2"].Points[index].SetValueXY(data.Blob2.X, data.Blob2.Y);
                    this.chartXY.Series["Blob2"].MarkerSize = 2 * data.Blob2.Size;
                    this.chartXY.Series["Blob3"].Points[index].SetValueXY(data.Blob3.X, data.Blob3.Y);
                    this.chartXY.Series["Blob3"].MarkerSize = 2 * data.Blob3.Size;
                    this.chartXY.Series["Blob4"].Points[index].SetValueXY(data.Blob4.X, data.Blob4.Y);
                    this.chartXY.Series["Blob4"].MarkerSize = 2 * data.Blob4.Size;

                    index = (index + 1) % 10;
                }


                this.chartXY.Update();
            }
        }

        private void ClearChart()
        {
            Form1.Instance.UpdateGUI();
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.chartXY.InvokeRequired)
            {
                SetChartCallback d = new SetChartCallback(UpdateChart);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.chartXY.Series["Blob1"].Points.Clear();
                this.chartXY.Series["Blob2"].Points.Clear();
                this.chartXY.Series["Blob3"].Points.Clear();
                this.chartXY.Series["Blob4"].Points.Clear();
            }
        }



        private void buttonStart_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM5";
            serialPort1.BaudRate = 9600;
            try
            {
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    buttonStart.Enabled = false;
                    buttonStop.Enabled = true;
                }
            }
            catch
            {
                Console.WriteLine("Unable to Start Connection");
            }

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }


        public static int currentId = 0;
        private void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string InputData = serialPort1.ReadLine();
            if (InputData != String.Empty)
            {
                Console.WriteLine(InputData);
                var ParsedSerial = InputData.Split(':');
                string blobName = "B1";
                int blobX = 700;
                int blobY = 700;
                int blobSize = 15;
                int objectId = 0;

                if (ParsedSerial.Length == 1)
                {
                    try
                    {
                        currentId = int.Parse(ParsedSerial[0]);
                        if (currentId == 1)
                        {
                            if (!SendData.isSending)
                            {
                                SendData.isSending = true;
                                SendData.Send();
                                SendData.isSending = false;
                            }
                        }
                    }
                    catch
                    {

                    }
                    return;
                }
                try
                {
                    blobName = ParsedSerial[0];
                    blobX = Convert.ToInt32(ParsedSerial[1]);
                    blobY = Convert.ToInt32(ParsedSerial[2]);
                    blobSize = Convert.ToInt32(ParsedSerial[3]);
                    if (blobSize < 3)
                    {
                        blobSize = 3;
                    }

                    var physicalObject = GridDataObject.physicalObjects.FirstOrDefault(l => l.Id == currentId);
                    if (physicalObject != null)
                    {
                        physicalObject.x = blobX;
                        physicalObject.y = blobY;
                    }

                }
                catch
                {
                    Console.WriteLine("Bad Parse");
                }

                switch (blobName)
                {
                    case "B1":
                        CameraData.Blob1.X = blobX;
                        CameraData.Blob1.Y = blobY;
                        CameraData.Blob1.Size = blobSize;

                        break;
                    case "B2":
                        CameraData.Blob2.X = blobX;
                        CameraData.Blob2.Y = blobY;
                        CameraData.Blob2.Size = blobSize;

                        break;
                    case "B3":
                        CameraData.Blob3.X = blobX;
                        CameraData.Blob3.Y = blobY;
                        CameraData.Blob3.Size = blobSize;

                        break;
                    case "B4":
                        CameraData.Blob4.X = blobX;
                        CameraData.Blob4.Y = blobY;
                        CameraData.Blob4.Size = blobSize;

                        break;
                    default:
                        break;

                }
                UpdateChart(CameraData);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearChart();
        }

    }
}
