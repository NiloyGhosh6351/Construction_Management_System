namespace Construction_Management_System
{
    partial class FormSalesReport
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
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Location = new System.Drawing.Point(1, -1);
            this.panelUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(204, 507);
            this.panelUser.TabIndex = 2;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(-1, 78);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(203, 37);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "SALES REPORT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 362);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonItemClear
            // 
            this.buttonItemClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonItemClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemClear.Location = new System.Drawing.Point(678, 440);
            this.buttonItemClear.Name = "buttonItemClear";
            this.buttonItemClear.Size = new System.Drawing.Size(96, 37);
            this.buttonItemClear.TabIndex = 17;
            this.buttonItemClear.Text = "CLEAR";
            this.buttonItemClear.UseVisualStyleBackColor = false;
            // 
            // buttonItemDelete
            // 
            this.buttonItemDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonItemDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemDelete.Location = new System.Drawing.Point(552, 440);
            this.buttonItemDelete.Name = "buttonItemDelete";
            this.buttonItemDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonItemDelete.TabIndex = 16;
            this.buttonItemDelete.Text = "DELETE";
            this.buttonItemDelete.UseVisualStyleBackColor = false;
            // 
            // buttonItemUpdate
            // 
            this.buttonItemUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonItemUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemUpdate.Location = new System.Drawing.Point(424, 440);
            this.buttonItemUpdate.Name = "buttonItemUpdate";
            this.buttonItemUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonItemUpdate.TabIndex = 15;
            this.buttonItemUpdate.Text = "UPDATE";
            this.buttonItemUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonItemAdd
            // 
            this.buttonItemAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonItemAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemAdd.Location = new System.Drawing.Point(286, 440);
            this.buttonItemAdd.Name = "buttonItemAdd";
            this.buttonItemAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonItemAdd.TabIndex = 14;
            this.buttonItemAdd.Text = "ADD";
            this.buttonItemAdd.UseVisualStyleBackColor = false;
            // 
            // FormSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.buttonItemClear);
            this.Controls.Add(this.buttonItemDelete);
            this.Controls.Add(this.buttonItemUpdate);
            this.Controls.Add(this.buttonItemAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSalesReport";
            this.Text = "Sales Report";
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
    }
}