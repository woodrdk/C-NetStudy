namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnExitBasic = new System.Windows.Forms.Button();
            this.btnBackBasic = new System.Windows.Forms.Button();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblLengthReq = new System.Windows.Forms.Label();
            this.lblWidthReq = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExitBasic
            // 
            this.btnExitBasic.Location = new System.Drawing.Point(93, 245);
            this.btnExitBasic.Name = "btnExitBasic";
            this.btnExitBasic.Size = new System.Drawing.Size(103, 23);
            this.btnExitBasic.TabIndex = 0;
            this.btnExitBasic.Text = "Exit Application";
            this.btnExitBasic.UseVisualStyleBackColor = true;
            this.btnExitBasic.Click += new System.EventHandler(this.btnExitBasic_Click);
            // 
            // btnBackBasic
            // 
            this.btnBackBasic.Location = new System.Drawing.Point(12, 245);
            this.btnBackBasic.Name = "btnBackBasic";
            this.btnBackBasic.Size = new System.Drawing.Size(75, 23);
            this.btnBackBasic.TabIndex = 1;
            this.btnBackBasic.Text = "Back";
            this.btnBackBasic.UseVisualStyleBackColor = true;
            this.btnBackBasic.Click += new System.EventHandler(this.btnBackBasic_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(9, 156);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(54, 13);
            this.lblPerimeter.TabIndex = 19;
            this.lblPerimeter.Text = "Perimeter:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(9, 130);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 18;
            this.lblArea.Text = "Area:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(9, 104);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 17;
            this.lblWidth.Text = "Width:";
            this.lblWidth.Click += new System.EventHandler(this.lblWidth_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(9, 78);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 16;
            this.lblLength.Text = "Length:";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(96, 149);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(100, 20);
            this.txtPerimeter.TabIndex = 15;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(96, 123);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 14;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(96, 97);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 13;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(96, 71);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 12;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 191);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(184, 23);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate Dimensions";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblLengthReq
            // 
            this.lblLengthReq.AutoSize = true;
            this.lblLengthReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthReq.Location = new System.Drawing.Point(202, 71);
            this.lblLengthReq.Name = "lblLengthReq";
            this.lblLengthReq.Size = new System.Drawing.Size(17, 24);
            this.lblLengthReq.TabIndex = 20;
            this.lblLengthReq.Text = "*";
            // 
            // lblWidthReq
            // 
            this.lblWidthReq.AutoSize = true;
            this.lblWidthReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthReq.Location = new System.Drawing.Point(202, 97);
            this.lblWidthReq.Name = "lblWidthReq";
            this.lblWidthReq.Size = new System.Drawing.Size(17, 24);
            this.lblWidthReq.TabIndex = 21;
            this.lblWidthReq.Text = "*";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.Location = new System.Drawing.Point(12, 217);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(128, 20);
            this.lblRequired.TabIndex = 28;
            this.lblRequired.Text = "* Item is required";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 286);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblWidthReq);
            this.Controls.Add(this.lblLengthReq);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnBackBasic);
            this.Controls.Add(this.btnExitBasic);
            this.Name = "Form2";
            this.Text = "Basic Area and Perimeter Calculator";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitBasic;
        private System.Windows.Forms.Button btnBackBasic;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblLengthReq;
        private System.Windows.Forms.Label lblWidthReq;
        private System.Windows.Forms.Label lblRequired;
    }
}