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
    public partial class FormItem : Form
    {
        public FormItem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void buttonItemAdd_Click(object sender, EventArgs e)
        {
            string Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ANUP\Documents\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30";
            string sql = string.Format("insert into Item (Item_ID, Item_Name, Item_Price, Item_Catagory, Supplier_Name) Values('{0}','{1}','{2}','{3}','{4}')", textBoxItemId.Text, textBoxItemName.Text,textBoxItemPrice.Text,textBoxCategory.Text,textBoxSupplierName.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Add successfully");

            sqlcmd.Connection.Close();
            
        }
    }
}
