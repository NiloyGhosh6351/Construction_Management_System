namespace Construction_Management_System.Gui_Design
{
    partial class Supplier_Manager
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxItemCatagory = new System.Windows.Forms.ComboBox();
            this.textBoxSupplierAddress = new System.Windows.Forms.TextBox();
            this.labelSupplierAddress = new System.Windows.Forms.Label();
            this.labelSupplierItem = new System.Windows.Forms.Label();
            this.textBoxSupplierContact = new System.Windows.Forms.TextBox();
            this.labelSupplierContact = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.textBoxSupplierId = new System.Windows.Forms.TextBox();
            this.labelSupplierId = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSupplierClear = new System.Windows.Forms.Button();
            this.buttonSupplierDelete = new System.Windows.Forms.Button();
            this.buttonSupplierUpdate = new System.Windows.Forms.Button();
            this.buttonSupplierAdd = new System.Windows.Forms.Button();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelUser.Controls.Add(this.pictureBox1);
            this.panelUser.Controls.Add(this.comboBoxItemCatagory);
            this.panelUser.Controls.Add(this.textBoxSupplierAddress);
            this.panelUser.Controls.Add(this.labelSupplierAddress);
            this.panelUser.Controls.Add(this.labelSupplierItem);
            this.panelUser.Controls.Add(this.textBoxSupplierContact);
            this.panelUser.Controls.Add(this.labelSupplierContact);
            this.panelUser.Controls.Add(this.textBoxSupplierName);
            this.panelUser.Controls.Add(this.labelSupplierName);
            this.panelUser.Controls.Add(this.textBoxSupplierId);
            this.panelUser.Controls.Add(this.labelSupplierId);
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Location = new System.Drawing.Point(-4, -2);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(277, 639);
            this.panelUser.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Construction_Management_System.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxItemCatagory
            // 
            this.comboBoxItemCatagory.FormattingEnabled = true;
            this.comboBoxItemCatagory.Location = new System.Drawing.Point(28, 427);
            this.comboBoxItemCatagory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxItemCatagory.Name = "comboBoxItemCatagory";
            this.comboBoxItemCatagory.Size = new System.Drawing.Size(201, 24);
            this.comboBoxItemCatagory.TabIndex = 3;
            // 
            // textBoxSupplierAddress
            // 
            this.textBoxSupplierAddress.Location = new System.Drawing.Point(29, 505);
            this.textBoxSupplierAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSupplierAddress.Multiline = true;
            this.textBoxSupplierAddress.Name = "textBoxSupplierAddress";
            this.textBoxSupplierAddress.Size = new System.Drawing.Size(201, 68);
            this.textBoxSupplierAddress.TabIndex = 4;
            // 
            // labelSupplierAddress
            // 
            this.labelSupplierAddress.AutoSize = true;
            this.labelSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierAddress.ForeColor = System.Drawing.Color.White;
            this.labelSupplierAddress.Location = new System.Drawing.Point(25, 474);
            this.labelSupplierAddress.Name = "labelSupplierAddress";
            this.labelSupplierAddress.Size = new System.Drawing.Size(74, 23);
            this.labelSupplierAddress.TabIndex = 9;
            this.labelSupplierAddress.Text = "Address";
            // 
            // labelSupplierItem
            // 
            this.labelSupplierItem.AutoSize = true;
            this.labelSupplierItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierItem.ForeColor = System.Drawing.Color.White;
            this.labelSupplierItem.Location = new System.Drawing.Point(24, 400);
            this.labelSupplierItem.Name = "labelSupplierItem";
            this.labelSupplierItem.Size = new System.Drawing.Size(126, 23);
            this.labelSupplierItem.TabIndex = 7;
            this.labelSupplierItem.Text = "Item Catagory";
            // 
            // textBoxSupplierContact
            // 
            this.textBoxSupplierContact.Location = new System.Drawing.Point(27, 356);
            this.textBoxSupplierContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSupplierContact.Name = "textBoxSupplierContact";
            this.textBoxSupplierContact.Size = new System.Drawing.Size(201, 22);
            this.textBoxSupplierContact.TabIndex = 2;
            // 
            // labelSupplierContact
            // 
            this.labelSupplierContact.AutoSize = true;
            this.labelSupplierContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierContact.ForeColor = System.Drawing.Color.White;
            this.labelSupplierContact.Location = new System.Drawing.Point(23, 325);
            this.labelSupplierContact.Name = "labelSupplierContact";
            this.labelSupplierContact.Size = new System.Drawing.Size(72, 23);
            this.labelSupplierContact.TabIndex = 5;
            this.labelSupplierContact.Text = "Contact";
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Location = new System.Drawing.Point(27, 276);
            this.textBoxSupplierName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(201, 22);
            this.textBoxSupplierName.TabIndex = 1;
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierName.ForeColor = System.Drawing.Color.White;
            this.labelSupplierName.Location = new System.Drawing.Point(24, 245);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(130, 23);
            this.labelSupplierName.TabIndex = 3;
            this.labelSupplierName.Text = "Supplier Name";
            // 
            // textBoxSupplierId
            // 
            this.textBoxSupplierId.Location = new System.Drawing.Point(27, 202);
            this.textBoxSupplierId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSupplierId.Name = "textBoxSupplierId";
            this.textBoxSupplierId.Size = new System.Drawing.Size(201, 22);
            this.textBoxSupplierId.TabIndex = 0;
            // 
            // labelSupplierId
            // 
            this.labelSupplierId.AutoSize = true;
            this.labelSupplierId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierId.ForeColor = System.Drawing.Color.White;
            this.labelSupplierId.Location = new System.Drawing.Point(24, 171);
            this.labelSupplierId.Name = "labelSupplierId";
            this.labelSupplierId.Size = new System.Drawing.Size(101, 23);
            this.labelSupplierId.TabIndex = 1;
            this.labelSupplierId.Text = "Supplier ID";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(41, 101);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(170, 45);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "SUPPLIER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(680, 471);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonSupplierClear
            // 
            this.buttonSupplierClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonSupplierClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplierClear.Location = new System.Drawing.Point(855, 543);
            this.buttonSupplierClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSupplierClear.Name = "buttonSupplierClear";
            this.buttonSupplierClear.Size = new System.Drawing.Size(128, 46);
            this.buttonSupplierClear.TabIndex = 17;
            this.buttonSupplierClear.Text = "CLEAR";
            this.buttonSupplierClear.UseVisualStyleBackColor = false;
            this.buttonSupplierClear.Click += new System.EventHandler(this.buttonSupplierClear_Click);
            // 
            // buttonSupplierDelete
            // 
            this.buttonSupplierDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSupplierDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplierDelete.Location = new System.Drawing.Point(687, 543);
            this.buttonSupplierDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSupplierDelete.Name = "buttonSupplierDelete";
            this.buttonSupplierDelete.Size = new System.Drawing.Size(128, 46);
            this.buttonSupplierDelete.TabIndex = 16;
            this.buttonSupplierDelete.Text = "DELETE";
            this.buttonSupplierDelete.UseVisualStyleBackColor = false;
            this.buttonSupplierDelete.Click += new System.EventHandler(this.buttonSupplierDelete_Click);
            // 
            // buttonSupplierUpdate
            // 
            this.buttonSupplierUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSupplierUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplierUpdate.Location = new System.Drawing.Point(517, 543);
            this.buttonSupplierUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSupplierUpdate.Name = "buttonSupplierUpdate";
            this.buttonSupplierUpdate.Size = new System.Drawing.Size(128, 46);
            this.buttonSupplierUpdate.TabIndex = 15;
            this.buttonSupplierUpdate.Text = "UPDATE";
            this.buttonSupplierUpdate.UseVisualStyleBackColor = false;
            this.buttonSupplierUpdate.Click += new System.EventHandler(this.buttonSupplierUpdate_Click);
            // 
            // buttonSupplierAdd
            // 
            this.buttonSupplierAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSupplierAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplierAdd.Location = new System.Drawing.Point(333, 543);
            this.buttonSupplierAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSupplierAdd.Name = "buttonSupplierAdd";
            this.buttonSupplierAdd.Size = new System.Drawing.Size(128, 46);
            this.buttonSupplierAdd.TabIndex = 14;
            this.buttonSupplierAdd.Text = "ADD";
            this.buttonSupplierAdd.UseVisualStyleBackColor = false;
            this.buttonSupplierAdd.Click += new System.EventHandler(this.buttonSupplierAdd_Click);
            // 
            // Supplier_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1028, 635);
            this.Controls.Add(this.buttonSupplierClear);
            this.Controls.Add(this.buttonSupplierDelete);
            this.Controls.Add(this.buttonSupplierUpdate);
            this.Controls.Add(this.buttonSupplierAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Supplier_Manager";
            this.Text = "Supplier_Manager";
            this.Load += new System.EventHandler(this.Supplier_Manager_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxItemCatagory;
        private System.Windows.Forms.TextBox textBoxSupplierAddress;
        private System.Windows.Forms.Label labelSupplierAddress;
        private System.Windows.Forms.Label labelSupplierItem;
        private System.Windows.Forms.TextBox textBoxSupplierContact;
        private System.Windows.Forms.Label labelSupplierContact;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.TextBox textBoxSupplierId;
        private System.Windows.Forms.Label labelSupplierId;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSupplierClear;
        private System.Windows.Forms.Button buttonSupplierDelete;
        private System.Windows.Forms.Button buttonSupplierUpdate;
        private System.Windows.Forms.Button buttonSupplierAdd;
    }
}