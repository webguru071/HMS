namespace Diagnostic_Center
{
    partial class Monthly_Opd_Account
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.user_cash_collection_OPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet38 = new Diagnostic_Center.DataSet38();
            this.user_cash_collection_OPDTableAdapter = new Diagnostic_Center.DataSet38TableAdapters.user_cash_collection_OPDTableAdapter();
            this.opd_due_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opd_due_collectionTableAdapter = new Diagnostic_Center.DataSet38TableAdapters.opd_due_collectionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_due_collectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet38";
            reportDataSource1.Value = this.user_cash_collection_OPDBindingSource;
            reportDataSource2.Name = "DataSet38a";
            reportDataSource2.Value = this.opd_due_collectionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report45.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(542, 325);
            this.reportViewer1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(158, 9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_cash_collection_OPDBindingSource
            // 
            this.user_cash_collection_OPDBindingSource.DataMember = "user_cash_collection_OPD";
            this.user_cash_collection_OPDBindingSource.DataSource = this.DataSet38;
            // 
            // DataSet38
            // 
            this.DataSet38.DataSetName = "DataSet38";
            this.DataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_cash_collection_OPDTableAdapter
            // 
            this.user_cash_collection_OPDTableAdapter.ClearBeforeFill = true;
            // 
            // opd_due_collectionBindingSource
            // 
            this.opd_due_collectionBindingSource.DataMember = "opd_due_collection";
            this.opd_due_collectionBindingSource.DataSource = this.DataSet38;
            // 
            // opd_due_collectionTableAdapter
            // 
            this.opd_due_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // Monthly_Opd_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Monthly_Opd_Account";
            this.Text = "Monthly_Opd_Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Monthly_Opd_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_OPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opd_due_collectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource user_cash_collection_OPDBindingSource;
        private DataSet38 DataSet38;
        private DataSet38TableAdapters.user_cash_collection_OPDTableAdapter user_cash_collection_OPDTableAdapter;
        private System.Windows.Forms.BindingSource opd_due_collectionBindingSource;
        private DataSet38TableAdapters.opd_due_collectionTableAdapter opd_due_collectionTableAdapter;
    }
}