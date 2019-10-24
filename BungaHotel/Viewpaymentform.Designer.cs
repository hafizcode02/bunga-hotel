namespace BungaHotel
{
    partial class Viewpaymentform
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentid,
            this.paymentdate,
            this.bookingid,
            this.guestname,
            this.roomno,
            this.employeename,
            this.payment,
            this.status});
            this.dg.Location = new System.Drawing.Point(14, 70);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(901, 423);
            this.dg.TabIndex = 13;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(404, 36);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 12;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Semerbak Bunga Hotel : View Payment Form";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(125, 40);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(251, 20);
            this.search.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search";
            // 
            // paymentid
            // 
            this.paymentid.HeaderText = "Payment ID";
            this.paymentid.Name = "paymentid";
            // 
            // paymentdate
            // 
            this.paymentdate.HeaderText = "Payment Date";
            this.paymentdate.Name = "paymentdate";
            // 
            // bookingid
            // 
            this.bookingid.HeaderText = "Booking ID";
            this.bookingid.Name = "bookingid";
            // 
            // guestname
            // 
            this.guestname.HeaderText = "Guest Name";
            this.guestname.Name = "guestname";
            // 
            // roomno
            // 
            this.roomno.HeaderText = "Room No";
            this.roomno.Name = "roomno";
            // 
            // employeename
            // 
            this.employeename.HeaderText = "Employee Name";
            this.employeename.Name = "employeename";
            // 
            // payment
            // 
            this.payment.HeaderText = "Payment";
            this.payment.Name = "payment";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // Viewpaymentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 505);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Name = "Viewpaymentform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : View PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingid;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestname;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomno;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeename;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}