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
        private void btn_Login_Click(object sender, EventArgs e)
        {
            dbh.TestConnection();
            dbh.OpenConnectionDB();

            bool exist = false;
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            int department;

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

                dbh.OpenConnectionDB();
                using (SqlCommand qry = new SqlCommand(@"
                    SELECT department FROM [tbl_users] 
                    WHERE username = @Username 
                    AND password = @Password", dbh.GetCon()))
                {
                    qry.Parameters.AddWithValue("Username", username);
                    qry.Parameters.AddWithValue("Password", password);
                    string res = qry.ExecuteScalar().ToString();
                    department = int.Parse(res);
                };

                switch (department)
                {
                    case 0:
                        client_list_Dev cl_Dev = new client_list_Dev();
                        this.Hide();
                        cl_Dev.Show();
                        break;
                    case 1:
                        client_list_Sales cl_Sal = new client_list_Sales();
                        this.Hide();
                        cl_Sal.Show();
                        break;
                    case 2:
                        client_list_Finance cl_Fin = new client_list_Finance();
                        this.Hide();
                        cl_Fin.Show();
                        break;
                    default:
                        MessageBox.Show("No department set. (" + department + ")");
                        break;
                }
            }
            else
            {
                dbh.CloseConnectionDB();
                MessageBox.Show("Wrong username and/or password.");
            }
        }
    }
}
