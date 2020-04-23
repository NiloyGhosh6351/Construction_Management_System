namespace Construction_Management_System.Gui_Design
{
    partial class Item_Manager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxItemCatagory = new System.Windows.Forms.ComboBox();
            this.textBoxItemQuantity = new System.Windows.Forms.TextBox();
            this.labelItemQuantity = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.textBoxItemId = new System.Windows.Forms.TextBox();
            this.labelItemId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonItemClear = new System.Windows.Forms.Button();
            this.buttonItemDelete = new System.Windows.Forms.Button();
            this.buttonItemUpdate = new System.Windows.Forms.Button();
            this.buttonItemAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBoxItemCatagory);
            this.panel1.Controls.Add(this.textBoxItemQuantity);
            this.panel1.Controls.Add(this.labelItemQuantity);
            this.panel1.Controls.Add(this.labelSupplierName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxItemPrice);
            this.panel1.Controls.Add(this.labelItemPrice);
            this.panel1.Controls.Add(this.textBoxItemName);
            this.panel1.Controls.Add(this.labelItemName);
            this.panel1.Controls.Add(this.textBoxItemId);
            this.panel1.Controls.Add(this.labelItemId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 614);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Construction_Management_System.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxItemCatagory
            // 
            this.comboBoxItemCatagory.FormattingEnabled = true;
            this.comboBoxItemCatagory.Location = new System.Drawing.Point(17, 423);
            this.comboBoxItemCatagory.Name = "comboBoxItemCatagory";
            this.comboBoxItemCatagory.Size = new System.Drawing.Size(168, 21);
            this.comboBoxItemCatagory.TabIndex = 4;
            // 
            // textBoxItemQuantity
            // 
            this.textBoxItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemQuantity.Location = new System.Drawing.Point(16, 368);
            this.textBoxItemQuantity.Name = "textBoxItemQuantity";
            this.textBoxItemQuantity.Size = new System.Drawing.Size(169, 20);
            this.textBoxItemQuantity.TabIndex = 3;
            // 
            // labelItemQuantity
            // 
            this.labelItemQuantity.AutoSize = true;
            this.labelItemQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemQuantity.ForeColor = System.Drawing.Color.White;
            this.labelItemQuantity.Location = new System.Drawing.Point(13, 348);
            this.labelItemQuantity.Name = "labelItemQuantity";
            this.labelItemQuantity.Size = new System.Drawing.Size(94, 17);
            this.labelItemQuantity.TabIndex = 11;
            this.labelItemQuantity.Text = "Item Quantity";
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierName.ForeColor = System.Drawing.Color.White;
            this.labelSupplierName.Location = new System.Drawing.Point(14, 455);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(99, 17);
            this.labelSupplierName.TabIndex = 9;
            this.labelSupplierName.Text = "Supplier Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Item Category";
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemPrice.Location = new System.Drawing.Point(16, 284);
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(169, 20);
            this.textBoxItemPrice.TabIndex = 2;
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPrice.ForeColor = System.Drawing.Color.White;
            this.labelItemPrice.Location = new System.Drawing.Point(13, 264);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(70, 17);
            this.labelItemPrice.TabIndex = 5;
            this.labelItemPrice.Text = "Item Price";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemName.Location = new System.Drawing.Point(16, 227);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(169, 20);
            this.textBoxItemName.TabIndex = 1;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.ForeColor = System.Drawing.Color.White;
            this.labelItemName.Location = new System.Drawing.Point(13, 207);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(76, 17);
            this.labelItemName.TabIndex = 3;
            this.labelItemName.Text = "Item Name";
            // 
            // textBoxItemId
            // 
            this.textBoxItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemId.Location = new System.Drawing.Point(16, 174);
            this.textBoxItemId.Name = "textBoxItemId";
            this.textBoxItemId.Size = new System.Drawing.Size(169, 20);
            this.textBoxItemId.TabIndex = 0;
            // 
            // labelItemId
            // 
            this.labelItemId.AutoSize = true;
            this.labelItemId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemId.ForeColor = System.Drawing.Color.White;
            this.labelItemId.Location = new System.Drawing.Point(13, 154);
            this.labelItemId.Name = "labelItemId";
            this.labelItemId.Size = new System.Drawing.Size(54, 17);
            this.labelItemId.TabIndex = 1;
            this.labelItemId.Text = "Item ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 388);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonItemClear
            // 
            this.buttonItemClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonItemClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemClear.Location = new System.Drawing.Point(633, 433);
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
            this.buttonItemDelete.Location = new System.Drawing.Point(507, 433);
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
            this.buttonItemUpdate.Location = new System.Drawing.Point(379, 433);
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
            this.buttonItemAdd.Location = new System.Drawing.Point(241, 433);
            this.buttonItemAdd.Name = "buttonItemAdd";
            this.buttonItemAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonItemAdd.TabIndex = 6;
            this.buttonItemAdd.Text = "ADD";
            this.buttonItemAdd.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 475);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // Item_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 604);
            this.Controls.Add(this.buttonItemClear);
            this.Controls.Add(this.buttonItemDelete);
            this.Controls.Add(this.buttonItemUpdate);
            this.Controls.Add(this.buttonItemAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Item_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item_Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxItemCatagory;
        private System.Windows.Forms.TextBox textBoxItemQuantity;
        private System.Windows.Forms.Label labelItemQuantity;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxItemPrice;
        private System.Windows.Forms.Label labelItemPrice;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.TextBox textBoxItemId;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonItemClear;
        private System.Windows.Forms.Button buttonItemDelete;
        private System.Windows.Forms.Button buttonItemUpdate;
        private System.Windows.Forms.Button buttonItemAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}