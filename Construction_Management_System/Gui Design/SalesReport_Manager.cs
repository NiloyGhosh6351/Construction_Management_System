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
    public partial class SalesReport_Manager : Form
    {
        string Connectionstring;
        public SalesReport_Manager()
        {
            InitializeComponent();
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            Connectionstring = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30", projectDir);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager f1 = new FormManager();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            string where = string.Format(" where convert(varchar,Date,101)<='{0}' and convert(varchar,Date,101)>='{1}' ", date1, date2);
            refreshTable2(where);
        }

        private void SalesReport_Manager_Load(object sender, EventArgs e)
        {
            refreshTable2("");
        }
        public void refreshTable2(string where)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            string sql2 = string.Format("select * from Sales inner join Sales_Price_Cart  ON Sales.Sales_ID=Sales_Price_Cart.Sales_ID {0} order by Sales.Date desc ", where);
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

        private void radioButtonDaily_CheckedChanged(object sender, EventArgs e)
        {
            string today = DateTime.Now.ToString("MM/dd/yyyy");
            string where = string.Format(" where convert(varchar,Date,101)='{0}' ", today);
            refreshTable2(where);
        }

        private void radioButtonWeekly_CheckedChanged(object sender, EventArgs e)
        {
            string today = DateTime.Now.AddDays(-7).ToString("MM/dd/yyyy");
            string where = string.Format(" where convert(varchar,Date,101)>'{0}' ", today);
            refreshTable2(where);
        }

        private void radioButtonMonthly_CheckedChanged(object sender, EventArgs e)
        {
            string today = DateTime.Now.AddMonths(-1).ToString("MM/dd/yyyy");
            string where = string.Format(" where convert(varchar,Date,101)>'{0}' ", today);
            refreshTable2(where);
        }

       
    }
}
