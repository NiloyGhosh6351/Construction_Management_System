namespace Construction_Management_System.Gui_Design
{
    partial class ItemPrice
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
            this.panelItemPrice = new System.Windows.Forms.Panel();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.comboBoxItemCatagory = new System.Windows.Forms.ComboBox();
            this.labelCatagory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelItemPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemPrice
            // 
            this.panelItemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelItemPrice.Controls.Add(this.buttonDelete);
            this.panelItemPrice.Controls.Add(this.buttonAdd);
            this.panelItemPrice.Controls.Add(this.textBoxPrice);
            this.panelItemPrice.Controls.Add(this.labelPrice);
            this.panelItemPrice.Controls.Add(this.comboBoxItemCatagory);
            this.panelItemPrice.Controls.Add(this.labelCatagory);
            this.panelItemPrice.Controls.Add(this.labelItemPrice);
            this.panelItemPrice.Location = new System.Drawing.Point(0, 0);
            this.panelItemPrice.Name = "panelItemPrice";
            this.panelItemPrice.Size = new System.Drawing.Size(200, 519);
            this.panelItemPrice.TabIndex = 0;
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPrice.ForeColor = System.Drawing.Color.White;
            this.labelItemPrice.Location = new System.Drawing.Point(12, 108);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(164, 37);
            this.labelItemPrice.TabIndex = 1;
            this.labelItemPrice.Text = "ITEM PRICE";
            this.labelItemPrice.Click += new System.EventHandler(this.labelItemPrice_Click);
            // 
            // comboBoxItemCatagory
            // 
            this.comboBoxItemCatagory.FormattingEnabled = true;
            this.comboBoxItemCatagory.Location = new System.Drawing.Point(16, 208);
            this.comboBoxItemCatagory.Name = "comboBoxItemCatagory";
            this.comboBoxItemCatagory.Size = new System.Drawing.Size(168, 21);
            this.comboBoxItemCatagory.TabIndex = 8;
            // 
            // labelCatagory
            // 
            this.labelCatagory.AutoSize = true;
            this.labelCatagory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatagory.ForeColor = System.Drawing.Color.White;
            this.labelCatagory.Location = new System.Drawing.Point(16, 188);
            this.labelCatagory.Name = "labelCatagory";
            this.labelCatagory.Size = new System.Drawing.Size(96, 17);
            this.labelCatagory.TabIndex = 9;
            this.labelCatagory.Text = "Item Category";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(16, 239);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(38, 17);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(19, 269);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(165, 20);
            this.textBoxPrice.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(19, 324);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(101, 324);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // ItemPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 516);
            this.Controls.Add(this.panelItemPrice);
            this.Name = "ItemPrice";
            this.Text = "ItemPrice";
            this.panelItemPrice.ResumeLayout(false);
            this.panelItemPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItemPrice;
        private System.Windows.Forms.Label labelItemPrice;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxItemCatagory;
        private System.Windows.Forms.Label labelCatagory;
    }
}