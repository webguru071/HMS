namespace Diagnostic_Center
{
    partial class due_collection
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
            this.due_collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet5 = new Diagnostic_Center.DataSet5();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.due_collectionTableAdapter = new Diagnostic_Center.DataSet5TableAdapters.due_collectionTableAdapter();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Button();
            this.DataSet4 = new Diagnostic_Center.DataSet4();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseTableAdapter = new Diagnostic_Center.DataSet4TableAdapters.expenseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.due_collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // due_collectionBindingSource
            // 
            this.due_collectionBindingSource.DataMember = "due_collection";
            this.due_collectionBindingSource.DataSource = this.DataSet5;
            // 
            // DataSet5
            // 
            this.DataSet5.DataSetName = "DataSet5";
            this.DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet5";
            reportDataSource1.Value = this.due_collectionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diagnostic_Center.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(896, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // due_collectionTableAdapter
            // 
            this.due_collectionTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(149, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "To";
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(268, 11);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 7;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "expense";
            this.expenseBindingSource.DataSource = this.DataSet4;
            // 
            // expenseTableAdapter
            // 
            this.expenseTableAdapter.ClearBeforeFill = true;
            // 
            // due_collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 398);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.reportViewer1);
            this.Name = "due_collection";
            this.Text = "due_collection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.due_collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource due_collectionBindingSource;
        private DataSet5 DataSet5;
        private DataSet5TableAdapters.due_collectionTableAdapter due_collectionTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private DataSet4 DataSet4;
        private DataSet4TableAdapters.expenseTableAdapter expenseTableAdapter;
    }
}