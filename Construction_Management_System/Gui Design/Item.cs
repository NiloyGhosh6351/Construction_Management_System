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
using Construction_Management_System.Gui_Design;

namespace Construction_Management_System
{
    public partial class FormItem : Form
    {
        string Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asifm\Documents\GitHub\Construction_Management_System\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30";
        public FormItem()
        {
            InitializeComponent();
            dataGridViewItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItem.MultiSelect = false;
        }
        int selectedRow;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Item_Load(object sender, EventArgs e)
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
        }

        private void buttonItemAdd_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into Item (Item_ID, Item_Name, Item_Price, Item_Catagory, Supplier_Name, Item_Quantity) Values('{0}','{1}','{2}','{3}','{4}','{5}')", textBoxItemId.Text, textBoxItemName.Text, textBoxItemPrice.Text, comboBoxItemCatagory.Text, textBoxSupplierName.Text, textBoxItemQuantity.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Add successfully");

            sqlcmd.Connection.Close();
            display_data();
            MessageBox.Show("Item Added Successfully");
            buttonItemClear_Click(new object(), new EventArgs());

        }

        public void display_data()
        {
            string sql = string.Format("select * " + " from Item");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            //MessageBox.Show("Add successfully");
            data1.Fill(dt1);
            dataGridViewItem.DataSource = dt1;
            sqlcmd.Connection.Close();
        }
        private void comboBoxItemCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxItemCatagory.SelectedValue.ToString());
            display_data();
        }

        private void buttonItemDelete_Click(object sender, EventArgs e)
        {
            //int rowIndex = dataGridViewItem.CurrentCell.RowIndex;
            //dataGridViewItem.Rows.RemoveAt(rowIndex);
            string sql = string.Format("delete " + " from Item where Item_ID={0}", textBoxItemId.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();
            display_data();
            MessageBox.Show("Delete Successfully");
            buttonItemClear_Click(new object(), new EventArgs());
        }

        private void buttonItemUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridViewItem.Rows[selectedRow];
            dataGridViewItem.SelectedCells[0].Value = textBoxItemId.Text;
            dataGridViewItem.SelectedCells[1].Value = textBoxItemName.Text;
            dataGridViewItem.SelectedCells[2].Value = textBoxItemPrice.Text;
            dataGridViewItem.SelectedCells[3].Value = comboBoxItemCatagory.Text;
            dataGridViewItem.SelectedCells[4].Value = textBoxSupplierName.Text;
            dataGridViewItem.SelectedCells[5].Value = textBoxItemQuantity.Text;
            string sql = string.Format("update Item set Item_ID={0}, Item_Name='{1}', Item_Price={2}, Item_Catagory='{3}', Supplier_Name='{4}', Item_Quantity='{5}'  where  Item_ID={6} ", textBoxItemId.Text, textBoxItemName.Text, textBoxItemPrice.Text, comboBoxItemCatagory.Text, textBoxSupplierName.Text, textBoxItemQuantity.Text, textBoxItemId.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully");

            sqlcmd.Connection.Close();
            display_data();
        }
        private void dataGridViewItem_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridViewItem.Rows[selectedRow];
            textBoxItemId.Text = row.Cells[0].Value.ToString();
            textBoxItemName.Text = row.Cells[1].Value.ToString();
            textBoxItemPrice.Text = row.Cells[2].Value.ToString();
            textBoxSupplierName.Text = row.Cells[4].Value.ToString();
            textBoxItemQuantity.Text = row.Cells[5].Value.ToString();
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

        private void buttonItemClear_Click(object sender, EventArgs e)
        {
            textBoxItemId.Clear();
            textBoxItemName.Clear();
            textBoxItemPrice.Clear();
            textBoxItemQuantity.Clear();
            comboBoxItemCatagory.SelectedIndex = -1;
            textBoxSupplierName.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxItemQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelItemQuantity_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxItemPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelItemPrice_Click(object sender, EventArgs e)
        {

        }

        private void textBoxItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelItemName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxItemId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelItemId_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           this.Close();
            FormHome f1 = new FormHome();
            f1.Show();
            this.Hide();
        }

        public static implicit operator FormItem(FormManager v)
        {
            throw new NotImplementedException();
        }
    }
}
