namespace BungaHotel
{
    partial class Managedailypriceform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.breakfast = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.roomprice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbroom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbday = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipekamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipehari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daytypename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.froomprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fbreakfast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Semerbak Bunga Hotel : Manage Daily Price Form";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.breakfast);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.roomprice);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbroom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbday);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 170);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Rp.";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(295, 123);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Add";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // breakfast
            // 
            this.breakfast.Location = new System.Drawing.Point(162, 123);
            this.breakfast.Name = "breakfast";
            this.breakfast.Size = new System.Drawing.Size(111, 20);
            this.breakfast.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Breakfast Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Rp.";
            // 
            // roomprice
            // 
            this.roomprice.Location = new System.Drawing.Point(162, 97);
            this.roomprice.Name = "roomprice";
            this.roomprice.Size = new System.Drawing.Size(111, 20);
            this.roomprice.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Room Price";
            // 
            // cbroom
            // 
            this.cbroom.FormattingEnabled = true;
            this.cbroom.Location = new System.Drawing.Point(132, 43);
            this.cbroom.Name = "cbroom";
            this.cbroom.Size = new System.Drawing.Size(186, 21);
            this.cbroom.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Room Type Name";
            // 
            // cbday
            // 
            this.cbday.FormattingEnabled = true;
            this.cbday.Location = new System.Drawing.Point(132, 70);
            this.cbday.Name = "cbday";
            this.cbday.Size = new System.Drawing.Size(186, 21);
            this.cbday.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Day Type Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Daily Price";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(394, 208);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 20;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(136, 210);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(251, 20);
            this.search.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Search Daily Price";
            // 
            // dg
            // 
            this.dg.AllowUserToOrderColumns = true;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.idtipekamar,
            this.idtipehari,
            this.roomtypename,
            this.daytypename,
            this.froomprice,
            this.fbreakfast,
            this.Delete});
            this.dg.Location = new System.Drawing.Point(16, 240);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(795, 248);
            this.dg.TabIndex = 21;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.Name = "no";
            // 
            // idtipekamar
            // 
            this.idtipekamar.HeaderText = "Room Type ID";
            this.idtipekamar.Name = "idtipekamar";
            this.idtipekamar.Visible = false;
            // 
            // idtipehari
            // 
            this.idtipehari.HeaderText = "Day Type ID";
            this.idtipehari.Name = "idtipehari";
            this.idtipehari.Visible = false;
            // 
            // roomtypename
            // 
            this.roomtypename.HeaderText = "Room Type Name";
            this.roomtypename.Name = "roomtypename";
            // 
            // daytypename
            // 
            this.daytypename.HeaderText = "Day Type Name";
            this.daytypename.Name = "daytypename";
            this.daytypename.Visible = false;
            // 
            // froomprice
            // 
            this.froomprice.HeaderText = "Room Price";
            this.froomprice.Name = "froomprice";
            // 
            // fbreakfast
            // 
            this.fbreakfast.HeaderText = "Breakfast Price";
            this.fbreakfast.Name = "fbreakfast";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(740, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 53;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Managedailypriceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 500);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg);
            this.Name = "Managedailypriceform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : Manage Daily Price Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox cbroom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox roomprice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox breakfast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipekamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipehari;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypename;
        private System.Windows.Forms.DataGridViewTextBoxColumn daytypename;
        private System.Windows.Forms.DataGridViewTextBoxColumn froomprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fbreakfast;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btn_refresh;
    }
}