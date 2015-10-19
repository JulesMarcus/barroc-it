using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barroc_IT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client_list_Dev cl_Dev = new client_list_Dev();
            client_list_Finance cl_Fin = new client_list_Finance();
            client_list_Sales cl_Sal = new client_list_Sales();

            if (txt_Username.Text == "Development")
            {
                this.Hide();
                cl_Dev.Show();
            }
            else if (txt_Username.Text == "Sales")
            {
                this.Hide();
                cl_Sal.Show();
            }
            else if (txt_Username.Text == "Finance")
            {
                this.Hide();
                cl_Fin.Show();
            }
            else MessageBox.Show("Wrong username");
        }
    }
}
