namespace ShoeStore.View
{
    partial class FormInventory
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
            this.dgvShowInventory = new System.Windows.Forms.DataGridView();
            this.labelInventory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowInventory
            // 
            this.dgvShowInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowInventory.Enabled = false;
            this.dgvShowInventory.Location = new System.Drawing.Point(47, 95);
            this.dgvShowInventory.Name = "dgvShowInventory";
            this.dgvShowInventory.RowHeadersWidth = 51;
            this.dgvShowInventory.RowTemplate.Height = 24;
            this.dgvShowInventory.Size = new System.Drawing.Size(726, 354);
            this.dgvShowInventory.TabIndex = 0;
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelInventory.Location = new System.Drawing.Point(48, 48);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(101, 25);
            this.labelInventory.TabIndex = 1;
            this.labelInventory.Text = "Inventory";
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 478);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.dgvShowInventory);
            this.Name = "FormInventory";
            this.Text = "INVENTORY";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowInventory;
        private System.Windows.Forms.Label labelInventory;
    }
}