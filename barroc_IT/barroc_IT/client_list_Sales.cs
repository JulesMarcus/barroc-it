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
    public partial class client_list_Sales : Form
    {
        public client_list_Sales()
        {
            InitializeComponent();
        }

        private void btn_Add_Client_Clientlist_Sales_Click(object sender, EventArgs e)
        {
            Sales Sal = new Sales();
            this.Hide();
            Sal.Show();
        }
    }
}
