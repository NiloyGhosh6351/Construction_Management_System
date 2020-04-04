namespace Construction_Management_System
{
    partial class FormUser
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
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonItemClear = new System.Windows.Forms.Button();
            this.buttonItemDelete = new System.Windows.Forms.Button();
            this.buttonItemUpdate = new System.Windows.Forms.Button();
            this.buttonItemAdd = new System.Windows.Forms.Button();
            this.textBoxUserAddress = new System.Windows.Forms.TextBox();
            this.labelUserAddress = new System.Windows.Forms.Label();
            this.textBoxUserCatagory = new System.Windows.Forms.TextBox();
            this.labelUserCatagory = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUName = new System.Windows.Forms.TextBox();
            this.labelUName = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.labelUserId = new System.Windows.Forms.Label();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelUser.Controls.Add(this.textBoxUserAddress);
            this.panelUser.Controls.Add(this.labelUserAddress);
            this.panelUser.Controls.Add(this.textBoxUserCatagory);
            this.panelUser.Controls.Add(this.labelUserCatagory);
            this.panelUser.Controls.Add(this.textBoxUserPassword);
            this.panelUser.Controls.Add(this.labelUserPassword);
            this.panelUser.Controls.Add(this.textBoxUserName);
            this.panelUser.Controls.Add(this.labelUserName);
            this.panelUser.Controls.Add(this.textBoxUName);
            this.panelUser.Controls.Add(this.labelUName);
            this.panelUser.Controls.Add(this.textBoxUserId);
            this.panelUser.Controls.Add(this.labelUserId);
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Location = new System.Drawing.Point(-2, -1);
            this.panelUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(204, 507);
            this.panelUser.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(52, 59);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(84, 37);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "USER";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 362);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonItemClear
            // 
            this.buttonItemClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonItemClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemClear.Location = new System.Drawing.Point(652, 433);
            this.buttonItemClear.Name = "buttonItemClear";
            this.buttonItemClear.Size = new System.Drawing.Size(96, 37);
            this.buttonItemClear.TabIndex = 9;
            this.buttonItemClear.Text = "CLEAR";
            this.buttonItemClear.UseVisualStyleBackColor = false;
            // 
            // buttonItemDelete
            // 
            this.buttonItemDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonItemDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemDelete.Location = new System.Drawing.Point(526, 433);
            this.buttonItemDelete.Name = "buttonItemDelete";
            this.buttonItemDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonItemDelete.TabIndex = 8;
            this.buttonItemDelete.Text = "DELETE";
            this.buttonItemDelete.UseVisualStyleBackColor = false;
            // 
            // buttonItemUpdate
            // 
            this.buttonItemUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonItemUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemUpdate.Location = new System.Drawing.Point(398, 433);
            this.buttonItemUpdate.Name = "buttonItemUpdate";
            this.buttonItemUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonItemUpdate.TabIndex = 7;
            this.buttonItemUpdate.Text = "UPDATE";
            this.buttonItemUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonItemAdd
            // 
            this.buttonItemAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonItemAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemAdd.Location = new System.Drawing.Point(260, 433);
            this.buttonItemAdd.Name = "buttonItemAdd";
            this.buttonItemAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonItemAdd.TabIndex = 6;
            this.buttonItemAdd.Text = "ADD";
            this.buttonItemAdd.UseVisualStyleBackColor = false;
            // 
            // textBoxUserAddress
            // 
            this.textBoxUserAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxUserAddress.Location = new System.Drawing.Point(14, 397);
            this.textBoxUserAddress.Multiline = true;
            this.textBoxUserAddress.Name = "textBoxUserAddress";
            this.textBoxUserAddress.Size = new System.Drawing.Size(169, 52);
            this.textBoxUserAddress.TabIndex = 34;
            this.textBoxUserAddress.TextChanged += new System.EventHandler(this.textBoxEmpAddress_TextChanged);
            // 
            // labelUserAddress
            // 
            this.labelUserAddress.AutoSize = true;
            this.labelUserAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserAddress.ForeColor = System.Drawing.Color.White;
            this.labelUserAddress.Location = new System.Drawing.Point(11, 377);
            this.labelUserAddress.Name = "labelUserAddress";
            this.labelUserAddress.Size = new System.Drawing.Size(57, 17);
            this.labelUserAddress.TabIndex = 33;
            this.labelUserAddress.Text = "Address";
            this.labelUserAddress.Click += new System.EventHandler(this.labelEmpAddress_Click);
            // 
            // textBoxUserCatagory
            // 
            this.textBoxUserCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxUserCatagory.Location = new System.Drawing.Point(14, 342);
            this.textBoxUserCatagory.Name = "textBoxUserCatagory";
            this.textBoxUserCatagory.Size = new System.Drawing.Size(169, 20);
            this.textBoxUserCatagory.TabIndex = 32;
            this.textBoxUserCatagory.TextChanged += new System.EventHandler(this.textBoxEmpContact_TextChanged);
            // 
            // labelUserCatagory
            // 
            this.labelUserCatagory.AutoSize = true;
            this.labelUserCatagory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserCatagory.ForeColor = System.Drawing.Color.White;
            this.labelUserCatagory.Location = new System.Drawing.Point(11, 322);
            this.labelUserCatagory.Name = "labelUserCatagory";
            this.labelUserCatagory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUserCatagory.Size = new System.Drawing.Size(64, 17);
            this.labelUserCatagory.TabIndex = 31;
            this.labelUserCatagory.Text = "Catagory";
            this.labelUserCatagory.Click += new System.EventHandler(this.labelEmpContact_Click);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxUserPassword.Location = new System.Drawing.Point(14, 290);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(169, 20);
            this.textBoxUserPassword.TabIndex = 30;
            this.textBoxUserPassword.TextChanged += new System.EventHandler(this.textBoxEmpCategory_TextChanged);
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPassword.ForeColor = System.Drawing.Color.White;
            this.labelUserPassword.Location = new System.Drawing.Point(11, 270);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(66, 17);
            this.labelUserPassword.TabIndex = 29;
            this.labelUserPassword.Text = "Password";
            this.labelUserPassword.Click += new System.EventHandler(this.labelEmpCategory_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxUserName.Location = new System.Drawing.Point(14, 232);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(169, 20);
            this.textBoxUserName.TabIndex = 28;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxEmpPrice_TextChanged);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(11, 212);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(69, 17);
            this.labelUserName.TabIndex = 27;
            this.labelUserName.Text = "Username";
            this.labelUserName.Click += new System.EventHandler(this.labelEmpSalary_Click);
            // 
            // textBoxUName
            // 
            this.textBoxUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxUName.Location = new System.Drawing.Point(14, 175);
            this.textBoxUName.Name = "textBoxUName";
            this.textBoxUName.Size = new System.Drawing.Size(169, 20);
            this.textBoxUName.TabIndex = 26;
            this.textBoxUName.TextChanged += new System.EventHandler(this.textBoxEmpName_TextChanged);
            // 
            // labelUName
            // 
            this.labelUName.AutoSize = true;
            this.labelUName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUName.ForeColor = System.Drawing.Color.White;
            this.labelUName.Location = new System.Drawing.Point(11, 155);
            this.labelUName.Name = "labelUName";
            this.labelUName.Size = new System.Drawing.Size(44, 17);
            this.labelUName.TabIndex = 25;
            this.labelUName.Text = "Name";
            this.labelUName.Click += new System.EventHandler(this.labelEmpName_Click);
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxUserId.Location = new System.Drawing.Point(14, 122);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(169, 20);
            this.textBoxUserId.TabIndex = 24;
            this.textBoxUserId.TextChanged += new System.EventHandler(this.textBoxEmpId_TextChanged);
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.ForeColor = System.Drawing.Color.White;
            this.labelUserId.Location = new System.Drawing.Point(11, 102);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(53, 17);
            this.labelUserId.TabIndex = 23;
            this.labelUserId.Text = "User ID";
            this.labelUserId.Click += new System.EventHandler(this.labelEmpId_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.buttonItemClear);
            this.Controls.Add(this.buttonItemDelete);
            this.Controls.Add(this.buttonItemUpdate);
            this.Controls.Add(this.buttonItemAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUser";
            this.Text = "User";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonItemClear;
        private System.Windows.Forms.Button buttonItemDelete;
        private System.Windows.Forms.Button buttonItemUpdate;
        private System.Windows.Forms.Button buttonItemAdd;
        private System.Windows.Forms.TextBox textBoxUserAddress;
        private System.Windows.Forms.Label labelUserAddress;
        private System.Windows.Forms.TextBox textBoxUserCatagory;
        private System.Windows.Forms.Label labelUserCatagory;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUName;
        private System.Windows.Forms.Label labelUName;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label labelUserId;
    }
}