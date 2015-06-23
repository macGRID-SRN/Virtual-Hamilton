using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Charettes.Properties;

namespace Charettes
{
    public partial class FormSelectGrid : Form
    {

        private Grid _grid;

        public FormSelectGrid()
        {
            InitializeComponent();
            _grid = new Grid();
            InitializeComboBox();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
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
                    gridMapper = new GridMapper(_grid);
                    break;
                case MohawkGarth:
                    gridMapper = new GridMapper(_grid);
                    break;
                case BartonKennelworth:
                    gridMapper = new GridMapper(_grid);
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
