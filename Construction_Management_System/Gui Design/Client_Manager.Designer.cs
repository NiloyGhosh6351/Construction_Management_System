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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxClientContact = new System.Windows.Forms.TextBox();
            this.labelClientEmail = new System.Windows.Forms.Label();
            this.textBoxClientAddress = new System.Windows.Forms.TextBox();
            this.labelSupplierAddress = new System.Windows.Forms.Label();
            this.textBoxClientEmail = new System.Windows.Forms.TextBox();
            this.labelClientContact = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.labelClientId = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.buttonClientClear = new System.Windows.Forms.Button();
            this.buttonIClientDelete = new System.Windows.Forms.Button();
            this.buttonClientUpdate = new System.Windows.Forms.Button();
            this.buttonClientAdd = new System.Windows.Forms.Button();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelClient.Controls.Add(this.pictureBox1);
            this.panelClient.Controls.Add(this.textBoxClientContact);
            this.panelClient.Controls.Add(this.labelClientEmail);
            this.panelClient.Controls.Add(this.textBoxClientAddress);
            this.panelClient.Controls.Add(this.labelSupplierAddress);
            this.panelClient.Controls.Add(this.textBoxClientEmail);
            this.panelClient.Controls.Add(this.labelClientContact);
            this.panelClient.Controls.Add(this.textBoxClientName);
            this.panelClient.Controls.Add(this.labelClientName);
            this.panelClient.Controls.Add(this.textBoxClientId);
            this.panelClient.Controls.Add(this.labelClientId);
            this.panelClient.Controls.Add(this.labelClient);
            this.panelClient.Location = new System.Drawing.Point(0, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(211, 521);
            this.panelClient.TabIndex = 1;
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
            // textBoxClientContact
            // 
            this.textBoxClientContact.Location = new System.Drawing.Point(30, 355);
            this.textBoxClientContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxClientContact.Name = "textBoxClientContact";
            this.textBoxClientContact.Size = new System.Drawing.Size(152, 20);
            this.textBoxClientContact.TabIndex = 20;
            this.textBoxClientContact.TextChanged += new System.EventHandler(this.textBoxClientContact_TextChanged);
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
            // textBoxClientAddress
            // 
            this.textBoxClientAddress.Location = new System.Drawing.Point(30, 405);
            this.textBoxClientAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxClientAddress.Multiline = true;
            this.textBoxClientAddress.Name = "textBoxClientAddress";
            this.textBoxClientAddress.Size = new System.Drawing.Size(152, 56);
            this.textBoxClientAddress.TabIndex = 16;
            this.textBoxClientAddress.TextChanged += new System.EventHandler(this.textBoxClientAddress_TextChanged);
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
            // textBoxClientEmail
            // 
            this.textBoxClientEmail.Location = new System.Drawing.Point(31, 303);
            this.textBoxClientEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxClientEmail.Name = "textBoxClientEmail";
            this.textBoxClientEmail.Size = new System.Drawing.Size(152, 20);
            this.textBoxClientEmail.TabIndex = 13;
            this.textBoxClientEmail.TextChanged += new System.EventHandler(this.textBoxClientEmail_TextChanged);
            // 
            // labelClientContact
            // 
            this.labelClientContact.AutoSize = true;
            this.labelClientContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientContact.ForeColor = System.Drawing.Color.White;
            this.labelClientContact.Location = new System.Drawing.Point(28, 334);
            this.labelClientContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientContact.Name = "labelClientContact";
            this.labelClientContact.Size = new System.Drawing.Size(60, 19);
            this.labelClientContact.TabIndex = 17;
            this.labelClientContact.Text = "Contact";
            this.labelClientContact.Click += new System.EventHandler(this.labelClientContact_Click);
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(30, 247);
            this.textBoxClientName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(152, 20);
            this.textBoxClientName.TabIndex = 11;
            this.textBoxClientName.TextChanged += new System.EventHandler(this.textBoxClientName_TextChanged);
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
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(30, 187);
            this.textBoxClientId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(152, 20);
            this.textBoxClientId.TabIndex = 10;
            this.textBoxClientId.TextChanged += new System.EventHandler(this.textBoxClientId_TextChanged);
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
            // dataGridViewClient
            // 
            this.dataGridViewClient.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(237, 35);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.Size = new System.Drawing.Size(509, 382);
            this.dataGridViewClient.TabIndex = 2;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            // 
            // buttonClientClear
            // 
            this.buttonClientClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonClientClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClientClear.Location = new System.Drawing.Point(638, 444);
            this.buttonClientClear.Name = "buttonClientClear";
            this.buttonClientClear.Size = new System.Drawing.Size(96, 37);
            this.buttonClientClear.TabIndex = 17;
            this.buttonClientClear.Text = "CLEAR";
            this.buttonClientClear.UseVisualStyleBackColor = false;
            this.buttonClientClear.Click += new System.EventHandler(this.buttonClientClear_Click);
            // 
            // buttonIClientDelete
            // 
            this.buttonIClientDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonIClientDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIClientDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonIClientDelete.Location = new System.Drawing.Point(512, 444);
            this.buttonIClientDelete.Name = "buttonIClientDelete";
            this.buttonIClientDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonIClientDelete.TabIndex = 16;
            this.buttonIClientDelete.Text = "DELETE";
            this.buttonIClientDelete.UseVisualStyleBackColor = false;
            this.buttonIClientDelete.Click += new System.EventHandler(this.buttonIClientDelete_Click);
            // 
            // buttonClientUpdate
            // 
            this.buttonClientUpdate.AllowDrop = true;
            this.buttonClientUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonClientUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClientUpdate.Location = new System.Drawing.Point(384, 444);
            this.buttonClientUpdate.Name = "buttonClientUpdate";
            this.buttonClientUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonClientUpdate.TabIndex = 15;
            this.buttonClientUpdate.Text = "UPDATE";
            this.buttonClientUpdate.UseVisualStyleBackColor = false;
            this.buttonClientUpdate.Click += new System.EventHandler(this.buttonClientUpdate_Click);
            // 
            // buttonClientAdd
            // 
            this.buttonClientAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonClientAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClientAdd.Location = new System.Drawing.Point(246, 444);
            this.buttonClientAdd.Name = "buttonClientAdd";
            this.buttonClientAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonClientAdd.TabIndex = 14;
            this.buttonClientAdd.Text = "ADD";
            this.buttonClientAdd.UseVisualStyleBackColor = false;
            this.buttonClientAdd.Click += new System.EventHandler(this.buttonClientAdd_Click);
            // 
            // Client_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 516);
            this.Controls.Add(this.buttonClientClear);
            this.Controls.Add(this.buttonIClientDelete);
            this.Controls.Add(this.buttonClientUpdate);
            this.Controls.Add(this.buttonClientAdd);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.panelClient);
            this.Name = "Client_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENT";
            this.Load += new System.EventHandler(this.Client_Manager_Load);
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxClientContact;
        private System.Windows.Forms.Label labelClientEmail;
        private System.Windows.Forms.TextBox textBoxClientAddress;
        private System.Windows.Forms.Label labelSupplierAddress;
        private System.Windows.Forms.TextBox textBoxClientEmail;
        private System.Windows.Forms.Label labelClientContact;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonClientClear;
        private System.Windows.Forms.Button buttonIClientDelete;
        private System.Windows.Forms.Button buttonClientUpdate;
        private System.Windows.Forms.Button buttonClientAdd;
    }
}