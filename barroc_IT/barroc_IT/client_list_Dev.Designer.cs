namespace barroc_IT
{
    partial class client_list_Dev
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Logout_Clientlist_Dev = new System.Windows.Forms.Button();
            this.dg_Client_list_Dev1 = new System.Windows.Forms.DataGridView();
            this.btn_Add_Client_Clientlist_Dev = new System.Windows.Forms.Button();
            this.dg_Client_list_Dev2 = new System.Windows.Forms.DataGridView();
            this.backBtn_client_list_Dev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Dev1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Dev2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Logout_Clientlist_Dev
            // 
            this.btn_Logout_Clientlist_Dev.Location = new System.Drawing.Point(829, 635);
            this.btn_Logout_Clientlist_Dev.Name = "btn_Logout_Clientlist_Dev";
            this.btn_Logout_Clientlist_Dev.Size = new System.Drawing.Size(160, 30);
            this.btn_Logout_Clientlist_Dev.TabIndex = 13;
            this.btn_Logout_Clientlist_Dev.Text = "Log out";
            this.btn_Logout_Clientlist_Dev.UseVisualStyleBackColor = true;
            this.btn_Logout_Clientlist_Dev.Click += new System.EventHandler(this.btn_Logout_Clientlist_Dev_Click);
            // 
            // dg_Client_list_Dev1
            // 
            this.dg_Client_list_Dev1.AllowUserToAddRows = false;
            this.dg_Client_list_Dev1.AllowUserToDeleteRows = false;
            this.dg_Client_list_Dev1.AllowUserToResizeColumns = false;
            this.dg_Client_list_Dev1.AllowUserToResizeRows = false;
            this.dg_Client_list_Dev1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Client_list_Dev1.ColumnHeadersVisible = false;
            this.dg_Client_list_Dev1.Location = new System.Drawing.Point(17, 41);
            this.dg_Client_list_Dev1.Name = "dg_Client_list_Dev1";
            this.dg_Client_list_Dev1.RowTemplate.Height = 24;
            this.dg_Client_list_Dev1.Size = new System.Drawing.Size(478, 591);
            this.dg_Client_list_Dev1.TabIndex = 12;
            this.dg_Client_list_Dev1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Client_list_Dev1_CellClick);
            // 
            // btn_Add_Client_Clientlist_Dev
            // 
            this.btn_Add_Client_Clientlist_Dev.Location = new System.Drawing.Point(387, 11);
            this.btn_Add_Client_Clientlist_Dev.Name = "btn_Add_Client_Clientlist_Dev";
            this.btn_Add_Client_Clientlist_Dev.Size = new System.Drawing.Size(108, 24);
            this.btn_Add_Client_Clientlist_Dev.TabIndex = 11;
            this.btn_Add_Client_Clientlist_Dev.Text = "Add Client";
            this.btn_Add_Client_Clientlist_Dev.UseVisualStyleBackColor = true;
            this.btn_Add_Client_Clientlist_Dev.Click += new System.EventHandler(this.btn_Add_Client_Clientlist_Dev_Click);
            // 
            // dg_Client_list_Dev2
            // 
            this.dg_Client_list_Dev2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Client_list_Dev2.Location = new System.Drawing.Point(511, 41);
            this.dg_Client_list_Dev2.Name = "dg_Client_list_Dev2";
            this.dg_Client_list_Dev2.RowTemplate.Height = 24;
            this.dg_Client_list_Dev2.Size = new System.Drawing.Size(478, 591);
            this.dg_Client_list_Dev2.TabIndex = 14;
            // 
            // backBtn_client_list_Dev
            // 
            this.backBtn_client_list_Dev.Location = new System.Drawing.Point(17, 11);
            this.backBtn_client_list_Dev.Name = "backBtn_client_list_Dev";
            this.backBtn_client_list_Dev.Size = new System.Drawing.Size(75, 23);
            this.backBtn_client_list_Dev.TabIndex = 15;
            this.backBtn_client_list_Dev.Text = "Back";
            this.backBtn_client_list_Dev.UseVisualStyleBackColor = true;
            this.backBtn_client_list_Dev.Click += new System.EventHandler(this.backBtn_client_list_Dev_Click);
            // 
            // client_list_Dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.backBtn_client_list_Dev);
            this.Controls.Add(this.dg_Client_list_Dev2);
            this.Controls.Add(this.btn_Logout_Clientlist_Dev);
            this.Controls.Add(this.dg_Client_list_Dev1);
            this.Controls.Add(this.btn_Add_Client_Clientlist_Dev);
            this.Name = "client_list_Dev";
            this.Text = "client_list_Dev";
            this.Load += new System.EventHandler(this.client_list_Dev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Dev1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Dev2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout_Clientlist_Dev;
        private System.Windows.Forms.DataGridView dg_Client_list_Dev1;
        private System.Windows.Forms.Button btn_Add_Client_Clientlist_Dev;
        private System.Windows.Forms.DataGridView dg_Client_list_Dev2;
        private System.Windows.Forms.Button backBtn_client_list_Dev;
    }
}