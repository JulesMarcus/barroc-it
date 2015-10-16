namespace barroc_IT
{
    partial class client_list_Sales
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
            this.dg_Client_list_Sales2 = new System.Windows.Forms.DataGridView();
            this.btn_Logout_Clientlist_Sales = new System.Windows.Forms.Button();
            this.dg_Client_list_Sales1 = new System.Windows.Forms.DataGridView();
            this.btn_Add_Client_Clientlist_Sales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Sales2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Sales1)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Client_list_Sales2
            // 
            this.dg_Client_list_Sales2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Client_list_Sales2.Location = new System.Drawing.Point(514, 38);
            this.dg_Client_list_Sales2.Name = "dg_Client_list_Sales2";
            this.dg_Client_list_Sales2.RowTemplate.Height = 24;
            this.dg_Client_list_Sales2.Size = new System.Drawing.Size(478, 591);
            this.dg_Client_list_Sales2.TabIndex = 15;
            // 
            // btn_Logout_Clientlist_Sales
            // 
            this.btn_Logout_Clientlist_Sales.Location = new System.Drawing.Point(826, 635);
            this.btn_Logout_Clientlist_Sales.Name = "btn_Logout_Clientlist_Sales";
            this.btn_Logout_Clientlist_Sales.Size = new System.Drawing.Size(160, 30);
            this.btn_Logout_Clientlist_Sales.TabIndex = 14;
            this.btn_Logout_Clientlist_Sales.Text = "Log out";
            this.btn_Logout_Clientlist_Sales.UseVisualStyleBackColor = true;
            // 
            // dg_Client_list_Sales1
            // 
            this.dg_Client_list_Sales1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Client_list_Sales1.Location = new System.Drawing.Point(14, 38);
            this.dg_Client_list_Sales1.Name = "dg_Client_list_Sales1";
            this.dg_Client_list_Sales1.RowTemplate.Height = 24;
            this.dg_Client_list_Sales1.Size = new System.Drawing.Size(478, 591);
            this.dg_Client_list_Sales1.TabIndex = 13;
            // 
            // btn_Add_Client_Clientlist_Sales
            // 
            this.btn_Add_Client_Clientlist_Sales.Location = new System.Drawing.Point(14, 8);
            this.btn_Add_Client_Clientlist_Sales.Name = "btn_Add_Client_Clientlist_Sales";
            this.btn_Add_Client_Clientlist_Sales.Size = new System.Drawing.Size(108, 24);
            this.btn_Add_Client_Clientlist_Sales.TabIndex = 12;
            this.btn_Add_Client_Clientlist_Sales.Text = "Add Client";
            this.btn_Add_Client_Clientlist_Sales.UseVisualStyleBackColor = true;
            // 
            // client_list_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.dg_Client_list_Sales2);
            this.Controls.Add(this.btn_Logout_Clientlist_Sales);
            this.Controls.Add(this.dg_Client_list_Sales1);
            this.Controls.Add(this.btn_Add_Client_Clientlist_Sales);
            this.Name = "client_list_Sales";
            this.Text = "client_list_Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Sales2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Sales1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Client_list_Sales2;
        private System.Windows.Forms.Button btn_Logout_Clientlist_Sales;
        private System.Windows.Forms.DataGridView dg_Client_list_Sales1;
        private System.Windows.Forms.Button btn_Add_Client_Clientlist_Sales;
    }
}