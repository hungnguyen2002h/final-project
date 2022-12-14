namespace ShoeStore.View
{
    partial class FormImportExport
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
            this.labelIID = new System.Windows.Forms.Label();
            this.labelPID = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.comboPID = new System.Windows.Forms.ComboBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.buttonImp = new System.Windows.Forms.Button();
            this.buttonExp = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelEmp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIID
            // 
            this.labelIID.AutoSize = true;
            this.labelIID.Location = new System.Drawing.Point(65, 52);
            this.labelIID.Name = "labelIID";
            this.labelIID.Size = new System.Drawing.Size(66, 16);
            this.labelIID.TabIndex = 0;
            this.labelIID.Text = "Invoice ID";
            // 
            // labelPID
            // 
            this.labelPID.AutoSize = true;
            this.labelPID.Location = new System.Drawing.Point(65, 96);
            this.labelPID.Name = "labelPID";
            this.labelPID.Size = new System.Drawing.Size(69, 16);
            this.labelPID.TabIndex = 1;
            this.labelPID.Text = "Product ID";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(400, 98);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(55, 16);
            this.labelQuantity.TabIndex = 3;
            this.labelQuantity.Text = "Quantity";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(140, 49);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(236, 22);
            this.textID.TabIndex = 4;
            this.textID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(499, 95);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(236, 22);
            this.textQuantity.TabIndex = 7;
            // 
            // comboPID
            // 
            this.comboPID.FormattingEnabled = true;
            this.comboPID.Items.AddRange(new object[] {
            "P001",
            "P002",
            "P003",
            "P004",
            "P005",
            "P006",
            "P007",
            "P008",
            "P009",
            "P010"});
            this.comboPID.Location = new System.Drawing.Point(140, 93);
            this.comboPID.Name = "comboPID";
            this.comboPID.Size = new System.Drawing.Size(121, 24);
            this.comboPID.TabIndex = 8;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(21, 269);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.Size = new System.Drawing.Size(759, 150);
            this.dgvInvoice.TabIndex = 9;
            // 
            // buttonImp
            // 
            this.buttonImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonImp.Location = new System.Drawing.Point(232, 176);
            this.buttonImp.Name = "buttonImp";
            this.buttonImp.Size = new System.Drawing.Size(100, 63);
            this.buttonImp.TabIndex = 10;
            this.buttonImp.Text = "Import";
            this.buttonImp.UseVisualStyleBackColor = true;
            this.buttonImp.Click += new System.EventHandler(this.buttonImp_Click);
            // 
            // buttonExp
            // 
            this.buttonExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonExp.Location = new System.Drawing.Point(469, 176);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(100, 63);
            this.buttonExp.TabIndex = 11;
            this.buttonExp.Text = "Export";
            this.buttonExp.UseVisualStyleBackColor = true;
            this.buttonExp.Click += new System.EventHandler(this.buttonExp_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(499, 49);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(236, 22);
            this.textName.TabIndex = 13;
            // 
            // labelEmp
            // 
            this.labelEmp.AutoSize = true;
            this.labelEmp.Location = new System.Drawing.Point(400, 52);
            this.labelEmp.Name = "labelEmp";
            this.labelEmp.Size = new System.Drawing.Size(69, 16);
            this.labelEmp.TabIndex = 12;
            this.labelEmp.Text = "Employee";
            // 
            // FormImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelEmp);
            this.Controls.Add(this.buttonExp);
            this.Controls.Add(this.buttonImp);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.comboPID);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPID);
            this.Controls.Add(this.labelIID);
            this.Name = "FormImportExport";
            this.Text = "FormImportExport";
            this.Load += new System.EventHandler(this.FormImportExport_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIID;
        private System.Windows.Forms.Label labelPID;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.ComboBox comboPID;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Button buttonImp;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelEmp;
    }
}