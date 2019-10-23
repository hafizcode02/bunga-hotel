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
    public partial class Viewpaymentform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        public Viewpaymentform()
        {
            InitializeComponent();
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
