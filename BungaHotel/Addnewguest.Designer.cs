﻿namespace BungaHotel
{
    partial class Addnewguest
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
            this.guestname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idcardnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.license = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbvt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add New Guest";
            // 
            // guestname
            // 
            this.guestname.Location = new System.Drawing.Point(123, 50);
            this.guestname.Name = "guestname";
            this.guestname.Size = new System.Drawing.Size(195, 20);
            this.guestname.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Guest Name";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(123, 76);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(250, 20);
            this.email.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // idcardnumber
            // 
            this.idcardnumber.Location = new System.Drawing.Point(123, 102);
            this.idcardnumber.Name = "idcardnumber";
            this.idcardnumber.Size = new System.Drawing.Size(195, 20);
            this.idcardnumber.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID Card Number";
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(123, 128);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(179, 20);
            this.phonenumber.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone Number";
            // 
            // license
            // 
            this.license.Location = new System.Drawing.Point(123, 154);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(100, 20);
            this.license.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vehicle License";
            // 
            // cbvt
            // 
            this.cbvt.FormattingEnabled = true;
            this.cbvt.Location = new System.Drawing.Point(123, 180);
            this.cbvt.Name = "cbvt";
            this.cbvt.Size = new System.Drawing.Size(119, 21);
            this.cbvt.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vehicle Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addnewguest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 247);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbvt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.license);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idcardnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guestname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Addnewguest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : Booking Room Form - Add New Guest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guestname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idcardnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox license;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbvt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}