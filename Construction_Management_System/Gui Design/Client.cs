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
    public partial class FormClient : Form
    {
        string Connectionstring;
        public FormClient()
        {
            InitializeComponent();
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            Connectionstring = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30", projectDir);
            dataGridViewClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClient.MultiSelect = false;
        }
        int selectedRow;

        private void Client_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * " + " from Client");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();
            display_dataClient();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHome f1 = new FormHome();
            f1.Show();
            this.Hide(); ;
        }

        private void buttonClientAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("insert into Client (Client_ID, Client_Name, Client_Contact, Client_Email, Client_Address) Values('{0}','{1}','{2}','{3}','{4}')", textBoxClientId.Text, textBoxClientName.Text, textBoxClientContact.Text, textBoxClientEmail.Text, textBoxClientAddress.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();
                display_dataClient();
                MessageBox.Show("ADDED SUCESSFULLY");
                buttonClientClear_Click(new object(), new EventArgs());
            }
            catch (Exception a)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }
        public void display_dataClient()
        {
            string sql = string.Format("select * " + " from Client");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            data1.Fill(dt1);
            dataGridViewClient.DataSource = dt1;
            sqlcmd.Connection.Close();
        }

        private void buttonClientDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete " + " from Client where Client_ID={0}", textBoxClientId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();
                display_dataClient();
                MessageBox.Show("DELETE SUCCESFULLY");
                buttonClientClear_Click(new object(), new EventArgs());
            }
            catch (Exception b)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }

        private void buttonClientUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dataGridViewRow = dataGridViewClient.Rows[selectedRow];
                dataGridViewClient.SelectedCells[0].Value = textBoxClientId.Text;
                dataGridViewClient.SelectedCells[1].Value = textBoxClientName.Text;
                dataGridViewClient.SelectedCells[2].Value = textBoxClientContact.Text;
                dataGridViewClient.SelectedCells[3].Value = textBoxClientEmail.Text;
                dataGridViewClient.SelectedCells[4].Value = textBoxClientAddress.Text;
                string sql = string.Format("update Client set Client_ID={0}, Client_Name='{1}', Client_Email='{2}', Client_Contact='{3}', Client_Address='{4}'  where  Client_ID={5} ", textBoxClientId.Text, textBoxClientName.Text, textBoxClientEmail.Text, textBoxClientContact.Text, textBoxClientAddress.Text, textBoxClientId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("UPDATE SUCCESSFULLY");
                sqlcmd.Connection.Close();
                display_dataClient();
            }
            catch (Exception c)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }

        private void buttonClientClear_Click(object sender, EventArgs e)
        {
            textBoxClientId.Clear();
            textBoxClientName.Clear();
            textBoxClientContact.Clear();
            textBoxClientEmail.Clear();
            textBoxClientAddress.Clear();
        }
        private void dataGridViewClient_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridViewClient.Rows[selectedRow];
            textBoxClientId.Text = row.Cells[0].Value.ToString();
            textBoxClientName.Text = row.Cells[1].Value.ToString();
            textBoxClientContact.Text = row.Cells[2].Value.ToString();
            textBoxClientEmail.Text = row.Cells[3].Value.ToString();
            textBoxClientAddress.Text = row.Cells[4].Value.ToString();
        }
    }
}
