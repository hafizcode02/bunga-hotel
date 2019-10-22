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
    public partial class Manageroomtypeform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        public Manageroomtypeform()
        {
            InitializeComponent();
            segar();
        }

        public void segar()
        {
            dg.Enabled = true;
            viewdg();
            roomtypeid.Text = "";
            name.Text = "";
            description.Text = "";
            search.Text = "";
            roomtypeid.Enabled = false;

            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
        }

        public void viewdg()
        {
            dt.Clear();
            dg.DataSource = dt;
            dg.Refresh();
            koneksi.select("select * from tipekamar");
            koneksi.adp.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Room Type ID";
            dg.Columns[1].HeaderText = "Room Type Name";
            dg.Columns[2].HeaderText = "Description";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.cud("insert into tipekamar (namatipekamar,deskripsi) values('" + name.Text
                    + "','" + description.Text + "')");
                MessageBox.Show("Data inserted success");
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.cud("update tipekamar set namatipekamar='" + name.Text + "',deskripsi='" + description.Text + "' where idtipekamar='" + roomtypeid.Text + "'");
                MessageBox.Show("Update data success");
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
                    koneksi.cud("delete from tipekamar where idtipekamar='" + roomtypeid.Text + "'");
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

        private void btn_load_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dg.DataSource = dt;
            dg.Refresh();
            koneksi.select("select * from tipekamar where idtipekamar like '%" + search.Text + "%' or namatipekamar like '%" + search.Text + "%' or deskripsi like '%" + search.Text + "%'");
            koneksi.adp.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Room Type ID";
            dg.Columns[1].HeaderText = "Room Type Name";
            dg.Columns[2].HeaderText = "Description";
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg.Rows[e.RowIndex];
                roomtypeid.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[1].Value.ToString();
                description.Text = row.Cells[2].Value.ToString();

                btn_add.Enabled = false;
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            segar();
        }
    }
}
