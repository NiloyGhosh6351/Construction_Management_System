using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Construction_Management_System.Gui_Design;

namespace Construction_Management_System
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHomeItem_Click(object sender, EventArgs e)
        {
            //Open Item Form
            FormItem openform = new FormItem();
            openform.Show();
            this.Hide();
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //open user Form
            FormUser openwindow = new FormUser();
            openwindow.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open Employee Form
            FormEmployee openEmployee = new FormEmployee();
            openEmployee.Show();
            this.Hide();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //open Supplier Form
            FormSupplier openSupplier = new FormSupplier();
            openSupplier.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //open Sales Report Form
            FormSalesReport opensalesReport = new FormSalesReport();
            opensalesReport.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            FormClient OpenClient = new FormClient();
            OpenClient.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }
    }
}
