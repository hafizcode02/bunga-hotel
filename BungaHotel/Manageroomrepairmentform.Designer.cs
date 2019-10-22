namespace BungaHotel
{
    partial class Manageroomrepairmentform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.note = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.begindate = new System.Windows.Forms.DateTimePicker();
            this.cbrn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finish = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.note);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.enddate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.begindate);
            this.panel1.Controls.Add(this.cbrn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 148);
            this.panel1.TabIndex = 14;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(433, 39);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(245, 48);
            this.note.TabIndex = 21;
            this.note.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Note";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(599, 97);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Add";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(127, 93);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(200, 20);
            this.enddate.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "End Date";
            // 
            // begindate
            // 
            this.begindate.Location = new System.Drawing.Point(127, 67);
            this.begindate.Name = "begindate";
            this.begindate.Size = new System.Drawing.Size(200, 20);
            this.begindate.TabIndex = 14;
            // 
            // cbrn
            // 
            this.cbrn.FormattingEnabled = true;
            this.cbrn.Location = new System.Drawing.Point(128, 39);
            this.cbrn.Name = "cbrn";
            this.cbrn.Size = new System.Drawing.Size(136, 21);
            this.cbrn.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Room Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Begin Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Room to be Repair in Schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Semerbak Bunga Hotel : Manage Room Repairment Form";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.roomid,
            this.rtn,
            this.rn,
            this.floor,
            this.bd,
            this.ed,
            this.rb,
            this.nt,
            this.finish});
            this.dg.Location = new System.Drawing.Point(16, 232);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(764, 270);
            this.dg.TabIndex = 18;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(397, 199);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 17;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(139, 201);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(251, 20);
            this.search.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = " Search Room Facility";
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.Name = "no";
            // 
            // roomid
            // 
            this.roomid.HeaderText = "Room ID";
            this.roomid.Name = "roomid";
            this.roomid.Visible = false;
            // 
            // rtn
            // 
            this.rtn.HeaderText = "Room Type Name";
            this.rtn.Name = "rtn";
            // 
            // rn
            // 
            this.rn.HeaderText = "Room No";
            this.rn.Name = "rn";
            // 
            // floor
            // 
            this.floor.HeaderText = "Floor";
            this.floor.Name = "floor";
            // 
            // bd
            // 
            this.bd.HeaderText = "Begin Date";
            this.bd.Name = "bd";
            // 
            // ed
            // 
            this.ed.HeaderText = "End Date";
            this.ed.Name = "ed";
            // 
            // rb
            // 
            this.rb.HeaderText = "Repaired By";
            this.rb.Name = "rb";
            // 
            // nt
            // 
            this.nt.HeaderText = "Note";
            this.nt.Name = "nt";
            // 
            // finish
            // 
            this.finish.HeaderText = "Finish";
            this.finish.Name = "finish";
            this.finish.Text = "Finish";
            this.finish.UseColumnTextForButtonValue = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(706, 7);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 54;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Manageroomrepairmentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 513);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label4);
            this.Name = "Manageroomrepairmentform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : Manage Room Repairment Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox cbrn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker begindate;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ed;
        private System.Windows.Forms.DataGridViewTextBoxColumn rb;
        private System.Windows.Forms.DataGridViewTextBoxColumn nt;
        private System.Windows.Forms.DataGridViewButtonColumn finish;
        private System.Windows.Forms.Button btn_refresh;
    }
}