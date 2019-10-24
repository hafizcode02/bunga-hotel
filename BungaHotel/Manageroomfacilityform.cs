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
    public partial class Manageroomfacilityform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        int i = 1;

        public Manageroomfacilityform()
        {
            InitializeComponent();
            segar();
        }

        private void segar()
        {
            viewcb();
            viewdg();
            cbfacility.Text = "";
            cbroomfacility.Text = "";
            i = 1;

        }

        private void viewdg()
        {
            dt.Clear();
            dg.Refresh();
            koneksi.select("select fbtk.IDFasilitas,tk.IDTipeKamar,NamaTipeKamar,k.NomorKamar,k.Lantai,f.NamaFasilitas from FasilitasBerdasarkanTipeKamar fbtk left join TipeKamar tk on fbtk.IDTipeKamar = tk.IDTipeKamar left join kamar k on tk.IDTipeKamar=k.IDTipeKamar left join Fasilitas f on fbtk.IDFasilitas=f.IDFasilitas");
            koneksi.adp.Fill(dt);
            dg.Rows.Clear();
            foreach (DataRow dtr in dt.Rows)
            {
                string[] row = new string[] {
                    i.ToString(),
                    dtr[0].ToString(),
                    dtr[1].ToString(),
                    dtr[2].ToString(),
                    dtr[3].ToString(),
                    dtr[4].ToString(),
                    dtr[5].ToString()
                    };
                dg.Rows.Add(row);
                i++;
            }
        }

        private void viewcb()
        {
            DataTable dt1 = new DataTable();
            cbroomfacility.Items.Clear();
            dt1.Clear();
            koneksi.select("select * from tipekamar");
            koneksi.adp.Fill(dt1);
            foreach (DataRow dtr in dt1.Rows)
            {
                cbroomfacility.DisplayMember = "value";
                cbroomfacility.DisplayMember = "text";
                cbroomfacility.Items.Add(new comboitem() { text = dtr[1].ToString(), value = dtr[0].ToString() });
            }

            DataTable dt2 = new DataTable();
            cbfacility.Items.Clear();
            dt2.Clear();
            koneksi.select("select * from fasilitas");
            koneksi.adp.Fill(dt2);
            foreach (DataRow dtr in dt2.Rows)
            {
                cbfacility.DisplayMember = "value";
                cbfacility.DisplayMember = "text";
                cbfacility.Items.Add(new comboitem() { text = dtr[1].ToString(), value = dtr[0].ToString() });
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(cbfacility.Text) || "".Equals(cbroomfacility.Text))
                {
                    MessageBox.Show("please fill all columns");
                }
                else
                {
                    koneksi.cud("insert into fasilitasberdasarkantipekamar (idfasilitas,idtipekamar) values('" + ((comboitem)cbfacility.SelectedItem).value + "','" + ((comboitem)cbroomfacility.SelectedItem).value + "')");
                    MessageBox.Show("Data Inserted Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                segar();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dg.Refresh();
            koneksi.select("select fbtk.IDFasilitas,tk.IDTipeKamar,NamaTipeKamar,k.NomorKamar,k.Lantai,f.NamaFasilitas from FasilitasBerdasarkanTipeKamar fbtk left join TipeKamar tk on fbtk.IDTipeKamar = tk.IDTipeKamar left join kamar k on tk.IDTipeKamar=k.IDTipeKamar left join Fasilitas f on fbtk.IDFasilitas=f.IDFasilitas where k.nomorkamar LIKE '" + search.Text + "' or f.namafasilitas LIKE '" + search.Text + "'");
            koneksi.adp.Fill(dt);
            dg.Rows.Clear();
            foreach (DataRow dtr in dt.Rows)
            {
                string[] row = new string[] {
                    i.ToString(),
                    dtr[0].ToString(),
                    dtr[1].ToString(),
                    dtr[2].ToString(),
                    dtr[3].ToString(),
                    dtr[4].ToString(),
                    dtr[5].ToString()
                    };
                dg.Rows.Add(row);
                i++;
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
                try
                {
                    DataGridViewRow row = this.dg.Rows[e.RowIndex];
                    String id = row.Cells[1].Value.ToString();
                    DialogResult result = MessageBox.Show("Are You sure to delete this data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult.Yes == result)
                    {
                        koneksi.cud("delete from fasilitasberdasarkantipekamar where idfasilitas='" + id + "'");
                        MessageBox.Show("Data Deleted Success");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    segar();
                }
                
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            i = 1;
            segar();
        }

        private void Manageroomfacilityform_Load(object sender, EventArgs e)
        {

        }
    }
}
