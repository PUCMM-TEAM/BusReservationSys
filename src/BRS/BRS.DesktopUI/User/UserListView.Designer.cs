namespace BRS.DesktopUI
{
    partial class UserListView
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
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.BtnUserSearch = new System.Windows.Forms.Button();
            this.TxtUserSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVUsers
            // 
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.Location = new System.Drawing.Point(12, 40);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.Size = new System.Drawing.Size(440, 270);
            this.DGVUsers.TabIndex = 0;
            this.DGVUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnUserSearch
            // 
            this.BtnUserSearch.Location = new System.Drawing.Point(376, 11);
            this.BtnUserSearch.Name = "BtnUserSearch";
            this.BtnUserSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnUserSearch.TabIndex = 1;
            this.BtnUserSearch.Text = "Search";
            this.BtnUserSearch.UseVisualStyleBackColor = true;
            // 
            // TxtUserSearch
            // 
            this.TxtUserSearch.Location = new System.Drawing.Point(12, 11);
            this.TxtUserSearch.Name = "TxtUserSearch";
            this.TxtUserSearch.Size = new System.Drawing.Size(358, 20);
            this.TxtUserSearch.TabIndex = 2;
            // 
            // UserListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.TxtUserSearch);
            this.Controls.Add(this.BtnUserSearch);
            this.Controls.Add(this.DGVUsers);
            this.Name = "UserListView";
            this.Text = "UserListView";
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.Button BtnUserSearch;
        private System.Windows.Forms.TextBox TxtUserSearch;
    }
}