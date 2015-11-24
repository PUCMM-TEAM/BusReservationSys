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
            this.BtnSearchDestination = new System.Windows.Forms.Button();
            this.TbSearchDestination = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDestination
            // 
            this.DGVDestination.AllowUserToAddRows = false;
            this.DGVDestination.AllowUserToDeleteRows = false;
            this.DGVDestination.AllowUserToOrderColumns = true;
            this.DGVDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDestination.Location = new System.Drawing.Point(12, 49);
            this.DGVDestination.Name = "DGVDestination";
            this.DGVDestination.Size = new System.Drawing.Size(436, 261);
            this.DGVDestination.TabIndex = 0;
            // 
            // BtnSearchDestination
            // 
            this.BtnSearchDestination.Location = new System.Drawing.Point(373, 15);
            this.BtnSearchDestination.Name = "BtnSearchDestination";
            this.BtnSearchDestination.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchDestination.TabIndex = 1;
            this.BtnSearchDestination.Text = "Search";
            this.BtnSearchDestination.UseVisualStyleBackColor = true;
            // 
            // TbSearchDestination
            // 
            this.TbSearchDestination.Location = new System.Drawing.Point(12, 15);
            this.TbSearchDestination.Name = "TbSearchDestination";
            this.TbSearchDestination.Size = new System.Drawing.Size(355, 20);
            this.TbSearchDestination.TabIndex = 2;
            // 
            // DestinationListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.TbSearchDestination);
            this.Controls.Add(this.BtnSearchDestination);
            this.Controls.Add(this.DGVDestination);
            this.Name = "DestinationListView";
            this.Text = "DestinationListView";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDestination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDestination;
        private System.Windows.Forms.Button BtnSearchDestination;
        private System.Windows.Forms.TextBox TbSearchDestination;
    }
}