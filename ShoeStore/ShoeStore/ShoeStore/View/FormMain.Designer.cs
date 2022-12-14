namespace ShoeStore.View
{
    partial class FormMain
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
            this.labelIntro = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CheckInvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIntro
            // 
            this.labelIntro.AutoSize = true;
            this.labelIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelIntro.Location = new System.Drawing.Point(920, 9);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(186, 25);
            this.labelIntro.TabIndex = 0;
            this.labelIntro.Text = "Hung Luc Co., Ltd";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckInvToolStripMenuItem,
            this.addNewEmployeeToolStripMenuItem,
            this.importExportToolStripMenuItem1,
            this.deliveryNoteToolStripMenuItem,
            this.receiptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CheckInvToolStripMenuItem
            // 
            this.CheckInvToolStripMenuItem.Name = "CheckInvToolStripMenuItem";
            this.CheckInvToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.CheckInvToolStripMenuItem.Text = "Check Inventory";
            this.CheckInvToolStripMenuItem.Click += new System.EventHandler(this.importExportToolStripMenuItem_Click);
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.addNewEmployeeToolStripMenuItem.Text = "Employee Manage";
            this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
            // 
            // importExportToolStripMenuItem1
            // 
            this.importExportToolStripMenuItem1.Name = "importExportToolStripMenuItem1";
            this.importExportToolStripMenuItem1.Size = new System.Drawing.Size(117, 24);
            this.importExportToolStripMenuItem1.Text = "Import/Export";
            this.importExportToolStripMenuItem1.Click += new System.EventHandler(this.importExportToolStripMenuItem1_Click);
            // 
            // receiptToolStripMenuItem
            // 
            this.receiptToolStripMenuItem.Name = "receiptToolStripMenuItem";
            this.receiptToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.receiptToolStripMenuItem.Text = "Statistics";
            this.receiptToolStripMenuItem.Click += new System.EventHandler(this.receiptToolStripMenuItem_Click);
            // 
            // deliveryNoteToolStripMenuItem
            // 
            this.deliveryNoteToolStripMenuItem.Name = "deliveryNoteToolStripMenuItem";
            this.deliveryNoteToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.deliveryNoteToolStripMenuItem.Text = "Delivery Note";
            this.deliveryNoteToolStripMenuItem.Click += new System.EventHandler(this.deliveryNoteToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 691);
            this.Controls.Add(this.labelIntro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CheckInvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importExportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem receiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryNoteToolStripMenuItem;
    }
}