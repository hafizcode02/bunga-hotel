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
        string idrt, idguest, idroompesan;
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
            cbroomnumber.Enabled = false;
            roomnumber.Enabled = false;
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
                };
            dg.Rows.Add(data);
            i++;

            int ts = Int32.Parse(facilitytotalprice.Text);
            int totalprice = ts + c;
            facilitytotalprice.Text = totalprice.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = this.dg.Rows[e.RowIndex];
                int a = Convert.ToInt32(row.Cells[3].Value.ToString());
                dg.Rows.Remove(dg.Rows[e.RowIndex]);
                dg.Refresh();
                i = 1;
                int ts = Int32.Parse(facilitytotalprice.Text);
                int totalprice = ts - a;
                facilitytotalprice.Text = totalprice.ToString();
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
                roomprice.Text = ((comboitem)cbroomnumber.SelectedItem).price;
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
            if ("" != roomfloor.Text)
            {
                cbroomnumber.Enabled = true;
                DataTable dt5 = new DataTable();
                dt5.Clear();
                cbroomnumber.Items.Clear();
                koneksi.select("select k.IDKamar,k.NomorKamar,hk.HargaKamar from HargaKamar hk left join TipeKamar tk on hk.IDTipeKamar=tk.IDTipeKamar left join kamar k on tk.IDTipeKamar=k.IDTipeKamar where hk.IDTipeKamar='" + idrt + "' and k.Lantai= '" + roomfloor.SelectedItem + "'");
                koneksi.adp.Fill(dt5);
                foreach (DataRow dtr in dt5.Rows)
                {
                    cbroomnumber.DisplayMember = "value";
                    cbroomnumber.DisplayMember = "text";
                    cbroomnumber.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString(), price = dtr[2].ToString() });
                }
            }
        }

        private void cbroomnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomnumber.Text = ((comboitem)cbroomnumber.SelectedItem).text;
            roomprice.Text = ((comboitem)cbroomnumber.SelectedItem).price;

            int a = Int32.Parse(roomprice.Text);
            int b = Int32.Parse(facilitytotalprice.Text);
            int c = a + b;

            int ttlpricetax = c / 10;
            tax.Text = ttlpricetax.ToString();

            int d = Int32.Parse(tax.Text);
            int total = c + d;
            alltotalprice.Text = total.ToString();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

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
