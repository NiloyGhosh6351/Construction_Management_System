namespace Construction_Management_System
{
    partial class FormItem
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
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.textBoxItemId = new System.Windows.Forms.TextBox();
            this.labelItemId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewItem = new System.Windows.Forms.DataGridView();
            this.buttonItemAdd = new System.Windows.Forms.Button();
            this.buttonItemUpdate = new System.Windows.Forms.Button();
            this.buttonItemDelete = new System.Windows.Forms.Button();
            this.buttonItemClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textBoxSupplierName);
            this.panel1.Controls.Add(this.labelSupplierName);
            this.panel1.Controls.Add(this.textBoxCategory);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxItemPrice);
            this.panel1.Controls.Add(this.labelItemPrice);
            this.panel1.Controls.Add(this.textBoxItemName);
            this.panel1.Controls.Add(this.labelItemName);
            this.panel1.Controls.Add(this.textBoxItemId);
            this.panel1.Controls.Add(this.labelItemId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 507);
            this.panel1.TabIndex = 0;
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxSupplierName.Location = new System.Drawing.Point(16, 344);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(169, 20);
            this.textBoxSupplierName.TabIndex = 10;
            this.textBoxSupplierName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierName.ForeColor = System.Drawing.Color.White;
            this.labelSupplierName.Location = new System.Drawing.Point(13, 324);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(99, 17);
            this.labelSupplierName.TabIndex = 9;
            this.labelSupplierName.Text = "Supplier Name";
            this.labelSupplierName.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCategory.Location = new System.Drawing.Point(16, 292);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(169, 20);
            this.textBoxCategory.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Item Category";
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemPrice.Location = new System.Drawing.Point(16, 234);
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(169, 20);
            this.textBoxItemPrice.TabIndex = 6;
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPrice.ForeColor = System.Drawing.Color.White;
            this.labelItemPrice.Location = new System.Drawing.Point(13, 214);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(70, 17);
            this.labelItemPrice.TabIndex = 5;
            this.labelItemPrice.Text = "Item Price";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemName.Location = new System.Drawing.Point(16, 177);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(169, 20);
            this.textBoxItemName.TabIndex = 4;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.ForeColor = System.Drawing.Color.White;
            this.labelItemName.Location = new System.Drawing.Point(13, 157);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(76, 17);
            this.labelItemName.TabIndex = 3;
            this.labelItemName.Text = "Item Name";
            // 
            // textBoxItemId
            // 
            this.textBoxItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemId.Location = new System.Drawing.Point(16, 124);
            this.textBoxItemId.Name = "textBoxItemId";
            this.textBoxItemId.Size = new System.Drawing.Size(169, 20);
            this.textBoxItemId.TabIndex = 2;
            // 
            // labelItemId
            // 
            this.labelItemId.AutoSize = true;
            this.labelItemId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemId.ForeColor = System.Drawing.Color.White;
            this.labelItemId.Location = new System.Drawing.Point(13, 104);
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
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM";
            // 
            // dataGridViewItem
            // 
            this.dataGridViewItem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItem.Location = new System.Drawing.Point(229, 29);
            this.dataGridViewItem.Name = "dataGridViewItem";
            this.dataGridViewItem.Size = new System.Drawing.Size(546, 373);
            this.dataGridViewItem.TabIndex = 1;
            // 
            // buttonItemAdd
            // 
            this.buttonItemAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonItemAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemAdd.Location = new System.Drawing.Point(251, 428);
            this.buttonItemAdd.Name = "buttonItemAdd";
            this.buttonItemAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonItemAdd.TabIndex = 2;
            this.buttonItemAdd.Text = "ADD";
            this.buttonItemAdd.UseVisualStyleBackColor = false;
            // 
            // buttonItemUpdate
            // 
            this.buttonItemUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonItemUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemUpdate.Location = new System.Drawing.Point(389, 428);
            this.buttonItemUpdate.Name = "buttonItemUpdate";
            this.buttonItemUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonItemUpdate.TabIndex = 3;
            this.buttonItemUpdate.Text = "UPDATE";
            this.buttonItemUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonItemDelete
            // 
            this.buttonItemDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonItemDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemDelete.Location = new System.Drawing.Point(517, 428);
            this.buttonItemDelete.Name = "buttonItemDelete";
            this.buttonItemDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonItemDelete.TabIndex = 4;
            this.buttonItemDelete.Text = "DELETE";
            this.buttonItemDelete.UseVisualStyleBackColor = false;
            // 
            // buttonItemClear
            // 
            this.buttonItemClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonItemClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemClear.Location = new System.Drawing.Point(643, 428);
            this.buttonItemClear.Name = "buttonItemClear";
            this.buttonItemClear.Size = new System.Drawing.Size(96, 37);
            this.buttonItemClear.TabIndex = 5;
            this.buttonItemClear.Text = "CLEAR";
            this.buttonItemClear.UseVisualStyleBackColor = false;
            // 
            // FormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.buttonItemClear);
            this.Controls.Add(this.buttonItemDelete);
            this.Controls.Add(this.buttonItemUpdate);
            this.Controls.Add(this.buttonItemAdd);
            this.Controls.Add(this.dataGridViewItem);
            this.Controls.Add(this.panel1);
            this.Name = "FormItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxItemId;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxItemPrice;
        private System.Windows.Forms.Label labelItemPrice;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.DataGridView dataGridViewItem;
        private System.Windows.Forms.Button buttonItemAdd;
        private System.Windows.Forms.Button buttonItemUpdate;
        private System.Windows.Forms.Button buttonItemDelete;
        private System.Windows.Forms.Button buttonItemClear;
    }
}