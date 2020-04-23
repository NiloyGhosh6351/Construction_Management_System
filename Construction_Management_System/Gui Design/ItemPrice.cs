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
    public partial class ItemPrice : Form
    {
        string Connectionstring;
        public ItemPrice()
        {
            InitializeComponent();
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            Connectionstring = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30", projectDir);
            dataGridViewItemPrice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItemPrice.MultiSelect = false;
        }
        int selectedRow;

        private void labelItemPrice_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("insert into Item_Price (Item_Catagory, Item_Pricee) Values('{0}','{1}')", comboBoxItemPriceCatagory.Text, textBoxPrice.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Add successfully");

                sqlcmd.Connection.Close();
                display_dataPrice();
                MessageBox.Show("Item Added Successfully");
                //buttonItemClear_Click(new object(), new EventArgs());
            }
            catch (Exception d)
            {
                MessageBox.Show("Duplicate price is not allowed");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridViewItemPrice.Rows[selectedRow];
            dataGridViewItemPrice.SelectedCells[0].Value = comboBoxItemPriceCatagory.Text;
            dataGridViewItemPrice.SelectedCells[1].Value = textBoxPrice.Text;
            string sql = string.Format("update Item_Price set Item_Catagory='{0}', Item_Pricee='{1}'  where  Item_Catagory='{2}' ", comboBoxItemPriceCatagory.Text, textBoxPrice.Text, comboBoxItemPriceCatagory.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully");

            sqlcmd.Connection.Close();
            display_dataPrice();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormItem f1 = new FormItem();
            f1.Show();
            this.Hide();
        }

        private void ItemPrice_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * " + " from Item_Catagory");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();
            comboBoxItemPriceCatagory.DataSource = dt1;
            comboBoxItemPriceCatagory.DisplayMember = "Item_Catagory";
            comboBoxItemPriceCatagory.ValueMember = "Id";
            display_dataPrice();
        }
        public void display_dataPrice()
        {
            string sql = string.Format("select * " + " from Item_Price");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            //MessageBox.Show("Add successfully");
            data1.Fill(dt1);
            dataGridViewItemPrice.DataSource = dt1;
            sqlcmd.Connection.Close();
        }

        private void dataGridViewItemPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridViewItemPrice.Rows[selectedRow];
            comboBoxItemPriceCatagory.Text = row.Cells[0].Value.ToString();
            textBoxPrice.Text = row.Cells[1].Value.ToString();
            string cc = row.Cells[0].Value.ToString().ToUpper();
            string c;
            if (row.Cells[0].Value.ToString().ToUpper() != comboBoxItemPriceCatagory.Text.ToUpper())
            {
                for (int i = 0; i < comboBoxItemPriceCatagory.Items.Count; i++)
                {
                    c = comboBoxItemPriceCatagory.GetItemText(comboBoxItemPriceCatagory.Items[i]).ToUpper();

                    if (cc == c)
                    {
                        comboBoxItemPriceCatagory.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void comboBoxItemPriceCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
