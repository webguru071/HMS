namespace Diagnostic_Center
{
    partial class Print_Purchase_List
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
            this.purchase_medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet45 = new Diagnostic_Center.DataSet45();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.purchase_medicineTableAdapter = new Diagnostic_Center.DataSet45TableAdapters.purchase_medicineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet45)).BeginInit();
            this.SuspendLayout();
            // 
            // purchase_medicineBindingSource
            // 
            this.purchase_medicineBindingSource.DataMember = "purchase_medicine";
            this.purchase_medicineBindingSource.DataSource = this.DataSet45;
            // 
            // DataSet45
            // 
            this.DataSet45.DataSetName = "DataSet45";
            this.DataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(157, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "To";
            // 
            // Load
            // 
            this.btn.Location = new System.Drawing.Point(276, 11);
            this.btn.Name = "Load";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 7;
            this.btn.Text = "Load";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.Load_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet45";
            reportDataSource2.Value = this.purchase_medicineBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report61.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(11, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(911, 476);
            this.reportViewer1.TabIndex = 11;
            // 
            // purchase_medicineTableAdapter
            // 
            this.purchase_medicineTableAdapter.ClearBeforeFill = true;
            // 
            // Print_Purchase_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 528);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Name = "Print_Purchase_List";
            this.Text = "Print_Purchase_List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Print_Purchase_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchase_medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet45)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource purchase_medicineBindingSource;
        private DataSet45 DataSet45;
        private DataSet45TableAdapters.purchase_medicineTableAdapter purchase_medicineTableAdapter;
    }
}