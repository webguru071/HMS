namespace Diagnostic_Center
{
    partial class OPD_Print
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.user_cash_collection_OPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet36 = new Diagnostic_Center.DataSet36();
            this.opdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opd_billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_cash_collection_OPDTableAdapter = new Diagnostic_Center.DataSet36TableAdapters.user_cash_collection_OPDTableAdapter();
            this.opdTableAdapter = new Diagnostic_Center.DataSet36TableAdapters.opdTableAdapter();
            this.opd_billTableAdapter = new Diagnostic_Center.DataSet36TableAdapters.opd_billTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.user_cash_collection_OPDBindingSource;
            reportDataSource2.Name = "DataSet10";
            reportDataSource2.Value = this.opdBindingSource;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.opd_billBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report43.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(610, 389);
            this.reportViewer1.TabIndex = 0;
            // 
            // user_cash_collection_OPDBindingSource
            // 
            this.user_cash_collection_OPDBindingSource.DataMember = "user_cash_collection_OPD";
            this.user_cash_collection_OPDBindingSource.DataSource = this.DataSet36;
            // 
            // DataSet36
            // 
            this.DataSet36.DataSetName = "DataSet36";
            this.DataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opdBindingSource
            // 
            this.opdBindingSource.DataMember = "opd";
            this.opdBindingSource.DataSource = this.DataSet36;
            // 
            // opd_billBindingSource
            // 
            this.opd_billBindingSource.DataMember = "opd_bill";
            this.opd_billBindingSource.DataSource = this.DataSet36;
            // 
            // user_cash_collection_OPDTableAdapter
            // 
            this.user_cash_collection_OPDTableAdapter.ClearBeforeFill = true;
            // 
            // opdTableAdapter
            // 
            this.opdTableAdapter.ClearBeforeFill = true;
            // 
            // opd_billTableAdapter
            // 
            this.opd_billTableAdapter.ClearBeforeFill = true;
            // 
            // OPD_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 389);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OPD_Print";
            this.Text = "OPD_Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OPD_Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource user_cash_collection_OPDBindingSource;
        private DataSet36 DataSet36;
        private System.Windows.Forms.BindingSource opdBindingSource;
        private DataSet36TableAdapters.user_cash_collection_OPDTableAdapter user_cash_collection_OPDTableAdapter;
        private DataSet36TableAdapters.opdTableAdapter opdTableAdapter;
        private System.Windows.Forms.BindingSource opd_billBindingSource;
        private DataSet36TableAdapters.opd_billTableAdapter opd_billTableAdapter;
    }
}