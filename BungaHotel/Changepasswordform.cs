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
    public partial class Changepasswordform : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        string idkaryawan,oldp;
        public Changepasswordform(String idkaryawan)
        {
            InitializeComponent();
            this.idkaryawan = idkaryawan;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.select("select * from karyawan where idkaryawan='" + idkaryawan + "'");
                koneksi.adp.Fill(dt);
                foreach (DataRow dtr in dt.Rows)
                {
                    oldp = dtr[3].ToString();
                }
                if ("".Equals(oldpassword.Text) || "".Equals(newpassword.Text) || "".Equals(confirmnewpassword.Text))
                {
                    MessageBox.Show("Please Fill All Column");
                }
                else
                {
                    if (oldpassword.Text != oldp.ToString())
                    {
                        MessageBox.Show("Wrong Old Password");
                    }
                    else if (newpassword.Text != confirmnewpassword.Text)
                    {
                        MessageBox.Show("Wrong Confirm Password");
                    }
                    else
                    {
                        koneksi.cud("update karyawan set password='" + confirmnewpassword.Text + "' where idkaryawan='" + idkaryawan + "'");
                        MessageBox.Show("Update Password Success");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                oldpassword.Text = "";
                newpassword.Text = "";
                confirmnewpassword.Text = "";
            }
           
        }
    }
}
