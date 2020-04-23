using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_Management_System.Gui_Design
{
    public partial class Login : Form
    {
        string Connectionstring;
        public Login()
        {
            InitializeComponent();
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            Connectionstring = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\Construction_Management_System.mdf;Integrated Security=True;Connect Timeout=30", projectDir);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from Login_User where UserName='" + textBoxLoginUser.Text + "' and Password='" + textBoxUserPassword.Text + "'";
            
            //SqlConnection conn = new SqlConnection(Connectionstring);
            //SqlCommand sqlCmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql,Connectionstring);

            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            string combovalue = comboBoxLLoginUserType.SelectedItem.ToString();

            //sqlCmd.Connection.Open();
            //var affectedRowCount=sqlCmd.ExecuteNonQuery();
            //dt1.Load(sqlCmd.ExecuteReader());
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                   if (dt1.Rows[i]["UserType"].ToString() == combovalue)
                   {
                        MessageBox.Show("you are login as" + dt1.Rows[i][2]);
                        if (comboBoxLLoginUserType.SelectedIndex == 0)
                        {
                            FormHome a1 = new FormHome();
                            a1.Show();
                            this.Hide();
                        }
                        else
                        {
                            FormManager i1 = new FormManager();
                            i1.Show();
                            this.Hide();
                        }
                   }
                }
            }

            else
            {
                MessageBox.Show("Login Failed");
            }
            //sqlCmd.Connection.Close();
        }

        /*private void Login_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * " + " from LoginUser");
            SqlConnection con1 = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(sql, con1);
            DataTable dt1 = new DataTable();
            sqlcmd.Connection.Open();
            dt1.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();
            comboBoxLLoginUserType.DataSource = dt1;
            comboBoxLLoginUserType.DisplayMember = "UserType";
            comboBoxLLoginUserType.ValueMember = "Id";
            //display_dataUser();
        }*/
    }
}
