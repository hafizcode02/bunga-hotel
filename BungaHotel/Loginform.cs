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
    public partial class Loginform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        string idkaryawan;
        public Loginform()
        {
            InitializeComponent();
            email.Enabled = false;
            password.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if("".Equals(email.Text) || "".Equals(password.Text))
            {
                MessageBox.Show("Please Fill All Column");
            }else
            {
                koneksi.select("select * from karyawan where email='" + email.Text + "' and password='" + password.Text + "'");
                koneksi.adp.Fill(dt);
                if(koneksi.dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Wrong Account");
                }else
                {
                    foreach(DataRow dtr in dt.Rows)
                    {
                        idkaryawan = dtr[0].ToString();
                    }
                    Mainform mf = new Mainform(idkaryawan);
                    this.Hide();
                    mf.ShowDialog();
                    this.Close();
                }
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
