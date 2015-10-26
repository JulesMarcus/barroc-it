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
        }

        private void Dev_Load(object sender, EventArgs e)
        {
            DatabaseHandler dbDev = new DatabaseHandler();
        
            dg_Infotab_Dev1.DataSource = dbDev.GetDataView(DataDict.TBL10);
            dg_ProjectsTab_Dev1.DataSource = dbDev.GetDataView(DataDict.TBL20);
            dg_AppointmentsTab_Dev1.DataSource = dbDev.GetDataView(DataDict.TBL30);
            dg_InvoicesTab_Dev1.DataSource = dbDev.GetDataView(DataDict.TBL40);
            dg_infotab_Dev2.DataSource = dbDev.GetDataView(DataDict.TBL10);           
            dg_ProjectsTab_Dev2.DataSource = dbDev.GetDataView(DataDict.TBL20);
            dg_AppointmentsTab_Dev2.DataSource = dbDev.GetDataView(DataDict.TBL30);
            dg_InvoicesTab_Dev2.DataSource = dbDev.GetDataView(DataDict.TBL40);

        }
        
        private void btn_edit_Infotab_Dev_Click(object sender, EventArgs e)
        {
            DatabaseHandler dbDev = new DatabaseHandler();
           
                if (btn_edit_Infotab_Dev.Text == "Edit")
                {
                    btn_edit_Infotab_Dev.Text = "Save";
                    dg_Infotab_Dev1.ForeColor = Color.Gray;
                    dg_Infotab_Dev1.Enabled = false;
                    dg_infotab_Dev2.DataSource = dbDev.GetDataView(DataDict.TBL10);
                    dg_infotab_Dev2.Show();
                    
                }
                else
                {
                    dbDev.Update("SELECT * FROM tbl_customers;", "tbl_customers");
                    btn_edit_Infotab_Dev.Text = "Edit";
                    dg_Infotab_Dev1.Enabled = true;
                    dg_infotab_Dev2.Hide();
                }
        }
    }
}
