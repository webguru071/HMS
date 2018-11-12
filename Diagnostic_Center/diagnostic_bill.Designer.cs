namespace Diagnostic_Center
{
    partial class diagnostic_bill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.diagnostic_billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Diagnostic_Center.DataSet1();
            this.user_cash_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.diagnostic_billTableAdapter = new Diagnostic_Center.DataSet1TableAdapters.diagnostic_billTableAdapter();
            this.user_cash_collectionTableAdapter = new Diagnostic_Center.DataSet1TableAdapters.user_cash_collectionTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diagnostic_billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnostic_billBindingSource
            // 
            this.diagnostic_billBindingSource.DataMember = "diagnostic_bill";
            this.diagnostic_billBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_cash_collectionBindingSource
            // 
            this.user_cash_collectionBindingSource.DataMember = "user_cash_collection";
            this.user_cash_collectionBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.diagnostic_billBindingSource;
            reportDataSource4.Name = "DataSet1a";
            reportDataSource4.Value = this.user_cash_collectionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(698, 471);
            this.reportViewer1.TabIndex = 0;
            // 
            // diagnostic_billTableAdapter
            // 
            this.diagnostic_billTableAdapter.ClearBeforeFill = true;
            // 
            // user_cash_collectionTableAdapter
            // 
            this.user_cash_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xerox Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diagnostic_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "diagnostic_bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "diagnostic_bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.diagnostic_bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnostic_billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource diagnostic_billBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.diagnostic_billTableAdapter diagnostic_billTableAdapter;
        private System.Windows.Forms.BindingSource user_cash_collectionBindingSource;
        private DataSet1TableAdapters.user_cash_collectionTableAdapter user_cash_collectionTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}