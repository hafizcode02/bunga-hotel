namespace BungaHotel
{
    partial class Transactionreport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TestingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Report = new BungaHotel.Report();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.begindate = new System.Windows.Forms.DateTimePicker();
            this.cbrt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TestingTableAdapter = new BungaHotel.ReportTableAdapters.TestingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TestingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).BeginInit();
            this.SuspendLayout();
            // 
            // TestingBindingSource
            // 
            this.TestingBindingSource.DataMember = "Testing";
            this.TestingBindingSource.DataSource = this.Report;
            // 
            // Report
            // 
            this.Report.DataSetName = "Report";
            this.Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(112, 66);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(200, 20);
            this.enddate.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "End Date";
            // 
            // begindate
            // 
            this.begindate.Location = new System.Drawing.Point(112, 40);
            this.begindate.Name = "begindate";
            this.begindate.Size = new System.Drawing.Size(200, 20);
            this.begindate.TabIndex = 21;
            // 
            // cbrt
            // 
            this.cbrt.FormattingEnabled = true;
            this.cbrt.Location = new System.Drawing.Point(112, 92);
            this.cbrt.Name = "cbrt";
            this.cbrt.Size = new System.Drawing.Size(136, 21);
            this.cbrt.TabIndex = 19;
            this.cbrt.SelectedIndexChanged += new System.EventHandler(this.cbrt_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Room Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Begin Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Semerbak Bunga Hotel : Transaction Report";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TestingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BungaHotel.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(371, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(454, 400);
            this.reportViewer1.TabIndex = 25;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // TestingTableAdapter
            // 
            this.TestingTableAdapter.ClearBeforeFill = true;
            // 
            // Transactionreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 484);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.begindate);
            this.Controls.Add(this.cbrt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "Transactionreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semerbak Bunga Hotel : Transaction Report";
            this.Load += new System.EventHandler(this.Transactionreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TestingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker begindate;
        private System.Windows.Forms.ComboBox cbrt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TestingBindingSource;
        private Report Report;
        private ReportTableAdapters.TestingTableAdapter TestingTableAdapter;
    }
}