namespace Lunch_Order_Proper
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
            this.gbMainCourse = new System.Windows.Forms.GroupBox();
            this.rbSalad = new System.Windows.Forms.RadioButton();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbHamburger = new System.Windows.Forms.RadioButton();
            this.gbOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.gbAddOns = new System.Windows.Forms.GroupBox();
            this.cbAdd1 = new System.Windows.Forms.CheckBox();
            this.cbAdd2 = new System.Windows.Forms.CheckBox();
            this.cbAdd3 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMainCourse.SuspendLayout();
            this.gbOrderTotal.SuspendLayout();
            this.gbAddOns.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMainCourse
            // 
            this.gbMainCourse.Controls.Add(this.rbSalad);
            this.gbMainCourse.Controls.Add(this.rbPizza);
            this.gbMainCourse.Controls.Add(this.rbHamburger);
            this.gbMainCourse.Location = new System.Drawing.Point(13, 24);
            this.gbMainCourse.Name = "gbMainCourse";
            this.gbMainCourse.Size = new System.Drawing.Size(136, 105);
            this.gbMainCourse.TabIndex = 1;
            this.gbMainCourse.TabStop = false;
            this.gbMainCourse.Text = "Main Course";
            // 
            // rbSalad
            // 
            this.rbSalad.AutoSize = true;
            this.rbSalad.Location = new System.Drawing.Point(7, 68);
            this.rbSalad.Name = "rbSalad";
            this.rbSalad.Size = new System.Drawing.Size(88, 17);
            this.rbSalad.TabIndex = 2;
            this.rbSalad.TabStop = true;
            this.rbSalad.Text = "Salad - $4.95";
            this.rbSalad.UseVisualStyleBackColor = true;
            this.rbSalad.CheckedChanged += new System.EventHandler(this.rbSalad_CheckedChanged);
            // 
            // rbPizza
            // 
            this.rbPizza.AutoSize = true;
            this.rbPizza.Location = new System.Drawing.Point(7, 44);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(89, 17);
            this.rbPizza.TabIndex = 1;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza -  $5.95";
            this.rbPizza.UseVisualStyleBackColor = true;
            this.rbPizza.CheckedChanged += new System.EventHandler(this.rbPizza_CheckedChanged);
            // 
            // rbHamburger
            // 
            this.rbHamburger.AutoSize = true;
            this.rbHamburger.Location = new System.Drawing.Point(7, 20);
            this.rbHamburger.Name = "rbHamburger";
            this.rbHamburger.Size = new System.Drawing.Size(113, 17);
            this.rbHamburger.TabIndex = 0;
            this.rbHamburger.TabStop = true;
            this.rbHamburger.Text = "Hamburger - $6.95";
            this.rbHamburger.UseVisualStyleBackColor = true;
            this.rbHamburger.CheckedChanged += new System.EventHandler(this.rbHamburger_CheckedChanged);
            // 
            // gbOrderTotal
            // 
            this.gbOrderTotal.Controls.Add(this.txtOrderTotal);
            this.gbOrderTotal.Controls.Add(this.txtTax);
            this.gbOrderTotal.Controls.Add(this.txtSubTotal);
            this.gbOrderTotal.Controls.Add(this.lblOrderTotal);
            this.gbOrderTotal.Controls.Add(this.lblTax);
            this.gbOrderTotal.Controls.Add(this.lblSubtotal);
            this.gbOrderTotal.Location = new System.Drawing.Point(13, 135);
            this.gbOrderTotal.Name = "gbOrderTotal";
            this.gbOrderTotal.Size = new System.Drawing.Size(200, 100);
            this.gbOrderTotal.TabIndex = 3;
            this.gbOrderTotal.TabStop = false;
            this.gbOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(94, 70);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 20);
            this.txtOrderTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(94, 45);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 4;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(94, 20);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 3;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(25, 73);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(63, 13);
            this.lblOrderTotal.TabIndex = 2;
            this.lblOrderTotal.Text = "Order Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(19, 48);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(69, 13);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax ( 7.75%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(39, 23);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(235, 172);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(75, 23);
            this.btnClearOrder.TabIndex = 11;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(235, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(235, 135);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // gbAddOns
            // 
            this.gbAddOns.Controls.Add(this.cbAdd3);
            this.gbAddOns.Controls.Add(this.cbAdd2);
            this.gbAddOns.Controls.Add(this.cbAdd1);
            this.gbAddOns.Location = new System.Drawing.Point(156, 25);
            this.gbAddOns.Name = "gbAddOns";
            this.gbAddOns.Size = new System.Drawing.Size(189, 104);
            this.gbAddOns.TabIndex = 12;
            this.gbAddOns.TabStop = false;
            this.gbAddOns.Visible = false;
            // 
            // cbAdd1
            // 
            this.cbAdd1.AutoSize = true;
            this.cbAdd1.Location = new System.Drawing.Point(7, 20);
            this.cbAdd1.Name = "cbAdd1";
            this.cbAdd1.Size = new System.Drawing.Size(15, 14);
            this.cbAdd1.TabIndex = 0;
            this.cbAdd1.UseVisualStyleBackColor = true;
            this.cbAdd1.CheckedChanged += new System.EventHandler(this.cbAdd1_CheckedChanged);
            // 
            // cbAdd2
            // 
            this.cbAdd2.AutoSize = true;
            this.cbAdd2.Location = new System.Drawing.Point(7, 44);
            this.cbAdd2.Name = "cbAdd2";
            this.cbAdd2.Size = new System.Drawing.Size(15, 14);
            this.cbAdd2.TabIndex = 1;
            this.cbAdd2.UseVisualStyleBackColor = true;
            this.cbAdd2.CheckedChanged += new System.EventHandler(this.cbAdd2_CheckedChanged);
            // 
            // cbAdd3
            // 
            this.cbAdd3.AutoSize = true;
            this.cbAdd3.Location = new System.Drawing.Point(7, 68);
            this.cbAdd3.Name = "cbAdd3";
            this.cbAdd3.Size = new System.Drawing.Size(15, 14);
            this.cbAdd3.TabIndex = 2;
            this.cbAdd3.UseVisualStyleBackColor = true;
            this.cbAdd3.CheckedChanged += new System.EventHandler(this.cbAdd3_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 24);
            this.menuStrip1.TabIndex = 13;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 255);
            this.Controls.Add(this.gbAddOns);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.gbOrderTotal);
            this.Controls.Add(this.gbMainCourse);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lunch Order Form";
            this.gbMainCourse.ResumeLayout(false);
            this.gbMainCourse.PerformLayout();
            this.gbOrderTotal.ResumeLayout(false);
            this.gbOrderTotal.PerformLayout();
            this.gbAddOns.ResumeLayout(false);
            this.gbAddOns.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMainCourse;
        private System.Windows.Forms.RadioButton rbSalad;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbHamburger;
        private System.Windows.Forms.GroupBox gbOrderTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.GroupBox gbAddOns;
        private System.Windows.Forms.CheckBox cbAdd3;
        private System.Windows.Forms.CheckBox cbAdd2;
        private System.Windows.Forms.CheckBox cbAdd1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

