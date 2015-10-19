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
            dg_ProjectsTab_Dev1.DataSource = db.QueryEx("SELECT * FROM tbl_projects;");
            dg_InvoicesTab_Dev1.DataSource = db.QueryEx("SELECT * FROM tbl_invoices;");
            dg_AppointmentsTab_Dev1.DataSource = db.QueryEx("SELECT * FROM tbl_appointments;");
        }

        private void Dev_Load(object sender, EventArgs e)
        {

        }

        private void btn_edit_Infotab_Dev_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
           
                if (btn_edit_Infotab_Dev.Text == "Edit")
                {
                    btn_edit_Infotab_Dev.Text = "Save";
                    dg_Infotab_Dev1.ForeColor = Color.Gray;
                    dg_Infotab_Dev1.Enabled = false;
                    dg_infotab_Dev2.DataSource = db.QueryEx("SELECT * FROM tbl_customers;");
                    dg_infotab_Dev2.Show();
                }
                else
                {
                    btn_edit_Infotab_Dev.Text = "Edit";
                    dg_Infotab_Dev1.Enabled = true;
                    dg_infotab_Dev2.Hide();
                }
         
            
        }

        
    }
}
