namespace BRS.DesktopUI
{
    partial class VehicleListView
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
            this.DGVVehicle = new System.Windows.Forms.DataGridView();
            this.BtnVehicleSearch = new System.Windows.Forms.Button();
            this.TbVehicleSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVVehicle
            // 
            this.DGVVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVehicle.Location = new System.Drawing.Point(12, 43);
            this.DGVVehicle.Name = "DGVVehicle";
            this.DGVVehicle.Size = new System.Drawing.Size(440, 267);
            this.DGVVehicle.TabIndex = 0;
            // 
            // BtnVehicleSearch
            // 
            this.BtnVehicleSearch.Location = new System.Drawing.Point(376, 14);
            this.BtnVehicleSearch.Name = "BtnVehicleSearch";
            this.BtnVehicleSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnVehicleSearch.TabIndex = 1;
            this.BtnVehicleSearch.Text = "Search";
            this.BtnVehicleSearch.UseVisualStyleBackColor = true;
            // 
            // TbVehicleSearch
            // 
            this.TbVehicleSearch.Location = new System.Drawing.Point(12, 14);
            this.TbVehicleSearch.Name = "TbVehicleSearch";
            this.TbVehicleSearch.Size = new System.Drawing.Size(358, 20);
            this.TbVehicleSearch.TabIndex = 2;
            // 
            // VehicleListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.TbVehicleSearch);
            this.Controls.Add(this.BtnVehicleSearch);
            this.Controls.Add(this.DGVVehicle);
            this.Name = "VehicleListView";
            this.Text = "VehicleListView";
            ((System.ComponentModel.ISupportInitialize)(this.DGVVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVVehicle;
        private System.Windows.Forms.Button BtnVehicleSearch;
        private System.Windows.Forms.TextBox TbVehicleSearch;
    }
}