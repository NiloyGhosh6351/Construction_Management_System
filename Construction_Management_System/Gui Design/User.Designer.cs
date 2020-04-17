﻿namespace Construction_Management_System
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
            this.textBoxUserAddress = new System.Windows.Forms.TextBox();
            this.labelUserAdress = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserType = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.buttonUserClear = new System.Windows.Forms.Button();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.buttonUserUpdate = new System.Windows.Forms.Button();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.textBoxUserContact = new System.Windows.Forms.TextBox();
            this.lableUserContact = new System.Windows.Forms.Label();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelUser.Controls.Add(this.textBoxUserContact);
            this.panelUser.Controls.Add(this.lableUserContact);
            this.panelUser.Controls.Add(this.comboBoxUserType);
            this.panelUser.Controls.Add(this.textBoxUserAddress);
            this.panelUser.Controls.Add(this.labelUserAdress);
            this.panelUser.Controls.Add(this.textBoxName);
            this.panelUser.Controls.Add(this.labelName);
            this.panelUser.Controls.Add(this.textBoxUserPassword);
            this.panelUser.Controls.Add(this.labelUserPassword);
            this.panelUser.Controls.Add(this.labelUserType);
            this.panelUser.Controls.Add(this.textBoxUserName);
            this.panelUser.Controls.Add(this.labelUserName);
            this.panelUser.Controls.Add(this.textBoxUserId);
            this.panelUser.Controls.Add(this.labelUserId);
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Location = new System.Drawing.Point(-2, -1);
            this.panelUser.Margin = new System.Windows.Forms.Padding(2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(204, 507);
            this.panelUser.TabIndex = 0;
            // 
            // textBoxUserAddress
            // 
            this.textBoxUserAddress.Location = new System.Drawing.Point(12, 394);
            this.textBoxUserAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserAddress.Multiline = true;
            this.textBoxUserAddress.Name = "textBoxUserAddress";
            this.textBoxUserAddress.Size = new System.Drawing.Size(166, 75);
            this.textBoxUserAddress.TabIndex = 12;
            this.textBoxUserAddress.TextChanged += new System.EventHandler(this.textBoxUserAdress_TextChanged);
            // 
            // labelUserAdress
            // 
            this.labelUserAdress.AutoSize = true;
            this.labelUserAdress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserAdress.ForeColor = System.Drawing.Color.White;
            this.labelUserAdress.Location = new System.Drawing.Point(11, 373);
            this.labelUserAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserAdress.Name = "labelUserAdress";
            this.labelUserAdress.Size = new System.Drawing.Size(63, 19);
            this.labelUserAdress.TabIndex = 11;
            this.labelUserAdress.Text = "Address";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 133);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(167, 20);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(13, 112);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 19);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxUserPassword.Location = new System.Drawing.Point(12, 234);
            this.textBoxUserPassword.Margin = new System.Windows.Forms.Padding(2);
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
            this.labelUserPassword.Location = new System.Drawing.Point(10, 215);
            this.labelUserPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(66, 17);
            this.labelUserPassword.TabIndex = 29;
            this.labelUserPassword.Text = "Password";
            this.labelUserPassword.Click += new System.EventHandler(this.labelEmpCategory_Click);
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserType.ForeColor = System.Drawing.Color.White;
            this.labelUserType.Location = new System.Drawing.Point(11, 267);
            this.labelUserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(71, 19);
            this.labelUserType.TabIndex = 5;
            this.labelUserType.Text = "UserType";
            this.labelUserType.Click += new System.EventHandler(this.labelUserType_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxUserName.Location = new System.Drawing.Point(13, 184);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(2);
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
            this.labelUserName.Location = new System.Drawing.Point(12, 165);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(69, 17);
            this.labelUserName.TabIndex = 27;
            this.labelUserName.Text = "Username";
            this.labelUserName.Click += new System.EventHandler(this.labelEmpSalary_Click);
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxUserId.Location = new System.Drawing.Point(15, 79);
            this.textBoxUserId.Margin = new System.Windows.Forms.Padding(2);
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
            this.labelUserId.Location = new System.Drawing.Point(16, 60);
            this.labelUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(53, 17);
            this.labelUserId.TabIndex = 23;
            this.labelUserId.Text = "User ID";
            this.labelUserId.Click += new System.EventHandler(this.labelEmpId_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(55, 10);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(84, 37);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "USER";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(228, 29);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(546, 362);
            this.dataGridViewUser.TabIndex = 1;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            // 
            // buttonUserClear
            // 
            this.buttonUserClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonUserClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserClear.Location = new System.Drawing.Point(652, 433);
            this.buttonUserClear.Name = "buttonUserClear";
            this.buttonUserClear.Size = new System.Drawing.Size(96, 37);
            this.buttonUserClear.TabIndex = 9;
            this.buttonUserClear.Text = "CLEAR";
            this.buttonUserClear.UseVisualStyleBackColor = false;
            this.buttonUserClear.Click += new System.EventHandler(this.buttonUserClear_Click);
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonUserDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserDelete.Location = new System.Drawing.Point(526, 433);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonUserDelete.TabIndex = 8;
            this.buttonUserDelete.Text = "DELETE";
            this.buttonUserDelete.UseVisualStyleBackColor = false;
            this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
            // 
            // buttonUserUpdate
            // 
            this.buttonUserUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonUserUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserUpdate.Location = new System.Drawing.Point(398, 433);
            this.buttonUserUpdate.Name = "buttonUserUpdate";
            this.buttonUserUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonUserUpdate.TabIndex = 7;
            this.buttonUserUpdate.Text = "UPDATE";
            this.buttonUserUpdate.UseVisualStyleBackColor = false;
            this.buttonUserUpdate.Click += new System.EventHandler(this.buttonUserUpdate_Click);
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUserAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserAdd.Location = new System.Drawing.Point(260, 433);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonUserAdd.TabIndex = 6;
            this.buttonUserAdd.Text = "ADD";
            this.buttonUserAdd.UseVisualStyleBackColor = false;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Location = new System.Drawing.Point(12, 289);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(165, 21);
            this.comboBoxUserType.TabIndex = 31;
            this.comboBoxUserType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxUserContact
            // 
            this.textBoxUserContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxUserContact.Location = new System.Drawing.Point(11, 344);
            this.textBoxUserContact.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserContact.Name = "textBoxUserContact";
            this.textBoxUserContact.Size = new System.Drawing.Size(169, 20);
            this.textBoxUserContact.TabIndex = 33;
            // 
            // lableUserContact
            // 
            this.lableUserContact.AutoSize = true;
            this.lableUserContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableUserContact.ForeColor = System.Drawing.Color.White;
            this.lableUserContact.Location = new System.Drawing.Point(10, 325);
            this.lableUserContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableUserContact.Name = "lableUserContact";
            this.lableUserContact.Size = new System.Drawing.Size(55, 17);
            this.lableUserContact.TabIndex = 32;
            this.lableUserContact.Text = "Contact";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.buttonUserClear);
            this.Controls.Add(this.buttonUserDelete);
            this.Controls.Add(this.buttonUserUpdate);
            this.Controls.Add(this.buttonUserAdd);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.panelUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUser";
            this.Text = "User";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelUser;
//<<<<<<< HEAD
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserName;
//=======
//>>>>>>> f58b353803b35c90697631ca42f0fc1fabbdddfb
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Button buttonUserClear;
        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Button buttonUserUpdate;
        private System.Windows.Forms.Button buttonUserAdd;
//<<<<<<< HEAD
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxUserAddress;
        private System.Windows.Forms.Label labelUserAdress;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.TextBox textBoxUserContact;
        private System.Windows.Forms.Label lableUserContact;
        //=======



    }
}