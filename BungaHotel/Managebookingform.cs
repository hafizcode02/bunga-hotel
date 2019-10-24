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
    public partial class Managebookingform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();

        public Managebookingform()
        {
            InitializeComponent();
            segar();
        }

        public void segar()
        {
            search.Text = "";
            viewdg();
        }

        public void viewdg()
        {
            dt.Clear();
            dg.Refresh();
            koneksi.select("select pem.IDPemesanan,pem.TglPemesanan,pem.WaktuMasukHotel,peng.NamaPenghuni,peng.NomorHP,k.NomorKamar,pem.Status from Pemesanan pem left join Penghuni peng on pem.IDPenghuni=peng.IDPenghuni left join kamar k on pem.IDKamar=k.IDKamar");
            koneksi.adp.Fill(dt);
            dg.Rows.Clear();
            foreach(DataRow dtr in dt.Rows)
            {
                string[] data = new string[]
                {
                    dtr[0].ToString(),
                    dtr[1].ToString(),
                    dtr[2].ToString(),
                    dtr[3].ToString(),
                    dtr[4].ToString(),
                    dtr[5].ToString(),
                    dtr[6].ToString()
                };
                dg.Rows.Add(data);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dg.Refresh();
            koneksi.select("select pem.IDPemesanan,pem.TglPemesanan,pem.WaktuMasukHotel,peng.NamaPenghuni,peng.NomorHP,k.NomorKamar,pem.Status from Pemesanan pem left join Penghuni peng on pem.IDPenghuni=peng.IDPenghuni left join kamar k on pem.IDKamar=k.IDKamar where ");
            koneksi.adp.Fill(dt);
            dg.Rows.Clear();
            foreach (DataRow dtr in dt.Rows)
            {
                string[] data = new string[]
                {
                    dtr[0].ToString(),
                    dtr[1].ToString(),
                    dtr[2].ToString(),
                    dtr[3].ToString(),
                    dtr[4].ToString(),
                    dtr[5].ToString(),
                    dtr[6].ToString()
                };
                dg.Rows.Add(data);
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dg.Rows[e.RowIndex];
                    if (row.Cells[0].Value.ToString() != "" || row.Cells[0].Value.ToString() != null)
                    {
                        String bi = row.Cells[0].Value.ToString();
                        String status = "C";
                        if (e.ColumnIndex == 7)
                        {
                            DialogResult result = MessageBox.Show("Are You Sure to cancel this booking ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (DialogResult.Yes == result)
                            {
                                koneksi.cud("update Pemesanan set Status='" + status + "' where idpemesanan='" + bi + "'");
                                MessageBox.Show("Booking Canceled Succeess");
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
                    segar();
                }
            }
        }
    }
}
