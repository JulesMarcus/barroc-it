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
            dg_Client_list_Finance1.DataSource = db.QueryEx("SELECT " + DataDict.FLD12 + " FROM " + DataDict.TBL10);
            DataGridViewColumn column = dg_Client_list_Finance1.Columns[0];
            column.Width = 315;
        }

        public void logOut()
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            this.Dispose();
        }

        private void btn_Add_Client_Clientlist_Fin_Click(object sender, EventArgs e)
        {
            finance Fin = new finance();
            Fin.load_info_Add();
            Fin.Show();
            this.Hide();
            this.Dispose();
        }

        private void dg_Client_list_Finance1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            finance Fin = new finance();
            string iQuery = "SELECT * FROM " + DataDict.TBL10 + " WHERE " + DataDict.FLD12 + " = '" + dg_Client_list_Finance1.CurrentCell.Value.ToString() + "';";
            string pQuery = "SELECT * FROM " + DataDict.TBL20 + " FULL OUTER JOIN " + DataDict.TBL10 + " ON " + DataDict.TBL10 + "." + DataDict.FLD12 + "=" + DataDict.TBL20 + "." + DataDict.FLD21 + ";";
            Fin.load_info_from_Cell(iQuery, pQuery);
            Fin.Show();
            this.Hide();
        }

        private void btn_Logout_Clientlist_Finance_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void backBtn_client_list_Fin_Click(object sender, EventArgs e)
        {
            logOut();
        }
    }
}
