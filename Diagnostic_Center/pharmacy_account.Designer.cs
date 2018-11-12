namespace Diagnostic_Center
{
    partial class pharmacy_account
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
            this.user_cash_collection_pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet16 = new Diagnostic_Center.DataSet16();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.user_cash_collection_pharmacyTableAdapter = new Diagnostic_Center.DataSet16TableAdapters.user_cash_collection_pharmacyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // user_cash_collection_pharmacyBindingSource
            // 
            this.user_cash_collection_pharmacyBindingSource.DataMember = "user_cash_collection_pharmacy";
            this.user_cash_collection_pharmacyBindingSource.DataSource = this.DataSet16;
            // 
            // DataSet16
            // 
            this.DataSet16.DataSetName = "DataSet16";
            this.DataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(158, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "To";
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(277, 11);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 8;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet16";
            reportDataSource1.Value = this.user_cash_collection_pharmacyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report17.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(755, 440);
            this.reportViewer1.TabIndex = 7;
            // 
            // user_cash_collection_pharmacyTableAdapter
            // 
            this.user_cash_collection_pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // pharmacy_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 492);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.reportViewer1);
            this.Name = "pharmacy_account";
            this.Text = "pharmacy_account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.user_cash_collection_pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Load;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource user_cash_collection_pharmacyBindingSource;
        private DataSet16 DataSet16;
        private DataSet16TableAdapters.user_cash_collection_pharmacyTableAdapter user_cash_collection_pharmacyTableAdapter;
    }
}