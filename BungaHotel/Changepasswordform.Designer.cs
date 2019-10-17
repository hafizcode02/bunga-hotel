namespace BungaHotel
{
    partial class Changepasswordform
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
            this.newpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oldpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmnewpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(22, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Semerbak Bunga Hotel : Change Password Form";
            // 
            // newpassword
            // 
            this.newpassword.Location = new System.Drawing.Point(184, 94);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(261, 20);
            this.newpassword.TabIndex = 9;
            this.newpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Password";
            // 
            // oldpassword
            // 
            this.oldpassword.Location = new System.Drawing.Point(184, 61);
            this.oldpassword.Name = "oldpassword";
            this.oldpassword.Size = new System.Drawing.Size(261, 20);
            this.oldpassword.TabIndex = 7;
            this.oldpassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Old Password";
            // 
            // confirmnewpassword
            // 
            this.confirmnewpassword.Location = new System.Drawing.Point(184, 129);
            this.confirmnewpassword.Name = "confirmnewpassword";
            this.confirmnewpassword.Size = new System.Drawing.Size(261, 20);
            this.confirmnewpassword.TabIndex = 11;
            this.confirmnewpassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm New Password";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(370, 165);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Changepasswordform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 208);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.confirmnewpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "Changepasswordform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : Change Password Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmnewpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
    }
}