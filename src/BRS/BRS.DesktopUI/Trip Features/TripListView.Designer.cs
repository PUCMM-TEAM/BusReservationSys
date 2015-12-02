using System.ComponentModel;
using System.Windows.Forms;

namespace BRS.DesktopUI
{
    partial class TripListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.DGVTrip = new System.Windows.Forms.DataGridView();
            this.BtnTripSearch = new System.Windows.Forms.Button();
            this.TbTripSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTrip)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTrip
            // 
            this.DGVTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTrip.Location = new System.Drawing.Point(12, 30);
            this.DGVTrip.Name = "DGVTrip";
            this.DGVTrip.Size = new System.Drawing.Size(440, 280);
            this.DGVTrip.TabIndex = 0;
            // 
            // BtnTripSearch
            // 
            this.BtnTripSearch.Location = new System.Drawing.Point(376, 4);
            this.BtnTripSearch.Name = "BtnTripSearch";
            this.BtnTripSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnTripSearch.TabIndex = 1;
            this.BtnTripSearch.Text = "Search";
            this.BtnTripSearch.UseVisualStyleBackColor = true;
            // 
            // TbTripSearch
            // 
            this.TbTripSearch.Location = new System.Drawing.Point(12, 4);
            this.TbTripSearch.Name = "TbTripSearch";
            this.TbTripSearch.Size = new System.Drawing.Size(358, 20);
            this.TbTripSearch.TabIndex = 2;
            // 
            // TripListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.TbTripSearch);
            this.Controls.Add(this.BtnTripSearch);
            this.Controls.Add(this.DGVTrip);
            this.Name = "TripListView";
            this.Text = "TripListView";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DGVTrip;
        private Button BtnTripSearch;
        private TextBox TbTripSearch;
    }
}