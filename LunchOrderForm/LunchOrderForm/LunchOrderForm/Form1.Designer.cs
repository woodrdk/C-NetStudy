namespace LunchOrderForm
{
    partial class frmLunchOrder
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
            this.gbMainCourse = new System.Windows.Forms.GroupBox();
            this.rbSalad = new System.Windows.Forms.RadioButton();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbHamburger = new System.Windows.Forms.RadioButton();
            this.addOns = new System.Windows.Forms.GroupBox();
            this.cbFrenchFries = new System.Windows.Forms.CheckBox();
            this.cbKetrchup = new System.Windows.Forms.CheckBox();
            this.cbLettuce = new System.Windows.Forms.CheckBox();
            this.gbOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAddOnSalad = new System.Windows.Forms.GroupBox();
            this.cbBreadsticls = new System.Windows.Forms.CheckBox();
            this.cbBaconbits = new System.Windows.Forms.CheckBox();
            this.cbCroutons = new System.Windows.Forms.CheckBox();
            this.gbAddOnPizza = new System.Windows.Forms.GroupBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.gbMainCourse.SuspendLayout();
            this.addOns.SuspendLayout();
            this.gbOrderTotal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbAddOnSalad.SuspendLayout();
            this.gbAddOnPizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMainCourse
            // 
            this.gbMainCourse.Controls.Add(this.rbSalad);
            this.gbMainCourse.Controls.Add(this.rbPizza);
            this.gbMainCourse.Controls.Add(this.rbHamburger);
            this.gbMainCourse.Location = new System.Drawing.Point(42, 59);
            this.gbMainCourse.Name = "gbMainCourse";
            this.gbMainCourse.Size = new System.Drawing.Size(136, 105);
            this.gbMainCourse.TabIndex = 0;
            this.gbMainCourse.TabStop = false;
            this.gbMainCourse.Text = "Main Course";
            this.gbMainCourse.Enter += new System.EventHandler(this.gbMainCourse_Enter);
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
            // addOns
            // 
            this.addOns.Controls.Add(this.cbFrenchFries);
            this.addOns.Controls.Add(this.cbKetrchup);
            this.addOns.Controls.Add(this.cbLettuce);
            this.addOns.Location = new System.Drawing.Point(208, 59);
            this.addOns.Name = "addOns";
            this.addOns.Size = new System.Drawing.Size(215, 100);
            this.addOns.TabIndex = 1;
            this.addOns.TabStop = false;
            this.addOns.Visible = false;
            this.addOns.Enter += new System.EventHandler(this.gbAddOnHamburger_Enter);
            // 
            // cbFrenchFries
            // 
            this.cbFrenchFries.AutoSize = true;
            this.cbFrenchFries.Location = new System.Drawing.Point(8, 75);
            this.cbFrenchFries.Name = "cbFrenchFries";
            this.cbFrenchFries.Size = new System.Drawing.Size(81, 17);
            this.cbFrenchFries.TabIndex = 2;
            this.cbFrenchFries.Text = "FrenchFries";
            this.cbFrenchFries.UseVisualStyleBackColor = true;
            this.cbFrenchFries.CheckedChanged += new System.EventHandler(this.cbFrenchFries_CheckedChanged);
            // 
            // cbKetrchup
            // 
            this.cbKetrchup.AutoSize = true;
            this.cbKetrchup.Location = new System.Drawing.Point(7, 52);
            this.cbKetrchup.Name = "cbKetrchup";
            this.cbKetrchup.Size = new System.Drawing.Size(172, 17);
            this.cbKetrchup.TabIndex = 1;
            this.cbKetrchup.Text = "Ketchup, Mustard, Mayonaisse";
            this.cbKetrchup.UseVisualStyleBackColor = true;
            this.cbKetrchup.CheckedChanged += new System.EventHandler(this.cbKetchup_CheckedChanged);
            // 
            // cbLettuce
            // 
            this.cbLettuce.AutoSize = true;
            this.cbLettuce.Location = new System.Drawing.Point(7, 29);
            this.cbLettuce.Name = "cbLettuce";
            this.cbLettuce.Size = new System.Drawing.Size(143, 17);
            this.cbLettuce.TabIndex = 0;
            this.cbLettuce.Text = "Lettuce, Tomato, Onions";
            this.cbLettuce.UseVisualStyleBackColor = true;
            this.cbLettuce.CheckedChanged += new System.EventHandler(this.cbLettuce_CheckedChanged);
            // 
            // gbOrderTotal
            // 
            this.gbOrderTotal.Controls.Add(this.txtOrderTotal);
            this.gbOrderTotal.Controls.Add(this.txtTax);
            this.gbOrderTotal.Controls.Add(this.txtSubTotal);
            this.gbOrderTotal.Controls.Add(this.lblOrderTotal);
            this.gbOrderTotal.Controls.Add(this.lblTax);
            this.gbOrderTotal.Controls.Add(this.lblSubtotal);
            this.gbOrderTotal.Location = new System.Drawing.Point(49, 188);
            this.gbOrderTotal.Name = "gbOrderTotal";
            this.gbOrderTotal.Size = new System.Drawing.Size(200, 100);
            this.gbOrderTotal.TabIndex = 2;
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
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(297, 188);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(297, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 5;
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
            // gbAddOnSalad
            // 
            this.gbAddOnSalad.Controls.Add(this.cbBreadsticls);
            this.gbAddOnSalad.Controls.Add(this.cbBaconbits);
            this.gbAddOnSalad.Controls.Add(this.cbCroutons);
            this.gbAddOnSalad.Location = new System.Drawing.Point(429, 59);
            this.gbAddOnSalad.Name = "gbAddOnSalad";
            this.gbAddOnSalad.Size = new System.Drawing.Size(200, 100);
            this.gbAddOnSalad.TabIndex = 6;
            this.gbAddOnSalad.TabStop = false;
            this.gbAddOnSalad.Visible = false;
            // 
            // cbBreadsticls
            // 
            this.cbBreadsticls.AutoSize = true;
            this.cbBreadsticls.Location = new System.Drawing.Point(7, 77);
            this.cbBreadsticls.Name = "cbBreadsticls";
            this.cbBreadsticls.Size = new System.Drawing.Size(86, 17);
            this.cbBreadsticls.TabIndex = 2;
            this.cbBreadsticls.Text = "Bread Sticks";
            this.cbBreadsticls.UseVisualStyleBackColor = true;
            this.cbBreadsticls.CheckedChanged += new System.EventHandler(this.cbBreadsticls_CheckedChanged);
            // 
            // cbBaconbits
            // 
            this.cbBaconbits.AutoSize = true;
            this.cbBaconbits.Location = new System.Drawing.Point(7, 53);
            this.cbBaconbits.Name = "cbBaconbits";
            this.cbBaconbits.Size = new System.Drawing.Size(77, 17);
            this.cbBaconbits.TabIndex = 1;
            this.cbBaconbits.Text = "Bacon Bits";
            this.cbBaconbits.UseVisualStyleBackColor = true;
            this.cbBaconbits.CheckedChanged += new System.EventHandler(this.cbBaconbits_CheckedChanged);
            // 
            // cbCroutons
            // 
            this.cbCroutons.AutoSize = true;
            this.cbCroutons.Location = new System.Drawing.Point(7, 29);
            this.cbCroutons.Name = "cbCroutons";
            this.cbCroutons.Size = new System.Drawing.Size(68, 17);
            this.cbCroutons.TabIndex = 0;
            this.cbCroutons.Text = "Croutons";
            this.cbCroutons.UseVisualStyleBackColor = true;
            this.cbCroutons.CheckedChanged += new System.EventHandler(this.cbCroutons_CheckedChanged);
            // 
            // gbAddOnPizza
            // 
            this.gbAddOnPizza.Controls.Add(this.cbOlives);
            this.gbAddOnPizza.Controls.Add(this.cbSausage);
            this.gbAddOnPizza.Controls.Add(this.cbPepperoni);
            this.gbAddOnPizza.Location = new System.Drawing.Point(429, 165);
            this.gbAddOnPizza.Name = "gbAddOnPizza";
            this.gbAddOnPizza.Size = new System.Drawing.Size(200, 100);
            this.gbAddOnPizza.TabIndex = 7;
            this.gbAddOnPizza.TabStop = false;
            this.gbAddOnPizza.Visible = false;
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Location = new System.Drawing.Point(17, 71);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(55, 17);
            this.cbOlives.TabIndex = 5;
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(17, 47);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(68, 17);
            this.cbSausage.TabIndex = 4;
            this.cbSausage.Text = "Sausage";
            this.cbSausage.UseVisualStyleBackColor = true;
            this.cbSausage.CheckedChanged += new System.EventHandler(this.cbSausage_CheckedChanged);
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(17, 23);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(74, 17);
            this.cbPepperoni.TabIndex = 3;
            this.cbPepperoni.Text = "Pepperoni";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            this.cbPepperoni.CheckedChanged += new System.EventHandler(this.cbPepperoni_CheckedChanged);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(297, 225);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(75, 23);
            this.btnClearOrder.TabIndex = 8;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // frmLunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 320);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.gbAddOnPizza);
            this.Controls.Add(this.gbAddOnSalad);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.gbOrderTotal);
            this.Controls.Add(this.addOns);
            this.Controls.Add(this.gbMainCourse);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLunchOrder";
            this.Text = "LunchOrder";
            this.gbMainCourse.ResumeLayout(false);
            this.gbMainCourse.PerformLayout();
            this.addOns.ResumeLayout(false);
            this.addOns.PerformLayout();
            this.gbOrderTotal.ResumeLayout(false);
            this.gbOrderTotal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbAddOnSalad.ResumeLayout(false);
            this.gbAddOnSalad.PerformLayout();
            this.gbAddOnPizza.ResumeLayout(false);
            this.gbAddOnPizza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMainCourse;
        private System.Windows.Forms.RadioButton rbSalad;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbHamburger;
        private System.Windows.Forms.GroupBox addOns;
        private System.Windows.Forms.CheckBox cbFrenchFries;
        private System.Windows.Forms.CheckBox cbKetrchup;
        private System.Windows.Forms.CheckBox cbLettuce;
        private System.Windows.Forms.GroupBox gbOrderTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbAddOnSalad;
        private System.Windows.Forms.GroupBox gbAddOnPizza;
        private System.Windows.Forms.CheckBox cbBreadsticls;
        private System.Windows.Forms.CheckBox cbBaconbits;
        private System.Windows.Forms.CheckBox cbCroutons;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbSausage;
        private System.Windows.Forms.CheckBox cbPepperoni;
        private System.Windows.Forms.Button btnClearOrder;
    }
}

