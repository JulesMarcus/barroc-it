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
    public partial class finance : Form
    {
        public finance()
        {
            InitializeComponent();
        }

        private void finance_Load(object sender, EventArgs e)
        {
            DatabaseHandler dbFin = new DatabaseHandler();

            dg_InfoTab_Finance1.DataSource = dbFin.GetDataView(DataDict.TBL10);
            dg_ProjectsTab_Finance1.DataSource = dbFin.GetDataView(DataDict.TBL20);
            dg_AppointmentsTab_Finance1.DataSource = dbFin.GetDataView(DataDict.TBL30);
            dg_InvoicesTab_Finance1.DataSource = dbFin.GetDataView(DataDict.TBL40);
            dg_InfoTab_Finance2.DataSource = dbFin.GetDataView(DataDict.TBL10);
            dg_ProjectsTab_Finance2.DataSource = dbFin.GetDataView(DataDict.TBL20);
            dg_AppointmentsTab_Finance2.DataSource = dbFin.GetDataView(DataDict.TBL30);
            dg_InvoicesTab_Finance2.DataSource = dbFin.GetDataView(DataDict.TBL40);
        }
    }
}
