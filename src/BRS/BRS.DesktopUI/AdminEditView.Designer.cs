namespace BRS.DesktopUI
{
    partial class AdminEditView
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
            this.BtnAdminUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAdminDestination = new System.Windows.Forms.Button();
            this.BtnAdminRoute = new System.Windows.Forms.Button();
            this.BtnAdminTrip = new System.Windows.Forms.Button();
            this.BtnAdminReservationList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdminUser
            // 
            this.BtnAdminUser.Location = new System.Drawing.Point(55, 44);
            this.BtnAdminUser.Name = "BtnAdminUser";
            this.BtnAdminUser.Size = new System.Drawing.Size(75, 23);
            this.BtnAdminUser.TabIndex = 0;
            this.BtnAdminUser.Text = "UserForm";
            this.BtnAdminUser.UseVisualStyleBackColor = true;
            this.BtnAdminUser.Click += new System.EventHandler(this.BtnAdminUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAdminReservationList);
            this.groupBox1.Controls.Add(this.BtnAdminDestination);
            this.groupBox1.Controls.Add(this.BtnAdminRoute);
            this.groupBox1.Controls.Add(this.BtnAdminTrip);
            this.groupBox1.Controls.Add(this.BtnAdminUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrator Options";
            // 
            // BtnAdminDestination
            // 
            this.BtnAdminDestination.Location = new System.Drawing.Point(299, 167);
            this.BtnAdminDestination.Name = "BtnAdminDestination";
            this.BtnAdminDestination.Size = new System.Drawing.Size(75, 23);
            this.BtnAdminDestination.TabIndex = 3;
            this.BtnAdminDestination.Text = "DestinationForm";
            this.BtnAdminDestination.UseVisualStyleBackColor = true;
            this.BtnAdminDestination.Click += new System.EventHandler(this.BtnAdminDestination_Click);
            // 
            // BtnAdminRoute
            // 
            this.BtnAdminRoute.Location = new System.Drawing.Point(55, 167);
            this.BtnAdminRoute.Name = "BtnAdminRoute";
            this.BtnAdminRoute.Size = new System.Drawing.Size(75, 23);
            this.BtnAdminRoute.TabIndex = 2;
            this.BtnAdminRoute.Text = "RouteForm";
            this.BtnAdminRoute.UseVisualStyleBackColor = true;
            this.BtnAdminRoute.Click += new System.EventHandler(this.BtnAdminRoute_Click);
            // 
            // BtnAdminTrip
            // 
            this.BtnAdminTrip.Location = new System.Drawing.Point(299, 44);
            this.BtnAdminTrip.Name = "BtnAdminTrip";
            this.BtnAdminTrip.Size = new System.Drawing.Size(75, 23);
            this.BtnAdminTrip.TabIndex = 1;
            this.BtnAdminTrip.Text = "TripForm";
            this.BtnAdminTrip.UseVisualStyleBackColor = true;
            this.BtnAdminTrip.Click += new System.EventHandler(this.BtnAdminTrip_Click);
            // 
            // BtnAdminReservationList
            // 
            this.BtnAdminReservationList.Location = new System.Drawing.Point(156, 104);
            this.BtnAdminReservationList.Name = "BtnAdminReservationList";
            this.BtnAdminReservationList.Size = new System.Drawing.Size(121, 23);
            this.BtnAdminReservationList.TabIndex = 4;
            this.BtnAdminReservationList.Text = "Reservation List";
            this.BtnAdminReservationList.UseVisualStyleBackColor = true;
            this.BtnAdminReservationList.Click += new System.EventHandler(this.BtnAdminReservationList_Click);
            // 
            // AdminEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminEditView";
            this.Text = "AdminEditView";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdminUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAdminDestination;
        private System.Windows.Forms.Button BtnAdminRoute;
        private System.Windows.Forms.Button BtnAdminTrip;
        private System.Windows.Forms.Button BtnAdminReservationList;
    }
}