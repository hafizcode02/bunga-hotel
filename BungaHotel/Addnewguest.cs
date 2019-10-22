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
    public partial class Addnewguest : Form
    {
        Koneksi koneksi = new Koneksi();
        
        public Addnewguest()
        {
            InitializeComponent();
            loadfirst();
        }

        public void loadfirst()
        {
            cbitem();
            guestname.Text = "";
            email.Text = "";
            idcardnumber.Text = "";
            phonenumber.Text = "";
            license.Text = "";
            cbvt.Text = "";
        }

        public void cbitem()
        {
            DataTable dt1 = new DataTable();

            dt1.Clear();
            cbvt.Items.Clear();
            koneksi.select("select * from tipekendaraan");
            koneksi.adp.Fill(dt1);
            foreach (DataRow dtr in dt1.Rows)
            {
                cbvt.DisplayMember = "value";
                cbvt.DisplayMember = "text";
                cbvt.Items.Add(new comboitem() { value = dtr[0].ToString(), text = dtr[1].ToString() });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(guestname.Text) || "".Equals(email.Text) || "".Equals(idcardnumber.Text) || "".Equals(phonenumber.Text) || "".Equals(license.Text) || "".Equals(cbvt.Text))
                {
                    MessageBox.Show("Please fill all columns");
                }
                else
                {
                    koneksi.cud("insert into penghuni (namapenghuni,nomorktp,email,nomorhp,platnokendaraan,idtipekendaraan) values('" + guestname.Text
                        + "','" + idcardnumber.Text
                        + "','" + email.Text
                        + "','" + phonenumber.Text
                        + "','" + license.Text
                        + "','" + ((comboitem)cbvt.SelectedItem).value + "')");
                    MessageBox.Show("Data insert success");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                loadfirst();
            }
            
        }
    }
}
