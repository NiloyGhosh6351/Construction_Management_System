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
    public partial class FormSalesReport : Form
    {
        public FormSalesReport()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHome f1 = new FormHome();
            f1.Show();
            this.Hide();

        }

        private void FormSalesReport_Load(object sender, EventArgs e)
        {
            this.Close();
            FormHome f1 = new FormHome();
            f1.Show();
            this.Hide();
        }
    }
}
