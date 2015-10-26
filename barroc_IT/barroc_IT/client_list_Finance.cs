using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace barroc_IT
{
    public partial class client_list_Finance : Form
    {
        public client_list_Finance()
        {
            InitializeComponent();
            DatabaseHandler dbFin = new DatabaseHandler();
            dg_Client_list_Finance1.DataSource = dbFin.GetDataView(DataDict.TBL10, DataDict.FLD12);
        }

        private void btn_Add_Client_Clientlist_Dev_Click(object sender, EventArgs e)
        {
            finance fin = new finance();
            this.Hide();
            fin.Show();
        }
    }
}
