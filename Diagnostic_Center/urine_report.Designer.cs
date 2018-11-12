namespace Diagnostic_Center
{
    partial class urine_report
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
            this.urine_microBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet26 = new Diagnostic_Center.DataSet26();
            this.urine_physicalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urine_chemicalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnostic_personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.urine_microTableAdapter = new Diagnostic_Center.DataSet26TableAdapters.urine_microTableAdapter();
            this.urine_physicalTableAdapter = new Diagnostic_Center.DataSet26TableAdapters.urine_physicalTableAdapter();
            this.urine_chemicalTableAdapter = new Diagnostic_Center.DataSet26TableAdapters.urine_chemicalTableAdapter();
            this.diagnostic_personTableAdapter = new Diagnostic_Center.DataSet26TableAdapters.diagnostic_personTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.urine_microBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urine_physicalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urine_chemicalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnostic_personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // urine_microBindingSource
            // 
            this.urine_microBindingSource.DataMember = "urine_micro";
            this.urine_microBindingSource.DataSource = this.DataSet26;
            // 
            // DataSet26
            // 
            this.DataSet26.DataSetName = "DataSet26";
            this.DataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urine_physicalBindingSource
            // 
            this.urine_physicalBindingSource.DataMember = "urine_physical";
            this.urine_physicalBindingSource.DataSource = this.DataSet26;
            // 
            // urine_chemicalBindingSource
            // 
            this.urine_chemicalBindingSource.DataMember = "urine_chemical";
            this.urine_chemicalBindingSource.DataSource = this.DataSet26;
            // 
            // diagnostic_personBindingSource
            // 
            this.diagnostic_personBindingSource.DataMember = "diagnostic_person";
            this.diagnostic_personBindingSource.DataSource = this.DataSet26;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.DocumentMapWidth = 51;
            reportDataSource1.Name = "DataSet26";
            reportDataSource1.Value = this.urine_microBindingSource;
            reportDataSource2.Name = "DataSet26a";
            reportDataSource2.Value = this.urine_physicalBindingSource;
            reportDataSource3.Name = "DataSet26b";
            reportDataSource3.Value = this.urine_chemicalBindingSource;
            reportDataSource4.Name = "DataSet26c";
            reportDataSource4.Value = this.diagnostic_personBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report29.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(567, 333);
            this.reportViewer1.TabIndex = 0;
            // 
            // urine_microTableAdapter
            // 
            this.urine_microTableAdapter.ClearBeforeFill = true;
            // 
            // urine_physicalTableAdapter
            // 
            this.urine_physicalTableAdapter.ClearBeforeFill = true;
            // 
            // urine_chemicalTableAdapter
            // 
            this.urine_chemicalTableAdapter.ClearBeforeFill = true;
            // 
            // diagnostic_personTableAdapter
            // 
            this.diagnostic_personTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pathologist";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // urine_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "urine_report";
            this.Text = "urine_report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.urine_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urine_microBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urine_physicalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urine_chemicalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnostic_personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource urine_microBindingSource;
        private DataSet26 DataSet26;
        private System.Windows.Forms.BindingSource urine_physicalBindingSource;
        private System.Windows.Forms.BindingSource urine_chemicalBindingSource;
        private System.Windows.Forms.BindingSource diagnostic_personBindingSource;
        private DataSet26TableAdapters.urine_microTableAdapter urine_microTableAdapter;
        private DataSet26TableAdapters.urine_physicalTableAdapter urine_physicalTableAdapter;
        private DataSet26TableAdapters.urine_chemicalTableAdapter urine_chemicalTableAdapter;
        private DataSet26TableAdapters.diagnostic_personTableAdapter diagnostic_personTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}