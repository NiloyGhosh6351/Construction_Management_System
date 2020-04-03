using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open Employee Foem
            FormEmployee openEmployee = new FormEmployee();
            openEmployee.Show();


        }
    }
}
