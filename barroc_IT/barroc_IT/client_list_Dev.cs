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
        public client_list_Dev()
        {
            InitializeComponent();
            DatabaseHandler dbDev = new DatabaseHandler();
            dg_Client_list_Dev1.DataSource = dbDev.GetDataView(DataDict.TBL10, DataDict.FLD12);
        }

        private void btn_Add_Client_Clientlist_Dev_Click(object sender, EventArgs e)
        {
            DatabaseHandler dbDev = new DatabaseHandler();
            Dev dev = new Dev();
            this.Hide();
            dev.Show();
        }
    }
}
