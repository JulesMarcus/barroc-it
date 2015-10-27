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
        private void Dev_Load(object sender, EventArgs e)
        {
             
        }
        public void load_info_from_Cell(string query)
        {
            dg_Infotab_Dev1.DataSource = db.GetDataView(query);
            btn_edit_Infotab_Dev.Text = "Edit";
        }
        public void load_info_Add()
        {
            btn_edit_Infotab_Dev.Text = "Save";
        }
        private void load_edittable_Info()
        {
            comName_txt.Text = dg_Infotab_Dev1.Rows[1].Cells["column2"].Value.ToString();
            addr1_txt.Text = dg_Infotab_Dev1.Rows[2].Cells["column2"].Value.ToString();
            zip1_txt.Text = dg_Infotab_Dev1.Rows[3].Cells["column2"].Value.ToString();
            city1_txt.Text = dg_Infotab_Dev1.Rows[4].Cells["column2"].Value.ToString();
            addr2_txt.Text = dg_Infotab_Dev1.Rows[5].Cells["column2"].Value.ToString();
            zip2_txt.Text = dg_Infotab_Dev1.Rows[6].Cells["column2"].Value.ToString();
            city2_txt.Text = dg_Infotab_Dev1.Rows[7].Cells["column2"].Value.ToString();
            conPerson_txt.Text = dg_Infotab_Dev1.Rows[8].Cells["column2"].Value.ToString();
            initials_txt.Text = dg_Infotab_Dev1.Rows[9].Cells["column2"].Value.ToString();
            phoneNum1_txt.Text = dg_Infotab_Dev1.Rows[10].Cells["column2"].Value.ToString();
            phoneNum2_txt.Text = dg_Infotab_Dev1.Rows[11].Cells["column2"].Value.ToString();
            faxNum_txt.Text = dg_Infotab_Dev1.Rows[12].Cells["column2"].Value.ToString();
            email_txt.Text = dg_Infotab_Dev1.Rows[13].Cells["column2"].Value.ToString();
            creditor_txt.Text = dg_Infotab_Dev1.Rows[14].Cells["column2"].Value.ToString();
            bankAcc_txt.Text = dg_Infotab_Dev1.Rows[15].Cells["column2"].Value.ToString();
            creditBal_txt.Text = dg_Infotab_Dev1.Rows[16].Cells["column2"].Value.ToString();
            numOfInvoices_txt.Text = dg_Infotab_Dev1.Rows[17].Cells["column2"].Value.ToString();
            grossRev_txt.Text = dg_Infotab_Dev1.Rows[18].Cells["column2"].Value.ToString();
            ledgerAcc_txt.Text = dg_Infotab_Dev1.Rows[19].Cells["column2"].Value.ToString();
            taxCode_txt.Text = dg_Infotab_Dev1.Rows[20].Cells["column2"].Value.ToString();
            if (dg_Infotab_Dev1.Rows[21].Cells["column2"].Value.ToString() == "True")
            {
                potClient_yes_checkbox.Checked = true;
            }
            //dtp_Dev.Value = dg_Infotab_Dev1.Rows[21].Cells["column2"].Value;
        }

        private void btn_edit_Infotab_Dev_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
           
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
                    dic.Add("company_Name", comName_txt.Text);
                    dic.Add("address1", addr1_txt.Text);
                    dic.Add("zipcode1", zip1_txt.Text);
                    dic.Add("city1", city1_txt.Text);
                    dic.Add("address2", addr2_txt.Text);
                    dic.Add("zipcode2", zip2_txt.Text);
                    dic.Add("city2", city2_txt.Text);
                    dic.Add("contact_Person", conPerson_txt.Text);
                    dic.Add("intials", initials_txt.Text);
                    dic.Add("phone_Num1", phoneNum1_txt.Text);
                    dic.Add("phone_Num2", phoneNum2_txt.Text);
                    dic.Add("fax_Num", faxNum_txt.Text);
                    dic.Add("email", email_txt.Text);
                    dic.Add("creditor", creditor_txt.Text);
                    dic.Add("bank_acc_Num", bankAcc_txt.Text);
                    dic.Add("credit_Balance", creditBal_txt.Text);
                    dic.Add("num_of_Invoices", numOfInvoices_txt.Text);
                    dic.Add("gross_revenue", grossRev_txt.Text);
                    dic.Add("ledger_acc_Num", ledgerAcc_txt.Text);
                    dic.Add("tax_Code", taxCode_txt.Text);
                    dic.Add("potential_Client", "" + potClient_yes_checkbox.Checked + "");
                    dic.Add("last_contact_Date", "" + dtp_Dev.Value.ToString("yyyy-MM-dd") + "");
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
                    dg_Infotab_Dev1.DataSource = db.GetDataView("SELECT * FROM tbl_customers");
                }
            }
        }
    }
}
