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
        string idrt,idguest;
        int i = 1;

        public Bookingroomform(String idkaryawan)
        {
            InitializeComponent();
            segar();
            this.idkaryawan = idkaryawan;
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
        }

        private void viewfloor()
        {
            DataTable vf = new DataTable();
            vf.Clear();
            roomfloor.Items.Clear();
            koneksi.select("Select TOP 1 Lantai from kamar where idtipekamar LIKE '" + idrt + "'");
            koneksi.adp.Fill(vf);
            foreach(DataRow dtr in vf.Rows)
            {
                roomfloor.Items.Add(dtr[0].ToString());
            }
        }

        public void viewdg()
        {
            
        }

        private void viewcb()
        {
            DataTable dt1 = new DataTable();
            dt1.Clear();
            roomtype.Items.Clear();
            koneksi.select("select * from tipekamar");
            koneksi.adp.Fill(dt1);
            foreach(DataRow dtr in dt1.Rows)
            {
                roomtype.DisplayMember = "value";
                roomtype.DisplayMember = "text";
                roomtype.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString() });
            }

            DataTable dt2 = new DataTable();
            dt2.Clear();
            bookingtype.Items.Clear();
            koneksi.select("select * from jenispemesanan");
            koneksi.adp.Fill(dt2);
            foreach(DataRow dtr in dt2.Rows)
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
            foreach(DataRow dtr in dt3.Rows)
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
            foreach(DataRow dtr in dt4.Rows)
            {
                addfacility.DisplayMember = "value";
                addfacility.DisplayMember = "text";
                addfacility.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString(),price=dtr[2].ToString() });
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
            segar();
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                dg.Rows.Remove(dg.Rows[e.RowIndex]);
                dg.Refresh();
                i = 1;
            }
        }

        private void guestnameemail_SelectedIndexChanged(object sender, EventArgs e)
        {
            idguest = ((comboitem)guestnameemail.SelectedItem).value;
            guestid.Text = idguest;
        }
    }
}
