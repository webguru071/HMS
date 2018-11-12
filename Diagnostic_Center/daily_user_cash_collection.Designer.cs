namespace Diagnostic_Center
{
    partial class daily_user_cash_collection
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet17 = new Diagnostic_Center.DataSet17();
            this.user_cash_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_cash_collectionTableAdapter = new Diagnostic_Center.DataSet17TableAdapters.user_cash_collectionTableAdapter();
            this.user_cash_collection_hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_cash_collection_hospitalTableAdapter = new Diagnostic_Center.DataSet17TableAdapters.user_cash_collection_hospitalTableAdapter();
            this.user_cash_collection_OPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_cash_collection_OPDTableAdapter = new Diagnostic_Center.DataSet17TableAdapters.user_cash_collection_OPDTableAdapter();
            this.user_cash_collection_pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_cash_collection_pharmacyTableAdapter = new Diagnostic_Center.DataSet17TableAdapters.user_cash_collection_pharmacyTableAdapter();
            this.opd_due_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opd_due_collectionTableAdapter = new Diagnostic_Center.DataSet17TableAdapters.opd_due_collectionTableAdapter();
            this.hospital_due_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_due_collectionTableAdapter = new Diagnostic_Center.DataSet17TableAdapters.hospital_due_collectionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_due_collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_due_collectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Print Sumarry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet17";
            reportDataSource1.Value = this.user_cash_collectionBindingSource;
            reportDataSource2.Name = "DataSet17a";
            reportDataSource2.Value = this.user_cash_collection_hospitalBindingSource;
            reportDataSource3.Name = "DataSet17b";
            reportDataSource3.Value = this.user_cash_collection_OPDBindingSource;
            reportDataSource4.Name = "DataSet17c";
            reportDataSource4.Value = this.user_cash_collection_pharmacyBindingSource;
            reportDataSource5.Name = "DataSet17d";
            reportDataSource5.Value = this.opd_due_collectionBindingSource;
            reportDataSource6.Name = "DataSet17e";
            reportDataSource6.Value = this.hospital_due_collectionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report18.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(715, 397);
            this.reportViewer1.TabIndex = 4;
            // 
            // DataSet17
            // 
            this.DataSet17.DataSetName = "DataSet17";
            this.DataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_cash_collectionBindingSource
            // 
            this.user_cash_collectionBindingSource.DataMember = "user_cash_collection";
            this.user_cash_collectionBindingSource.DataSource = this.DataSet17;
            // 
            // user_cash_collectionTableAdapter
            // 
            this.user_cash_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // user_cash_collection_hospitalBindingSource
            // 
            this.user_cash_collection_hospitalBindingSource.DataMember = "user_cash_collection_hospital";
            this.user_cash_collection_hospitalBindingSource.DataSource = this.DataSet17;
            // 
            // user_cash_collection_hospitalTableAdapter
            // 
            this.user_cash_collection_hospitalTableAdapter.ClearBeforeFill = true;
            // 
            // user_cash_collection_OPDBindingSource
            // 
            this.user_cash_collection_OPDBindingSource.DataMember = "user_cash_collection_OPD";
            this.user_cash_collection_OPDBindingSource.DataSource = this.DataSet17;
            // 
            // user_cash_collection_OPDTableAdapter
            // 
            this.user_cash_collection_OPDTableAdapter.ClearBeforeFill = true;
            // 
            // user_cash_collection_pharmacyBindingSource
            // 
            this.user_cash_collection_pharmacyBindingSource.DataMember = "user_cash_collection_pharmacy";
            this.user_cash_collection_pharmacyBindingSource.DataSource = this.DataSet17;
            // 
            // user_cash_collection_pharmacyTableAdapter
            // 
            this.user_cash_collection_pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // opd_due_collectionBindingSource
            // 
            this.opd_due_collectionBindingSource.DataMember = "opd_due_collection";
            this.opd_due_collectionBindingSource.DataSource = this.DataSet17;
            // 
            // opd_due_collectionTableAdapter
            // 
            this.opd_due_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // hospital_due_collectionBindingSource
            // 
            this.hospital_due_collectionBindingSource.DataMember = "hospital_due_collection";
            this.hospital_due_collectionBindingSource.DataSource = this.DataSet17;
            // 
            // hospital_due_collectionTableAdapter
            // 
            this.hospital_due_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // daily_user_cash_collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 472);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "daily_user_cash_collection";
            this.Text = "daily_user_cash_collection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.daily_user_cash_collection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_due_collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_due_collectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource user_cash_collectionBindingSource;
        private DataSet17 DataSet17;
        private System.Windows.Forms.BindingSource user_cash_collection_hospitalBindingSource;
        private System.Windows.Forms.BindingSource user_cash_collection_OPDBindingSource;
        private System.Windows.Forms.BindingSource user_cash_collection_pharmacyBindingSource;
        private System.Windows.Forms.BindingSource opd_due_collectionBindingSource;
        private System.Windows.Forms.BindingSource hospital_due_collectionBindingSource;
        private DataSet17TableAdapters.user_cash_collectionTableAdapter user_cash_collectionTableAdapter;
        private DataSet17TableAdapters.user_cash_collection_hospitalTableAdapter user_cash_collection_hospitalTableAdapter;
        private DataSet17TableAdapters.user_cash_collection_OPDTableAdapter user_cash_collection_OPDTableAdapter;
        private DataSet17TableAdapters.user_cash_collection_pharmacyTableAdapter user_cash_collection_pharmacyTableAdapter;
        private DataSet17TableAdapters.opd_due_collectionTableAdapter opd_due_collectionTableAdapter;
        private DataSet17TableAdapters.hospital_due_collectionTableAdapter hospital_due_collectionTableAdapter;
    }
}