namespace Diagnostic_Center
{
    partial class BD_Connection
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
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.richTextBox12 = new System.Windows.Forms.RichTextBox();
            this.richTextBox13 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(259, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Configure";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Password:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "UserName:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(29, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "Database:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "Server:";
            // 
            // richTextBox11
            // 
            this.richTextBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox11.Location = new System.Drawing.Point(121, 165);
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.Size = new System.Drawing.Size(213, 30);
            this.richTextBox11.TabIndex = 23;
            this.richTextBox11.Text = "123";
            // 
            // richTextBox12
            // 
            this.richTextBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox12.Location = new System.Drawing.Point(121, 117);
            this.richTextBox12.Name = "richTextBox12";
            this.richTextBox12.Size = new System.Drawing.Size(213, 30);
            this.richTextBox12.TabIndex = 22;
            this.richTextBox12.Text = "sk";
            // 
            // richTextBox13
            // 
            this.richTextBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox13.Location = new System.Drawing.Point(121, 67);
            this.richTextBox13.Name = "richTextBox13";
            this.richTextBox13.Size = new System.Drawing.Size(213, 30);
            this.richTextBox13.TabIndex = 21;
            this.richTextBox13.Text = "database";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ".\\sqlexpress",
            "192.168.1.2,1433"});
            this.comboBox1.Location = new System.Drawing.Point(121, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 28);
            this.comboBox1.TabIndex = 20;
            // 
            // BD_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 257);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.richTextBox11);
            this.Controls.Add(this.richTextBox12);
            this.Controls.Add(this.richTextBox13);
            this.Controls.Add(this.comboBox1);
            this.Name = "BD_Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BD_Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox richTextBox11;
        private System.Windows.Forms.RichTextBox richTextBox12;
        private System.Windows.Forms.RichTextBox richTextBox13;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}