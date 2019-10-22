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
    public partial class Managedailypriceform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        Boolean newdata;
        string idrt, iddt, idhk;
        public Managedailypriceform()
        {
            InitializeComponent();
            segar();
        }

        public void segar()
        {
            viewdg();
            viewcb();
            cbroom.Text = "";
            cbday.Text = "";
            roomprice.Text = "";
            breakfast.Text = "";
            search.Text = "";
            btn_submit.Text = "Add";
            newdata = true;
        }

        public void viewdg()
        {
            dt.Clear();
            dg.Refresh();
            koneksi.select("select h.IDHargaKamar,tk.IDTipeKamar,th.IDTipeHari,tk.NamaTipeKamar,th.NamaTipeHari,h.HargaKamar,h.HargaSarapan from HargaKamar h left join TipeKamar tk on h.IDTipeKamar=tk.IDTipeKamar left join TipeHari th on h.IDTipeHari=th.IDTipeHari");
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
                    dtr[6].ToString() };
                dg.Rows.Add(row);
            }
        }

        public void viewcb()
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            dt1.Clear();
            cbroom.Items.Clear();
            koneksi.select("select * from tipekamar");
            koneksi.adp.Fill(dt1);
            foreach (DataRow dtr in dt1.Rows)
            {
                cbroom.DisplayMember = "value";
                cbroom.DisplayMember = "text";
                cbroom.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString() });
            }

            dt2.Clear();
            cbday.Items.Clear();
            koneksi.select("select * from tipehari");
            koneksi.adp.Fill(dt2);
            foreach (DataRow dtr in dt2.Rows)
            {
                cbday.DisplayMember = "value";
                cbday.DisplayMember = "text";
                cbday.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString() });
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg.Rows[e.RowIndex];
                idhk = row.Cells[0].Value.ToString();
                idrt = row.Cells[1].Value.ToString();
                iddt = row.Cells[2].Value.ToString();
                cbroom.Text = row.Cells[3].Value.ToString();
                cbday.Text = row.Cells[4].Value.ToString();
                roomprice.Text = row.Cells[5].Value.ToString();
                breakfast.Text = row.Cells[6].Value.ToString();

                btn_submit.Text = "Edit";
                newdata = false;
            }
            if (e.ColumnIndex == 7)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are You sure to delete this data?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult.Yes == result)
                    {
                        koneksi.cud("delete from hargakamar where idhargakamar='" + idhk + "'");
                        MessageBox.Show("Data deleted success");
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
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            segar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(cbday.Text) || "".Equals(cbroom.Text) || "".Equals(roomprice.Text) || "".Equals(breakfast.Text))
                {
                    MessageBox.Show("Please Fill All Columns");
                }
                else
                {
                    if (newdata)
                    {
                        koneksi.cud("insert into hargakamar(idtipekamar,idtipehari,hargakamar,hargasarapan) values('"
                            + ((comboitem)cbroom.SelectedItem).value
                            + "','" + ((comboitem)cbday.SelectedItem).value
                            + "','" + roomprice.Text
                            + "','" + breakfast.Text + "')");
                        MessageBox.Show("Data Inserted Successfully");
                    }
                    else
                    {
                        if (cbroom.SelectedIndex < 0)
                        {
                            
                        }else
                        {
                            idrt = ((comboitem)cbroom.SelectedItem).value;
                        }
                        if (cbday.SelectedIndex < 0)
                        {

                        }else
                        {
                            iddt = ((comboitem)cbday.SelectedItem).value;

                        }
                        koneksi.cud("update hargakamar set idtipekamar='" + idrt
                            + "',idtipehari='" + iddt
                            + "',hargakamar='" + roomprice.Text
                            + "',hargasarapan='" + breakfast.Text
                            + "' where idhargakamar='" + idhk + "'");
                        MessageBox.Show("Update data success");
                    }
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
            koneksi.select("select h.IDHargaKamar,tk.IDTipeKamar,th.IDTipeHari,tk.NamaTipeKamar,th.NamaTipeHari,h.HargaKamar,h.HargaSarapan from HargaKamar h left join TipeKamar tk on h.IDTipeKamar=tk.IDTipeKamar left join TipeHari th on h.IDTipeHari=th.IDTipeHari left join kamar k on tk.IDTipeKamar=k.IDTipeKamar where k.idkamar LIKE '%" + search.Text + "%' or k.lantai LIKE '%" + search.Text + "%' or k.nomorkamar LIKE '%" + search.Text + "%' or tk.namatipekamar LIKE '%" + search.Text + "%' ");
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
                    dtr[6].ToString() };
                dg.Rows.Add(row);
            }
        }
    }
}
