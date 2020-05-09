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

namespace Construction_Management_System
{
    public partial class FormEmployee : Form
    {
        string Connectionstring;
        int selectedRow;
        Form prevForm4;
        public FormEmployee(Form form)
        {
            InitializeComponent();
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            Connectionstring = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30", projectDir);
            dataGridViewEmp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmp.MultiSelect = false;
            this.prevForm4 = form;
        }
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * " + " from Employee_Catagory");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();
            comboBoxEmpCatagory.DataSource = dt1;
            comboBoxEmpCatagory.DisplayMember = "Employee_Catagory";
            comboBoxEmpCatagory.ValueMember = "Id";
            comboBoxEmpCatagory.Text = "";
        }
        private void buttonEmpAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("insert into Employee (Employee_ID, Employee_Name, Employee_Salary, Employee_Catagory, Employee_Contact, Employee_Address) Values('{0}','{1}','{2}','{3}','{4}','{5}')", textBoxEmpId.Text, textBoxEmpName.Text, textBoxEmpSalary.Text, comboBoxEmpCatagory.Text, textBoxEmpContact.Text, textBoxEmpAddress.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();
                dispaly_dataEmp();
                MessageBox.Show("ADDED SUCCESSFULLY");
                buttonEmpClear_Click(new object(), new EventArgs());
            }
            catch (Exception a)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }

        public void dispaly_dataEmp()
        {
            string sql = string.Format("select * " + " from Employee ");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            data1.Fill(dt1);
            dataGridViewEmp.DataSource = dt1;
            sqlcmd.Connection.Close();
        }

        private void buttonEmpClear_Click(object sender, EventArgs e)
        {
            textBoxEmpId.Clear();
            textBoxEmpName.Clear();
            textBoxEmpSalary.Clear();
            comboBoxEmpCatagory.SelectedIndex = -1;
            textBoxEmpContact.Clear();
            textBoxEmpAddress.Clear();
        }

        private void comboBoxEmpCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dispaly_dataEmp();
        }

        private void buttonIEmpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete " + " from Employee where Employee_ID={0}", textBoxEmpId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();
                dispaly_dataEmp();
                MessageBox.Show("DELETE SUCCESSFULLY");
                buttonEmpClear_Click(new object(), new EventArgs());
            }
            catch (Exception b)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }

        private void buttonEmpUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dataGridViewRow = dataGridViewEmp.Rows[selectedRow];
                dataGridViewEmp.SelectedCells[0].Value = textBoxEmpId.Text;
                dataGridViewEmp.SelectedCells[1].Value = textBoxEmpName.Text;
                dataGridViewEmp.SelectedCells[2].Value = textBoxEmpSalary.Text;
                dataGridViewEmp.SelectedCells[3].Value = comboBoxEmpCatagory.Text;
                dataGridViewEmp.SelectedCells[4].Value = textBoxEmpContact.Text;
                dataGridViewEmp.SelectedCells[5].Value = textBoxEmpAddress.Text;
                string sql = string.Format("update Employee set Employee_ID={0}, Employee_Name='{1}', Employee_Salary={2}, Employee_Catagory='{3}', Employee_Contact='{4}', Employee_Address='{5}'  where  Employee_ID={6} ", textBoxEmpId.Text, textBoxEmpName.Text, textBoxEmpSalary.Text, comboBoxEmpCatagory.Text, textBoxEmpContact.Text, textBoxEmpAddress.Text, textBoxEmpId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("UPDATE SUCCESSFULLY");
                sqlcmd.Connection.Close();
                dispaly_dataEmp();
            }
            catch (Exception c)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }
        private void dataGridViewEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridViewEmp.Rows[selectedRow];
            textBoxEmpId.Text = row.Cells[0].Value.ToString();
            textBoxEmpName.Text = row.Cells[1].Value.ToString();
            textBoxEmpSalary.Text = row.Cells[2].Value.ToString();
            textBoxEmpContact.Text = row.Cells[4].Value.ToString();
            textBoxEmpAddress.Text = row.Cells[5].Value.ToString();
            string aa = row.Cells[3].Value.ToString().ToUpper();
            string a;
            if (aa!= comboBoxEmpCatagory.Text.ToUpper())
            {
                for (int i = 0; i < comboBoxEmpCatagory.Items.Count; i++)
                {
                    a = comboBoxEmpCatagory.GetItemText(comboBoxEmpCatagory.Items[i]).ToUpper();

                    if (aa == a)
                    {
                        comboBoxEmpCatagory.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm4.Show();
            this.Hide();
        }
    }
}
