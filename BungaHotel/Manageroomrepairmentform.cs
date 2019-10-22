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
    public partial class Manageroomrepairmentform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        Boolean newdata;
        string idkaryawan;
        string idpk, idkamar;
        public Manageroomrepairmentform(String idkaryawan)
        {
            InitializeComponent();
            this.idkaryawan = idkaryawan;
            segar();
        }

        public void viewdg()
        {
            dt.Clear();
            dg.Refresh();
            koneksi.select("select pk.IDPerbaikanKamar,k.IDKamar,tk.NamaTipeKamar,k.NomorKamar,k.Lantai,pk.TglMulai,pk.TglSelesai,kry.NamaKaryawan,pk.Catatan from PerbaikanKamar pk left join kamar k on pk.IDKamar=k.IDKamar left join TipeKamar tk on k.IDTipeKamar=tk.IDTipeKamar left join Karyawan kry on pk.IDKaryawan=kry.IDKaryawan");
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
                    dtr[7].ToString(),
                    dtr[8].ToString() };
                dg.Rows.Add(row);
            }
        }

        public void segar()
        {
            viewdg();
            viewcb();
            cbrn.Text = "";
            begindate.Text = "";
            enddate.Text = "";
            note.Text = "";
            search.Text = "";
            newdata = true;
            btn_submit.Text = "Add";
        }

        public void viewcb()
        {
            DataTable dt1 = new DataTable();
            cbrn.Items.Clear();
            dt1.Clear();
            koneksi.select("select * from kamar");
            koneksi.adp.Fill(dt1);
            foreach(DataRow dtr in dt1.Rows)
            {
                cbrn.DisplayMember = "value";
                cbrn.DisplayMember = "text";
                cbrn.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString() });
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg.Rows[e.RowIndex];
                idpk = row.Cells[0].Value.ToString();
                idkamar = row.Cells[1].Value.ToString();
                cbrn.Text = row.Cells[3].Value.ToString();
                begindate.Text = row.Cells[5].Value.ToString();
                enddate.Text = row.Cells[6].Value.ToString();
                note.Text = row.Cells[8].Value.ToString();

                btn_submit.Text = "Edit";
                newdata = false;
            }
            if(e.ColumnIndex == 9)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure to delete this data?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(DialogResult.Yes == result)
                    {
                        koneksi.cud("delete from perbaikankamar where idperbaikankamar='" + idpk + "'");
                        MessageBox.Show("delete data success");
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
            koneksi.select("select pk.IDPerbaikanKamar,k.IDKamar,tk.NamaTipeKamar,k.NomorKamar,k.Lantai,pk.TglMulai,pk.TglSelesai,kry.NamaKaryawan,pk.Catatan from PerbaikanKamar pk left join kamar k on pk.IDKamar=k.IDKamar left join TipeKamar tk on k.IDTipeKamar=tk.IDTipeKamar left join Karyawan kry on pk.IDKaryawan=kry.IDKaryawan where tk.namatipekamar LIKE '%" + search.Text + "%' or k.lantai LIKE '%" + search.Text + "%' or k.nomorkamar LIKE '%" + search.Text + "%' or tk.idtipekamar LIKE '%" + search.Text + "%'");
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
                    dtr[7].ToString(),
                    dtr[8].ToString() };
                dg.Rows.Add(row);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            segar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(cbrn.Text) || "".Equals(note.Text))
                {
                    MessageBox.Show("Please Fill All Column");
                }
                else
                {
                    if (newdata)
                    {
                        koneksi.cud("insert into perbaikankamar (idkamar,tglmulai,tglselesai,catatan,idkaryawan) values('" + ((comboitem)cbrn.SelectedItem).value + "','" + begindate.Text + "','" + enddate.Text + "','" + note.Text + "','" + idkaryawan + "')");
                        MessageBox.Show("Data Insert Success");
                    }
                    else
                    {
                        if (cbrn.SelectedIndex < 0)
                        {

                        }
                        else
                        {
                            idkamar = ((comboitem)cbrn.SelectedItem).value;
                        }
                        koneksi.cud("update perbaikankamar set idkamar='" + idkamar + "',tglmulai='" + begindate.Text + "',tglselesai='" + enddate.Text + "',catatan='" + note.Text + "' where idperbaikankamar='" + idpk + "'");
                        MessageBox.Show("Data Update Success");
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
    }
}
