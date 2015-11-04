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
    public partial class client_list_Finance : Form
    {
        finance fin;
        public client_list_Finance()
        {
            InitializeComponent();
            DatabaseHandler db = new DatabaseHandler();
            dg_Client_list_Finance1.DataSource = db.QueryEx("SELECT company_Name FROM tbl_customers");
            DataGridViewColumn column = dg_Client_list_Finance1.Columns[0];
            column.Width = 315;
        }

        private void btn_Add_Client_Clientlist_Fin_Click(object sender, EventArgs e)
        {
            finance Fin = new finance();
            Fin.
            this.Hide();
            Fin.Show();
        }
    }
}
