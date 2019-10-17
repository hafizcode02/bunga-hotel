namespace BungaHotel
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomRepairmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDailyPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageHolidayPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.priceManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(942, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingRoomToolStripMenuItem,
            this.manageBookingToolStripMenuItem,
            this.inputPaymentToolStripMenuItem,
            this.viewPaymentToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // bookingRoomToolStripMenuItem
            // 
            this.bookingRoomToolStripMenuItem.Name = "bookingRoomToolStripMenuItem";
            this.bookingRoomToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.bookingRoomToolStripMenuItem.Text = "Booking Room";
            this.bookingRoomToolStripMenuItem.Click += new System.EventHandler(this.bookingRoomToolStripMenuItem_Click);
            // 
            // manageBookingToolStripMenuItem
            // 
            this.manageBookingToolStripMenuItem.Name = "manageBookingToolStripMenuItem";
            this.manageBookingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.manageBookingToolStripMenuItem.Text = "Manage Booking";
            this.manageBookingToolStripMenuItem.Click += new System.EventHandler(this.manageBookingToolStripMenuItem_Click);
            // 
            // inputPaymentToolStripMenuItem
            // 
            this.inputPaymentToolStripMenuItem.Name = "inputPaymentToolStripMenuItem";
            this.inputPaymentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.inputPaymentToolStripMenuItem.Text = "Input Payment";
            this.inputPaymentToolStripMenuItem.Click += new System.EventHandler(this.inputPaymentToolStripMenuItem_Click);
            // 
            // viewPaymentToolStripMenuItem
            // 
            this.viewPaymentToolStripMenuItem.Name = "viewPaymentToolStripMenuItem";
            this.viewPaymentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.viewPaymentToolStripMenuItem.Text = "View Payment";
            this.viewPaymentToolStripMenuItem.Click += new System.EventHandler(this.viewPaymentToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageRoomTypeToolStripMenuItem,
            this.manageRoomToolStripMenuItem,
            this.manageRoomFacilityToolStripMenuItem,
            this.manageRoomRepairmentToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.managementToolStripMenuItem.Text = "Room Management";
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // manageRoomTypeToolStripMenuItem
            // 
            this.manageRoomTypeToolStripMenuItem.Name = "manageRoomTypeToolStripMenuItem";
            this.manageRoomTypeToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.manageRoomTypeToolStripMenuItem.Text = "Manage Room Type";
            this.manageRoomTypeToolStripMenuItem.Click += new System.EventHandler(this.manageRoomTypeToolStripMenuItem_Click);
            // 
            // manageRoomToolStripMenuItem
            // 
            this.manageRoomToolStripMenuItem.Name = "manageRoomToolStripMenuItem";
            this.manageRoomToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.manageRoomToolStripMenuItem.Text = "Manage Room";
            this.manageRoomToolStripMenuItem.Click += new System.EventHandler(this.manageRoomToolStripMenuItem_Click);
            // 
            // manageRoomFacilityToolStripMenuItem
            // 
            this.manageRoomFacilityToolStripMenuItem.Name = "manageRoomFacilityToolStripMenuItem";
            this.manageRoomFacilityToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.manageRoomFacilityToolStripMenuItem.Text = "Manage Room Facility";
            this.manageRoomFacilityToolStripMenuItem.Click += new System.EventHandler(this.manageRoomFacilityToolStripMenuItem_Click);
            // 
            // manageRoomRepairmentToolStripMenuItem
            // 
            this.manageRoomRepairmentToolStripMenuItem.Name = "manageRoomRepairmentToolStripMenuItem";
            this.manageRoomRepairmentToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.manageRoomRepairmentToolStripMenuItem.Text = "Manage Room Repairment";
            this.manageRoomRepairmentToolStripMenuItem.Click += new System.EventHandler(this.manageRoomRepairmentToolStripMenuItem_Click);
            // 
            // priceManagementToolStripMenuItem
            // 
            this.priceManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDailyPriceToolStripMenuItem,
            this.manageHolidayPriceToolStripMenuItem});
            this.priceManagementToolStripMenuItem.Name = "priceManagementToolStripMenuItem";
            this.priceManagementToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.priceManagementToolStripMenuItem.Text = "Price Management";
            // 
            // manageDailyPriceToolStripMenuItem
            // 
            this.manageDailyPriceToolStripMenuItem.Name = "manageDailyPriceToolStripMenuItem";
            this.manageDailyPriceToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.manageDailyPriceToolStripMenuItem.Text = "Manage Daily Price";
            this.manageDailyPriceToolStripMenuItem.Click += new System.EventHandler(this.manageDailyPriceToolStripMenuItem_Click);
            // 
            // manageHolidayPriceToolStripMenuItem
            // 
            this.manageHolidayPriceToolStripMenuItem.Name = "manageHolidayPriceToolStripMenuItem";
            this.manageHolidayPriceToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.manageHolidayPriceToolStripMenuItem.Text = "Manage Holiday Price";
            this.manageHolidayPriceToolStripMenuItem.Click += new System.EventHandler(this.manageHolidayPriceToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeeToolStripMenuItem,
            this.manageGuestToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // manageGuestToolStripMenuItem
            // 
            this.manageGuestToolStripMenuItem.Name = "manageGuestToolStripMenuItem";
            this.manageGuestToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.manageGuestToolStripMenuItem.Text = "Manage Guest";
            this.manageGuestToolStripMenuItem.Click += new System.EventHandler(this.manageGuestToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionReportToolStripMenuItem,
            this.roomAvailableToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // transactionReportToolStripMenuItem
            // 
            this.transactionReportToolStripMenuItem.Name = "transactionReportToolStripMenuItem";
            this.transactionReportToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.transactionReportToolStripMenuItem.Text = "Transaction Report";
            this.transactionReportToolStripMenuItem.Click += new System.EventHandler(this.transactionReportToolStripMenuItem_Click);
            // 
            // roomAvailableToolStripMenuItem
            // 
            this.roomAvailableToolStripMenuItem.Name = "roomAvailableToolStripMenuItem";
            this.roomAvailableToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.roomAvailableToolStripMenuItem.Text = "Room Availability Report";
            this.roomAvailableToolStripMenuItem.Click += new System.EventHandler(this.roomAvailableToolStripMenuItem_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 503);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : Main Form";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomFacilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomRepairmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDailyPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageHolidayPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomAvailableToolStripMenuItem;
    }
}