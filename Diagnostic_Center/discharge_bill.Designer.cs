namespace Diagnostic_Center
{
    partial class discharge_bill
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
            this.patient_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet9 = new Diagnostic_Center.DataSet9();
            this.discharge_paidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_cash_collection_hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet7 = new Diagnostic_Center.DataSet7();
    
            this.operation_monthBindingSource = new System.Windows.Forms.BindingSource(this.components);
      
            this.discharge_bill_monthBindingSource = new System.Windows.Forms.BindingSource(this.components);
     
            this.patient_infoTableAdapter = new Diagnostic_Center.DataSet9TableAdapters.patient_infoTableAdapter();
     
            this.patient_billTableAdapter = new Diagnostic_Center.DataSet9TableAdapters.patient_billTableAdapter();
            this.user_cash_collection_hospitalTableAdapter = new Diagnostic_Center.DataSet9TableAdapters.user_cash_collection_hospitalTableAdapter();
            this.admissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discharge_billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bed_billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.patient_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discharge_paidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operation_monthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discharge_bill_monthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discharge_billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bed_billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patient_infoBindingSource
            // 
            this.patient_infoBindingSource.DataMember = "patient_info";
            this.patient_infoBindingSource.DataSource = this.DataSet9;
            // 
            // DataSet9
            // 
            this.DataSet9.DataSetName = "DataSet9";
            this.DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discharge_paidBindingSource
            // 
            this.discharge_paidBindingSource.DataMember = "discharge_paid";
            this.discharge_paidBindingSource.DataSource = this.DataSet9;
            // 
            // patient_billBindingSource
            // 
            this.patient_billBindingSource.DataMember = "patient_bill";
            this.patient_billBindingSource.DataSource = this.DataSet9;
            // 
            // user_cash_collection_hospitalBindingSource
            // 
            this.user_cash_collection_hospitalBindingSource.DataMember = "user_cash_collection_hospital";
            this.user_cash_collection_hospitalBindingSource.DataSource = this.DataSet9;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.patient_infoBindingSource;
            reportDataSource2.Name = "DataSet9a";
            reportDataSource2.Value = this.discharge_paidBindingSource;
            reportDataSource3.Name = "DataSet9b";
            reportDataSource3.Value = this.patient_billBindingSource;
            reportDataSource4.Name = "DataSet9c";
            reportDataSource4.Value = this.user_cash_collection_hospitalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(843, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet7
            // 
            this.DataSet7.DataSetName = "DataSet7";
            this.DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bed_billTableAdapter
            // 
  
            // 
            // operation_monthBindingSource
            // 
            this.operation_monthBindingSource.DataMember = "operation_month";
            this.operation_monthBindingSource.DataSource = this.DataSet7;
            // 
            // operation_monthTableAdapter
            // 

            // 
            // discharge_bill_monthBindingSource
            // 
            this.discharge_bill_monthBindingSource.DataMember = "discharge_bill_month";
            this.discharge_bill_monthBindingSource.DataSource = this.DataSet7;
            // 
            // discharge_bill_monthTableAdapter
            // 
      
            // 
            // patient_infoTableAdapter
            // 
            this.patient_infoTableAdapter.ClearBeforeFill = true;
            // 
            // discharge_paidTableAdapter
            // 
           
            // 
            // patient_billTableAdapter
            // 
            this.patient_billTableAdapter.ClearBeforeFill = true;
            // 
            // user_cash_collection_hospitalTableAdapter
            // 
            this.user_cash_collection_hospitalTableAdapter.ClearBeforeFill = true;
            // 
            // admissionBindingSource
            // 
            this.admissionBindingSource.DataMember = "admission";
            // 
            // discharge_billBindingSource
            // 
            this.discharge_billBindingSource.DataMember = "discharge_bill";
            // 
            // operationBindingSource
            // 
            this.operationBindingSource.DataMember = "operation";
            // 
            // bed_billBindingSource
            // 
            this.bed_billBindingSource.DataMember = "bed_bill";
            // 
            // discharge_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 522);
            this.Controls.Add(this.reportViewer1);
            this.Name = "discharge_bill";
            this.Text = "discharge_bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.discharge_bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patient_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discharge_paidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operation_monthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discharge_bill_monthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discharge_billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bed_billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource admissionBindingSource;
       
        private System.Windows.Forms.BindingSource discharge_billBindingSource;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private System.Windows.Forms.BindingSource bed_billBindingSource;
        private System.Windows.Forms.BindingSource operation_monthBindingSource;
        private DataSet7 DataSet7;
        private System.Windows.Forms.BindingSource discharge_bill_monthBindingSource;
    
        private System.Windows.Forms.BindingSource patient_infoBindingSource;
        private DataSet9 DataSet9;
        private DataSet9TableAdapters.patient_infoTableAdapter patient_infoTableAdapter;
        private System.Windows.Forms.BindingSource discharge_paidBindingSource;
        private System.Windows.Forms.BindingSource patient_billBindingSource;
    
        private DataSet9TableAdapters.patient_billTableAdapter patient_billTableAdapter;
        private System.Windows.Forms.BindingSource user_cash_collection_hospitalBindingSource;
        private DataSet9TableAdapters.user_cash_collection_hospitalTableAdapter user_cash_collection_hospitalTableAdapter;
      
       
        
    }
}