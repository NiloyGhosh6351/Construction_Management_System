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
    public partial class FormSupplier : Form
    {
        string Connectionstring;
        int selectedRow;
        public FormSupplier()
        {
            InitializeComponent();
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            Connectionstring = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30", projectDir);
            dataGridViewSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSupplier.MultiSelect = false;
        }      
        private void FormSupplier_Load(object sender, EventArgs e)
        {         
            string sql = string.Format("select * " + " from Item_Catagory");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();
            comboBoxItemCatagory.DataSource = dt1;
            comboBoxItemCatagory.DisplayMember = "Item_Catagory";
            comboBoxItemCatagory.ValueMember = "Id";
            comboBoxItemCatagory.Text = "";
            display_dataSupplier();
        }

        private void buttonSupplierAdd_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into Supplier (Supplier_ID, Supplier_Name, Supplier_Contact, Supplier_Item_Catagory, Supplier_Address) Values('{0}','{1}','{2}','{3}','{4}')", textBoxSupplierId.Text, textBoxSupplierName.Text, textBoxSupplierContact.Text, comboBoxItemCatagory.Text, textBoxSupplierAddress.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();
            display_dataSupplier();
            MessageBox.Show("ITEM ADDED SUCCESSFULLY");
            buttonSupplierClear_Click(new object(), new EventArgs());
        }

        public void display_dataSupplier()
        {
            string sql = string.Format("select * " + " from Supplier");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            data1.Fill(dt1);
            dataGridViewSupplier.DataSource = dt1;
            sqlcmd.Connection.Close();
        }

        private void buttonSupplierDelete_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete " + " from Supplier where Supplier_ID={0}", textBoxSupplierId.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();
            display_dataSupplier();
            MessageBox.Show("DELETE SUCCESSFULLY");
            buttonSupplierClear_Click(new object(), new EventArgs());
        }

        private void buttonSupplierUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridViewSupplier.Rows[selectedRow];
            dataGridViewSupplier.SelectedCells[0].Value = textBoxSupplierId.Text;
            dataGridViewSupplier.SelectedCells[1].Value = textBoxSupplierName.Text;
            dataGridViewSupplier.SelectedCells[2].Value = textBoxSupplierContact.Text;
            dataGridViewSupplier.SelectedCells[3].Value = comboBoxItemCatagory.Text;
            dataGridViewSupplier.SelectedCells[4].Value = textBoxSupplierAddress.Text;
           
            string sql = string.Format("update Supplier set Supplier_ID={0}, Supplier_Name='{1}', Supplier_Contact={2}, Supplier_Item_Catagory='{3}', Supplier_Address='{4}'  where Supplier_ID={5} ", textBoxSupplierId.Text, textBoxSupplierName.Text, textBoxSupplierContact.Text, comboBoxItemCatagory.Text, textBoxSupplierAddress.Text, textBoxSupplierId.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("UPDATE SUCCESSFULLY");
            sqlcmd.Connection.Close();
            display_dataSupplier();
        }

        private void buttonSupplierClear_Click(object sender, EventArgs e)
        {
            textBoxSupplierId.Clear();
            textBoxSupplierName.Clear();
            textBoxSupplierContact.Clear();      
            comboBoxItemCatagory.SelectedIndex = -1;
            textBoxSupplierAddress.Clear();
        }

        private void dataGridViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridViewSupplier.Rows[selectedRow];
            textBoxSupplierId.Text = row.Cells[0].Value.ToString();
            textBoxSupplierName.Text = row.Cells[1].Value.ToString();
            textBoxSupplierContact.Text = row.Cells[2].Value.ToString();
            textBoxSupplierAddress.Text = row.Cells[4].Value.ToString();
           
            string aa = row.Cells[3].Value.ToString().ToUpper();
            string a;
            if (row.Cells[3].Value.ToString().ToUpper() != comboBoxItemCatagory.Text.ToUpper())
            {
                for (int i = 0; i < comboBoxItemCatagory.Items.Count; i++)
                {
                    a = comboBoxItemCatagory.GetItemText(comboBoxItemCatagory.Items[i]).ToUpper();

                    if (aa == a)
                    {
                        comboBoxItemCatagory.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHome f1 = new FormHome();
            f1.Show();
            this.Hide();
        }
    }
}
