namespace BungaHotel
{
    partial class Manageholidaypriceform
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
            this.end = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.begin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.percentage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbrt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fpercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begindate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.end);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.begin);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.percentage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbrt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 158);
            this.panel1.TabIndex = 17;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(132, 95);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(200, 20);
            this.end.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "End Date";
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(132, 69);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(200, 20);
            this.begin.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Begin Date";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(324, 119);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Add";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // percentage
            // 
            this.percentage.Location = new System.Drawing.Point(134, 122);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(111, 20);
            this.percentage.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Percentage";
            // 
            // cbrt
            // 
            this.cbrt.FormattingEnabled = true;
            this.cbrt.Location = new System.Drawing.Point(132, 42);
            this.cbrt.Name = "cbrt";
            this.cbrt.Size = new System.Drawing.Size(186, 21);
            this.cbrt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Room Type Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Daily Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Semerbak Bunga Hotel : Manage Holiday Price Form";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.roomtypeid,
            this.roomtypename,
            this.roomprice,
            this.fpercentage,
            this.finalprice,
            this.begindate,
            this.enddate,
            this.delete});
            this.dg.Location = new System.Drawing.Point(16, 227);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(764, 256);
            this.dg.TabIndex = 22;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(397, 194);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 21;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(139, 196);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(251, 20);
            this.search.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = " Search Holiday Price";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(708, 9);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 53;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
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
            // roomprice
            // 
            this.roomprice.HeaderText = "Room Price";
            this.roomprice.Name = "roomprice";
            // 
            // fpercentage
            // 
            this.fpercentage.HeaderText = "Percentage";
            this.fpercentage.Name = "fpercentage";
            // 
            // finalprice
            // 
            this.finalprice.HeaderText = "Final Price";
            this.finalprice.Name = "finalprice";
            // 
            // begindate
            // 
            this.begindate.HeaderText = "Begin Date";
            this.begindate.Name = "begindate";
            // 
            // enddate
            // 
            this.enddate.HeaderText = "End Date";
            this.enddate.Name = "enddate";
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // Manageholidaypriceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 495);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "Manageholidaypriceform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : Manage Holiday Price Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox percentage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbrt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker begin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypename;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fpercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn begindate;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}