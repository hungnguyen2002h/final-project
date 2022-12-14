namespace ShoeStore.View
{
    partial class FormDeli
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
            this.labelDeli = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.comboPayment = new System.Windows.Forms.ComboBox();
            this.labelPayment = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDeli
            // 
            this.labelDeli.AutoSize = true;
            this.labelDeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDeli.Location = new System.Drawing.Point(314, 13);
            this.labelDeli.Name = "labelDeli";
            this.labelDeli.Size = new System.Drawing.Size(172, 25);
            this.labelDeli.TabIndex = 0;
            this.labelDeli.Text = "Delivery Change";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(83, 74);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 16);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Packing",
            "Sending",
            "Completed"});
            this.comboStatus.Location = new System.Drawing.Point(172, 71);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(183, 24);
            this.comboStatus.TabIndex = 2;
            // 
            // comboPayment
            // 
            this.comboPayment.FormattingEnabled = true;
            this.comboPayment.Items.AddRange(new object[] {
            "Haven\'t pay yet",
            "Momo",
            "Zalopay",
            "VNPay",
            "ShopeePay",
            "Mastercard/Visa"});
            this.comboPayment.Location = new System.Drawing.Point(534, 71);
            this.comboPayment.Name = "comboPayment";
            this.comboPayment.Size = new System.Drawing.Size(183, 24);
            this.comboPayment.TabIndex = 4;
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Location = new System.Drawing.Point(445, 74);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(60, 16);
            this.labelPayment.TabIndex = 3;
            this.labelPayment.Text = "Payment";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonUpdate.Location = new System.Drawing.Point(359, 130);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 53);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Location = new System.Drawing.Point(50, 189);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(701, 239);
            this.dgvReceipt.TabIndex = 7;
            // 
            // FormDeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReceipt);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboPayment);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelDeli);
            this.Name = "FormDeli";
            this.Text = "Delivery Note";
            this.Load += new System.EventHandler(this.FormDeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeli;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboPayment;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dgvReceipt;
    }
}