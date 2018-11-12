namespace Diagnostic_Center
{
    partial class Lab_Inventory_Print
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lab_inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet31 = new Diagnostic_Center.DataSet31();
            this.lab_inventoryTableAdapter = new Diagnostic_Center.DataSet31TableAdapters.lab_inventoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lab_inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet31)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet31";
            reportDataSource1.Value = this.lab_inventoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report37.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(662, 413);
            this.reportViewer1.TabIndex = 0;
            // 
            // lab_inventoryBindingSource
            // 
            this.lab_inventoryBindingSource.DataMember = "lab_inventory";
            this.lab_inventoryBindingSource.DataSource = this.DataSet31;
            // 
            // DataSet31
            // 
            this.DataSet31.DataSetName = "DataSet31";
            this.DataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lab_inventoryTableAdapter
            // 
            this.lab_inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // Lab_Inventory_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 413);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Lab_Inventory_Print";
            this.Text = "Lab_Inventory_Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lab_Inventory_Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab_inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet31)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lab_inventoryBindingSource;
        private DataSet31 DataSet31;
        private DataSet31TableAdapters.lab_inventoryTableAdapter lab_inventoryTableAdapter;
    }
}