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
    public partial class client_list_Dev : Form
    {
        Dev dev;
        public client_list_Dev()
        {
            InitializeComponent();
            DatabaseHandler db = new DatabaseHandler();
            dg_Client_list_Dev1.DataSource = db.QueryEx("SELECT company_Name FROM tbl_customers");
            DataGridViewColumn column = dg_Client_list_Dev1.Columns[0];
            column.Width = 315;
            
        }

        private void btn_Add_Client_Clientlist_Dev_Click(object sender, EventArgs e)
        {
            dev = new Dev();
            dev.load_info_Add();
            dev.Show();
            this.Hide();
            this.Dispose();
        }

        private void dg_Client_list_Dev1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dev dev = new Dev();
            string query = "SELECT * FROM tbl_customers WHERE company_Name = " + "'" +dg_Client_list_Dev1.CurrentCell.Value.ToString() + "' ;";
            dev.load_info_from_Cell(query);
            dev.Show();
            this.Hide();
        }

        private void btn_Logout_Clientlist_Dev_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            this.Dispose();
        }

        private void backBtn_client_list_Dev_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            this.Dispose();
        }
    }
}
