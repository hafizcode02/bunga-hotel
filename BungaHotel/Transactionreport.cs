using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BungaHotel
{
    public partial class Transactionreport : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable cb = new DataTable();
        public Transactionreport()
        {
            InitializeComponent();
            viewcb();
            cbrt.Text = "All";
        }

        public void viewcb()
        {
            cb.Clear();
            cbrt.Items.Clear();
            koneksi.select("select * from tipekamar");
            koneksi.adp.Fill(cb);
            foreach (DataRow dtr in cb.Rows)
            {
                cbrt.DisplayMember = "value";
                cbrt.DisplayMember = "text";
                cbrt.Items.Add(new comboitem() { text = dtr[1].ToString(), value = dtr[0].ToString() });
            }
            cbrt.Items.Add("All");
        }

        private void Transactionreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Report.Testing' table. You can move, or remove it, as needed.
            //this.TestingTableAdapter.Fill(this.Report.Testing);
            refreshreport();
            //this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbrt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshreport();

        }

        private void refreshreport()
        {
            if (cbrt.Text != "")
            {

                string tipe = "";
                if (cbrt.Text != "All")
                {
                    string vsts = ((comboitem)cbrt.SelectedItem).value;
                    tipe = " and kamar.idtipekamar=" + vsts + "";
                }

                koneksi.select("SELECT FORMAT(Pembayaran.TglPembayaran,'dd-MMM-yy') as TglPembayaran, Pembayaran.TotalPembayaran, kamar.IDTipeKamar, (CASE WHEN Pemesanan.IDHargaFluktuatif IS NULL THEN 'Normal' ELSE 'Fluktuatif' END) AS tipe_harga " +
                    "FROM Pembayaran INNER JOIN Pemesanan ON Pemesanan.IDPemesanan = Pembayaran.IDPemesanan " +
                    "INNER JOIN kamar ON kamar.IDKamar = Pemesanan.IDKamar where (pembayaran.tglpembayaran between '" + begindate.Value.ToString("yyyy-MM-dd") + "' and '" + enddate.Value.ToString("yyyy-MM-dd") + "')" + tipe);
                this.Report.Clear();
                koneksi.adp.Fill(this.Report.Testing);

                ReportParameterCollection rp = new ReportParameterCollection();
                rp.Add(new ReportParameter("satu", cbrt.Text));
                this.reportViewer1.LocalReport.SetParameters(rp);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
