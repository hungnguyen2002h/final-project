namespace ShoeStore
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
            this.dGVEmployee = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVEmployee
            // 
            this.dGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEmployee.Location = new System.Drawing.Point(51, 372);
            this.dGVEmployee.Name = "dGVEmployee";
            this.dGVEmployee.RowHeadersWidth = 51;
            this.dGVEmployee.RowTemplate.Height = 24;
            this.dGVEmployee.Size = new System.Drawing.Size(921, 212);
            this.dGVEmployee.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.Location = new System.Drawing.Point(184, 265);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 72);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonUpdate.Location = new System.Drawing.Point(335, 265);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 72);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDel.Location = new System.Drawing.Point(486, 265);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 72);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCancel.Location = new System.Drawing.Point(788, 265);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 72);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(169, 48);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(327, 22);
            this.textID.TabIndex = 7;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(169, 88);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(327, 22);
            this.textName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full Name";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(169, 128);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(327, 22);
            this.textUser.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(169, 168);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(327, 22);
            this.textPass.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(659, 171);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(327, 22);
            this.textAddress.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Address";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(659, 131);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(327, 22);
            this.textPhone.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Phone number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gender";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(659, 51);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(327, 22);
            this.textAge.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Age";
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboGender.Location = new System.Drawing.Point(659, 88);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(121, 24);
            this.comboGender.TabIndex = 22;
            this.comboGender.SelectedIndexChanged += new System.EventHandler(this.comboGender_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSave.Location = new System.Drawing.Point(637, 265);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 72);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 623);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dGVEmployee);
            this.Name = "Form1";
            this.Text = "Hung Luc Co., Ltd";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVEmployee;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Button buttonSave;
    }
}

