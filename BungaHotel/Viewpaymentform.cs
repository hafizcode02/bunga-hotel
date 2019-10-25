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
            viewdg();

        }

        private void segar()
        {

        }

        private void viewdg()
        {
            dt.Clear();
            dg.Refresh();
            koneksi.select("select Pembayaran.IDPembayaran,Pembayaran.TglPembayaran,Pemesanan.IDPemesanan,Penghuni.NamaPenghuni,kamar.NomorKamar,Karyawan.NamaKaryawan,Pembayaran.TotalPembayaran,Pemesanan.Status from pembayaran left join Pemesanan on Pembayaran.IDPemesanan=Pemesanan.IDPemesanan left join Karyawan on Pemesanan.IDKaryawan=Karyawan.IDKaryawan left join Penghuni on Pemesanan.IDPenghuni=Penghuni.IDPenghuni left join kamar on Pemesanan.IDKamar = kamar.IDKamar");
            koneksi.adp.Fill(dt);
            dg.Rows.Clear();
            foreach (DataRow dtr in dt.Rows)
            {
                string[] row = new string[] {
                    dtr[0].ToString(),
                    dtr[1].ToString(),
                    dtr[2].ToString(),
                    dtr[3].ToString(),
                    dtr[4].ToString(),
                    dtr[5].ToString(),
                    dtr[6].ToString(),
                    dtr[7].ToString()
                    };
                dg.Rows.Add(row);
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dg.Refresh();
            koneksi.select("select Pembayaran.IDPembayaran,Pembayaran.TglPembayaran,Pemesanan.IDPemesanan,Penghuni.NamaPenghuni,kamar.NomorKamar,Karyawan.NamaKaryawan,Pembayaran.TotalPembayaran,Pemesanan.Status from pembayaran left join Pemesanan on Pembayaran.IDPemesanan=Pemesanan.IDPemesanan left join Karyawan on Pemesanan.IDKaryawan=Karyawan.IDKaryawan left join Penghuni on Pemesanan.IDPenghuni=Penghuni.IDPenghuni left join kamar on Pemesanan.IDKamar = kamar.IDKamar where pembayaran.tglpembayaran LIKE '%" + search.Text + "%' or pembayaran.idpembayaran LIKE '%" + search.Text + "%' or pemesanan.idpemesanan LIKE '%" + search.Text + "%' or penghuni.namapenghuni LIKE '%" + search.Text + "%' or kamar.nomorkamar LIKE '%" + search.Text + "%' or karyawan.namakaryawan LIKE '%" + search.Text + "%'");
            koneksi.adp.Fill(dt);
            dg.Rows.Clear();
            foreach (DataRow dtr in dt.Rows)
            {
                string[] row = new string[] {
                    dtr[0].ToString(),
                    dtr[1].ToString(),
                    dtr[2].ToString(),
                    dtr[3].ToString(),
                    dtr[4].ToString(),
                    dtr[5].ToString(),
                    dtr[6].ToString(),
                    dtr[7].ToString()
                    };
                dg.Rows.Add(row);
            }
        }
    }
}
