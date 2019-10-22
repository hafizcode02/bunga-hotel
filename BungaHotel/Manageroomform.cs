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
    public partial class Manageroomform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        string idrt;
        public Manageroomform()
        {
            InitializeComponent();
            segar();
        }

        public void segar()
        {
            viewcb();
            viewdg();
            roomid.Enabled = false;
            roomid.Text = "";
            cbrt.Text = "";
            roomnumber.Text = "";
            floor.Text = "";
            search.Text = "";

            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
        }

        public void viewdg()
        {
            dt.Clear();
            dg.DataSource = dt;
            dg.Refresh();
            koneksi.select("select IDKamar,tipekamar.NamaTipeKamar,NomorKamar,Lantai,kamar.IDTipeKamar from kamar left join tipekamar on kamar.IDTipeKamar=tipekamar.IDTipeKamar");
            koneksi.adp.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[4].Visible = false;
            dg.Columns[0].HeaderText = "Room ID";
            dg.Columns[1].HeaderText = "Room Type Name";
            dg.Columns[2].HeaderText = "Room Number";
            dg.Columns[3].HeaderText = "Floor";

        }

        public void viewcb()
        {
            DataTable da = new DataTable();
            da.Clear();
            cbrt.Items.Clear();
            koneksi.select("select * from tipekamar");
            koneksi.adp.Fill(da);
            foreach(DataRow dtr in da.Rows)
            {
                cbrt.DisplayMember = "value";
                cbrt.DisplayMember = "text";
                cbrt.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString() });
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if("".Equals(cbrt.Text) || "".Equals(roomnumber.Text) || "".Equals(floor.Text))
                {
                    MessageBox.Show("Please Fill All Column");
                }
                else
                {
                    koneksi.cud("insert into kamar(nomorkamar,lantai,idtipekamar) values('" + roomnumber.Text + "','" + floor.Text + "','" + ((comboitem)cbrt.SelectedItem).value + "')");
                    MessageBox.Show("Insert data success");
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            segar();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(roomid.Text) || "".Equals(cbrt.Text) || "".Equals(roomnumber.Text) || "".Equals(floor.Text))
                {
                    MessageBox.Show("Please Fill All Column");
                }
                else
                {
                    if (cbrt.SelectedIndex < 0)
                    {
                        koneksi.cud("update kamar set nomorkamar='" + roomnumber.Text + "',lantai='" + floor.Text + "',idtipekamar='" + idrt + "' where idkamar='" + roomid.Text + "'");
                        MessageBox.Show("Update data success");
                    }
                    else
                    {
                        koneksi.cud("update kamar set nomorkamar='" + roomnumber.Text + "',lantai='" + floor.Text + "',idtipekamar='" + ((comboitem)cbrt.SelectedItem).value + "' where idkamar='" + roomid.Text + "'");
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this data ?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(DialogResult.Yes == result)
                {
                    koneksi.cud("delete from kamar where idkamar='" + roomid.Text + "'");
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

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg.Rows[e.RowIndex];
                idrt = row.Cells[4].Value.ToString();
                roomid.Text = row.Cells[0].Value.ToString();
                cbrt.Text = row.Cells[1].Value.ToString();
                roomnumber.Text = row.Cells[2].Value.ToString();
                floor.Text = row.Cells[3].Value.ToString();

                btn_add.Enabled = false;
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dg.DataSource = dt;
            dg.Refresh();
            koneksi.select("select IDKamar,tipekamar.NamaTipeKamar,NomorKamar,Lantai,kamar.idtipekamar from kamar left join tipekamar on kamar.IDTipeKamar=tipekamar.IDTipeKamar where tipekamar.idtipekamar like '%" + search.Text + "%' or tipekamar.namatipekamar like '%" + search.Text + "%' or deskripsi like '%" + search.Text + "%' ");
            koneksi.adp.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[4].Visible = false;
            dg.Columns[0].HeaderText = "Room ID";
            dg.Columns[1].HeaderText = "Room Type Name";
            dg.Columns[2].HeaderText = "Room Number";
            dg.Columns[3].HeaderText = "Floor";
        }
    }
}
