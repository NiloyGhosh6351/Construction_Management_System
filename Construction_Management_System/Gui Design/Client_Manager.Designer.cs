namespace Construction_Management_System.Gui_Design
{
    partial class Client_Manager
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
            this.panelClient = new System.Windows.Forms.Panel();
            this.textBoxClientEmail = new System.Windows.Forms.TextBox();
            this.labelClientEmail = new System.Windows.Forms.Label();
            this.textBoxSupplierAddress = new System.Windows.Forms.TextBox();
            this.labelSupplierAddress = new System.Windows.Forms.Label();
            this.textBoxSupplierContact = new System.Windows.Forms.TextBox();
            this.labelClientContact = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxSupplierId = new System.Windows.Forms.TextBox();
            this.labelClientId = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.buttonEmpClear = new System.Windows.Forms.Button();
            this.buttonIEmpDelete = new System.Windows.Forms.Button();
            this.buttonEmpUpdate = new System.Windows.Forms.Button();
            this.buttonEmpAdd = new System.Windows.Forms.Button();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelClient.Controls.Add(this.pictureBox1);
            this.panelClient.Controls.Add(this.textBoxClientEmail);
            this.panelClient.Controls.Add(this.labelClientEmail);
            this.panelClient.Controls.Add(this.textBoxSupplierAddress);
            this.panelClient.Controls.Add(this.labelSupplierAddress);
            this.panelClient.Controls.Add(this.textBoxSupplierContact);
            this.panelClient.Controls.Add(this.labelClientContact);
            this.panelClient.Controls.Add(this.textBoxSupplierName);
            this.panelClient.Controls.Add(this.labelClientName);
            this.panelClient.Controls.Add(this.textBoxSupplierId);
            this.panelClient.Controls.Add(this.labelClientId);
            this.panelClient.Controls.Add(this.labelClient);
            this.panelClient.Location = new System.Drawing.Point(0, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(211, 521);
            this.panelClient.TabIndex = 1;
            // 
            // textBoxClientEmail
            // 
            this.textBoxClientEmail.Location = new System.Drawing.Point(30, 355);
            this.textBoxClientEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxClientEmail.Name = "textBoxClientEmail";
            this.textBoxClientEmail.Size = new System.Drawing.Size(152, 20);
            this.textBoxClientEmail.TabIndex = 20;
            // 
            // labelClientEmail
            // 
            this.labelClientEmail.AutoSize = true;
            this.labelClientEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientEmail.ForeColor = System.Drawing.Color.White;
            this.labelClientEmail.Location = new System.Drawing.Point(28, 278);
            this.labelClientEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientEmail.Name = "labelClientEmail";
            this.labelClientEmail.Size = new System.Drawing.Size(45, 19);
            this.labelClientEmail.TabIndex = 21;
            this.labelClientEmail.Text = "Email";
            // 
            // textBoxSupplierAddress
            // 
            this.textBoxSupplierAddress.Location = new System.Drawing.Point(30, 405);
            this.textBoxSupplierAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSupplierAddress.Multiline = true;
            this.textBoxSupplierAddress.Name = "textBoxSupplierAddress";
            this.textBoxSupplierAddress.Size = new System.Drawing.Size(152, 56);
            this.textBoxSupplierAddress.TabIndex = 16;
            // 
            // labelSupplierAddress
            // 
            this.labelSupplierAddress.AutoSize = true;
            this.labelSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierAddress.ForeColor = System.Drawing.Color.White;
            this.labelSupplierAddress.Location = new System.Drawing.Point(28, 384);
            this.labelSupplierAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSupplierAddress.Name = "labelSupplierAddress";
            this.labelSupplierAddress.Size = new System.Drawing.Size(63, 19);
            this.labelSupplierAddress.TabIndex = 19;
            this.labelSupplierAddress.Text = "Address";
            // 
            // textBoxSupplierContact
            // 
            this.textBoxSupplierContact.Location = new System.Drawing.Point(30, 303);
            this.textBoxSupplierContact.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSupplierContact.Name = "textBoxSupplierContact";
            this.textBoxSupplierContact.Size = new System.Drawing.Size(152, 20);
            this.textBoxSupplierContact.TabIndex = 13;
            // 
            // labelClientContact
            // 
            this.labelClientContact.AutoSize = true;
            this.labelClientContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientContact.ForeColor = System.Drawing.Color.White;
            this.labelClientContact.Location = new System.Drawing.Point(28, 226);
            this.labelClientContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientContact.Name = "labelClientContact";
            this.labelClientContact.Size = new System.Drawing.Size(60, 19);
            this.labelClientContact.TabIndex = 17;
            this.labelClientContact.Text = "Contact";
            this.labelClientContact.Click += new System.EventHandler(this.labelClientContact_Click);
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Location = new System.Drawing.Point(30, 247);
            this.textBoxSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(152, 20);
            this.textBoxSupplierName.TabIndex = 11;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.ForeColor = System.Drawing.Color.White;
            this.labelClientName.Location = new System.Drawing.Point(28, 222);
            this.labelClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(91, 19);
            this.labelClientName.TabIndex = 15;
            this.labelClientName.Text = "Client Name";
            // 
            // textBoxSupplierId
            // 
            this.textBoxSupplierId.Location = new System.Drawing.Point(30, 187);
            this.textBoxSupplierId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSupplierId.Name = "textBoxSupplierId";
            this.textBoxSupplierId.Size = new System.Drawing.Size(152, 20);
            this.textBoxSupplierId.TabIndex = 10;
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientId.ForeColor = System.Drawing.Color.White;
            this.labelClientId.Location = new System.Drawing.Point(28, 162);
            this.labelClientId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(65, 19);
            this.labelClientId.TabIndex = 12;
            this.labelClientId.Text = "Client ID";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.White;
            this.labelClient.Location = new System.Drawing.Point(41, 91);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(123, 50);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Client";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Construction_Management_System.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(237, 35);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(509, 382);
            this.dataGridViewClient.TabIndex = 2;
            // 
            // buttonEmpClear
            // 
            this.buttonEmpClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonEmpClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEmpClear.Location = new System.Drawing.Point(638, 444);
            this.buttonEmpClear.Name = "buttonEmpClear";
            this.buttonEmpClear.Size = new System.Drawing.Size(96, 37);
            this.buttonEmpClear.TabIndex = 17;
            this.buttonEmpClear.Text = "CLEAR";
            this.buttonEmpClear.UseVisualStyleBackColor = false;
            // 
            // buttonIEmpDelete
            // 
            this.buttonIEmpDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonIEmpDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIEmpDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonIEmpDelete.Location = new System.Drawing.Point(512, 444);
            this.buttonIEmpDelete.Name = "buttonIEmpDelete";
            this.buttonIEmpDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonIEmpDelete.TabIndex = 16;
            this.buttonIEmpDelete.Text = "DELETE";
            this.buttonIEmpDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEmpUpdate
            // 
            this.buttonEmpUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEmpUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEmpUpdate.Location = new System.Drawing.Point(384, 444);
            this.buttonEmpUpdate.Name = "buttonEmpUpdate";
            this.buttonEmpUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonEmpUpdate.TabIndex = 15;
            this.buttonEmpUpdate.Text = "UPDATE";
            this.buttonEmpUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonEmpAdd
            // 
            this.buttonEmpAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEmpAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEmpAdd.Location = new System.Drawing.Point(246, 444);
            this.buttonEmpAdd.Name = "buttonEmpAdd";
            this.buttonEmpAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonEmpAdd.TabIndex = 14;
            this.buttonEmpAdd.Text = "ADD";
            this.buttonEmpAdd.UseVisualStyleBackColor = false;
            // 
            // Client_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 516);
            this.Controls.Add(this.buttonEmpClear);
            this.Controls.Add(this.buttonIEmpDelete);
            this.Controls.Add(this.buttonEmpUpdate);
            this.Controls.Add(this.buttonEmpAdd);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.panelClient);
            this.Name = "Client_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENT";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxClientEmail;
        private System.Windows.Forms.Label labelClientEmail;
        private System.Windows.Forms.TextBox textBoxSupplierAddress;
        private System.Windows.Forms.Label labelSupplierAddress;
        private System.Windows.Forms.TextBox textBoxSupplierContact;
        private System.Windows.Forms.Label labelClientContact;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxSupplierId;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonEmpClear;
        private System.Windows.Forms.Button buttonIEmpDelete;
        private System.Windows.Forms.Button buttonEmpUpdate;
        private System.Windows.Forms.Button buttonEmpAdd;
    }
}