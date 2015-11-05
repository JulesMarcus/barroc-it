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
        DatabaseHandler db = new DatabaseHandler();
        DataGridViewHelper dgvHelp = new DataGridViewHelper();
        public Dev(string customerID)
        {
            InitializeComponent();
        }
        public Dev()
        {
            InitializeComponent();
            dg_Infotab_Dev1.Enabled = true;
            btn_edit_Infotab_Dev.Text = "Save";
        }
        public void load_info_from_Cell(string iQuery, string pQuery)
        {
            dg_Infotab_Dev1.DataSource = db.GetDataView(iQuery, null, true);
            dg_ProjectsTab_Dev1.DataSource = db.GetDataView(pQuery, null, true);
            btn_edit_Infotab_Dev.Text = "Edit";
        }
        public void load_info_Add()
        {
            btn_edit_Infotab_Dev.Text = "Save";
            dg_Infotab_Dev1.DataSource = db.GetDataView(DataDict.TBL10, null, false, "1=2");
        }
        private void load_edittable_Info()
        {
            //dev part
            dgvHelp.LoadInfo(info_tab, 20, dg_Infotab_Dev1);
           
            if (dg_Infotab_Dev1.Rows[21].Cells["column2"].Value.ToString() == "True")
            {
                potClient_yes_checkbox.Checked = true;
            }
            //dtp_Dev.Value = dg_Infotab_Dev1.Rows[21].Cells["column2"].Value;

            //projects part

        }

        private void btn_edit_Infotab_Dev_Click(object sender, EventArgs e)
        {
            if (btn_edit_Infotab_Dev.Text == "Edit")
            {
                load_edittable_Info();
                btn_edit_Infotab_Dev.Text = "Save";
                dg_Infotab_Dev1.ForeColor = Color.Gray;
                dg_Infotab_Dev1.Enabled = true;
            }
            else if (btn_edit_Infotab_Dev.Text == "Save")
            {
                bool exception = false;
                Dictionary<string, object> dic = new Dictionary<string, object>();
                    
                foreach (Control c in info_tab.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        if (c.Text == string.Empty & (c.Name != "addr2_txt" || c.Name != "zip2_txt" || c.Name != "city2_txt" || c.Name != "phoneNum2_txt"))
                        {
                            MessageBox.Show("Not all required fields have been filled out.");
                            exception = true;
                            break;
                        }
                    }
                }
                if (!exception)
                {
                    int b = 1;
                    for (int i = 0; i < 100; i++)
                    {
                        foreach (Control c in info_tab.Controls)
                        {
                            if (c is TextBox)
                            {
                                TextBox textbox = c as TextBox;
                                dic.Add(dg_Infotab_Dev1.Rows[b].Cells["column1"].Value.ToString(), c.Name = "infoTabText"+b.ToString());
                                b++;
                                if (c.Name == "infoTabText20")
                                {
                                    i = 100;
                                    dic.Add("potential_Client", "" + potClient_yes_checkbox.Checked + "");
                                    dic.Add("last_contact_Date", "" + dtp_Dev.Value.ToString("yyyy-MM-dd") + "");
                                    break;
                                }
                            }
                        }
                    }
                    if (dg_Infotab_Dev1.Columns.Count == 2)
                    {
                        db.updateCmd("tbl_customers", dic);
                    }
                    else if(dg_Infotab_Dev1.Columns.Count == 1 || dg_Infotab_Dev1.Columns.Count == 0)
                    {
                        db.insertCmd("tbl_customers", dic);
                    }
                    btn_edit_Infotab_Dev.Text = "Edit";
                    dg_Infotab_Dev1.Enabled = true;
                    dg_Infotab_Dev1.DataSource = db.GetDataView(DataDict.TBL10, null, false, DataDict.FLD12 + "=" + infoTabText1.Text);
                }
            }
        }

        private void btn_Logout_InfoTab_Dev_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            this.Dispose();
        }

        private void backBtn_infoTab_Dev_Click(object sender, EventArgs e)
        {
            client_list_Dev cList = new client_list_Dev();
            cList.Show();
            this.Hide();
            this.Dispose();
        }

        private void btn_Logout_AppointmentTab_Dev_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            this.Dispose();
        }

        private void btn_Add_Project_Dev_Click(object sender, EventArgs e)
        {
            dg_ProjectsTab_Dev1.DataSource = db.GetDataView(DataDict.TBL20, null, false, "1=2");
            btn_Edit_ProjectTab_Dev.Text = "Save";
        }
    }
}
