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
    public partial class Bookingroomform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        String idkaryawan;
        string ihf, idpem;
        string idrt, idguest, idroompesan;
        string hargakamar;
        int i = 1;

        public Bookingroomform(String idkaryawan)
        {
            InitializeComponent();
            segar();
            this.idkaryawan = idkaryawan;
            timer1.Start();
        }

        private void segar()
        {
            viewcb();
            guestid.Enabled = false;
            roomfloor.Enabled = false;
            roomtype.Text = "";
            cidate.Text = "";
            bookingtype.Text = "";
            guestid.Text = "";
            guestnameemail.Text = "";
            roomnumber.Text = "";
            cidatetime.Text = "";
            facilitytotalprice.Text = "0";
            roomprice.Text = "0";
            alltotalprice.Text = "0";
            tax.Text = "0";
            facilitytotalprice.Enabled = false;
            roomprice.Enabled = false;
            alltotalprice.Enabled = false;
            tax.Enabled = false;
            roomnumber.Enabled = false;
            longstay.Text = "";
            addfacility.Text = "";
            qty.Text = "";
            dg.Rows.Clear();
            flowLayoutPanel1.Controls.Clear();
            roomfloor.Text = "";
        }

        private void viewfloor()
        {
            DataTable vf = new DataTable();
            vf.Clear();
            roomfloor.Items.Clear();
            koneksi.select("Select distinct lantai from kamar where idtipekamar LIKE '" + idrt + "'");
            koneksi.adp.Fill(vf);
            foreach (DataRow dtr in vf.Rows)
            {
                roomfloor.Items.Add(dtr[0].ToString());
            }
        }

        private void viewcb()
        {
            DataTable dt1 = new DataTable();
            dt1.Clear();
            roomtype.Items.Clear();
            koneksi.select("select * from tipekamar");
            koneksi.adp.Fill(dt1);
            foreach (DataRow dtr in dt1.Rows)
            {
                roomtype.DisplayMember = "value";
                roomtype.DisplayMember = "text";
                roomtype.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString() });
            }

            DataTable dt2 = new DataTable();
            bookingtype.Items.Clear();
            koneksi.select("select * from jenispemesanan");
            koneksi.adp.Fill(dt2);
            foreach (DataRow dtr in dt2.Rows)
            {
                bookingtype.DisplayMember = "value";
                bookingtype.DisplayMember = "text";
                bookingtype.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString() });
            }

            DataTable dt3 = new DataTable();
            dt3.Clear();
            guestnameemail.Items.Clear();
            koneksi.select("select * from penghuni");
            koneksi.adp.Fill(dt3);
            foreach (DataRow dtr in dt3.Rows)
            {
                guestnameemail.DisplayMember = "value";
                guestnameemail.DisplayMember = "text";
                guestnameemail.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString() });
            }

            DataTable dt4 = new DataTable();
            dt4.Clear();
            addfacility.Items.Clear();
            koneksi.select("select * from fasilitastambahan");
            koneksi.adp.Fill(dt4);
            foreach (DataRow dtr in dt4.Rows)
            {
                addfacility.DisplayMember = "value";
                addfacility.DisplayMember = "text";
                addfacility.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString(), price = dtr[2].ToString() });
            }
        }

        private void linkadg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Addnewguest adg = new Addnewguest();
            adg.ShowDialog();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            idrt = ((comboitem)roomtype.SelectedItem).value;
            viewfloor();
            roomfloor.Enabled = true;
        }

        private void linkrefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dt3 = new DataTable();
            dt3.Clear();
            guestnameemail.Items.Clear();
            koneksi.select("select * from penghuni");
            koneksi.adp.Fill(dt3);
            foreach (DataRow dtr in dt3.Rows)
            {
                guestnameemail.DisplayMember = "value";
                guestnameemail.DisplayMember = "text";
                guestnameemail.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString() });
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((comboitem)addfacility.SelectedItem).price);
            int b = Convert.ToInt32(qty.Text);
            int c = a * b;
            String[] data = new String[]
                {
                    i.ToString(),
                    ((comboitem)addfacility.SelectedItem).value.ToString(),
                    ((comboitem)addfacility.SelectedItem).text.ToString(),
                    c.ToString(),
                    qty.Text.ToString(),
                    a.ToString()
                };
            dg.Rows.Add(data);
            i++;

            int ts = Int32.Parse(facilitytotalprice.Text);
            int totalprice = ts + c;
            facilitytotalprice.Text = totalprice.ToString();

            int ts1 = Int32.Parse(facilitytotalprice.Text);
            int ttlpc = Int32.Parse(alltotalprice.Text);
            int total2 = ts1 + ttlpc;
            alltotalprice.Text = total2.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = this.dg.Rows[e.RowIndex];
                int a = Convert.ToInt32(row.Cells[3].Value.ToString());
                dg.Rows.Remove(dg.Rows[e.RowIndex]);
                dg.Refresh();
                i = 1;

                int ts = Int32.Parse(facilitytotalprice.Text);
                int totalprice = ts - a;
                facilitytotalprice.Text = totalprice.ToString();

                int allttlp = Int32.Parse(alltotalprice.Text);
                int jml = allttlp - a;
                alltotalprice.Text = jml.ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (longstay.Text != "" || longstay.Text == null)
            {
                int aa = Int32.Parse(roomprice.Text);
                int bb = aa * Int32.Parse(longstay.Text);
                roomprice.Text = bb.ToString();
            }
            else
            {
                roomprice.Text = hargakamar;
            }

            int a = Int32.Parse(roomprice.Text);
            int b = Int32.Parse(facilitytotalprice.Text);
            int c = a + b;

            int ttlpricetax = c / 10;
            tax.Text = ttlpricetax.ToString();

            int d = Int32.Parse(tax.Text);
            int total = c + d;
            alltotalprice.Text = total.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;

            hour.Text = hh.ToString();
            minute.Text = mm.ToString();
        }

        private void roomfloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            koneksi.select("select max(kamar.idkamar) as idkamar, max(perbaikankamar.idperbaikankamar) as idperbaikan,max(kamar.nomorkamar) as nokamar,max(pemesanan.status) as status,max(HargaKamar.HargaKamar) as hargakamar from kamar left join perbaikankamar on (kamar.idkamar=perbaikankamar.idkamar and ('" + cidate.Value.ToString("yyyy-MM-dd") + "' between TglMulai and TglSelesai)) left join pemesanan on (kamar.idkamar=pemesanan.idkamar and ('" + cidate.Value.ToString("yyyy-MM-dd") + "' between WaktuMasukHotel and DATEADD(day,LamaTinggal,WaktuMasukHotel))) left join HargaKamar on kamar.IDTipeKamar=HargaKamar.IDTipeKamar where lantai = '" + idrt + "' and kamar.idtipekamar= '" + roomfloor.SelectedItem + "' group by kamar.idkamar");
            if (koneksi.dt.Rows.Count != 0)
            {
                for (int i = 0; i < koneksi.dt.Rows.Count; i++)
                {
                    string nokamar = koneksi.dt.Rows[i]["nokamar"].ToString();
                    string idkamar = koneksi.dt.Rows[i]["idkamar"].ToString();
                    string status = koneksi.dt.Rows[i]["status"].ToString();
                    string idperbaikan = koneksi.dt.Rows[i]["idperbaikan"].ToString();
                    string harga = koneksi.dt.Rows[i]["hargakamar"].ToString();
                    Button b = new Button();
                    b.Name = "ID" + idkamar;
                    b.Text = nokamar;
                    b.Tag = harga;
                    if (idperbaikan != "")
                    {
                        b.ForeColor = Color.Maroon;
                        b.BackColor = Color.White;
                    }
                    else if (status.Equals("B") || status.Equals("I"))
                    {
                        b.BackColor = Color.Red;
                        b.ForeColor = Color.White;
                    }
                    else if (status.Equals("C") || status.Equals(""))
                    {
                        b.BackColor = Color.Blue;
                        b.ForeColor = Color.White;
                    }

                    b.Click += new System.EventHandler(roomclick);
                    flowLayoutPanel1.Controls.Add(b);
                }
            }
        }

        void roomclick(object s, EventArgs e)
        {
            Button thisbtn = (Button)s;
            if (thisbtn.BackColor == Color.White)
            {
                MessageBox.Show("Kamar " + thisbtn.Text + " Sedang Diperbaiki");

            }
            else if (thisbtn.BackColor == Color.Blue)
            {
                hargakamar = thisbtn.Tag.ToString();
                roomprice.Text = thisbtn.Tag.ToString();
                alltotalprice.Text = thisbtn.Tag.ToString();
                roomnumber.Text = thisbtn.Text;
                idroompesan = thisbtn.Name.Substring(2);


                int a = Int32.Parse(roomprice.Text);
                int b = Int32.Parse(facilitytotalprice.Text);
                int c = a + b;

                int ttlpricetax = c / 10;
                tax.Text = ttlpricetax.ToString();

                int d = Int32.Parse(tax.Text);
                int total = c + d;
                alltotalprice.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Kamar " + thisbtn.Text + " Sedang Dipakai");
            }
        }

        private void cbroomnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(bookingtype.Text) || "".Equals(guestid.Text) || "".Equals(guestnameemail.Text) || "".Equals(roomnumber.Text) || "".Equals(longstay.Text))
                {
                    MessageBox.Show("Please fill a form");
                }
                else
                {
                    String dtime = DateTime.Now.ToString("yyyy-MM-dd");
                    string sts = "B";
                    koneksi.cud("insert into pemesanan (idjenispemesanan,tglpemesanan,waktumasukhotel,idpenghuni,idkamar,hargapermalam,idhargafluktuatif,lamatinggal,status,idkaryawan,totalbayar) values('" + ((comboitem)bookingtype.SelectedItem).value
                            + "','" + dtime
                            + "','" + cidatetime.Text
                            + "','" + guestid.Text
                            + "','" + idroompesan
                            + "','" + roomprice.Text
                            + "'," + ihf
                            + ",'" + longstay.Text
                            + "','" + sts
                            + "','" + idkaryawan
                            + "','" + alltotalprice.Text + "')");


                    DataTable cekidp = new DataTable();
                    koneksi.select("select top 1 * from Pemesanan order by idpemesanan desc");
                    koneksi.adp.Fill(cekidp);
                    foreach (DataRow dtr in cekidp.Rows)
                    {
                        idpem = dtr[0].ToString();
                    }

                    int dgr = dg.Rows.Count;

                    if (dgr > 0)
                    {
                        for (int i = 0; i < dg.Rows.Count; i++)
                        {
                            koneksi.cud("insert into pemesanandetail (idpemesanan,idfasilitastambahan,jumlahfasilitastambahan,hargasatuan) values('" + idpem
                                + "','" + dg.Rows[i].Cells["idfasilitas"].Value.ToString()
                                + "','" + dg.Rows[i].Cells["totalitem"].Value.ToString()
                                + "','" + dg.Rows[i].Cells["priceasli"].Value.ToString() + "')");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("booking success");
                segar();
            }
        }

        private void cidatetime_ValueChanged(object sender, EventArgs e)
        {
            DataTable cek = new DataTable();
            koneksi.select("select hf.idhargafluktuatif,hk.hargakamar + (hf.persentase * hk.hargakamar/100) as 'final price' from hargafluktuatif hf left join tipekamar tk on hf.idtipekamar=tk.idtipekamar left join hargakamar hk on tk.idtipekamar=hk.idtipekamar where tglmulai <='" + cidatetime.Value.ToString("yyyy/MM/dd") + "' and tglselesai >='" + cidatetime.Value.ToString("yyyy/MM/dd") + "' and hf.idtipekamar='" + idrt + "'");
            koneksi.adp.Fill(cek);
            if (cek.Rows.Count != 0)
            {
                String aa = "0";
                foreach (DataRow dtr in cek.Rows)
                {
                    aa = dtr[1].ToString();
                    ihf = dtr[0].ToString();
                }

                roomprice.Text = aa.ToString();

                int a = Int32.Parse(roomprice.Text);
                int b = Int32.Parse(facilitytotalprice.Text);
                int c = a + b;

                int ttlpricetax = c / 10;
                tax.Text = ttlpricetax.ToString();

                int d = Int32.Parse(tax.Text);
                int total = c + d;
                alltotalprice.Text = total.ToString();

            }
            else
            {
                roomprice.Text = hargakamar;
                ihf = "NULL";
            }
        }

        private void roomnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void guestnameemail_SelectedIndexChanged(object sender, EventArgs e)
        {
            idguest = ((comboitem)guestnameemail.SelectedItem).value;
            guestid.Text = idguest;
        }
    }
}
