namespace Diagnostic_Center
{
    partial class user_Account
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
            this.reference_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet20 = new Diagnostic_Center.DataSet20();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.user_cash_collection_pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet16 = new Diagnostic_Center.DataSet16();
            this.DataSet1 = new Diagnostic_Center.DataSet1();
            this.diagnostic_billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnostic_billTableAdapter = new Diagnostic_Center.DataSet1TableAdapters.diagnostic_billTableAdapter();
            this.user_cash_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_cash_collectionTableAdapter = new Diagnostic_Center.DataSet1TableAdapters.user_cash_collectionTableAdapter();
            this.user_cash_collection_pharmacyTableAdapter = new Diagnostic_Center.DataSet16TableAdapters.user_cash_collection_pharmacyTableAdapter();
            this.diagnostic_user_accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet18 = new Diagnostic_Center.DataSet18();
            this.hospital_user_accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_cash_collection_OPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnostic_user_accountTableAdapter = new Diagnostic_Center.DataSet18TableAdapters.diagnostic_user_accountTableAdapter();
            this.hospital_user_accountTableAdapter = new Diagnostic_Center.DataSet18TableAdapters.hospital_user_accountTableAdapter();
            this.user_OPDTableAdapter = new Diagnostic_Center.DataSet18TableAdapters.user_OPDTableAdapter();
            this.user_pharmacyTableAdapter = new Diagnostic_Center.DataSet18TableAdapters.user_pharmacyTableAdapter();
            this.hospital_due_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_due_collectionTableAdapter = new Diagnostic_Center.DataSet18TableAdapters.hospital_due_collectionTableAdapter();
            this.opd_due_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opd_due_collectionTableAdapter = new Diagnostic_Center.DataSet18TableAdapters.opd_due_collectionTableAdapter();
            this.reference_listTableAdapter = new Diagnostic_Center.DataSet20TableAdapters.reference_listTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reference_listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnostic_billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnostic_user_accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_user_accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_due_collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_due_collectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reference_listBindingSource
            // 
            this.reference_listBindingSource.DataMember = "reference_list";
            this.reference_listBindingSource.DataSource = this.DataSet20;
            // 
            // DataSet20
            // 
            this.DataSet20.DataSetName = "DataSet20";
            this.DataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet18";
            reportDataSource1.Value = this.diagnostic_user_accountBindingSource;
            reportDataSource2.Name = "DataSet18a";
            reportDataSource2.Value = this.hospital_user_accountBindingSource;
            reportDataSource3.Name = "DataSet18b";
            reportDataSource3.Value = this.user_cash_collection_OPDBindingSource;
            reportDataSource4.Name = "DataSet18c";
            reportDataSource4.Value = this.user_cash_collection_pharmacyBindingSource;
            reportDataSource5.Name = "DataSet18d";
            reportDataSource5.Value = this.hospital_due_collectionBindingSource;
            reportDataSource6.Name = "DataSet18e";
            reportDataSource6.Value = this.opd_due_collectionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report20.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(690, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select User:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_cash_collection_pharmacyBindingSource
            // 
            this.user_cash_collection_pharmacyBindingSource.DataMember = "user_cash_collection_pharmacy";
            this.user_cash_collection_pharmacyBindingSource.DataSource = this.DataSet16;
            // 
            // DataSet16
            // 
            this.DataSet16.DataSetName = "DataSet16";
            this.DataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnostic_billBindingSource
            // 
            this.diagnostic_billBindingSource.DataMember = "diagnostic_bill";
            this.diagnostic_billBindingSource.DataSource = this.DataSet1;
            // 
            // diagnostic_billTableAdapter
            // 
            this.diagnostic_billTableAdapter.ClearBeforeFill = true;
            // 
            // user_cash_collectionBindingSource
            // 
            this.user_cash_collectionBindingSource.DataMember = "user_cash_collection";
            this.user_cash_collectionBindingSource.DataSource = this.DataSet1;
            // 
            // user_cash_collectionTableAdapter
            // 
            this.user_cash_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // user_cash_collection_pharmacyTableAdapter
            // 
            this.user_cash_collection_pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // diagnostic_user_accountBindingSource
            // 
            this.diagnostic_user_accountBindingSource.DataMember = "diagnostic_user_account";
            this.diagnostic_user_accountBindingSource.DataSource = this.DataSet18;
            // 
            // DataSet18
            // 
            this.DataSet18.DataSetName = "DataSet18";
            this.DataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospital_user_accountBindingSource
            // 
            this.hospital_user_accountBindingSource.DataMember = "hospital_user_account";
            this.hospital_user_accountBindingSource.DataSource = this.DataSet18;
            // 
            // user_cash_collection_OPDBindingSource
            // 
            this.user_cash_collection_OPDBindingSource.DataMember = "user_cash_collection_OPD";
            this.user_cash_collection_OPDBindingSource.DataSource = this.DataSet18;
            // 
            // diagnostic_user_accountTableAdapter
            // 
            this.diagnostic_user_accountTableAdapter.ClearBeforeFill = true;
            // 
            // hospital_user_accountTableAdapter
            // 
            this.hospital_user_accountTableAdapter.ClearBeforeFill = true;
            // 
            // user_OPDTableAdapter
            // 
            this.user_OPDTableAdapter.ClearBeforeFill = true;
            // 
            // user_pharmacyTableAdapter
            // 
            this.user_pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // hospital_due_collectionBindingSource
            // 
            this.hospital_due_collectionBindingSource.DataMember = "hospital_due_collection";
            this.hospital_due_collectionBindingSource.DataSource = this.DataSet18;
            // 
            // hospital_due_collectionTableAdapter
            // 
            this.hospital_due_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // opd_due_collectionBindingSource
            // 
            this.opd_due_collectionBindingSource.DataMember = "opd_due_collection";
            this.opd_due_collectionBindingSource.DataSource = this.DataSet18;
            // 
            // opd_due_collectionTableAdapter
            // 
            this.opd_due_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // reference_listTableAdapter
            // 
            this.reference_listTableAdapter.ClearBeforeFill = true;
            // 
            // user_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "user_Account";
            this.Text = "user_Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.user_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reference_listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnostic_billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnostic_user_accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_user_accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_due_collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_due_collectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource diagnostic_billBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource user_cash_collectionBindingSource;
        private DataSet1TableAdapters.diagnostic_billTableAdapter diagnostic_billTableAdapter;
        private DataSet1TableAdapters.user_cash_collectionTableAdapter user_cash_collectionTableAdapter;
        private System.Windows.Forms.BindingSource diagnostic_user_accountBindingSource;
        private DataSet18 DataSet18;
        private System.Windows.Forms.BindingSource hospital_user_accountBindingSource;
        private DataSet18TableAdapters.diagnostic_user_accountTableAdapter diagnostic_user_accountTableAdapter;
        private DataSet18TableAdapters.hospital_user_accountTableAdapter hospital_user_accountTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource user_cash_collection_pharmacyBindingSource;
        private DataSet16 DataSet16;
        private DataSet16TableAdapters.user_cash_collection_pharmacyTableAdapter user_cash_collection_pharmacyTableAdapter;
        private System.Windows.Forms.BindingSource user_cash_collection_OPDBindingSource;
        private DataSet18TableAdapters.user_OPDTableAdapter user_OPDTableAdapter;
        private DataSet18TableAdapters.user_pharmacyTableAdapter user_pharmacyTableAdapter;
        private System.Windows.Forms.BindingSource hospital_due_collectionBindingSource;
        private System.Windows.Forms.BindingSource opd_due_collectionBindingSource;
        private DataSet18TableAdapters.hospital_due_collectionTableAdapter hospital_due_collectionTableAdapter;
        private DataSet18TableAdapters.opd_due_collectionTableAdapter opd_due_collectionTableAdapter;
        private System.Windows.Forms.BindingSource reference_listBindingSource;
        private DataSet20 DataSet20;
        private DataSet20TableAdapters.reference_listTableAdapter reference_listTableAdapter;
    }
}