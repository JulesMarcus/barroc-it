﻿using System;
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
        DatabaseHandler db = new DatabaseHandler();
        DataGridViewHelper dgvHelp = new DataGridViewHelper();
        public finance(string customerID)
        {
            InitializeComponent();
        }
        public finance()
        {
            InitializeComponent();
            dg_InfoTab_Finance1.Enabled = true;
            btn_edit_Infotab_Finance.Text = "Save";
        }
        public void load_info_from_Cell(string iQuery, string pQuery)
        {
            dg_InfoTab_Finance1.DataSource = db.GetDataView(iQuery);
            dg_ProjectsTab_Finance1.DataSource = db.GetDataView(pQuery);
            btn_edit_Infotab_Finance.Text = "Edit";
        }
        public void load_info_Add()
        {
            btn_edit_Infotab_Finance.Text = "Save";
            dg_InfoTab_Finance1.DataSource = db.GetDataView("SELECT * FROM tbl_customers WHERE 1=2");
        }
        private void load_edittable_Info()
        {
            dgvHelp.LoadInfo(info_tab, 20, dg_InfoTab_Finance1);

            if (dg_InfoTab_Finance1.Rows[21].Cells["column2"].Value.ToString() == "True")
            {
                potClient_yes_checkbox.Checked = true;
            }
        }

        private void btn_edit_Infotab_Finance_Click(object sender, EventArgs e)
        {
            if (btn_edit_Infotab_Finance.Text == "Edit")
            {
                load_edittable_Info();
                btn_edit_Infotab_Finance.Text = "Save";
                dg_InfoTab_Finance1.ForeColor = Color.Gray;
                dg_InfoTab_Finance1.Enabled = true;
            }
            else if (btn_edit_Infotab_Finance.Text == "Save")
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
                                dic.Add(dg_InfoTab_Finance1.Rows[b].Cells["column1"].Value.ToString(), c.Name = "infoTabText" + b.ToString());
                                b++;
                                if (c.Name == "infoTabText20")
                                {
                                    i = 100;
                                    dic.Add("potential_Client", "" + potClient_yes_checkbox.Checked + "");
                                    dic.Add("last_contact_Date", "" + dtp_Fin.Value.ToString("yyyy-MM-dd") + "");
                                    break;
                                }
                            }
                        }
                    }
                    if (dg_InfoTab_Finance1.Columns.Count == 2)
                    {
                        db.updateCmd("tbl_customers", dic);
                    }
                    else if (dg_InfoTab_Finance1.Columns.Count < 2)
                    {
                        db.insertCmd("tbl_customers", dic);
                    }
                    btn_edit_Infotab_Finance.Text = "Edit";
                    dg_InfoTab_Finance1.Enabled = true;
                    dg_InfoTab_Finance1.DataSource = db.GetDataView("SELECT * FROM tbl_customers WHERE company_Name = " + infoTabText1.Text);
                }
            }
        }
        private void btn_Logout_InfoTab_Finance_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            this.Dispose();
        }

        private void backBtn_infoTab_Fin_Click(object sender, EventArgs e)
        {
            client_list_Finance cList = new client_list_Finance();
            cList.Show();
            this.Hide();
            this.Dispose();
        }

        private void btn_Add_Project_Finance_Click(object sender, EventArgs e)
        {
            dg_ProjectsTab_Finance1.DataSource = db.GetDataView("SELECT * FROM tbl_projects WHERE 1=2");
            btn_Edit_ProjectTab_Finance.Text = "Save";
        }
        
    }
}
