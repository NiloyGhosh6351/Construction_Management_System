using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_Management_System.Gui_Design
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }

        private void buttonHomeItem_Click(object sender, EventArgs e)
        {
            Item_Manager openform = new Item_Manager();
            openform.Show();
            this.Hide();

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Client_Manager openform = new Client_Manager();
            openform.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Supplier_Manager openform = new Supplier_Manager();
            openform.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sales open = new Sales();
            open.Show();
            this.Hide();
        }
    }
}
