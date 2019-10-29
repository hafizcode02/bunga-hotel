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
    public partial class Roomavailabilityreport : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        CheckBox box;
        string idbox, txtbox;
        public Roomavailabilityreport()
        {
            InitializeComponent();
            foreachpanel();
            foreachmonth();
            foreachduration();
        }

        private void foreachmonth()
        {
            String[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            month.Items.Clear();
            int i = 1;
            foreach(String isi in months)
            {
                month.DisplayMember = "value";
                month.DisplayMember = "text";
                month.Items.Add(new comboitem() { text = isi, value = i.ToString() });
                i++;
            }
        }

        private void foreachduration()
        {
            String[] durations = { "3 Months", "6 Months", "9 Months", "12 Moths" };
            duration.Items.Clear();
            int i = 3;
            foreach (String isi in durations)
            {
                duration.DisplayMember = "value";
                duration.DisplayMember = "text";
                duration.Items.Add(new comboitem() { text = isi, value = i.ToString() });
                int a = i + 3;
                i = a;
            }
        }

        private void foreachpanel()
        {
            dt.Clear();
            koneksi.select("select * from tipekamar");
            koneksi.adp.Fill(dt);
            foreach (DataRow dtr in dt.Rows)
            {
                for(int i = 1; i< 2; i++)
                {
                    box = new CheckBox();
                    box.Text = dtr[1].ToString();
                    box.Name = "ID" + dtr[0].ToString();
                    box.AutoSize = true;
                    flowLayoutPanel1.Controls.Add(box);
                    box.Click += new System.EventHandler(boxclick);
                }
            }
            box = new CheckBox();
            box.Text = "All";
            box.AutoSize = true;
            flowLayoutPanel1.Controls.Add(box);
        }

        void boxclick(object s, EventArgs e)
        {
            CheckBox boks = (CheckBox)s;
            if(boks.Checked == true)
            {
                idbox = boks.Name.Substring(2);
                txtbox = boks.Text;
                MessageBox.Show(idbox);
                MessageBox.Show(txtbox);
            }else
            {
                idbox = "";
                txtbox = "";
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //chart1.Series.Add("Deluxe");
            //chart1.Series["Deluxe"].Points.AddXY("Testing", "100000");
            //chart1.Series["Deluxe"].Points.AddXY("anjay", "63000");
            //chart1.Titles.Add("Ini Testing");

            int idmonth = Convert.ToInt32(((comboitem)month.SelectedItem).value);
            int idduration = Convert.ToInt32(((comboitem)duration.SelectedItem).value);
            if (txtbox == "Deluxe")
            {
                chart1.Series.Add("Deluxe");
                for (int i = idmonth; i <= idmonth + idduration; i++)
                {
                    String[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                    koneksi.chart("select count(*) from kamar where not exists(select idkamar from Pemesanan where kamar.IDKamar=Pemesanan.IDKamar and MONTH(TglPemesanan)='" + i + "') and kamar.IDTipeKamar='" + idbox + "'");
                    chart1.DataSource = koneksi.ds;
                    for(int j = idmonth-1; i<= idmonth +idduration; i++)
                    {
                        chart1.Series["Deluxe"].Points.AddXY("");
                    }
                    if (i > 12)
                    {
                        break;
                    }
                }
            }
            else if (txtbox == "Superior")
            {

            }
            else if (txtbox == "Executive")
            {

            }
            else if (txtbox == "Standart")
            {

            }
            else if (txtbox == "All")
            {

            }
            else
            {
                MessageBox.Show("Anda Belum Memilih");
            }

            //for (int i = idmonth; i <= idmonth + idduration; i++)
            //{
            //    if (i > 12)
            //    {

            //    }
            //}

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Roomavailabilityreport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void duration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
