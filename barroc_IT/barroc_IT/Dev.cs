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
    public partial class Dev : Form
    {
        public Dev()
        {
            InitializeComponent();
            DatabaseHandler db = new DatabaseHandler();
            dg_Infotab_Dev1.DataSource = db.QueryEx("SELECT * FROM tbl_customers;");
        }

        private void Dev_Load(object sender, EventArgs e)
        {

        }
    }
}
