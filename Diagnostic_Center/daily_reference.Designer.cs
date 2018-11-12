namespace Diagnostic_Center
{
    partial class daily_reference
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.referanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet11 = new Diagnostic_Center.DataSet11();
            this.referanceTableAdapter = new Diagnostic_Center.DataSet11TableAdapters.referanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.referanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet11";
            reportDataSource1.Value = this.referanceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report12.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(775, 457);
            this.reportViewer1.TabIndex = 2;
            // 
            // referanceBindingSource
            // 
            this.referanceBindingSource.DataMember = "referance";
            this.referanceBindingSource.DataSource = this.DataSet11;
            // 
            // DataSet11
            // 
            this.DataSet11.DataSetName = "DataSet11";
            this.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // referanceTableAdapter
            // 
            this.referanceTableAdapter.ClearBeforeFill = true;
            // 
            // daily_reference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 489);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "daily_reference";
            this.Text = "daily_reference";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.daily_reference_Load);
            ((System.ComponentModel.ISupportInitialize)(this.referanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource referanceBindingSource;
        private DataSet11 DataSet11;
        private DataSet11TableAdapters.referanceTableAdapter referanceTableAdapter;
    }
}