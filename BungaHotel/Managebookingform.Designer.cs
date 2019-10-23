namespace BungaHotel
{
    partial class Managebookingform
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
            this.search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.bookingid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(127, 39);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(251, 20);
            this.search.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Semerbak Bunga Hotel : Manage Booking Form";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(406, 35);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingid,
            this.bookingdate,
            this.cidatetime,
            this.guestname,
            this.phoneno,
            this.roomno,
            this.status,
            this.action});
            this.dg.Location = new System.Drawing.Point(16, 69);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(901, 423);
            this.dg.TabIndex = 8;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // bookingid
            // 
            this.bookingid.HeaderText = "Booking ID";
            this.bookingid.Name = "bookingid";
            // 
            // bookingdate
            // 
            this.bookingdate.HeaderText = "Booking Date";
            this.bookingdate.Name = "bookingdate";
            // 
            // cidatetime
            // 
            this.cidatetime.HeaderText = "Check-In Date Time";
            this.cidatetime.Name = "cidatetime";
            // 
            // guestname
            // 
            this.guestname.HeaderText = "Guest Name";
            this.guestname.Name = "guestname";
            // 
            // phoneno
            // 
            this.phoneno.HeaderText = "Phone No";
            this.phoneno.Name = "phoneno";
            // 
            // roomno
            // 
            this.roomno.HeaderText = "Room No";
            this.roomno.Name = "roomno";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            this.action.Text = "Cancel";
            this.action.UseColumnTextForButtonValue = true;
            // 
            // Managebookingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 504);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Name = "Managebookingform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : Manage Booking Form";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneno;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomno;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}