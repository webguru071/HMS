namespace Diagnostic_Center
{
    partial class Pharmacy_Customer_History
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.medicine_selling_historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet44 = new Diagnostic_Center.DataSet44();
            this.medicine_selling_historyTableAdapter = new Diagnostic_Center.DataSet44TableAdapters.medicine_selling_historyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.medicine_selling_historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet44)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet44";
            reportDataSource1.Value = this.medicine_selling_historyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report58.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(581, 277);
            this.reportViewer1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // medicine_selling_historyBindingSource
            // 
            this.medicine_selling_historyBindingSource.DataMember = "medicine_selling_history";
            this.medicine_selling_historyBindingSource.DataSource = this.DataSet44;
            // 
            // DataSet44
            // 
            this.DataSet44.DataSetName = "DataSet44";
            this.DataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicine_selling_historyTableAdapter
            // 
            this.medicine_selling_historyTableAdapter.ClearBeforeFill = true;
            // 
            // Pharmacy_Customer_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 320);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Pharmacy_Customer_History";
            this.Text = "Pharmacy_Customer_History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pharmacy_Customer_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicine_selling_historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet44)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource medicine_selling_historyBindingSource;
        private DataSet44 DataSet44;
        private DataSet44TableAdapters.medicine_selling_historyTableAdapter medicine_selling_historyTableAdapter;
    }
}