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
    public partial class Manageholidaypriceform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        Boolean newdata;
        string idrt, idhf;
        public Manageholidaypriceform()
        {
            InitializeComponent();
            segar();
        }

        public void segar()
        {
            viewdg();
            viewcb();
            cbrt.Text = "";
            begin.Text = "";
            end.Text = "";
            percentage.Text = "";
            search.Text = "";
            btn_submit.Text = "Add";
            newdata = true;
        }
        public void viewdg()
        {
            dt.Clear();
            dg.Refresh();
            koneksi.select("select hf.IDHargaFluktuatif,tk.IDTipeKamar,tk.NamaTipeKamar,hk.HargaKamar,hf.Persentase, hk.HargaKamar - (hf.Persentase * hk.HargaKamar/100) as 'Final Price', hf.TglMulai,hf.TglSelesai from HargaFluktuatif hf left join TipeKamar tk on hf.IDTipeKamar=tk.IDTipeKamar left join HargaKamar hk on tk.IDTipeKamar=hk.IDTipeKamar");
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
                    dtr[7].ToString() };
                dg.Rows.Add(row);
            }
        }

        public void viewcb()
        {
            DataTable dt1 = new DataTable();

            dt1.Clear();
            cbrt.Items.Clear();
            koneksi.select("select * from tipekamar");
            koneksi.adp.Fill(dt1);
            foreach (DataRow dtr in dt1.Rows)
            {
                cbrt.DisplayMember = "value";
                cbrt.DisplayMember = "text";
                cbrt.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString() });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if("".Equals(cbrt.Text)||"".Equals(percentage.Text))
                {
                    MessageBox.Show("please fill all columns");
                }else
                {
                    if(newdata)
                    {
                        koneksi.cud("insert into hargafluktuatif (idtipekamar,persentase,tglmulai,tglselesai) values('" + ((comboitem)cbrt.SelectedItem).value
                            + "','" + percentage.Text
                            + "','" + begin.Text
                            + "','" + end.Text + "')");
                        MessageBox.Show("Data insert success");
                    }else
                    {
                        if(cbrt.SelectedIndex < 0)
                        {

                        }else
                        {
                            idrt = ((comboitem)cbrt.SelectedItem).value;
                        }
                        koneksi.cud("update hargafluktuatif set idtipekamar='" + idrt
                            + "',persentase='" + percentage.Text
                            + "',tglmulai='" + begin.Text
                            + "',tglselesai='" + end.Text + "' where idhargafluktuatif='" + idhf + "'");
                        MessageBox.Show("Data updated success");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                segar();
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg.Rows[e.RowIndex];
                idhf = row.Cells[0].Value.ToString();
                idrt = row.Cells[1].Value.ToString();
                cbrt.Text = row.Cells[2].Value.ToString();
                percentage.Text = row.Cells[4].Value.ToString();
                begin.Text = row.Cells[6].Value.ToString();
                end.Text = row.Cells[7].Value.ToString();

                newdata = false;
                btn_submit.Text = "Edit";
            }
            if(e.ColumnIndex == 8)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are You sure to delete this data ?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(DialogResult.Yes == result)
                    {
                        koneksi.cud("delete from hargafluktuatif where idhargafluktuatif='" + idhf + "'");
                        MessageBox.Show("data delete success");
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

        private void btn_load_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dg.Refresh();
            koneksi.select("select hf.IDHargaFluktuatif,tk.IDTipeKamar,tk.NamaTipeKamar,hf.Persentase,hk.HargaKamar, hk.HargaKamar - (hf.Persentase * hk.HargaKamar/100) as 'Final Price', hf.TglMulai,hf.TglSelesai from HargaFluktuatif hf left join TipeKamar tk on hf.IDTipeKamar=tk.IDTipeKamar left join HargaKamar hk on tk.IDTipeKamar=hk.IDTipeKamar left join kamar k on tk.idtipekamar=k.idtipekamar where k.idkamar LIKE '%" + search.Text + "%' or k.lantai LIKE '%" + search.Text + "%' or k.nomorkamar LIKE '%" + search.Text + "%' or tk.namatipekamar LIKE '%" + search.Text + "%'");
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
                    dtr[7].ToString() };
                dg.Rows.Add(row);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            segar();
        }
    }
}
