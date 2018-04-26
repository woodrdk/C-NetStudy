namespace ExceptionHandlingPractice
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSsn = new System.Windows.Forms.TextBox();
            this.btnValidateSsn = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(77, 23);
            this.txtLength.MaxLength = 100;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(77, 74);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(38, 118);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(139, 51);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Area and Perimeter";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Social Security Number";
            // 
            // txtSsn
            // 
            this.txtSsn.Location = new System.Drawing.Point(409, 34);
            this.txtSsn.Name = "txtSsn";
            this.txtSsn.Size = new System.Drawing.Size(100, 20);
            this.txtSsn.TabIndex = 6;
            // 
            // btnValidateSsn
            // 
            this.btnValidateSsn.Location = new System.Drawing.Point(361, 88);
            this.btnValidateSsn.Name = "btnValidateSsn";
            this.btnValidateSsn.Size = new System.Drawing.Size(122, 42);
            this.btnValidateSsn.TabIndex = 7;
            this.btnValidateSsn.Text = "Validate SSN";
            this.btnValidateSsn.UseVisualStyleBackColor = true;
            this.btnValidateSsn.Click += new System.EventHandler(this.btnValidateSsn_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(317, 180);
            this.maskedTextBox1.Mask = "000-00-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 262);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnValidateSsn);
            this.Controls.Add(this.txtSsn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSsn;
        private System.Windows.Forms.Button btnValidateSsn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

