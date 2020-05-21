using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_Management_System.Gui_Design
{
    public partial class Storage : Form
    {
        string Connectionstring;
        Form prevForm1;
        public Storage(Form form)
        {
            InitializeComponent();
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            Connectionstring = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30", projectDir);
            this.prevForm1 = form;
            dataGridViewStorage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStorage.MultiSelect = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm1.Show();
            this.Hide();

        }

        private void Storage_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * from Storage");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();
            dataGridViewStorage.DataSource = dt1;
        }
    }
}
