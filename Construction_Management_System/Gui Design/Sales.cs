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
        int selectedRow;
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
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

            comboBoxTransportation.Text = "";

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

            buttonSalesAdd_Click(new object(), new EventArgs());

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
                string sql2 = string.Format("select * from Sales_Price_Cart where Item='{0}' and Sales_ID={1}",comboBoxSalesItem.Text,textBoxSalesId.Text);
                DataTable dt4 = new DataTable();
                SqlConnection con = new SqlConnection(Connectionstring);
                SqlCommand sqlcmd2 = new SqlCommand(sql2, con);
                sqlcmd2.Connection.Open();
                dt4.Load(sqlcmd2.ExecuteReader());
                sqlcmd2.Connection.Close();
                if (dt4.Rows.Count==0)
                {
                    if (textBoxAfterDiscount.Text == "")
                    {
                        totalprice = Convert.ToDouble(textBoxSalesTotal.Text);
                    }
                    string sql = string.Format("insert into Sales_Price_Cart (Item, Price, Quantity, Discount_Price, Total, Sales_ID) Values('{0}','{1}','{2}','{3}','{4}','{5}')", comboBoxSalesItem.Text, textBoxSalesPrice.Text, textBoxSalesQuantity.Text, textBoxDiscountPrice.Text, totalprice.ToString(), textBoxSalesId.Text);
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
                else
                {
                    MessageBox.Show("Duplicate Item cannot be inserted");
                }
                
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
                        discountGiven = float.Parse(textBoxSalesTotal.Text) * (discount / 100);
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
            string sql = string.Format("select * " + " from Sales_Price_Cart where Sales_ID={0}",textBoxSalesId.Text);
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
                textBoxSalesAvailable.Text = "Booked";
            }
        }

        private void buttonUnbooked_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalesAdd_Click(object sender, EventArgs e)
        {
            string a = textBoxSalesAvailable.Text;
            if (a != "Not Available")
            {
                try
                {
                    string sql = string.Format("insert into Sales(Sales_ID,Client_ID,Client_Name,Contact,Transportation,Date) Values('{0}','{1}','{2}','{3}','{4}','{5}')", textBoxSalesId.Text, comboBoxClientId.Text, textBoxClientName.Text, textBoxClientContact.Text, comboBoxTransportation.Text, DateTime.Now.ToString());
                    SqlConnection con1 = new SqlConnection(Connectionstring);
                    SqlCommand sqlcmd = new SqlCommand(sql, con1);
                    sqlcmd.Connection.Open();
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.Connection.Close();
                }
                catch (Exception ex)
                {
                    

                }



                refreshTable2();
                dataGridViewTotal.DataSource = null;
            }
            else
            {
                MessageBox.Show("Selected Transport Not Available");
            }
            
            //DataTable dt = dataGridViewTotal.DataSource as DataTable;
            //DataTable dt1 = new DataTable();
            //dt1 = dt.Copy();
            //dt1.Columns.Add("Sales_ID", typeof(String));
            //dt1.Columns.Add("Client_ID", typeof(String));
            //dt1.Columns.Add("Client_Name", typeof(String));
            //dt1.Columns.Add("Transportation", typeof(String));
            //dt1.Columns.Add("Date", typeof(DateTime));
            //dt1.Rows[0][5] = textBoxSalesId.Text;
            //dt1.Rows[0][6] = comboBoxClientId.Text;
            //dt1.Rows[0][7] = textBoxClientName.Text;
            //dt1.Rows[0][8] = comboBoxTransportation.Text;
            //dt1.Rows[0][9] = DateTime.Now.ToString();
            //dataGridView1.DataSource = dt1;
        }

        private void buttonSalesClear_Click(object sender, EventArgs e)
        {
            dataGridViewTotal.DataSource = null;
            textBoxSalesId.Text = "";
            comboBoxClientId.Text = "";
            textBoxClientName.Text = "";
            textBoxClientContact.Text = "";
            textBoxSalesPrice.Text = "";
            textBoxSalesQuantity.Text = "";
            textBoxGrantTotal.Text = "";
            textBoxAfterDiscount.Text = "";
            textBoxDiscount.Text = "";
            comboBoxSalesItem.Text = "";
            textBoxDiscountPrice.Text = "";
            comboBoxTransportation.Text = "";
            textBoxSalesTotal.Text = "";
            textBoxSalesAvailable.Text = "";
        }
        private void buttonSalesDelete_Click(object sender, EventArgs e)
        {
            //string sql = string.Format("delete from Sales inner join Sales_Price_Cart  ON Sales.Sales_ID=Sales_Price_Cart.Sales_ID where Sales_ID={0}", textBoxSalesId.Text);
            //SqlConnection con = new SqlConnection(Connectionstring);
            //SqlCommand sqlcmd = new SqlCommand(sql, con);
            //DataTable dt = new DataTable();
            //sqlcmd.Connection.Open();
            //sqlcmd.ExecuteNonQuery();
            //sqlcmd.Connection.Close();
            //MessageBox.Show("Delete Successfully");

            string sql = string.Format("delete from Sales where Sales_ID={0}", textBoxSalesId.Text);
            SqlConnection con = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();
            MessageBox.Show("Delete Successfully");

            string sql1 = string.Format("delete from Sales_Price_Cart where Sales_ID={0}", textBoxSalesId.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd1 = new SqlCommand(sql1, con1);
            DataTable dt1 = new DataTable();
            sqlcmd1.Connection.Open();
            sqlcmd1.ExecuteNonQuery();
            sqlcmd1.Connection.Close();
            MessageBox.Show("Delete Successfully");

//            update_Database();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBoxSalesId.Text = row.Cells[0].Value.ToString();
            comboBoxClientId.Text = row.Cells[1].Value.ToString();
            textBoxClientName.Text = row.Cells[2].Value.ToString();
            textBoxClientContact.Text = row.Cells[3].Value.ToString();
            comboBoxTransportation.Text = row.Cells[4].Value.ToString();
            //DateTime.Now = row.Cells[5].Value.ToString();
            comboBoxSalesItem.Text = row.Cells[6].Value.ToString();
            textBoxSalesPrice.Text = row.Cells[7].Value.ToString();
            textBoxSalesQuantity.Text = row.Cells[8].Value.ToString();
            textBoxDiscountPrice.Text = row.Cells[9].Value.ToString();
            textBoxSalesTotal.Text = row.Cells[10].Value.ToString();
            string bb = row.Cells[4].Value.ToString().ToUpper();
            string cc = row.Cells[6].Value.ToString().ToUpper();
            string aa = row.Cells[1].Value.ToString().ToUpper();
            string a;
            if (aa != comboBoxClientId.Text.ToUpper())
            {
                for (int i = 0; i < comboBoxClientId.Items.Count; i++)
                {
                    a = comboBoxClientId.GetItemText(comboBoxClientId.Items[i]).ToUpper();

                    if (aa == a)
                    {
                        comboBoxClientId.SelectedIndex = i;
                        break;
                    }
                }
            }

            string b;
            if (bb != comboBoxTransportation.Text.ToUpper())
            {
                for (int i = 0; i < comboBoxTransportation.Items.Count; i++)
                {
                    b = comboBoxTransportation.GetItemText(comboBoxTransportation.Items[i]).ToUpper();

                    if (bb == b)
                    {
                        comboBoxTransportation.SelectedIndex = i;
                        break;
                    }
                }
            }
            string c;
            if (cc != comboBoxSalesItem.Text.ToUpper())
            {
                for (int i = 0; i < comboBoxSalesItem.Items.Count; i++)
                {
                    c = comboBoxSalesItem.GetItemText(comboBoxSalesItem.Items[i]).ToUpper();

                    if (cc == c)
                    {
                        comboBoxSalesItem.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void buttonSalesUpdate_Click(object sender, EventArgs e)
        {
            //DataGridViewRow dataGridViewRow = dataGridView1.Rows[selectedRow];
            //dataGridView1.SelectedCells[0].Value = textBoxSalesId.Text;
            //dataGridView1.SelectedCells[1].Value = comboBoxClientId.Text;
            //dataGridView1.SelectedCells[2].Value = textBoxClientName.Text;
            //dataGridView1.SelectedCells[3].Value = textBoxClientContact.Text;
            //dataGridView1.SelectedCells[4].Value = comboBoxTransportation.Text;
            //dataGridView1.SelectedCells[6].Value = comboBoxSalesItem.Text;
            //dataGridView1.SelectedCells[7].Value = textBoxSalesPrice.Text;
            //dataGridView1.SelectedCells[8].Value = textBoxSalesQuantity.Text;
            //dataGridView1.SelectedCells[9].Value = textBoxDiscountPrice.Text;
            //dataGridView1.SelectedCells[10].Value = textBoxSalesTotal.Text;

            //string sql = string.Format("update Sales set inner join Sales_Price_Cart  ON Sales.Sales_ID=Sales_Price_Cart.Sales_ID where Sales_ID={0}",textBoxSalesId.Text);
            //SqlConnection con1 = new SqlConnection(Connectionstring);
            //SqlCommand sqlcmd = new SqlCommand(sql, con1);
            //DataTable dt1 = new DataTable();
            //sqlcmd.Connection.Open();
            //sqlcmd.ExecuteNonQuery();
            //MessageBox.Show("Update Successfully");

            //sqlcmd.Connection.Close();

            string sql = string.Format("update Sales set Client_ID={0}, Client_Name='{1}', Contact='{2}', Transportation='{3}'  where  Sales_ID={4} ", comboBoxClientId.Text, textBoxClientName.Text, textBoxClientContact.Text,comboBoxTransportation.Text, textBoxSalesId.Text);
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully");

            sqlcmd.Connection.Close();


            // update_Database();
            refreshTable2();
        }

        private void textBoxSalesTotal_TextChanged(object sender, EventArgs e)
        {

        }

        public void refreshTable2()
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            string sql2 = string.Format("select * from Sales inner join Sales_Price_Cart  ON Sales.Sales_ID=Sales_Price_Cart.Sales_ID order by Sales.Date desc", textBoxSalesId.Text);
            DataTable dt = new DataTable();
            SqlCommand sqlcmd2 = new SqlCommand(sql2, con);
            sqlcmd2.Connection.Open();
            dt.Load(sqlcmd2.ExecuteReader());
            sqlcmd2.Connection.Close();
            dt.Columns.Remove("Sales_ID1");
            dataGridView1.DataSource = dt;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
    }
}
