namespace WindowsFormsApp1
{
    partial class Form3
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
            this.btnBackfancy = new System.Windows.Forms.Button();
            this.btnExitFancy = new System.Windows.Forms.Button();
            this.lblSide1 = new System.Windows.Forms.Label();
            this.lblSide2 = new System.Windows.Forms.Label();
            this.lblSide3 = new System.Windows.Forms.Label();
            this.lblSide4 = new System.Windows.Forms.Label();
            this.txtSide1 = new System.Windows.Forms.TextBox();
            this.txtSide2 = new System.Windows.Forms.TextBox();
            this.txtSide3 = new System.Windows.Forms.TextBox();
            this.txtSide4 = new System.Windows.Forms.TextBox();
            this.lblLengthReq = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMetric = new System.Windows.Forms.CheckBox();
            this.cbStandard = new System.Windows.Forms.CheckBox();
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblDimensionChoice = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.cbFeet = new System.Windows.Forms.CheckBox();
            this.cbInches = new System.Windows.Forms.CheckBox();
            this.cbMeters = new System.Windows.Forms.CheckBox();
            this.cbCentimeters = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrementOfMeasureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centimetersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackfancy
            // 
            this.btnBackfancy.Location = new System.Drawing.Point(12, 415);
            this.btnBackfancy.Name = "btnBackfancy";
            this.btnBackfancy.Size = new System.Drawing.Size(75, 23);
            this.btnBackfancy.TabIndex = 3;
            this.btnBackfancy.Text = "Back";
            this.btnBackfancy.UseVisualStyleBackColor = true;
            this.btnBackfancy.Click += new System.EventHandler(this.btnBackfancy_Click);
            // 
            // btnExitFancy
            // 
            this.btnExitFancy.Location = new System.Drawing.Point(93, 415);
            this.btnExitFancy.Name = "btnExitFancy";
            this.btnExitFancy.Size = new System.Drawing.Size(100, 23);
            this.btnExitFancy.TabIndex = 2;
            this.btnExitFancy.Text = "Exit Application";
            this.btnExitFancy.UseVisualStyleBackColor = true;
            this.btnExitFancy.Click += new System.EventHandler(this.btnExitFancy_Click);
            // 
            // lblSide1
            // 
            this.lblSide1.AutoSize = true;
            this.lblSide1.Location = new System.Drawing.Point(13, 93);
            this.lblSide1.Name = "lblSide1";
            this.lblSide1.Size = new System.Drawing.Size(37, 13);
            this.lblSide1.TabIndex = 4;
            this.lblSide1.Text = "Side 1";
            // 
            // lblSide2
            // 
            this.lblSide2.AutoSize = true;
            this.lblSide2.Location = new System.Drawing.Point(13, 124);
            this.lblSide2.Name = "lblSide2";
            this.lblSide2.Size = new System.Drawing.Size(37, 13);
            this.lblSide2.TabIndex = 6;
            this.lblSide2.Text = "Side 2";
            // 
            // lblSide3
            // 
            this.lblSide3.AutoSize = true;
            this.lblSide3.Location = new System.Drawing.Point(13, 160);
            this.lblSide3.Name = "lblSide3";
            this.lblSide3.Size = new System.Drawing.Size(37, 13);
            this.lblSide3.TabIndex = 7;
            this.lblSide3.Text = "Side 3";
            // 
            // lblSide4
            // 
            this.lblSide4.AutoSize = true;
            this.lblSide4.Location = new System.Drawing.Point(13, 192);
            this.lblSide4.Name = "lblSide4";
            this.lblSide4.Size = new System.Drawing.Size(37, 13);
            this.lblSide4.TabIndex = 8;
            this.lblSide4.Text = "Side 4";
            // 
            // txtSide1
            // 
            this.txtSide1.Location = new System.Drawing.Point(102, 85);
            this.txtSide1.Name = "txtSide1";
            this.txtSide1.Size = new System.Drawing.Size(100, 20);
            this.txtSide1.TabIndex = 9;
            this.txtSide1.TextChanged += new System.EventHandler(this.txtSide1_TextChanged);
            // 
            // txtSide2
            // 
            this.txtSide2.Location = new System.Drawing.Point(102, 116);
            this.txtSide2.Name = "txtSide2";
            this.txtSide2.Size = new System.Drawing.Size(100, 20);
            this.txtSide2.TabIndex = 10;
            // 
            // txtSide3
            // 
            this.txtSide3.Location = new System.Drawing.Point(102, 153);
            this.txtSide3.Name = "txtSide3";
            this.txtSide3.Size = new System.Drawing.Size(100, 20);
            this.txtSide3.TabIndex = 11;
            // 
            // txtSide4
            // 
            this.txtSide4.Location = new System.Drawing.Point(102, 192);
            this.txtSide4.Name = "txtSide4";
            this.txtSide4.Size = new System.Drawing.Size(100, 20);
            this.txtSide4.TabIndex = 12;
            // 
            // lblLengthReq
            // 
            this.lblLengthReq.AutoSize = true;
            this.lblLengthReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthReq.Location = new System.Drawing.Point(208, 82);
            this.lblLengthReq.Name = "lblLengthReq";
            this.lblLengthReq.Size = new System.Drawing.Size(17, 24);
            this.lblLengthReq.TabIndex = 21;
            this.lblLengthReq.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "*";
            // 
            // cbMetric
            // 
            this.cbMetric.AutoSize = true;
            this.cbMetric.Location = new System.Drawing.Point(298, 109);
            this.cbMetric.Name = "cbMetric";
            this.cbMetric.Size = new System.Drawing.Size(55, 17);
            this.cbMetric.TabIndex = 25;
            this.cbMetric.Text = "Metric";
            this.cbMetric.UseVisualStyleBackColor = true;
            this.cbMetric.CheckedChanged += new System.EventHandler(this.cbMetric_CheckedChanged);
            // 
            // cbStandard
            // 
            this.cbStandard.AutoSize = true;
            this.cbStandard.Location = new System.Drawing.Point(416, 109);
            this.cbStandard.Name = "cbStandard";
            this.cbStandard.Size = new System.Drawing.Size(69, 17);
            this.cbStandard.TabIndex = 26;
            this.cbStandard.Text = "Standard";
            this.cbStandard.UseVisualStyleBackColor = true;
            this.cbStandard.CheckedChanged += new System.EventHandler(this.cbStandard_CheckedChanged);
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.Location = new System.Drawing.Point(12, 392);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(128, 20);
            this.lblRequired.TabIndex = 27;
            this.lblRequired.Text = "* Item is required";
            // 
            // lblDimensionChoice
            // 
            this.lblDimensionChoice.AutoSize = true;
            this.lblDimensionChoice.Location = new System.Drawing.Point(295, 93);
            this.lblDimensionChoice.Name = "lblDimensionChoice";
            this.lblDimensionChoice.Size = new System.Drawing.Size(190, 13);
            this.lblDimensionChoice.TabIndex = 28;
            this.lblDimensionChoice.Text = "What is your  system of measurements.";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(13, 257);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 29;
            this.lblArea.Text = "Area";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(13, 279);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(51, 13);
            this.lblPerimeter.TabIndex = 30;
            this.lblPerimeter.Text = "Perimeter";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(102, 279);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 20);
            this.txtPerimeter.TabIndex = 31;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 322);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(186, 23);
            this.btnCalculate.TabIndex = 32;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(102, 250);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 33;
            // 
            // cbFeet
            // 
            this.cbFeet.AutoSize = true;
            this.cbFeet.Location = new System.Drawing.Point(416, 132);
            this.cbFeet.Name = "cbFeet";
            this.cbFeet.Size = new System.Drawing.Size(47, 17);
            this.cbFeet.TabIndex = 34;
            this.cbFeet.Text = "Feet";
            this.cbFeet.UseVisualStyleBackColor = true;
            this.cbFeet.Visible = false;
            this.cbFeet.CheckedChanged += new System.EventHandler(this.cbFeet_CheckedChanged);
            // 
            // cbInches
            // 
            this.cbInches.AutoSize = true;
            this.cbInches.Location = new System.Drawing.Point(481, 132);
            this.cbInches.Name = "cbInches";
            this.cbInches.Size = new System.Drawing.Size(58, 17);
            this.cbInches.TabIndex = 35;
            this.cbInches.Text = "Inches";
            this.cbInches.UseVisualStyleBackColor = true;
            this.cbInches.Visible = false;
            this.cbInches.CheckedChanged += new System.EventHandler(this.cbInches_CheckedChanged);
            // 
            // cbMeters
            // 
            this.cbMeters.AutoSize = true;
            this.cbMeters.Location = new System.Drawing.Point(251, 132);
            this.cbMeters.Name = "cbMeters";
            this.cbMeters.Size = new System.Drawing.Size(58, 17);
            this.cbMeters.TabIndex = 36;
            this.cbMeters.Text = "Meters";
            this.cbMeters.UseVisualStyleBackColor = true;
            this.cbMeters.Visible = false;
            this.cbMeters.CheckedChanged += new System.EventHandler(this.cbMeters_CheckedChanged);
            // 
            // cbCentimeters
            // 
            this.cbCentimeters.AutoSize = true;
            this.cbCentimeters.Location = new System.Drawing.Point(315, 132);
            this.cbCentimeters.Name = "cbCentimeters";
            this.cbCentimeters.Size = new System.Drawing.Size(81, 17);
            this.cbCentimeters.TabIndex = 37;
            this.cbCentimeters.Text = "Centimeters";
            this.cbCentimeters.UseVisualStyleBackColor = true;
            this.cbCentimeters.Visible = false;
            this.cbCentimeters.CheckedChanged += new System.EventHandler(this.cbCentimeters_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.incrementOfMeasureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // incrementOfMeasureToolStripMenuItem
            // 
            this.incrementOfMeasureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metricToolStripMenuItem,
            this.standardToolStripMenuItem});
            this.incrementOfMeasureToolStripMenuItem.Name = "incrementOfMeasureToolStripMenuItem";
            this.incrementOfMeasureToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.incrementOfMeasureToolStripMenuItem.Text = "Increment Of Measure";
            // 
            // metricToolStripMenuItem
            // 
            this.metricToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metersToolStripMenuItem,
            this.centimetersToolStripMenuItem});
            this.metricToolStripMenuItem.Name = "metricToolStripMenuItem";
            this.metricToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.metricToolStripMenuItem.Text = "Metric";
            // 
            // metersToolStripMenuItem
            // 
            this.metersToolStripMenuItem.Name = "metersToolStripMenuItem";
            this.metersToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.metersToolStripMenuItem.Text = "Meters";
            this.metersToolStripMenuItem.Click += new System.EventHandler(this.metersToolStripMenuItem_Click);
            // 
            // centimetersToolStripMenuItem
            // 
            this.centimetersToolStripMenuItem.Name = "centimetersToolStripMenuItem";
            this.centimetersToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.centimetersToolStripMenuItem.Text = "Centimeters";
            this.centimetersToolStripMenuItem.Click += new System.EventHandler(this.centimetersToolStripMenuItem_Click);
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feetToolStripMenuItem,
            this.inchesToolStripMenuItem});
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            // 
            // feetToolStripMenuItem
            // 
            this.feetToolStripMenuItem.Name = "feetToolStripMenuItem";
            this.feetToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.feetToolStripMenuItem.Text = "Feet";
            this.feetToolStripMenuItem.Click += new System.EventHandler(this.feetToolStripMenuItem_Click);
            // 
            // inchesToolStripMenuItem
            // 
            this.inchesToolStripMenuItem.Name = "inchesToolStripMenuItem";
            this.inchesToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.inchesToolStripMenuItem.Text = "Inches";
            this.inchesToolStripMenuItem.Click += new System.EventHandler(this.inchesToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCentimeters);
            this.Controls.Add(this.cbMeters);
            this.Controls.Add(this.cbInches);
            this.Controls.Add(this.cbFeet);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblDimensionChoice);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.cbStandard);
            this.Controls.Add(this.cbMetric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLengthReq);
            this.Controls.Add(this.txtSide4);
            this.Controls.Add(this.txtSide3);
            this.Controls.Add(this.txtSide2);
            this.Controls.Add(this.txtSide1);
            this.Controls.Add(this.lblSide4);
            this.Controls.Add(this.lblSide3);
            this.Controls.Add(this.lblSide2);
            this.Controls.Add(this.lblSide1);
            this.Controls.Add(this.btnBackfancy);
            this.Controls.Add(this.btnExitFancy);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Fancy area and perimeter Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackfancy;
        private System.Windows.Forms.Button btnExitFancy;
        private System.Windows.Forms.Label lblSide1;
        private System.Windows.Forms.Label lblSide2;
        private System.Windows.Forms.Label lblSide3;
        private System.Windows.Forms.Label lblSide4;
        private System.Windows.Forms.TextBox txtSide1;
        private System.Windows.Forms.TextBox txtSide2;
        private System.Windows.Forms.TextBox txtSide3;
        private System.Windows.Forms.TextBox txtSide4;
        private System.Windows.Forms.Label lblLengthReq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbMetric;
        private System.Windows.Forms.CheckBox cbStandard;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblDimensionChoice;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.CheckBox cbFeet;
        private System.Windows.Forms.CheckBox cbInches;
        private System.Windows.Forms.CheckBox cbMeters;
        private System.Windows.Forms.CheckBox cbCentimeters;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrementOfMeasureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centimetersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchesToolStripMenuItem;
    }
}