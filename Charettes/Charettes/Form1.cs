using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Charettes.Properties;

namespace Charettes
{
    public partial class FormSelectGrid : Form
    {

        private Grid _grid;
        public static SerialPort Port;

        private Thread _readThread = null;

        public FormSelectGrid()
        {
            InitializeComponent();
            InitializeComboBox();
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBocComPort.Items.Add(s);
            }
            if (comboBocComPort.Items.Count > 0)
                comboBocComPort.SelectedIndex = comboBocComPort.Items.Count - 1;
            else
                comboBocComPort.SelectedIndex = 0;

        }

        protected void InitializeSerial()
        {
            var components = new Container();
            Port = new SerialPort(components)
            {
                PortName = comboBocComPort.SelectedItem.ToString(),
                BaudRate = Int32.Parse("9600"),
                DtrEnable = true,
                ReadTimeout = 500,
                WriteTimeout = 500
            };
            Port.Open();
            _grid = new Grid(Port);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            InitializeSerial();
            if (_grid != null)
            {
                StartCapture();
            }
            else
            {
                MessageBox.Show(Resources.FormSelectGrid_btnstart_Click_Select_a_grid_to_continue_);
            }
        }

        private void combogridselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormSelectGrid_Load(object sender, EventArgs e)
        {

        }

        private void StartCapture()
        {
            GridMapper gridMapper;
            switch (combogridselect.Text)
            {
                case MainEmerson:
                    gridMapper = (new GridMapper(_grid));
                    break;
                case MohawkGarth:
                    gridMapper = (new GridMapper(_grid));
                    break;
                case BartonKennelworth:
                    gridMapper = (new GridMapper(_grid));
                    break;
            }
        }

        private void InitializeComboBox()
        {
            combogridselect.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combogridselect.DataSource = _gridNames;
        }

        private const string MainEmerson = "Main and Emerson";
        private const string MohawkGarth = "Mohawk and Garth";
        private const string BartonKennelworth = "Barton and Kennelworth";
        private readonly string[] _gridNames = {
            MainEmerson,
            MohawkGarth,
            BartonKennelworth
        };
    }
}
