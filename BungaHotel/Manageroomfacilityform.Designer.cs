namespace BungaHotel
{
    partial class Manageroomfacilityform
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
            this.btn_add = new System.Windows.Forms.Button();
            this.cbroomfacility = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbfacility = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfasilitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.label3.Size = new System.Drawing.Size(410, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Semerbak Bunga Hotel : Manage Room Facility Form";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.cbroomfacility);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbfacility);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 125);
            this.panel1.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(327, 68);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbroomfacility
            // 
            this.cbroomfacility.FormattingEnabled = true;
            this.cbroomfacility.Location = new System.Drawing.Point(110, 43);
            this.cbroomfacility.Name = "cbroomfacility";
            this.cbroomfacility.Size = new System.Drawing.Size(204, 21);
            this.cbroomfacility.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Room Type Name";
            // 
            // cbfacility
            // 
            this.cbfacility.FormattingEnabled = true;
            this.cbfacility.Location = new System.Drawing.Point(110, 70);
            this.cbfacility.Name = "cbfacility";
            this.cbfacility.Size = new System.Drawing.Size(204, 21);
            this.cbfacility.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Facility  Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Facility Into Room";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(397, 183);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 11;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(139, 185);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(251, 20);
            this.search.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = " Search Room Facility";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.idfasilitas,
            this.roomtypeid,
            this.roomtypename,
            this.roomno,
            this.floor,
            this.facility,
            this.delete});
            this.dg.Location = new System.Drawing.Point(16, 216);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(764, 270);
            this.dg.TabIndex = 12;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.Name = "no";
            // 
            // idfasilitas
            // 
            this.idfasilitas.HeaderText = "Facility Name ID";
            this.idfasilitas.Name = "idfasilitas";
            this.idfasilitas.Visible = false;
            // 
            // roomtypeid
            // 
            this.roomtypeid.HeaderText = "Room Type ID";
            this.roomtypeid.Name = "roomtypeid";
            this.roomtypeid.Visible = false;
            // 
            // roomtypename
            // 
            this.roomtypename.HeaderText = "Room Type Name";
            this.roomtypename.Name = "roomtypename";
            // 
            // roomno
            // 
            this.roomno.HeaderText = "Room No";
            this.roomno.Name = "roomno";
            // 
            // floor
            // 
            this.floor.HeaderText = "Room Floor";
            this.floor.Name = "floor";
            // 
            // facility
            // 
            this.facility.HeaderText = "Facility";
            this.facility.Name = "facility";
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // Manageroomfacilityform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 498);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "Manageroomfacilityform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : Manage Room Facility Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbroomfacility;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbfacility;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfasilitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypename;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomno;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn facility;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}