namespace BRS.DesktopUI
{
    partial class DestinationListView
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
            this.DGVDestination = new System.Windows.Forms.DataGridView();
            this.BtnDestinationSearch = new System.Windows.Forms.Button();
            this.TbDestinationSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDestination
            // 
            this.DGVDestination.AllowUserToAddRows = false;
            this.DGVDestination.AllowUserToDeleteRows = false;
            this.DGVDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDestination.Location = new System.Drawing.Point(12, 37);
            this.DGVDestination.Name = "DGVDestination";
            this.DGVDestination.ReadOnly = true;
            this.DGVDestination.Size = new System.Drawing.Size(440, 273);
            this.DGVDestination.TabIndex = 0;
            this.DGVDestination.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnDestinationSearch
            // 
            this.BtnDestinationSearch.Location = new System.Drawing.Point(377, 8);
            this.BtnDestinationSearch.Name = "BtnDestinationSearch";
            this.BtnDestinationSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnDestinationSearch.TabIndex = 1;
            this.BtnDestinationSearch.Text = "Search";
            this.BtnDestinationSearch.UseVisualStyleBackColor = true;
            // 
            // TbDestinationSearch
            // 
            this.TbDestinationSearch.Location = new System.Drawing.Point(12, 8);
            this.TbDestinationSearch.Name = "TbDestinationSearch";
            this.TbDestinationSearch.Size = new System.Drawing.Size(359, 20);
            this.TbDestinationSearch.TabIndex = 2;
            // 
            // DestinationListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.TbDestinationSearch);
            this.Controls.Add(this.BtnDestinationSearch);
            this.Controls.Add(this.DGVDestination);
            this.Name = "DestinationListView";
            this.Text = "DestinationListView";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDestination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDestination;
        private System.Windows.Forms.Button BtnDestinationSearch;
        private System.Windows.Forms.TextBox TbDestinationSearch;
    }
}