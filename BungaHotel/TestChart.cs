using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BungaHotel
{
    public partial class TestChart : Form
    {
        public TestChart()
        {
            InitializeComponent();
        }

        private void TestChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Report.Testing' table. You can move, or remove it, as needed.
            this.TestingTableAdapter.Fill(this.Report.Testing);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
