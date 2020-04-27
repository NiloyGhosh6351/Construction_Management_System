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
            this.panelClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(281, 641);
            this.panelClient.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Construction_Management_System.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(19, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxClientContact
            // 
            this.textBoxClientContact.Location = new System.Drawing.Point(40, 437);
            this.textBoxClientContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClientContact.Name = "textBoxClientContact";
            this.textBoxClientContact.Size = new System.Drawing.Size(201, 22);
            this.textBoxClientContact.TabIndex = 20;
            this.textBoxClientContact.TextChanged += new System.EventHandler(this.textBoxClientContact_TextChanged);
            // 
            // labelClientEmail
            // 
            this.labelClientEmail.AutoSize = true;
            this.labelClientEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientEmail.ForeColor = System.Drawing.Color.White;
            this.labelClientEmail.Location = new System.Drawing.Point(37, 342);
            this.labelClientEmail.Name = "labelClientEmail";
            this.labelClientEmail.Size = new System.Drawing.Size(54, 23);
            this.labelClientEmail.TabIndex = 21;
            this.labelClientEmail.Text = "Email";
            // 
            // textBoxClientAddress
            // 
            this.textBoxClientAddress.Location = new System.Drawing.Point(40, 498);
            this.textBoxClientAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClientAddress.Multiline = true;
            this.textBoxClientAddress.Name = "textBoxClientAddress";
            this.textBoxClientAddress.Size = new System.Drawing.Size(201, 68);
            this.textBoxClientAddress.TabIndex = 16;
            this.textBoxClientAddress.TextChanged += new System.EventHandler(this.textBoxClientAddress_TextChanged);
            // 
            // labelSupplierAddress
            // 
            this.labelSupplierAddress.AutoSize = true;
            this.labelSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierAddress.ForeColor = System.Drawing.Color.White;
            this.labelSupplierAddress.Location = new System.Drawing.Point(37, 473);
            this.labelSupplierAddress.Name = "labelSupplierAddress";
            this.labelSupplierAddress.Size = new System.Drawing.Size(74, 23);
            this.labelSupplierAddress.TabIndex = 19;
            this.labelSupplierAddress.Text = "Address";
            // 
            // textBoxClientEmail
            // 
            this.textBoxClientEmail.Location = new System.Drawing.Point(41, 373);
            this.textBoxClientEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClientEmail.Name = "textBoxClientEmail";
            this.textBoxClientEmail.Size = new System.Drawing.Size(201, 22);
            this.textBoxClientEmail.TabIndex = 13;
            this.textBoxClientEmail.TextChanged += new System.EventHandler(this.textBoxClientEmail_TextChanged);
            // 
            // labelClientContact
            // 
            this.labelClientContact.AutoSize = true;
            this.labelClientContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientContact.ForeColor = System.Drawing.Color.White;
            this.labelClientContact.Location = new System.Drawing.Point(37, 411);
            this.labelClientContact.Name = "labelClientContact";
            this.labelClientContact.Size = new System.Drawing.Size(72, 23);
            this.labelClientContact.TabIndex = 17;
            this.labelClientContact.Text = "Contact";
            this.labelClientContact.Click += new System.EventHandler(this.labelClientContact_Click);
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(40, 304);
            this.textBoxClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(201, 22);
            this.textBoxClientName.TabIndex = 11;
            this.textBoxClientName.TextChanged += new System.EventHandler(this.textBoxClientName_TextChanged);
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.ForeColor = System.Drawing.Color.White;
            this.labelClientName.Location = new System.Drawing.Point(37, 273);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(109, 23);
            this.labelClientName.TabIndex = 15;
            this.labelClientName.Text = "Client Name";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(40, 230);
            this.textBoxClientId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(201, 22);
            this.textBoxClientId.TabIndex = 10;
            this.textBoxClientId.TextChanged += new System.EventHandler(this.textBoxClientId_TextChanged);
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientId.ForeColor = System.Drawing.Color.White;
            this.labelClientId.Location = new System.Drawing.Point(37, 199);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(80, 23);
            this.labelClientId.TabIndex = 12;
            this.labelClientId.Text = "Client ID";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.White;
            this.labelClient.Location = new System.Drawing.Point(55, 112);
            this.labelClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(153, 62);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Client";
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(316, 43);
            this.dataGridViewClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.Size = new System.Drawing.Size(679, 470);
            this.dataGridViewClient.TabIndex = 2;
            // 
            // buttonClientClear
            // 
            this.buttonClientClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonClientClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClientClear.Location = new System.Drawing.Point(851, 546);
            this.buttonClientClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClientClear.Name = "buttonClientClear";
            this.buttonClientClear.Size = new System.Drawing.Size(128, 46);
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
            this.buttonIClientDelete.Location = new System.Drawing.Point(683, 546);
            this.buttonIClientDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIClientDelete.Name = "buttonIClientDelete";
            this.buttonIClientDelete.Size = new System.Drawing.Size(128, 46);
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
            this.buttonClientUpdate.Location = new System.Drawing.Point(512, 546);
            this.buttonClientUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClientUpdate.Name = "buttonClientUpdate";
            this.buttonClientUpdate.Size = new System.Drawing.Size(128, 46);
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
            this.buttonClientAdd.Location = new System.Drawing.Point(328, 546);
            this.buttonClientAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClientAdd.Name = "buttonClientAdd";
            this.buttonClientAdd.Size = new System.Drawing.Size(128, 46);
            this.buttonClientAdd.TabIndex = 14;
            this.buttonClientAdd.Text = "ADD";
            this.buttonClientAdd.UseVisualStyleBackColor = false;
            this.buttonClientAdd.Click += new System.EventHandler(this.buttonClientAdd_Click);
            // 
            // Client_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1028, 635);
            this.Controls.Add(this.buttonClientClear);
            this.Controls.Add(this.buttonIClientDelete);
            this.Controls.Add(this.buttonClientUpdate);
            this.Controls.Add(this.buttonClientAdd);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.panelClient);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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