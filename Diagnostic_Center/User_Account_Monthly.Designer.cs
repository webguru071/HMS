namespace Diagnostic_Center
{
    partial class User_Account_Monthly
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.user_cash_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet19 = new Diagnostic_Center.DataSet19();
            this.user_cash_collection_hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_cash_collection_OPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_cash_collection_pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.diagnostic_cash = new Diagnostic_Center.DataSet19TableAdapters.diagnostic_cash();
            this.hospital_cash = new Diagnostic_Center.DataSet19TableAdapters.hospital_cash();
            this.opd_cash = new Diagnostic_Center.DataSet19TableAdapters.opd_cash();
            this.pharmacy_cash = new Diagnostic_Center.DataSet19TableAdapters.pharmacy_cash();
            this.hospital_due_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_due_collectionTableAdapter = new Diagnostic_Center.DataSet19TableAdapters.hospital_due_collectionTableAdapter();
            this.opd_due_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opd_due_collectionTableAdapter = new Diagnostic_Center.DataSet19TableAdapters.opd_due_collectionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_due_collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_due_collectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // user_cash_collectionBindingSource
            // 
            this.user_cash_collectionBindingSource.DataMember = "user_cash_collection";
            this.user_cash_collectionBindingSource.DataSource = this.DataSet19;
            // 
            // DataSet19
            // 
            this.DataSet19.DataSetName = "DataSet19";
            this.DataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_cash_collection_hospitalBindingSource
            // 
            this.user_cash_collection_hospitalBindingSource.DataMember = "user_cash_collection_hospital";
            this.user_cash_collection_hospitalBindingSource.DataSource = this.DataSet19;
            // 
            // user_cash_collection_OPDBindingSource
            // 
            this.user_cash_collection_OPDBindingSource.DataMember = "user_cash_collection_OPD";
            this.user_cash_collection_OPDBindingSource.DataSource = this.DataSet19;
            // 
            // user_cash_collection_pharmacyBindingSource
            // 
            this.user_cash_collection_pharmacyBindingSource.DataMember = "user_cash_collection_pharmacy";
            this.user_cash_collection_pharmacyBindingSource.DataSource = this.DataSet19;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet9";
            reportDataSource1.Value = this.user_cash_collectionBindingSource;
            reportDataSource2.Name = "DataSet19a";
            reportDataSource2.Value = this.user_cash_collection_hospitalBindingSource;
            reportDataSource3.Name = "DataSet19b";
            reportDataSource3.Value = this.user_cash_collection_OPDBindingSource;
            reportDataSource4.Name = "DataSet19c";
            reportDataSource4.Value = this.user_cash_collection_pharmacyBindingSource;
            reportDataSource5.Name = "DataSet19d";
            reportDataSource5.Value = this.hospital_due_collectionBindingSource;
            reportDataSource6.Name = "DataSet19e";
            reportDataSource6.Value = this.opd_due_collectionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report21.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 408);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select User:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(417, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // diagnostic_cash
            // 
            this.diagnostic_cash.ClearBeforeFill = true;
            // 
            // hospital_cash
            // 
            this.hospital_cash.ClearBeforeFill = true;
            // 
            // opd_cash
            // 
            this.opd_cash.ClearBeforeFill = true;
            // 
            // pharmacy_cash
            // 
            this.pharmacy_cash.ClearBeforeFill = true;
            // 
            // hospital_due_collectionBindingSource
            // 
            this.hospital_due_collectionBindingSource.DataMember = "hospital_due_collection";
            this.hospital_due_collectionBindingSource.DataSource = this.DataSet19;
            // 
            // hospital_due_collectionTableAdapter
            // 
            this.hospital_due_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // opd_due_collectionBindingSource
            // 
            this.opd_due_collectionBindingSource.DataMember = "opd_due_collection";
            this.opd_due_collectionBindingSource.DataSource = this.DataSet19;
            // 
            // opd_due_collectionTableAdapter
            // 
            this.opd_due_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // User_Account_Monthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 469);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "User_Account_Monthly";
            this.Text = "User_Account_Monthly";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Account_Monthly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_due_collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_due_collectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource user_cash_collectionBindingSource;
        private DataSet19 DataSet19;
        private System.Windows.Forms.BindingSource user_cash_collection_hospitalBindingSource;
        private System.Windows.Forms.BindingSource user_cash_collection_OPDBindingSource;
        private System.Windows.Forms.BindingSource user_cash_collection_pharmacyBindingSource;
        private DataSet19TableAdapters.diagnostic_cash diagnostic_cash;
        private DataSet19TableAdapters.hospital_cash hospital_cash;
        private DataSet19TableAdapters.opd_cash opd_cash;
        private DataSet19TableAdapters.pharmacy_cash pharmacy_cash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource hospital_due_collectionBindingSource;
        private System.Windows.Forms.BindingSource opd_due_collectionBindingSource;
        private DataSet19TableAdapters.hospital_due_collectionTableAdapter hospital_due_collectionTableAdapter;
        private DataSet19TableAdapters.opd_due_collectionTableAdapter opd_due_collectionTableAdapter;



    }
}