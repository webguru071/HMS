namespace Diagnostic_Center
{
    partial class Print_Medicine_Stock
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet39 = new Diagnostic_Center.DataSet39();
            this.medicine_pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicine_pharmacyTableAdapter = new Diagnostic_Center.DataSet39TableAdapters.medicine_pharmacyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicine_pharmacyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet39";
            reportDataSource2.Value = this.medicine_pharmacyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report46.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(606, 358);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet39
            // 
            this.DataSet39.DataSetName = "DataSet39";
            this.DataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicine_pharmacyBindingSource
            // 
            this.medicine_pharmacyBindingSource.DataMember = "medicine_pharmacy";
            this.medicine_pharmacyBindingSource.DataSource = this.DataSet39;
            // 
            // medicine_pharmacyTableAdapter
            // 
            this.medicine_pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // Print_Medicine_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 358);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Print_Medicine_Stock";
            this.Text = "Print_Medicine_Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Print_Medicine_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicine_pharmacyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource medicine_pharmacyBindingSource;
        private DataSet39 DataSet39;
        private DataSet39TableAdapters.medicine_pharmacyTableAdapter medicine_pharmacyTableAdapter;
    }
}