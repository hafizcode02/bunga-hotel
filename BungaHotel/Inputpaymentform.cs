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
    public partial class Inputpaymentform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        string idkaryawan;
        public Inputpaymentform(String idkaryawan)
        {
            InitializeComponent();
            segar();
            this.idkaryawan = idkaryawan;
        }

        private void segar()
        {
            bookingid.Text = "";
            remainingpayment.Text = "";
            payment.Text = "0";
            balance.Text = "0";
            payment.Text = "0";
            getidpemesan();
            remainingpayment.Enabled = false;
            balance.Enabled = false;
        }

        private void getidpemesan()
        {
            bookingid.Items.Clear();
            dt.Clear();
            koneksi.select("select Pemesanan.IDPemesanan, Pemesanan.totalbayar from Pemesanan left join Pembayaran on Pemesanan.IDPemesanan=Pembayaran.IDPemesanan where Pemesanan.Status != 'I' and Pemesanan.Status != 'C'");
            koneksi.adp.Fill(dt);
            foreach(DataRow dtr in dt.Rows)
            {
                bookingid.DisplayMember = "price";
                bookingid.DisplayMember = "text";
                bookingid.Items.Add(new comboitem() { text = dtr[0].ToString(), price = dtr[1].ToString() });
            }
        }

        private void Inputpaymentform_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if("".Equals(bookingid.Text) || "".Equals(remainingpayment.Text) || "".Equals(payment.Text) || "".Equals(balance.Text))
                {
                    MessageBox.Show("Please fill all columns");
                }else
                {
                    koneksi.cud("update pemesanan set status='I' where idpemesanan='" + ((comboitem)bookingid.SelectedItem).text + "'");
                    koneksi.cud("insert into pembayaran (tglpembayaran,idpemesanan,idkaryawan,totalpembayaran) values('" + pdate.Text + "','" + ((comboitem)bookingid.SelectedItem).text + "','" + idkaryawan + "','" + payment.Text + "')");
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                MessageBox.Show("Payment Success");
                segar();
            }
        }

        private void payment_TextChanged(object sender, EventArgs e)
        {
            int rp = Int32.Parse(remainingpayment.Text);
            int p = Int32.Parse(payment.Text);

            int ttl = p - rp;
            balance.Text = ttl.ToString();
        }

        private void bookingid_SelectedIndexChanged(object sender, EventArgs e)
        {
            remainingpayment.Text = ((comboitem)bookingid.SelectedItem).price;
        }
    }
}
