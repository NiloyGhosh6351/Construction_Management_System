namespace Construction_Management_System
{
    partial class FormEmployee
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
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.textBoxEmpContact = new System.Windows.Forms.TextBox();
            this.labelEmpContact = new System.Windows.Forms.Label();
            this.textBoxEmpCategory = new System.Windows.Forms.TextBox();
            this.labelEmpCategory = new System.Windows.Forms.Label();
            this.textBoxEmpPrice = new System.Windows.Forms.TextBox();
            this.labelEmpSalary = new System.Windows.Forms.Label();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.textBoxEmpId = new System.Windows.Forms.TextBox();
            this.labelEmpId = new System.Windows.Forms.Label();
            this.textBoxEmpAddress = new System.Windows.Forms.TextBox();
            this.labelEmpAddress = new System.Windows.Forms.Label();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.buttonEmpClear = new System.Windows.Forms.Button();
            this.buttonIEmpDelete = new System.Windows.Forms.Button();
            this.buttonEmpUpdate = new System.Windows.Forms.Button();
            this.buttonEmpAdd = new System.Windows.Forms.Button();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelEmployee.Controls.Add(this.textBoxEmpAddress);
            this.panelEmployee.Controls.Add(this.labelEmpAddress);
            this.panelEmployee.Controls.Add(this.textBoxEmpContact);
            this.panelEmployee.Controls.Add(this.labelEmpContact);
            this.panelEmployee.Controls.Add(this.textBoxEmpCategory);
            this.panelEmployee.Controls.Add(this.labelEmpCategory);
            this.panelEmployee.Controls.Add(this.textBoxEmpPrice);
            this.panelEmployee.Controls.Add(this.labelEmpSalary);
            this.panelEmployee.Controls.Add(this.textBoxEmpName);
            this.panelEmployee.Controls.Add(this.labelEmpName);
            this.panelEmployee.Controls.Add(this.textBoxEmpId);
            this.panelEmployee.Controls.Add(this.labelEmpId);
            this.panelEmployee.Controls.Add(this.labelEmployee);
            this.panelEmployee.Location = new System.Drawing.Point(0, 0);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(200, 522);
            this.panelEmployee.TabIndex = 0;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.ForeColor = System.Drawing.Color.White;
            this.labelEmployee.Location = new System.Drawing.Point(22, 56);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(150, 37);
            this.labelEmployee.TabIndex = 0;
            this.labelEmployee.Text = "EMPLOYEE";
            this.labelEmployee.Click += new System.EventHandler(this.labelEmployee_Click);
            // 
            // textBoxEmpContact
            // 
            this.textBoxEmpContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEmpContact.Location = new System.Drawing.Point(12, 346);
            this.textBoxEmpContact.Name = "textBoxEmpContact";
            this.textBoxEmpContact.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmpContact.TabIndex = 20;
            // 
            // labelEmpContact
            // 
            this.labelEmpContact.AutoSize = true;
            this.labelEmpContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpContact.ForeColor = System.Drawing.Color.White;
            this.labelEmpContact.Location = new System.Drawing.Point(9, 326);
            this.labelEmpContact.Name = "labelEmpContact";
            this.labelEmpContact.Size = new System.Drawing.Size(55, 17);
            this.labelEmpContact.TabIndex = 19;
            this.labelEmpContact.Text = "Contact";
            // 
            // textBoxEmpCategory
            // 
            this.textBoxEmpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEmpCategory.Location = new System.Drawing.Point(12, 294);
            this.textBoxEmpCategory.Name = "textBoxEmpCategory";
            this.textBoxEmpCategory.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmpCategory.TabIndex = 18;
            // 
            // labelEmpCategory
            // 
            this.labelEmpCategory.AutoSize = true;
            this.labelEmpCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpCategory.ForeColor = System.Drawing.Color.White;
            this.labelEmpCategory.Location = new System.Drawing.Point(9, 274);
            this.labelEmpCategory.Name = "labelEmpCategory";
            this.labelEmpCategory.Size = new System.Drawing.Size(128, 17);
            this.labelEmpCategory.TabIndex = 17;
            this.labelEmpCategory.Text = "Employee Category";
            // 
            // textBoxEmpPrice
            // 
            this.textBoxEmpPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEmpPrice.Location = new System.Drawing.Point(12, 236);
            this.textBoxEmpPrice.Name = "textBoxEmpPrice";
            this.textBoxEmpPrice.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmpPrice.TabIndex = 16;
            // 
            // labelEmpSalary
            // 
            this.labelEmpSalary.AutoSize = true;
            this.labelEmpSalary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpSalary.ForeColor = System.Drawing.Color.White;
            this.labelEmpSalary.Location = new System.Drawing.Point(9, 216);
            this.labelEmpSalary.Name = "labelEmpSalary";
            this.labelEmpSalary.Size = new System.Drawing.Size(46, 17);
            this.labelEmpSalary.TabIndex = 15;
            this.labelEmpSalary.Text = "Salary";
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEmpName.Location = new System.Drawing.Point(12, 179);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmpName.TabIndex = 14;
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpName.ForeColor = System.Drawing.Color.White;
            this.labelEmpName.Location = new System.Drawing.Point(9, 159);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(108, 17);
            this.labelEmpName.TabIndex = 13;
            this.labelEmpName.Text = "Employee Name";
            // 
            // textBoxEmpId
            // 
            this.textBoxEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEmpId.Location = new System.Drawing.Point(12, 126);
            this.textBoxEmpId.Name = "textBoxEmpId";
            this.textBoxEmpId.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmpId.TabIndex = 12;
            // 
            // labelEmpId
            // 
            this.labelEmpId.AutoSize = true;
            this.labelEmpId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpId.ForeColor = System.Drawing.Color.White;
            this.labelEmpId.Location = new System.Drawing.Point(9, 106);
            this.labelEmpId.Name = "labelEmpId";
            this.labelEmpId.Size = new System.Drawing.Size(86, 17);
            this.labelEmpId.TabIndex = 11;
            this.labelEmpId.Text = "Employee ID";
            // 
            // textBoxEmpAddress
            // 
            this.textBoxEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEmpAddress.Location = new System.Drawing.Point(12, 401);
            this.textBoxEmpAddress.Multiline = true;
            this.textBoxEmpAddress.Name = "textBoxEmpAddress";
            this.textBoxEmpAddress.Size = new System.Drawing.Size(169, 52);
            this.textBoxEmpAddress.TabIndex = 22;
            // 
            // labelEmpAddress
            // 
            this.labelEmpAddress.AutoSize = true;
            this.labelEmpAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpAddress.ForeColor = System.Drawing.Color.White;
            this.labelEmpAddress.Location = new System.Drawing.Point(9, 381);
            this.labelEmpAddress.Name = "labelEmpAddress";
            this.labelEmpAddress.Size = new System.Drawing.Size(57, 17);
            this.labelEmpAddress.TabIndex = 21;
            this.labelEmpAddress.Text = "Address";
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Location = new System.Drawing.Point(224, 21);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.Size = new System.Drawing.Size(522, 402);
            this.dataGridViewEmp.TabIndex = 1;
            // 
            // buttonEmpClear
            // 
            this.buttonEmpClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonEmpClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpClear.Location = new System.Drawing.Point(635, 441);
            this.buttonEmpClear.Name = "buttonEmpClear";
            this.buttonEmpClear.Size = new System.Drawing.Size(96, 37);
            this.buttonEmpClear.TabIndex = 9;
            this.buttonEmpClear.Text = "CLEAR";
            this.buttonEmpClear.UseVisualStyleBackColor = false;
            // 
            // buttonIEmpDelete
            // 
            this.buttonIEmpDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonIEmpDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIEmpDelete.Location = new System.Drawing.Point(509, 441);
            this.buttonIEmpDelete.Name = "buttonIEmpDelete";
            this.buttonIEmpDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonIEmpDelete.TabIndex = 8;
            this.buttonIEmpDelete.Text = "DELETE";
            this.buttonIEmpDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEmpUpdate
            // 
            this.buttonEmpUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEmpUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpUpdate.Location = new System.Drawing.Point(381, 441);
            this.buttonEmpUpdate.Name = "buttonEmpUpdate";
            this.buttonEmpUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonEmpUpdate.TabIndex = 7;
            this.buttonEmpUpdate.Text = "UPDATE";
            this.buttonEmpUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonEmpAdd
            // 
            this.buttonEmpAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEmpAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpAdd.Location = new System.Drawing.Point(243, 441);
            this.buttonEmpAdd.Name = "buttonEmpAdd";
            this.buttonEmpAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonEmpAdd.TabIndex = 6;
            this.buttonEmpAdd.Text = "ADD";
            this.buttonEmpAdd.UseVisualStyleBackColor = false;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 516);
            this.Controls.Add(this.buttonEmpClear);
            this.Controls.Add(this.buttonIEmpDelete);
            this.Controls.Add(this.buttonEmpUpdate);
            this.Controls.Add(this.buttonEmpAdd);
            this.Controls.Add(this.dataGridViewEmp);
            this.Controls.Add(this.panelEmployee);
            this.Name = "FormEmployee";
            this.Text = "Employee";
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.TextBox textBoxEmpAddress;
        private System.Windows.Forms.Label labelEmpAddress;
        private System.Windows.Forms.TextBox textBoxEmpContact;
        private System.Windows.Forms.Label labelEmpContact;
        private System.Windows.Forms.TextBox textBoxEmpCategory;
        private System.Windows.Forms.Label labelEmpCategory;
        private System.Windows.Forms.TextBox textBoxEmpPrice;
        private System.Windows.Forms.Label labelEmpSalary;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.TextBox textBoxEmpId;
        private System.Windows.Forms.Label labelEmpId;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.Button buttonEmpClear;
        private System.Windows.Forms.Button buttonIEmpDelete;
        private System.Windows.Forms.Button buttonEmpUpdate;
        private System.Windows.Forms.Button buttonEmpAdd;
    }
}