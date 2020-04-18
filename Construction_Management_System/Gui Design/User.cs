using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_Management_System
{
    public partial class FormUser : Form
    {
        string Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ANUP\Documents\GitHub\Construction_Management_System\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30";
        public FormUser()
        {
            InitializeComponent();
            dataGridViewUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUser.MultiSelect = false;
        }
        int selectedRow;

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * " + " from User_Type");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();
            comboBoxUserType.DataSource = dt1;
            comboBoxUserType.DisplayMember = "User_Type";
            comboBoxUserType.ValueMember = "Id";
            display_dataUser();
        }

        private void labelEmpId_Click(object sender, EventArgs e)
        {

        }

        private void labelEmpAddress_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmpContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmpContact_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmpCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmpCategory_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmpPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmpSalary_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmpName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmpAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmpId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUserType_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into [User] (User_ID, Name, User_Name, User_Password, User_Type, User_Contact, User_Address) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", textBoxUserId.Text, textBoxName.Text, textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserType.Text, textBoxUserContact.Text, textBoxUserAddress.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Add successfully");

            sqlcmd.Connection.Close();
            display_dataUser();
            MessageBox.Show("Item Added Successfully");
            AddUser();
            buttonUserClear_Click(new object(), new EventArgs());
        }
        public void AddUser()
        {
            string sql = string.Format("insert into Login_User (UserName, Password, UserType) Values('{0}','{1}','{2}')", textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserType.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Add To LoginUser Database successfully");

            sqlcmd.Connection.Close();
        }

        public void display_dataUser()
        {
            string sql = string.Format("select * " + " from [User]");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            //MessageBox.Show("Add successfully");
            data1.Fill(dt1);
            dataGridViewUser.DataSource = dt1;
            sqlcmd.Connection.Close();
        }

        private void buttonUserDelete_Click(object sender, EventArgs e)
        {
            //int rowIndex = dataGridViewItem.CurrentCell.RowIndex;
            //dataGridViewItem.Rows.RemoveAt(rowIndex);
            string sql = string.Format("delete " + " from [User] where User_ID={0}", textBoxUserId.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();
            display_dataUser();
            MessageBox.Show("Delete Successfully");
            buttonUserClear_Click(new object(), new EventArgs());
        }

        private void buttonUserUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridViewUser.Rows[selectedRow];
            dataGridViewUser.SelectedCells[0].Value = textBoxUserId.Text;
            dataGridViewUser.SelectedCells[1].Value = textBoxName.Text;
            dataGridViewUser.SelectedCells[2].Value = textBoxUserName.Text;
            dataGridViewUser.SelectedCells[3].Value = textBoxUserPassword.Text;
            dataGridViewUser.SelectedCells[4].Value = comboBoxUserType.Text;
            dataGridViewUser.SelectedCells[5].Value = textBoxUserContact.Text;
            dataGridViewUser.SelectedCells[6].Value = textBoxUserAddress.Text;
            string sql = string.Format("update [User] set User_ID={0}, Name='{1}', User_Name='{2}', User_Password='{3}', User_Type='{4}', User_Contact='{5}', User_Address='{6}'  where  User_ID={7} ", textBoxUserId.Text, textBoxName.Text, textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserType.Text, textBoxUserContact.Text, textBoxUserAddress.Text, textBoxUserId.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully");

            sqlcmd.Connection.Close();
            display_dataUser();
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridViewUser.Rows[selectedRow];
            textBoxUserId.Text = row.Cells[0].Value.ToString();
            textBoxName.Text = row.Cells[1].Value.ToString();
            textBoxUserName.Text = row.Cells[2].Value.ToString();
            textBoxUserPassword.Text = row.Cells[3].Value.ToString();
            textBoxUserContact.Text = row.Cells[5].Value.ToString();
            textBoxUserAddress.Text = row.Cells[6].Value.ToString();
            string aa = row.Cells[4].Value.ToString().ToUpper();
            string a;
            if (row.Cells[3].Value.ToString().ToUpper() != comboBoxUserType.Text.ToUpper())
            {
                for (int i = 0; i < comboBoxUserType.Items.Count; i++)
                {
                    a = comboBoxUserType.GetItemText(comboBoxUserType.Items[i]).ToUpper();

                    if (aa == a)
                    {
                        comboBoxUserType.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void buttonUserClear_Click(object sender, EventArgs e)
        {
            textBoxUserId.Clear();
            textBoxName.Clear();
            textBoxUserName.Clear();
            textBoxUserPassword.Clear();
            comboBoxUserType.SelectedIndex = -1;
            textBoxUserContact.Clear();
            textBoxUserAddress.Clear();

        }
    }

}