namespace Construction_Management_System
{
    partial class FormEmployee
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
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.panelEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelEmployee.Controls.Add(this.textBox1);
            this.panelEmployee.Controls.Add(this.labelEmployee);
            this.panelEmployee.Location = new System.Drawing.Point(0, 0);
            this.panelEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(267, 642);
            this.panelEmployee.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.ForeColor = System.Drawing.Color.White;
            this.labelEmployee.Location = new System.Drawing.Point(31, 48);
            this.labelEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(190, 46);
            this.labelEmployee.TabIndex = 0;
            this.labelEmployee.Text = "EMPLOYEE";
            this.labelEmployee.Click += new System.EventHandler(this.labelEmployee_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 635);
            this.Controls.Add(this.panelEmployee);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEmployee";
            this.Text = "Employee";
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.TextBox textBox1;
    }
}