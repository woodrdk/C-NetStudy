namespace AdvancedForms
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
            this.cboCourseList = new System.Windows.Forms.ComboBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCourseInfo = new System.Windows.Forms.Label();
            this.lstExpirationYear = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCourseList
            // 
            this.cboCourseList.FormattingEnabled = true;
            this.cboCourseList.Location = new System.Drawing.Point(518, 103);
            this.cboCourseList.Name = "cboCourseList";
            this.cboCourseList.Size = new System.Drawing.Size(121, 21);
            this.cboCourseList.TabIndex = 0;
            this.cboCourseList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(49, 103);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstStudents.Size = new System.Drawing.Size(120, 95);
            this.lstStudents.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshAllDataToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // refreshAllDataToolStripMenuItem
            // 
            this.refreshAllDataToolStripMenuItem.Name = "refreshAllDataToolStripMenuItem";
            this.refreshAllDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshAllDataToolStripMenuItem.Text = "Refresh All Data";
            this.refreshAllDataToolStripMenuItem.Click += new System.EventHandler(this.refreshAllDataToolStripMenuItem_Click);
            // 
            // lblCourseInfo
            // 
            this.lblCourseInfo.Location = new System.Drawing.Point(186, 103);
            this.lblCourseInfo.Name = "lblCourseInfo";
            this.lblCourseInfo.Size = new System.Drawing.Size(294, 95);
            this.lblCourseInfo.TabIndex = 3;
            this.lblCourseInfo.Click += new System.EventHandler(this.lblCourseInfo_Click);
            // 
            // lstExpirationYear
            // 
            this.lstExpirationYear.FormattingEnabled = true;
            this.lstExpirationYear.Location = new System.Drawing.Point(48, 265);
            this.lstExpirationYear.Name = "lstExpirationYear";
            this.lstExpirationYear.Size = new System.Drawing.Size(120, 95);
            this.lstExpirationYear.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstExpirationYear);
            this.Controls.Add(this.lblCourseInfo);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.cboCourseList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCourseList;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshAllDataToolStripMenuItem;
        private System.Windows.Forms.Label lblCourseInfo;
        private System.Windows.Forms.ListBox lstExpirationYear;
    }
}

