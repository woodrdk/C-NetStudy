namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBasic = new System.Windows.Forms.Button();
            this.btnFancy = new System.Windows.Forms.Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblPlain = new System.Windows.Forms.Label();
            this.lblFancy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasic
            // 
            this.btnBasic.Location = new System.Drawing.Point(124, 126);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(115, 23);
            this.btnBasic.TabIndex = 0;
            this.btnBasic.Text = "Basic Calculator";
            this.btnBasic.UseVisualStyleBackColor = true;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnFancy
            // 
            this.btnFancy.Location = new System.Drawing.Point(520, 126);
            this.btnFancy.Name = "btnFancy";
            this.btnFancy.Size = new System.Drawing.Size(109, 23);
            this.btnFancy.TabIndex = 1;
            this.btnFancy.Text = "Fancy Calculator";
            this.btnFancy.UseVisualStyleBackColor = true;
            this.btnFancy.Click += new System.EventHandler(this.btnFancy_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(42, 39);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(682, 31);
            this.lblIntro.TabIndex = 2;
            this.lblIntro.Text = "Welcome to the fancy area and perimeter calculator";
            this.lblIntro.Click += new System.EventHandler(this.lblIntro_Click);
            // 
            // lblPlain
            // 
            this.lblPlain.AutoSize = true;
            this.lblPlain.Location = new System.Drawing.Point(80, 98);
            this.lblPlain.Name = "lblPlain";
            this.lblPlain.Size = new System.Drawing.Size(222, 13);
            this.lblPlain.TabIndex = 3;
            this.lblPlain.Text = "Click the button below for the basic calculator";
            this.lblPlain.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFancy
            // 
            this.lblFancy.AutoSize = true;
            this.lblFancy.Location = new System.Drawing.Point(464, 98);
            this.lblFancy.Name = "lblFancy";
            this.lblFancy.Size = new System.Drawing.Size(226, 13);
            this.lblFancy.TabIndex = 4;
            this.lblFancy.Text = "Click the button below for the fancy calculator.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 228);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFancy);
            this.Controls.Add(this.lblPlain);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.btnFancy);
            this.Controls.Add(this.btnBasic);
            this.Name = "Form1";
            this.Text = "Area & Perimeter Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Button btnFancy;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblPlain;
        private System.Windows.Forms.Label lblFancy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

