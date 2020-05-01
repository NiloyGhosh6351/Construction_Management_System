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

namespace Construction_Management_System.Gui_Design
{
    public partial class Manager_ItemCatagory : Form
    {
        string Connectionstring;
        int selectedRow;
        public Manager_ItemCatagory()
        {
            InitializeComponent();
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            Connectionstring = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30", projectDir);
            dataGridViewCatagory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCatagory.MultiSelect = false;
        }
        private void pictureBoxCatagory_Click(object sender, EventArgs e)
        {
            this.Close();
            Item_Manager f1 = new Item_Manager();
            f1.Show();
            this.Hide();
        }

        private void buttonICatagoryAdd_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into Item_Catagory (Id, Item_Catagory) Values('{0}','{1}')", textBoxCatagoryId.Text, textBoxCatagoryName.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();
            display_dataCatagory();
            MessageBox.Show("ITEM ADDED SUCCESSFULLY");
        }
        public void display_dataCatagory()
        {
            string sql = string.Format("select * " + " from Item_Catagory");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            data1.Fill(dt1);
            dataGridViewCatagory.DataSource = dt1;
            sqlcmd.Connection.Close();
            buttonCatagoryClear_Click(new object(), new EventArgs());
        }

        private void buttonCatagoryUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridViewCatagory.Rows[selectedRow];
            dataGridViewCatagory.SelectedCells[0].Value = textBoxCatagoryId.Text;
            dataGridViewCatagory.SelectedCells[1].Value = textBoxCatagoryName.Text;
            string sql = string.Format("update Item_Catagory set Id={0}, Item_Catagory='{1}'  where  Id={2} ", textBoxCatagoryId.Text, textBoxCatagoryName.Text, textBoxCatagoryId.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("UPDATE SUCCESSFULLY");
            sqlcmd.Connection.Close();
            display_dataCatagory();
        }

        private void buttonCatagoryDelete_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete " + " from Item_Catagory where Id={0}", textBoxCatagoryId.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();
            display_dataCatagory();
            MessageBox.Show("DELETE SUCCESSFULLY");
            buttonCatagoryClear_Click(new object(), new EventArgs());
        }

        private void buttonCatagoryClear_Click(object sender, EventArgs e)
        {
            textBoxCatagoryId.Clear();
            textBoxCatagoryName.Clear();
        }

        private void dataGridViewCatagory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridViewCatagory.Rows[selectedRow];
            textBoxCatagoryId.Text = row.Cells[0].Value.ToString();
            textBoxCatagoryName.Text = row.Cells[1].Value.ToString();
        }

        private void ItemCatagory_Load(object sender, EventArgs e)
        {
            display_dataCatagory();
        }
    }
}
