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
    public partial class Manageemployeeform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        string gender;
        public Manageemployeeform()
        {
            InitializeComponent();
            segar();
        }

        public void segar()
        {
            viewdg();

            dg.Enabled = true;
            employeeid.Text = "";
            name.Text = "";
            email.Text = "";
            password.Text = "";
            dob.Text = "";
            male.Checked = false;
            female.Checked = false;
            search.Text = "";

            employeeid.Enabled = false;
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;

        }

        public void viewdg()
        {
            dt.Clear();
            dg.DataSource = dt;
            dg.Refresh();
            koneksi.select("select * from karyawan");
            koneksi.adp.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Employee ID";
            dg.Columns[1].HeaderText = "Employee Name";
            dg.Columns[4].HeaderText = "Date Of Birth";
            dg.Columns[5].HeaderText = "Gender";

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(name.Text) || "".Equals(email.Text) || "".Equals(password.Text) ||
                    "".Equals(dob.Text))
                {
                    MessageBox.Show("Please Fill All Columns");
                }
                else
                {
                    if (male.Checked)
                    {
                        gender = "M";
                    }
                    if (female.Checked)
                    {
                        gender = "F";
                    }

                    koneksi.cud("insert into  karyawan (namakaryawan,email,password,tgllahir,jeniskelamin) values('" + name.Text + "','" + email.Text + "','" + password.Text + "','" + dob.Text + "','" + gender + "')");
                    MessageBox.Show("Insert Data Successfull");
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

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            female.Checked = false;
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            male.Checked = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {

                if ("".Equals(name.Text) || "".Equals(email.Text) || "".Equals(password.Text) ||
                    "".Equals(dob.Text) || "".Equals(employeeid.Text))
                {
                    MessageBox.Show("Please Fill All Columns");
                }
                else
                {
                    if (male.Checked)
                    {
                        gender = "M";
                    }
                    if (female.Checked)
                    {
                        gender = "F";
                    }

                    koneksi.cud("update karyawan set namakaryawan='" + name.Text + "',email='" + email.Text + "',password='" + password.Text + "',tgllahir='" + dob.Text + "',jeniskelamin='" + gender + "' where idkaryawan='" + employeeid.Text + "'");
                    MessageBox.Show("Update Data Successfull");
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
                if (DialogResult.Yes == result)
                {
                    koneksi.cud("delete from karyawan where idkaryawan='" + employeeid.Text + "'");
                    MessageBox.Show("Delete Data Successfull");
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            segar();
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg.Rows[e.RowIndex];
                employeeid.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[1].Value.ToString();
                email.Text = row.Cells[2].Value.ToString();
                password.Text = row.Cells[3].Value.ToString();
                dob.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString() == "M")
                {
                    male.Checked = true;
                }
                else
                {
                    female.Checked = true;
                }

                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
                btn_add.Enabled = false;
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            DataTable load = new DataTable();
            load.Clear();
            dg.DataSource = load;
            dg.Refresh();
            koneksi.select("select * from karyawan where namakaryawan LIKE'%" + search.Text + "%' or email LIKE'%" + search.Text + "%'");
            koneksi.adp.Fill(load);
            dg.DataSource = load;
            dg.Columns[0].HeaderText = "Employee ID";
            dg.Columns[1].HeaderText = "Employee Name";
            dg.Columns[4].HeaderText = "Date Of Birth";
            dg.Columns[5].HeaderText = "Gender";
        }
    }
}
