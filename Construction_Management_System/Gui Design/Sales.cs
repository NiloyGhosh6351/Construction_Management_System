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
    public partial class Sales : Form
    {
        bool selectionCombo = false;
        bool selectionCombo1 = false;
        bool selectionCombo2 = false;
        float discount, discountGiven;
        double totalprice;
        string Connectionstring;
        public Sales()
        {
            InitializeComponent();
            //var currentLocation = Directory.GetCurrentDirectory();
            //var projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            Connectionstring = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30",projectDir);
            dataGridViewTotal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTotal.MultiSelect = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager f1 = new FormManager();
            f1.Show();
            this.Hide();
        }

        private void panelSales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            string sql1 = string.Format("select * " + " from Client");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd1 = new SqlCommand(sql1, con1);
            DataTable dt1 = new DataTable();
            sqlcmd1.Connection.Open();
            dt1.Load(sqlcmd1.ExecuteReader());
            sqlcmd1.Connection.Close();
            comboBoxClientId.DataSource = dt1;
            comboBoxClientId.DisplayMember = "Client_ID";
            comboBoxClientId.ValueMember = "Client_ID";

            selectionCombo = true;

            string sql = string.Format("select * " + " from Item_Price");
            SqlConnection con = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            sqlcmd.Connection.Open();
            dt.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();
            comboBoxSalesItem.DataSource = dt;
            comboBoxSalesItem.DisplayMember = "Item_Catagory";
            comboBoxSalesItem.ValueMember = "Item_Catagory";

            selectionCombo1 = true;

            string sql2 = string.Format("select * " + " from Transportation_Manager");
            SqlConnection con2 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd2 = new SqlCommand(sql2, con2);
            DataTable dt2 = new DataTable();
            sqlcmd2.Connection.Open();
            dt2.Load(sqlcmd2.ExecuteReader());
            sqlcmd2.Connection.Close();
            comboBoxTransportation.DataSource = dt2;
            comboBoxTransportation.DisplayMember = "Car_Number";
            comboBoxTransportation.ValueMember = "Transportation_Id";

            selectionCombo2 = true;
            textBoxAfterDiscount.Text = "";

        }
        private void caltotal()
        {
            double cal2=0;
            for(int i=0; i < dataGridViewTotal.Rows.Count; i++)
            {
                try
                {
                    cal2 += Convert.ToDouble(dataGridViewTotal.Rows[i].Cells[4].Value);
                }
                catch (Exception r)
                {

                }
                textBoxGrantTotal.Text = cal2.ToString();
            }
        }

        private void comboBoxClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectionCombo)
                {
                    //display_data();
                    SqlConnection con1 = new SqlConnection(Connectionstring);
                    SqlCommand sqlcmd1 = new SqlCommand("select * from Client where Client_ID= '" + comboBoxClientId.Text.ToString() + "'", con1);
                    DataTable dt1 = new DataTable();
                    sqlcmd1.Connection.Open();
                    dt1.Load(sqlcmd1.ExecuteReader());
                    sqlcmd1.Connection.Close();
                    textBoxClientName.Text = dt1.Rows[0][1].ToString();
                    textBoxClientContact.Text = dt1.Rows[0][3].ToString();
                }
            }
            catch (Exception h)
            {

            }
        }

        private void comboBoxSalesItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectionCombo1)
                {
                    //display_data();
                    SqlConnection con = new SqlConnection(Connectionstring);
                    SqlCommand sqlcmd = new SqlCommand("select * from Item_Price where Item_Catagory= '" + comboBoxSalesItem.Text.ToString() + "'", con);
                    DataTable dt = new DataTable();
                    sqlcmd.Connection.Open();
                    dt.Load(sqlcmd.ExecuteReader());
                    sqlcmd.Connection.Close();
                    textBoxSalesPrice.Text = dt.Rows[0][1].ToString();
                    //textBoxClientContact.Text = dt.Rows[0][3].ToString();
                }
            }
            catch (Exception h)
            {

            }
        }

        private void textBoxSalesQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxSalesTotal.Text = (float.Parse(textBoxSalesPrice.Text) * float.Parse(textBoxSalesQuantity.Text)).ToString();
            }
            catch (Exception q)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAfterDiscount.Text == "")
                {
                    totalprice = Convert.ToDouble(textBoxSalesTotal.Text);
                }
                string sql = string.Format("insert into Sales_Price_Cart (Item, Price, Quantity, Discount, Total) Values('{0}','{1}','{2}','{3}','{4}')", comboBoxSalesItem.Text, textBoxSalesPrice.Text, textBoxSalesQuantity.Text, textBoxDiscountPrice.Text, totalprice.ToString());
                SqlConnection con = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con);
                DataTable dt = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                //MessageBox.Show("Add successfully");

                sqlcmd.Connection.Close();
                display_dataSales();
                MessageBox.Show("Item Added Successfully");
                //buttonItemClear_Click(new object(), new EventArgs());
                textBoxDiscount.Text = "";
                textBoxDiscountPrice.Text = "";
                textBoxSalesQuantity.Text = "";
                textBoxSalesPrice.Text = "";
                textBoxSalesTotal.Text = "";
                comboBoxSalesItem.Text = "";

                caltotal();
                textBoxAfterDiscount.Text = "";
            }
            catch (Exception o)
            {
                MessageBox.Show("Selected Duplicate Item");
            }
            
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if(textBoxDiscount.Text=="")
                {
                    textBoxDiscountPrice.Text = "";
                    textBoxAfterDiscount.Text = "";
                    totalprice = Convert.ToDouble(textBoxSalesTotal.Text);
                }
                else if (textBoxDiscount.Text != "0")
                {
                    discount = float.Parse(textBoxDiscount.Text.ToString());
                    if(discount<=100 && discount>=0)
                    {
                        discountGiven = (float.Parse(textBoxSalesTotal.Text) * discount) / 100;
                        textBoxDiscountPrice.Text = discountGiven.ToString();

                        textBoxAfterDiscount.Text = (float.Parse(textBoxSalesTotal.Text) - discountGiven).ToString();
                        totalprice = Convert.ToDouble(textBoxAfterDiscount.Text);
                    }
                    else
                    {
                        MessageBox.Show("DISCOUNT CAN NOT BE NEGATIVE OR EXCEED 100%");
                        textBoxDiscount.Text = "";
                    }
                }
                else
                {
                    totalprice = Convert.ToDouble(textBoxSalesTotal.Text);
                }
            }
            catch (Exception p)
            {
                MessageBox.Show("Enter a Number or Fill Quantity");
                textBoxDiscount.Text = "";
                textBoxDiscountPrice.Text = "";
                textBoxAfterDiscount.Text = "";
            }
            
        }

        private void textBoxDiscountPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxAfterDiscount_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void display_dataSales()
        {
            string sql = string.Format("select * " + " from Sales_Price_Cart");
            SqlConnection con = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataAdapter data1 = new SqlDataAdapter(sqlcmd);
            //MessageBox.Show("Add successfully");
            data1.Fill(dt);
            dataGridViewTotal.DataSource = dt;
            sqlcmd.Connection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxTransportation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectionCombo2)
                {
                    //display_data();
                    SqlConnection con = new SqlConnection(Connectionstring);
                    SqlCommand sqlcmd = new SqlCommand("select * from Transportation_Manager where Booking_Condition='Available' and Car_Number='" + comboBoxTransportation.Text.ToString()+"'", con);
                    DataTable dt = new DataTable();
                    sqlcmd.Connection.Open();
                    dt.Load(sqlcmd.ExecuteReader());
                    sqlcmd.Connection.Close();
                    //textBoxSalesAvailable.Text = dt.Rows[0][1].ToString();
                    //textBoxClientContact.Text = dt.Rows[0][3].ToString();
                    if(dt.Rows.Count==0)
                    {
                        textBoxSalesAvailable.Text = "Not Available";
                    }
                    else
                    {
                        textBoxSalesAvailable.Text = "Available";
                    }
                }
            }
            catch (Exception h)
            {

            }
        }

        private void dataGridViewTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBooked_Click(object sender, EventArgs e)
        {
            if (textBoxSalesAvailable.Text == "Available")
            {
                string sql = string.Format("update Transportation_Manager set Booking_Condition='Booked'  where  Car_Number='{0}' ",comboBoxTransportation.Text);
                SqlConnection con1 = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, con1);
                DataTable dt1 = new DataTable();
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");

                sqlcmd.Connection.Close();
                textBoxSalesAvailable.Text = "Not Available";
            }
        }

        private void buttonUnbooked_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalesAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalesClear_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from Sales_Price_Cart");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();

            dataGridViewTotal.DataSource = null;

            textBoxGrantTotal.Text = "";
            totalprice = 0;
        }

        private void textBoxSalesTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
