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
        string lg1, lg2;
        public Transactionreport()
        {
            InitializeComponent();
            viewcb();
        }

        public void viewcb()
        {
            cb.Clear();
            cbrt.Items.Clear();
            koneksi.select("select * from tipekamar");
            koneksi.adp.Fill(cb);
            foreach(DataRow dtr in cb.Rows)
            {
                cbrt.DisplayMember = "value";
                cbrt.DisplayMember = "text";
                cbrt.Items.Add(new comboitem() { text = dtr[1].ToString(), value = dtr[0].ToString() });
            }
            cbrt.Items.Add("All");
        }

        private void Transactionreport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            chart1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var series = new Series("Finance");
            // Frist parameter is X-Axis and Second is Collection of Y- Axis
            //series.Points.DataBindXY(new[] { 2001, 2002, 2003, 2004 }, new[] { 100, 200, 90, 150 });
            //chart1.Series.Add(series);
            //series.ChartType = SeriesChartType.Line;

            DateTime startdate = begindate.Value.Date;
            DateTime finishdate = enddate.Value.Date;
            TimeSpan dayscount = finishdate.Subtract(startdate);
            int jmldays = Convert.ToInt32(dayscount.TotalDays.ToString());


            if (cbrt.Text != "" && cbrt.Text != "All")
            {
                string sts = ((comboitem)cbrt.SelectedItem).text;
                string vsts = ((comboitem)cbrt.SelectedItem).value;
                if (sts == "Deluxe")
                {
                    lg1 = "Deluxe - Normal Day";
                    lg2 = "Deluxe - Fluktuatif Day";
                }
                else if (sts == "Superior")
                {
                    lg1 = "Superior - Normal Day";
                    lg2 = "Superior - Fluktuatif Day";
                }
                else if (sts == "Executive")
                {
                    lg1 = "Executive - Normal Day";
                    lg2 = "Executive - Fluktuatif Day";
                }
                else if (sts == "Standart")
                {
                    lg1 = "Standart - Normal Day";
                    lg2 = "Standart - Fluktuatif Day";
                }

                chart1.Series[0].LegendText = lg1;
                chart1.Series[1].LegendText = lg2;
                for (int i = 0; i <= jmldays; i++)
                {
                    koneksi.select("select sum(totalbayar) ttlbayar from Pemesanan left join kamar on Pemesanan.IDKamar=kamar.IDKamar left join Pembayaran on Pembayaran.IDPemesanan=Pemesanan.IDPemesanan where TglPembayaran = '" + startdate.AddDays(i).ToString("yyyy-MM-dd") + "' and IDHargaFluktuatif is null and kamar.IDTipeKamar='" + vsts + "'");
                    if (koneksi.dt.Rows.Count != 0)
                    {
                        string ttl = koneksi.dt.Rows[0]["ttlbayar"].ToString();
                        chart1.Series[0].Points.AddXY(startdate.AddDays(i).ToString("dd-MMM-yy"), ttl);
                    }
                    koneksi.select("select sum(totalbayar) ttlbayar from Pemesanan left join kamar on Pemesanan.IDKamar=kamar.IDKamar left join Pembayaran on Pembayaran.IDPemesanan=Pemesanan.IDPemesanan where TglPembayaran = '" + startdate.AddDays(i).ToString("yyyy-MM-dd") + "' and IDHargaFluktuatif is not null and kamar.IDTipeKamar='" + vsts + "'");
                    if (koneksi.dt.Rows.Count != 0)
                    {
                        string ttl = koneksi.dt.Rows[0]["ttlbayar"].ToString();
                        chart1.Series[1].Points.AddXY(startdate.AddDays(i).ToString("dd-MMM-yy"), ttl);
                    }
                }
            }
            else
            {
                if(cbrt.Text == "All")
                {
                    chart1.Series[0].LegendText = "Normal Day";
                    chart1.Series[1].LegendText = "Fluktutatif Day";
                    for (int i = 0; i <= jmldays; i++)
                    {
                        koneksi.select("select sum(totalbayar) ttlbayar from Pemesanan left join kamar on Pemesanan.IDKamar=kamar.IDKamar left join Pembayaran on Pembayaran.IDPemesanan=Pemesanan.IDPemesanan where TglPembayaran = '" + startdate.AddDays(i).ToString("yyyy-MM-dd") + "' and IDHargaFluktuatif is null");
                        if (koneksi.dt.Rows.Count != 0)
                        {
                            string ttl = koneksi.dt.Rows[0]["ttlbayar"].ToString();
                            chart1.Series[0].Points.AddXY(startdate.AddDays(i).ToString("dd-MMM-yy"), ttl);
                        }
                        koneksi.select("select sum(totalbayar) ttlbayar from Pemesanan left join kamar on Pemesanan.IDKamar=kamar.IDKamar left join Pembayaran on Pembayaran.IDPemesanan=Pemesanan.IDPemesanan where TglPembayaran = '" + startdate.AddDays(i).ToString("yyyy-MM-dd") + "' and IDHargaFluktuatif is not null");
                        if (koneksi.dt.Rows.Count != 0)
                        {
                            string ttl = koneksi.dt.Rows[0]["ttlbayar"].ToString();
                            chart1.Series[1].Points.AddXY(startdate.AddDays(i).ToString("dd-MMM-yy"), ttl);
                        }
                    }
                }
            }

        }
    }
}
