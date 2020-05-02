namespace Construction_Management_System.Gui_Design
{
    partial class SalesReport_Manager
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonWeekly = new System.Windows.Forms.RadioButton();
            this.labelUser = new System.Windows.Forms.Label();
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelUser.Controls.Add(this.label2);
            this.panelUser.Controls.Add(this.label1);
            this.panelUser.Controls.Add(this.button1);
            this.panelUser.Controls.Add(this.dateTimePicker2);
            this.panelUser.Controls.Add(this.radioButtonMonthly);
            this.panelUser.Controls.Add(this.pictureBox1);
            this.panelUser.Controls.Add(this.radioButtonWeekly);
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Controls.Add(this.radioButtonDaily);
            this.panelUser.Controls.Add(this.dateTimePicker1);
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Margin = new System.Windows.Forms.Padding(2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(220, 520);
            this.panelUser.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(9, 186);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMonthly.ForeColor = System.Drawing.Color.White;
            this.radioButtonMonthly.Location = new System.Drawing.Point(61, 429);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(93, 25);
            this.radioButtonMonthly.TabIndex = 21;
            this.radioButtonMonthly.TabStop = true;
            this.radioButtonMonthly.Text = "Monthly";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            this.radioButtonMonthly.CheckedChanged += new System.EventHandler(this.radioButtonMonthly_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Construction_Management_System.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(18, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButtonWeekly
            // 
            this.radioButtonWeekly.AutoSize = true;
            this.radioButtonWeekly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWeekly.ForeColor = System.Drawing.Color.White;
            this.radioButtonWeekly.Location = new System.Drawing.Point(61, 398);
            this.radioButtonWeekly.Name = "radioButtonWeekly";
            this.radioButtonWeekly.Size = new System.Drawing.Size(85, 25);
            this.radioButtonWeekly.TabIndex = 20;
            this.radioButtonWeekly.TabStop = true;
            this.radioButtonWeekly.Text = "Weekly";
            this.radioButtonWeekly.UseVisualStyleBackColor = true;
            this.radioButtonWeekly.CheckedChanged += new System.EventHandler(this.radioButtonWeekly_CheckedChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(7, 76);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(203, 37);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "SALES REPORT";
            // 
            // radioButtonDaily
            // 
            this.radioButtonDaily.AutoSize = true;
            this.radioButtonDaily.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDaily.ForeColor = System.Drawing.Color.White;
            this.radioButtonDaily.Location = new System.Drawing.Point(61, 367);
            this.radioButtonDaily.Name = "radioButtonDaily";
            this.radioButtonDaily.Size = new System.Drawing.Size(68, 25);
            this.radioButtonDaily.TabIndex = 19;
            this.radioButtonDaily.TabStop = true;
            this.radioButtonDaily.Text = "Daily";
            this.radioButtonDaily.UseVisualStyleBackColor = true;
            this.radioButtonDaily.CheckedChanged += new System.EventHandler(this.radioButtonDaily_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(243, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 458);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 25;
            this.label2.Text = "FROM";
            // 
            // SalesReport_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelUser);
            this.Name = "SalesReport_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Report_Manager";
            this.Load += new System.EventHandler(this.SalesReport_Manager_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.RadioButton radioButtonWeekly;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}