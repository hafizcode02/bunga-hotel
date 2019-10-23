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
    public partial class Mainform : Form
    {
        string idkaryawan;
        public Mainform(String idkaryawan)
        {
            InitializeComponent();
            this.idkaryawan = idkaryawan;
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changepasswordform cpf = new Changepasswordform(idkaryawan);
            cpf.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loginform lf = new Loginform();
            this.Hide();
            MessageBox.Show("You Has Been Logged Out");
            lf.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transactionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactionreport tr = new Transactionreport();
            tr.ShowDialog();
        }

        private void roomAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roomavailabilityreport rar = new Roomavailabilityreport();
            rar.ShowDialog();
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manageemployeeform me = new Manageemployeeform();
            me.ShowDialog();
        }

        private void manageGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manageguestform mg = new Manageguestform();
            mg.ShowDialog();
        }

        private void manageDailyPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Managedailypriceform mdp = new Managedailypriceform();
            mdp.ShowDialog();
        }

        private void manageHolidayPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manageholidaypriceform mhp = new Manageholidaypriceform();
            mhp.ShowDialog();
        }

        private void manageRoomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manageroomtypeform mrt = new Manageroomtypeform();
            mrt.ShowDialog();
        }

        private void manageRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manageroomform mr = new Manageroomform();
            mr.ShowDialog();
        }

        private void manageRoomFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manageroomfacilityform mrf = new Manageroomfacilityform();
            mrf.ShowDialog();
        }

        private void manageRoomRepairmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manageroomrepairmentform mrp = new Manageroomrepairmentform(idkaryawan);
            mrp.ShowDialog();
        }

        private void bookingRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookingroomform bk = new Bookingroomform(idkaryawan);
            bk.ShowDialog();
        }

        private void manageBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Managebookingform mb = new Managebookingform();
            mb.ShowDialog();
        }

        private void inputPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inputpaymentform ip = new Inputpaymentform();
            ip.ShowDialog();
        }

        private void viewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewpaymentform vp = new Viewpaymentform();
            vp.ShowDialog();
        }
    }
}
