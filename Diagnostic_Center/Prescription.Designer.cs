namespace Diagnostic_Center
{
    partial class Prescription
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet22 = new Diagnostic_Center.DataSet22();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescriptionTableAdapter = new Diagnostic_Center.DataSet22TableAdapters.prescriptionTableAdapter();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new Diagnostic_Center.DataSet22TableAdapters.appointmentTableAdapter();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosisTableAdapter = new Diagnostic_Center.DataSet22TableAdapters.diagnosisTableAdapter();
            this.patient_testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_testTableAdapter = new Diagnostic_Center.DataSet22TableAdapters.patient_testTableAdapter();
            this.symptomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.symptomsTableAdapter = new Diagnostic_Center.DataSet22TableAdapters.symptomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet22";
            reportDataSource1.Value = this.prescriptionBindingSource;
            reportDataSource2.Name = "DataSet22a";
            reportDataSource2.Value = this.appointmentBindingSource;
            reportDataSource3.Name = "DataSet22b";
            reportDataSource3.Value = this.diagnosisBindingSource;
            reportDataSource4.Name = "DataSet22c";
            reportDataSource4.Value = this.patient_testBindingSource;
            reportDataSource5.Name = "DataSet22d";
            reportDataSource5.Value = this.symptomsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report24.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(742, 460);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet22
            // 
            this.DataSet22.DataSetName = "DataSet22";
            this.DataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "prescription";
            this.prescriptionBindingSource.DataSource = this.DataSet22;
            // 
            // prescriptionTableAdapter
            // 
            this.prescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.DataSet22;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataMember = "diagnosis";
            this.diagnosisBindingSource.DataSource = this.DataSet22;
            // 
            // diagnosisTableAdapter
            // 
            this.diagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // patient_testBindingSource
            // 
            this.patient_testBindingSource.DataMember = "patient_test";
            this.patient_testBindingSource.DataSource = this.DataSet22;
            // 
            // patient_testTableAdapter
            // 
            this.patient_testTableAdapter.ClearBeforeFill = true;
            // 
            // symptomsBindingSource
            // 
            this.symptomsBindingSource.DataMember = "symptoms";
            this.symptomsBindingSource.DataSource = this.DataSet22;
            // 
            // symptomsTableAdapter
            // 
            this.symptomsTableAdapter.ClearBeforeFill = true;
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 460);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private DataSet22 DataSet22;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private System.Windows.Forms.BindingSource patient_testBindingSource;
        private System.Windows.Forms.BindingSource symptomsBindingSource;
        private DataSet22TableAdapters.prescriptionTableAdapter prescriptionTableAdapter;
        private DataSet22TableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private DataSet22TableAdapters.diagnosisTableAdapter diagnosisTableAdapter;
        private DataSet22TableAdapters.patient_testTableAdapter patient_testTableAdapter;
        private DataSet22TableAdapters.symptomsTableAdapter symptomsTableAdapter;
    }
}