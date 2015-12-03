namespace BRS.DesktopUI
{
    partial class ReservationListView
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
            this.DGVReservation = new System.Windows.Forms.DataGridView();
            this.TxtReservationHere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVReservation
            // 
            this.DGVReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReservation.Location = new System.Drawing.Point(12, 41);
            this.DGVReservation.Name = "DGVReservation";
            this.DGVReservation.Size = new System.Drawing.Size(440, 269);
            this.DGVReservation.TabIndex = 0;
            // 
            // TxtReservationHere
            // 
            this.TxtReservationHere.AutoSize = true;
            this.TxtReservationHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReservationHere.Location = new System.Drawing.Point(13, 22);
            this.TxtReservationHere.Name = "TxtReservationHere";
            this.TxtReservationHere.Size = new System.Drawing.Size(193, 16);
            this.TxtReservationHere.TabIndex = 1;
            this.TxtReservationHere.Text = "Here are your reservations";
            // 
            // ReservationListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.TxtReservationHere);
            this.Controls.Add(this.DGVReservation);
            this.Name = "ReservationListView";
            this.Text = "ReservationListView";
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVReservation;
        private System.Windows.Forms.Label TxtReservationHere;
    }
}