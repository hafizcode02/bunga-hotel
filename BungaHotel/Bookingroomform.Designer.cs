namespace BungaHotel
{
    partial class Bookingroomform
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_check = new System.Windows.Forms.Button();
            this.cidate = new System.Windows.Forms.DateTimePicker();
            this.roomtype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.qty = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.addfacility = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.longstay = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.TextBox();
            this.hour = new System.Windows.Forms.TextBox();
            this.cidatetime = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.roomnumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guestnameemail = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.linkrefresh = new System.Windows.Forms.LinkLabel();
            this.linkadg = new System.Windows.Forms.LinkLabel();
            this.guestid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bookingtype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.roomfloor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roomprice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.facilitytotalprice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.alltotalprice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfasilitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namafasilitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceasli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Semerbak Bunga Hotel : Booking Room Form";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(this.cidate);
            this.panel1.Controls.Add(this.roomtype);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 111);
            this.panel1.TabIndex = 6;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(241, 83);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 9;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // cidate
            // 
            this.cidate.Location = new System.Drawing.Point(116, 60);
            this.cidate.Name = "cidate";
            this.cidate.Size = new System.Drawing.Size(200, 20);
            this.cidate.TabIndex = 4;
            // 
            // roomtype
            // 
            this.roomtype.FormattingEnabled = true;
            this.roomtype.Location = new System.Drawing.Point(116, 33);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(200, 21);
            this.roomtype.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Check In Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check Room Availability";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.dg);
            this.panel2.Controls.Add(this.qty);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.addfacility);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.longstay);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.minute);
            this.panel2.Controls.Add(this.hour);
            this.panel2.Controls.Add(this.cidatetime);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.roomnumber);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.guestnameemail);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.linkrefresh);
            this.panel2.Controls.Add(this.linkadg);
            this.panel2.Controls.Add(this.guestid);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.bookingtype);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(16, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 393);
            this.panel2.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(254, 214);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.idfasilitas,
            this.namafasilitas,
            this.price,
            this.totalitem,
            this.priceasli,
            this.delete});
            this.dg.Location = new System.Drawing.Point(11, 245);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(539, 136);
            this.dg.TabIndex = 24;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(137, 216);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(48, 20);
            this.qty.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 219);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "Qty";
            // 
            // addfacility
            // 
            this.addfacility.FormattingEnabled = true;
            this.addfacility.Location = new System.Drawing.Point(137, 189);
            this.addfacility.Name = "addfacility";
            this.addfacility.Size = new System.Drawing.Size(151, 21);
            this.addfacility.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 193);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "Additional Facility";
            // 
            // longstay
            // 
            this.longstay.Location = new System.Drawing.Point(137, 163);
            this.longstay.Name = "longstay";
            this.longstay.Size = new System.Drawing.Size(48, 20);
            this.longstay.TabIndex = 19;
            this.longstay.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 166);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "Long Stay";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(369, 141);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(10, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = ":";
            // 
            // minute
            // 
            this.minute.Location = new System.Drawing.Point(380, 137);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(24, 20);
            this.minute.TabIndex = 16;
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(343, 137);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(24, 20);
            this.hour.TabIndex = 15;
            // 
            // cidatetime
            // 
            this.cidatetime.Location = new System.Drawing.Point(137, 137);
            this.cidatetime.Name = "cidatetime";
            this.cidatetime.Size = new System.Drawing.Size(200, 20);
            this.cidatetime.TabIndex = 10;
            this.cidatetime.ValueChanged += new System.EventHandler(this.cidatetime_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 141);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Check-In Date - Hour";
            // 
            // roomnumber
            // 
            this.roomnumber.Location = new System.Drawing.Point(137, 111);
            this.roomnumber.Name = "roomnumber";
            this.roomnumber.Size = new System.Drawing.Size(119, 20);
            this.roomnumber.TabIndex = 13;
            this.roomnumber.TextChanged += new System.EventHandler(this.roomnumber_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Room Number";
            // 
            // guestnameemail
            // 
            this.guestnameemail.FormattingEnabled = true;
            this.guestnameemail.Location = new System.Drawing.Point(137, 84);
            this.guestnameemail.Name = "guestnameemail";
            this.guestnameemail.Size = new System.Drawing.Size(254, 21);
            this.guestnameemail.TabIndex = 11;
            this.guestnameemail.SelectedIndexChanged += new System.EventHandler(this.guestnameemail_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Guest Name - Email";
            // 
            // linkrefresh
            // 
            this.linkrefresh.AutoSize = true;
            this.linkrefresh.Location = new System.Drawing.Point(347, 64);
            this.linkrefresh.Name = "linkrefresh";
            this.linkrefresh.Size = new System.Drawing.Size(44, 13);
            this.linkrefresh.TabIndex = 9;
            this.linkrefresh.TabStop = true;
            this.linkrefresh.Text = "Refresh";
            this.linkrefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkrefresh_LinkClicked);
            // 
            // linkadg
            // 
            this.linkadg.AutoSize = true;
            this.linkadg.Location = new System.Drawing.Point(263, 64);
            this.linkadg.Name = "linkadg";
            this.linkadg.Size = new System.Drawing.Size(82, 13);
            this.linkadg.TabIndex = 8;
            this.linkadg.TabStop = true;
            this.linkadg.Text = "Add New Guest";
            this.linkadg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkadg_LinkClicked);
            // 
            // guestid
            // 
            this.guestid.Location = new System.Drawing.Point(137, 58);
            this.guestid.Name = "guestid";
            this.guestid.Size = new System.Drawing.Size(119, 20);
            this.guestid.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Guest ID";
            // 
            // bookingtype
            // 
            this.bookingtype.FormattingEnabled = true;
            this.bookingtype.Location = new System.Drawing.Point(137, 31);
            this.bookingtype.Name = "bookingtype";
            this.bookingtype.Size = new System.Drawing.Size(176, 21);
            this.bookingtype.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Booking Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Booking Room";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.roomfloor);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(591, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 369);
            this.panel3.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(279, 232);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(138, 336);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 13);
            this.label27.TabIndex = 27;
            this.label27.Text = "Occupied";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(138, 306);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 26;
            this.label26.Text = "Available";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 306);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 13);
            this.label25.TabIndex = 25;
            this.label25.Text = "Note";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(196, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Repair";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(48, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Alvailable";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(48, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Occupied";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // roomfloor
            // 
            this.roomfloor.FormattingEnabled = true;
            this.roomfloor.Location = new System.Drawing.Point(64, 33);
            this.roomfloor.Name = "roomfloor";
            this.roomfloor.Size = new System.Drawing.Size(100, 21);
            this.roomfloor.TabIndex = 5;
            this.roomfloor.SelectedIndexChanged += new System.EventHandler(this.roomfloor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Floor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room Map";
            // 
            // roomprice
            // 
            this.roomprice.Location = new System.Drawing.Point(788, 410);
            this.roomprice.Name = "roomprice";
            this.roomprice.Size = new System.Drawing.Size(119, 20);
            this.roomprice.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(608, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Room Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(759, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Rp.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(759, 439);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Rp.";
            // 
            // facilitytotalprice
            // 
            this.facilitytotalprice.Location = new System.Drawing.Point(788, 436);
            this.facilitytotalprice.Name = "facilitytotalprice";
            this.facilitytotalprice.Size = new System.Drawing.Size(119, 20);
            this.facilitytotalprice.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(608, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Total Additional Facility Price";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(759, 491);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Rp.";
            // 
            // alltotalprice
            // 
            this.alltotalprice.Location = new System.Drawing.Point(788, 488);
            this.alltotalprice.Name = "alltotalprice";
            this.alltotalprice.Size = new System.Drawing.Size(119, 20);
            this.alltotalprice.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(608, 491);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Total Price";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(759, 465);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Rp.";
            // 
            // tax
            // 
            this.tax.Location = new System.Drawing.Point(788, 462);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(119, 20);
            this.tax.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(608, 465);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Tax";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(832, 522);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.Name = "no";
            // 
            // idfasilitas
            // 
            this.idfasilitas.HeaderText = "Facility  ID";
            this.idfasilitas.Name = "idfasilitas";
            this.idfasilitas.Visible = false;
            // 
            // namafasilitas
            // 
            this.namafasilitas.HeaderText = "Additional Facility Name";
            this.namafasilitas.Name = "namafasilitas";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // totalitem
            // 
            this.totalitem.HeaderText = "totalitem";
            this.totalitem.Name = "totalitem";
            this.totalitem.Visible = false;
            // 
            // priceasli
            // 
            this.priceasli.HeaderText = "Price Asli";
            this.priceasli.Name = "priceasli";
            this.priceasli.Visible = false;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // Bookingroomform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 557);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.alltotalprice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.facilitytotalprice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.roomprice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "Bookingroomform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : Booking Room Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomtype;
        private System.Windows.Forms.DateTimePicker cidate;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox roomfloor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox bookingtype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox guestid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkrefresh;
        private System.Windows.Forms.LinkLabel linkadg;
        private System.Windows.Forms.ComboBox guestnameemail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox roomnumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox roomprice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox facilitytotalprice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox alltotalprice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tax;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DateTimePicker cidatetime;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox minute;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox longstay;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox addfacility;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfasilitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn namafasilitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceasli;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}