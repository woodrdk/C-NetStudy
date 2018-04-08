namespace WindowsFormsApp1
{
    partial class frmInvoiceCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceCalc));
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcTotal = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.lblInstSub = new System.Windows.Forms.Label();
            this.lblInstTax = new System.Windows.Forms.Label();
            this.lblInsCalc = new System.Windows.Forms.Label();
            this.btnCloseInstructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(213, 98);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(213, 142);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 20);
            this.txtTaxRate.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(213, 188);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Subtotal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Tax Rate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total";
            // 
            // btnCalcTotal
            // 
            this.btnCalcTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTotal.Location = new System.Drawing.Point(92, 226);
            this.btnCalcTotal.Name = "btnCalcTotal";
            this.btnCalcTotal.Size = new System.Drawing.Size(221, 32);
            this.btnCalcTotal.TabIndex = 6;
            this.btnCalcTotal.Text = "Calculate Total";
            this.btnCalcTotal.UseVisualStyleBackColor = true;
            this.btnCalcTotal.Click += new System.EventHandler(this.btnCalcTotal_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(406, 410);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(172, 28);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Click Here To Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.Location = new System.Drawing.Point(12, 410);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(112, 26);
            this.btnInstructions.TabIndex = 8;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // lblInstSub
            // 
            this.lblInstSub.AutoSize = true;
            this.lblInstSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstSub.Location = new System.Drawing.Point(347, 98);
            this.lblInstSub.Name = "lblInstSub";
            this.lblInstSub.Size = new System.Drawing.Size(231, 24);
            this.lblInstSub.TabIndex = 9;
            this.lblInstSub.Text = "Input the subtotal value.";
            this.lblInstSub.Visible = false;
            this.lblInstSub.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblInstTax
            // 
            this.lblInstTax.AutoSize = true;
            this.lblInstTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstTax.Location = new System.Drawing.Point(345, 138);
            this.lblInstTax.Name = "lblInstTax";
            this.lblInstTax.Size = new System.Drawing.Size(227, 24);
            this.lblInstTax.TabIndex = 10;
            this.lblInstTax.Text = "Input the tax rate value.";
            this.lblInstTax.Visible = false;
            // 
            // lblInsCalc
            // 
            this.lblInsCalc.AutoSize = true;
            this.lblInsCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsCalc.Location = new System.Drawing.Point(369, 230);
            this.lblInsCalc.Name = "lblInsCalc";
            this.lblInsCalc.Size = new System.Drawing.Size(173, 24);
            this.lblInsCalc.TabIndex = 11;
            this.lblInsCalc.Text = "Click to calculate.";
            this.lblInsCalc.Visible = false;
            this.lblInsCalc.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCloseInstructions
            // 
            this.btnCloseInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseInstructions.Location = new System.Drawing.Point(12, 410);
            this.btnCloseInstructions.Name = "btnCloseInstructions";
            this.btnCloseInstructions.Size = new System.Drawing.Size(177, 28);
            this.btnCloseInstructions.TabIndex = 12;
            this.btnCloseInstructions.Text = "Close Instructions";
            this.btnCloseInstructions.UseVisualStyleBackColor = true;
            this.btnCloseInstructions.Visible = false;
            this.btnCloseInstructions.Click += new System.EventHandler(this.btnCloseInstructions_Click);
            // 
            // frmInvoiceCalc
            // 
            this.AcceptButton = this.btnCalcTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.btnCloseInstructions);
            this.Controls.Add(this.lblInsCalc);
            this.Controls.Add(this.lblInstTax);
            this.Controls.Add(this.lblInstSub);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.btnCalcTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.txtSubtotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInvoiceCalc";
            this.Text = "Invoice Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcTotal;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Label lblInstSub;
        private System.Windows.Forms.Label lblInstTax;
        private System.Windows.Forms.Label lblInsCalc;
        private System.Windows.Forms.Button btnCloseInstructions;
    }
}

