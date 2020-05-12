﻿using System;
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
using Construction_Management_System.Gui_Design;

namespace Construction_Management_System
{
    public partial class FormItem : Form
    {
        bool selectionCombo = false;
        string Connectionstring;
        int selectedRow;
        double newValue;
        public FormItem()
        {
            InitializeComponent();
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            Connectionstring = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30", projectDir);
            dataGridViewItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItem.MultiSelect = false;
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

            string sql1 = string.Format("select * " + " from Supplier");
            SqlConnection con2 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd1 = new SqlCommand(sql1, con2);
            DataTable dt2 = new DataTable();
            sqlcmd1.Connection.Open();
            dt2.Load(sqlcmd1.ExecuteReader());
            sqlcmd1.Connection.Close();
            comboBoxSupplierName.DataSource = dt2;
            comboBoxSupplierName.DisplayMember = "Supplier_Name";
            comboBoxSupplierName.ValueMember = "Supplier_ID";

            selectionCombo = true;
            //comboBoxItemCatagory.Text = "";
            //comboBoxSupplierName.Text = "";
            display_data();
        }

        private void buttonItemAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("insert into Item (Item_ID, Item_Name, Item_Catagory, Item_Price, Item_Quantity, Total_Price, Supplier_Name, Date) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", textBoxItemId.Text, textBoxItemName.Text, comboBoxItemCatagory.Text, textBoxItemPrice.Text, textBoxItemQuantity.Text, textBoxItemTotal.Text, comboBoxSupplierName.Text, DateTime.Now.ToString());
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();
                display_data();
                MessageBox.Show("ADDED SUCCESSFULLY");
                updateStorage();
                buttonItemClear_Click(new object(), new EventArgs());
                
            }
            catch (Exception a)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
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
            data1.Fill(dt1);
            dataGridViewItem.DataSource = dt1;
            sqlcmd.Connection.Close();
        }

        private void buttonItemDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete " + " from Item where Item_ID={0}", textBoxItemId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();
                display_data();
                MessageBox.Show("DELETE SUCCESSFULLY");
                deleteFromStorage();
                buttonItemClear_Click(new object(), new EventArgs());
            }
            catch (Exception b)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }

        private void buttonItemUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dataGridViewRow = dataGridViewItem.Rows[selectedRow];
                dataGridViewItem.SelectedCells[0].Value = textBoxItemId.Text;
                dataGridViewItem.SelectedCells[1].Value = textBoxItemName.Text;
                dataGridViewItem.SelectedCells[2].Value = comboBoxItemCatagory.Text;
                dataGridViewItem.SelectedCells[3].Value = textBoxItemPrice.Text;
                dataGridViewItem.SelectedCells[4].Value = textBoxItemQuantity.Text;
                dataGridViewItem.SelectedCells[5].Value = textBoxItemTotal.Text;
                dataGridViewItem.SelectedCells[6].Value = comboBoxSupplierName.Text;
                string sql = string.Format("update Item set Item_ID={0}, Item_Name='{1}', Item_Catagory='{2}', Item_Price={3}, Item_Quantity={4}, Total_Price={5}, Supplier_Name='{6}'  where  Item_ID={7} ", textBoxItemId.Text, textBoxItemName.Text, comboBoxItemCatagory.Text, textBoxItemPrice.Text, textBoxItemQuantity.Text, textBoxItemTotal.Text, comboBoxSupplierName.Text, textBoxItemId.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("UPDATE SUCCCESSFULLY");
                sqlcmd.Connection.Close();
                display_data();
                if(newValue!=Convert.ToDouble(textBoxItemQuantity.Text))
                {
                    textBoxItemQuantity.Text = (Convert.ToDouble(textBoxItemQuantity.Text)- newValue).ToString();
                }
                updateStorage();
                buttonItemClear_Click(new object(), new EventArgs());
            }
            catch (Exception c)
            {
                MessageBox.Show("SELECT WRONG BUTTON");
            }
            
        }
        private void dataGridViewItem_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                DataGridViewRow row = dataGridViewItem.Rows[selectedRow];
                textBoxItemId.Text = row.Cells[0].Value.ToString();
                textBoxItemName.Text = row.Cells[1].Value.ToString();
                textBoxItemPrice.Text = row.Cells[3].Value.ToString();
                textBoxItemQuantity.Text = row.Cells[4].Value.ToString();
                textBoxItemTotal.Text = row.Cells[5].Value.ToString();
                newValue = Convert.ToDouble(textBoxItemQuantity.Text);
                string bb = row.Cells[6].Value.ToString().ToUpper();
                string aa = row.Cells[2].Value.ToString().ToUpper();
                string a;
                if (aa != comboBoxItemCatagory.Text.ToUpper())
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

                string b;
                if (bb != comboBoxSupplierName.Text.ToUpper())
                {
                    for (int i = 0; i < comboBoxSupplierName.Items.Count; i++)
                    {
                        b = comboBoxSupplierName.GetItemText(comboBoxSupplierName.Items[i]).ToUpper();

                        if (bb == b)
                        {
                            comboBoxSupplierName.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("PLEASE SELECT VALID ROW!!");
            }
            
        }

        private void buttonItemClear_Click(object sender, EventArgs e)
        {
            textBoxItemId.Clear();
            textBoxItemName.Clear();
            textBoxItemPrice.Clear();
            textBoxItemQuantity.Clear();
            textBoxItemTotal.Clear();
            comboBoxItemCatagory.SelectedIndex = -1;
            comboBoxSupplierName.SelectedIndex = -1;
        }
        private void textBoxItemQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxItemTotal.Text = (float.Parse(textBoxItemPrice.Text) * float.Parse(textBoxItemQuantity.Text)).ToString();
            }
            catch (Exception q)
            {

            }
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

        private void buttonAddCatagory_Click(object sender, EventArgs e)
        {
            ItemCatagory openform = new ItemCatagory();
            openform.Show();
            this.Hide();
        }

        private void buttonAddPrice_Click(object sender, EventArgs e)
        {
            ItemPrice openform = new ItemPrice();
            openform.Show();
            this.Hide();
        }

        private void comboBoxItemCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectionCombo)
                {
                    display_data();
                    SqlConnection con1 = new SqlConnection(Connectionstring);
                    SqlCommand sqlcmd = new SqlCommand("select * from Item_Price where Item_Catagory='" + comboBoxItemCatagory.Text.ToString() + "'", con1);
                    DataTable dt1 = new DataTable();
                    sqlcmd.Connection.Open();
                    dt1.Load(sqlcmd.ExecuteReader());
                    sqlcmd.Connection.Close();
                    textBoxItemPrice.Text = dt1.Rows[0][1].ToString();
                }
            }
            catch (Exception h)
            {

            }
        }
        public void updateStorage()
        {
            try
            {
                string sql = string.Format("insert into Storage (Item_Catagory, Item_Quantity) Values('{0}',{1})", comboBoxItemCatagory.Text,textBoxItemQuantity.Text);
                SqlConnection con2 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd2 = new SqlCommand(sql, con2);
                sqlcmd2.Connection.Open();
                sqlcmd2.ExecuteNonQuery();
                sqlcmd2.Connection.Close();
                MessageBox.Show("Storage Inserted");
            }
            catch
            {
                string sql = string.Format("select Item_Quantity from Storage where Item_Catagory='{0}'",comboBoxItemCatagory.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                dt1.Load(sqlcmd.ExecuteReader());
                sqlcmd.Connection.Close();

                double currnetQuantity=Convert.ToDouble(dt1.Rows[0][0].ToString());
                double newTotal = currnetQuantity + Convert.ToDouble(textBoxItemQuantity.Text);

                string sq2 = string.Format("update Storage set Item_Quantity={0} where  Item_Catagory='{1}' ", newTotal, comboBoxItemCatagory.Text);
                SqlConnection con3 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd3 = new SqlCommand(sq2, con3);
                sqlcmd3.Connection.Open();
                sqlcmd3.ExecuteNonQuery();
                sqlcmd3.Connection.Close();
                MessageBox.Show("Storage Updated");
            }

        }

        public void deleteFromStorage()
        {
            string sql = string.Format("select Item_Quantity from Storage where Item_Catagory='{0}'", comboBoxItemCatagory.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();

            double currnetQuantity = Convert.ToDouble(dt1.Rows[0][0].ToString());
            double newTotal = currnetQuantity - Convert.ToDouble(textBoxItemQuantity.Text);

            string sq2 = string.Format("update Storage set Item_Quantity={0} where  Item_Catagory='{1}' ", newTotal, comboBoxItemCatagory.Text);
            SqlConnection con3 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd3 = new SqlCommand(sq2, con3);
            sqlcmd3.Connection.Open();
            sqlcmd3.ExecuteNonQuery();
            sqlcmd3.Connection.Close();
            MessageBox.Show("Storage Updated");
        }

    }
}
