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
    public partial class Manageguestform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        string idguest,idkendaraan;
        public Manageguestform()
        {
            InitializeComponent();
            segar();
        }

        public void segar()
        {
            viewdg();
            cbitem();
            guestname.Text = "";
            email.Text = "";
            idcardnumber.Text = "";
            phonenumber.Text = "";
            phonenumber.Text = "";
            vehiclelicense.Text = "";
            cbvt.Text = "";
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
            koneksi.select("select * from penghuni left join tipekendaraan on penghuni.IDTipeKendaraan=tipekendaraan.IDTipeKendaraan");
            koneksi.adp.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[6].Visible = false;
            dg.Columns[7].Visible = false;
        }

        public void cbitem()
        {
            DataTable item = new DataTable();
            item.Clear();
            cbvt.Items.Clear();
            koneksi.select("select * from tipekendaraan");
            koneksi.adp.Fill(item);
            foreach(DataRow dtr in item.Rows)
            {
                cbvt.DisplayMember = "value";
                cbvt.DisplayMember = "text";
                cbvt.Items.Add(new comboitem() { text = dtr[1].ToString(), value = dtr[0].ToString() });
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if("".Equals(guestname.Text)|| "".Equals(email.Text) || "".Equals(idcardnumber.Text) ||
                    "".Equals(phonenumber.Text) || "".Equals(vehiclelicense.Text) || "".Equals(cbvt.Text))
                {
                    MessageBox.Show("Please Fill All Columns");
                }else
                {
                    koneksi.cud("insert into penghuni (namapenghuni,nomorktp,email,nomorhp,platnokendaraan,idtipekendaraan) values('" + guestname.Text
                        + "','" + idcardnumber.Text
                        + "','" + email.Text
                        + "','" + phonenumber.Text
                        + "','" + vehiclelicense.Text
                        + "','" + ((comboitem)cbvt.SelectedItem).value + "')");
                    MessageBox.Show("Data Inserted Success");
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this data ?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(DialogResult.Yes == result)
                {
                    koneksi.cud("delete from penghuni where idpenghuni='" + idguest + "'");
                    MessageBox.Show("Data deleted success");
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
                idguest = row.Cells[0].Value.ToString();
                idkendaraan = row.Cells[6].Value.ToString();
                guestname.Text = row.Cells[1].Value.ToString();
                idcardnumber.Text = row.Cells[2].Value.ToString();
                email.Text = row.Cells[3].Value.ToString();
                phonenumber.Text = row.Cells[4].Value.ToString();
                vehiclelicense.Text = row.Cells[5].Value.ToString();
                cbvt.Text = row.Cells[8].Value.ToString();

                btn_add.Enabled = false;
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            segar();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dg.DataSource = dt;
            dg.Refresh();
            koneksi.select("select * from penghuni left join tipekendaraan on penghuni.IDTipeKendaraan=tipekendaraan.IDTipeKendaraan where email LIKE '%" + search.Text + "%' or namapenghuni LIKE '%" + search.Text + "%' or nomorhp LIKE '%" + search.Text + "%'");
            koneksi.adp.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[6].Visible = false;
            dg.Columns[7].Visible = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(guestname.Text) || "".Equals(email.Text) || "".Equals(idcardnumber.Text) ||
                    "".Equals(phonenumber.Text) || "".Equals(vehiclelicense.Text) || "".Equals(cbvt.Text))
                {
                    MessageBox.Show("Please Fill All Columns");
                }else
                {
                    if(cbvt.SelectedIndex < 1)
                    {
                        koneksi.cud("update penghuni set namapenghuni='" + guestname.Text
                            + "',nomorktp='" + idcardnumber.Text
                            + "',email='" + email.Text
                            + "',nomorhp='" + phonenumber.Text
                            + "',platnokendaraan='" + vehiclelicense.Text
                            + "',idtipekendaraan='" + idkendaraan
                            + "' where idpenghuni='" + idguest + "'");
                        MessageBox.Show("Data updated success");
                    }else
                    {
                        koneksi.cud("update penghuni set namapenghuni='" + guestname.Text
                            + "',nomorktp='" + idcardnumber.Text
                            + "',email='" + email.Text
                            + "',nomorhp='" + phonenumber.Text
                            + "',platnokendaraan='" + vehiclelicense.Text
                            + "',idtipekendaraan='" + ((comboitem)cbvt.SelectedItem).value
                            + "' where idpenghuni='" + idguest + "'");
                        MessageBox.Show("Data updated success");
                    }
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
}
