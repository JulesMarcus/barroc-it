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

namespace barroc_IT
{
    public partial class Login : Form
    {
        private DatabaseHandler dbh;
        public Login()
        {
            InitializeComponent();
            dbh = new DatabaseHandler();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            dbh.TestConnection();
            dbh.OpenConnectionDB();

            bool exist = false;
            string username = txt_Username.Text;
            string password = txt_Password.Text;

            txt_Username.Text = "";
            txt_Password.Text = "";

            using (SqlCommand cmd = new SqlCommand(@"
                SELECT COUNT(*) 
                FROM [tbl_users] 
                WHERE username = @Username
                AND password = @Password", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("Username", username);
                cmd.Parameters.AddWithValue("Password", password);
                exist = (int)cmd.ExecuteScalar() > 0;
                dbh.CloseConnectionDB();
            }

            if (exist)
            {
                MessageBox.Show("Login succesful");

                client_list_Dev cl_Dev = new client_list_Dev();
                client_list_Finance cl_Fin = new client_list_Finance();
                client_list_Sales cl_Sal = new client_list_Sales();

                if (txt_Username.Text == "dev")
                {
                    this.Hide();
                    cl_Dev.Show();
                }
                else if (txt_Username.Text == "sal")
                {
                    this.Hide();
                    cl_Sal.Show();
                }
                else if (txt_Username.Text == "fin")
                {
                    this.Hide();
                    cl_Fin.Show();
                }
            }
            else
            {
                dbh.CloseConnectionDB();
                MessageBox.Show("Wrong username and/or password.");
            }
        }
        



        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
