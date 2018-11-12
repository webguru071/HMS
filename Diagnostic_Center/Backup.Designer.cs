namespace Diagnostic_Center
{
    partial class Backup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox16 = new System.Windows.Forms.RichTextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.richTextBox17 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.richTextBox16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Database";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.richTextBox17);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore Database";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(337, 102);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 42);
            this.button7.TabIndex = 7;
            this.button7.Text = "Backup";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(21, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(254, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Browse Destination Folder Except  \'C\' Drive";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(471, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 42);
            this.button6.TabIndex = 5;
            this.button6.Text = "Browse";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // richTextBox16
            // 
            this.richTextBox16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox16.Location = new System.Drawing.Point(24, 54);
            this.richTextBox16.Name = "richTextBox16";
            this.richTextBox16.Size = new System.Drawing.Size(428, 42);
            this.richTextBox16.TabIndex = 4;
            this.richTextBox16.Text = "";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(340, 107);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 42);
            this.button8.TabIndex = 11;
            this.button8.Text = "Restore";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(24, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(189, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "Browse Backup File From Folder";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(474, 59);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 42);
            this.button9.TabIndex = 9;
            this.button9.Text = "Browse";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // richTextBox17
            // 
            this.richTextBox17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox17.Location = new System.Drawing.Point(27, 59);
            this.richTextBox17.Name = "richTextBox17";
            this.richTextBox17.Size = new System.Drawing.Size(428, 42);
            this.richTextBox17.TabIndex = 8;
            this.richTextBox17.Text = "";
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 382);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(606, 412);
            this.MinimumSize = new System.Drawing.Size(606, 412);
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RichTextBox richTextBox17;
    }
}