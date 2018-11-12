namespace Diagnostic_Center
{
    partial class User_Single_Collection_Print
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
            this.user_cash_collection_hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet40 = new Diagnostic_Center.DataSet40();
            this.admissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet10 = new Diagnostic_Center.DataSet10();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.user_cash_collection_hospitalTableAdapter = new Diagnostic_Center.DataSet40TableAdapters.user_cash_collection_hospitalTableAdapter();
            this.admissionTableAdapter = new Diagnostic_Center.DataSet10TableAdapters.admissionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // user_cash_collection_hospitalBindingSource
            // 
            this.user_cash_collection_hospitalBindingSource.DataMember = "user_cash_collection_hospital";
            this.user_cash_collection_hospitalBindingSource.DataSource = this.DataSet40;
            // 
            // DataSet40
            // 
            this.DataSet40.DataSetName = "DataSet40";
            this.DataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admissionBindingSource
            // 
            this.admissionBindingSource.DataMember = "admission";
            this.admissionBindingSource.DataSource = this.DataSet10;
            // 
            // DataSet10
            // 
            this.DataSet10.DataSetName = "DataSet10";
            this.DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet40";
            reportDataSource1.Value = this.user_cash_collection_hospitalBindingSource;
            reportDataSource2.Name = "DataSet10";
            reportDataSource2.Value = this.admissionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report51.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(562, 374);
            this.reportViewer1.TabIndex = 0;
            // 
            // user_cash_collection_hospitalTableAdapter
            // 
            this.user_cash_collection_hospitalTableAdapter.ClearBeforeFill = true;
            // 
            // admissionTableAdapter
            // 
            this.admissionTableAdapter.ClearBeforeFill = true;
            // 
            // User_Single_Collection_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 374);
            this.Controls.Add(this.reportViewer1);
            this.Name = "User_Single_Collection_Print";
            this.Text = "User_Single_Collection_Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Single_Collection_Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource user_cash_collection_hospitalBindingSource;
        private DataSet40 DataSet40;
        private DataSet40TableAdapters.user_cash_collection_hospitalTableAdapter user_cash_collection_hospitalTableAdapter;
        private System.Windows.Forms.BindingSource admissionBindingSource;
        private DataSet10 DataSet10;
        private DataSet10TableAdapters.admissionTableAdapter admissionTableAdapter;
    }
}