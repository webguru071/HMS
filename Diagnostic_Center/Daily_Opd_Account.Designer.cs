namespace Diagnostic_Center
{
    partial class Daily_Opd_Account
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.user_cash_collection_OPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet37 = new Diagnostic_Center.DataSet37();
            this.dailyopdTableAdapter = new Diagnostic_Center.DataSet37TableAdapters.dailyopdTableAdapter();
            this.opd_due_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opd_due_collectionTableAdapter = new Diagnostic_Center.DataSet37TableAdapters.opd_due_collectionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_due_collectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet37";
            reportDataSource1.Value = this.user_cash_collection_OPDBindingSource;
            reportDataSource2.Name = "DataSet37a";
            reportDataSource2.Value = this.opd_due_collectionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report44.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 32);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(522, 280);
            this.reportViewer1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // user_cash_collection_OPDBindingSource
            // 
            this.user_cash_collection_OPDBindingSource.DataMember = "user_cash_collection_OPD";
            this.user_cash_collection_OPDBindingSource.DataSource = this.DataSet37;
            // 
            // DataSet37
            // 
            this.DataSet37.DataSetName = "DataSet37";
            this.DataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dailyopdTableAdapter
            // 
            this.dailyopdTableAdapter.ClearBeforeFill = true;
            // 
            // opd_due_collectionBindingSource
            // 
            this.opd_due_collectionBindingSource.DataMember = "opd_due_collection";
            this.opd_due_collectionBindingSource.DataSource = this.DataSet37;
            // 
            // opd_due_collectionTableAdapter
            // 
            this.opd_due_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // Daily_Opd_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 320);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Daily_Opd_Account";
            this.Text = "Daily_Opd_Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Daily_Opd_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_due_collectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource user_cash_collection_OPDBindingSource;
        private DataSet37 DataSet37;
        private DataSet37TableAdapters.dailyopdTableAdapter dailyopdTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource opd_due_collectionBindingSource;
        private DataSet37TableAdapters.opd_due_collectionTableAdapter opd_due_collectionTableAdapter;
    }
}