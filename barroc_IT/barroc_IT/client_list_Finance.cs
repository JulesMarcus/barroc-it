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
        public client_list_Finance()
        {
            InitializeComponent();
        }

        private void btn_Add_Client_Clientlist_Dev_Click(object sender, EventArgs e)
        {
            finance Fin = new finance();
            this.Hide();
            Fin.Show();
        }
    }
}
