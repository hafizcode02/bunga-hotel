namespace BungaHotel
{
    partial class Inputpaymentform
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
            this.label3 = new System.Windows.Forms.Label();
            this.bookingid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.remainingpayment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Semerbak Bunga Hotel : Input Payment Form";
            // 
            // bookingid
            // 
            this.bookingid.FormattingEnabled = true;
            this.bookingid.Location = new System.Drawing.Point(161, 34);
            this.bookingid.Name = "bookingid";
            this.bookingid.Size = new System.Drawing.Size(200, 21);
            this.bookingid.TabIndex = 9;
            this.bookingid.SelectedIndexChanged += new System.EventHandler(this.bookingid_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Booking ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Rp.";
            // 
            // remainingpayment
            // 
            this.remainingpayment.Location = new System.Drawing.Point(239, 61);
            this.remainingpayment.Name = "remainingpayment";
            this.remainingpayment.Size = new System.Drawing.Size(119, 20);
            this.remainingpayment.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Remaining Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rp.";
            // 
            // payment
            // 
            this.payment.Location = new System.Drawing.Point(239, 87);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(119, 20);
            this.payment.TabIndex = 21;
            this.payment.TextChanged += new System.EventHandler(this.payment_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Rp.";
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(239, 113);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(119, 20);
            this.balance.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Balance";
            // 
            // pdate
            // 
            this.pdate.Location = new System.Drawing.Point(161, 139);
            this.pdate.Name = "pdate";
            this.pdate.Size = new System.Drawing.Size(200, 20);
            this.pdate.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Payment Date";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(286, 165);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 28;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // Inputpaymentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 196);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.pdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.remainingpayment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bookingid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Inputpaymentform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : Input Payment Form";
            this.Load += new System.EventHandler(this.Inputpaymentform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bookingid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox remainingpayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker pdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_submit;
    }
}