namespace BRS.DesktopUI
{
    partial class EditRouteView
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
            this.GbRoute = new System.Windows.Forms.GroupBox();
            this.TbRouteDropOff = new System.Windows.Forms.TextBox();
            this.TbRoutePickup = new System.Windows.Forms.TextBox();
            this.TxtRouteDropoff = new System.Windows.Forms.Label();
            this.TxtRoutePickup = new System.Windows.Forms.Label();
            this.BtnRouteCreate = new System.Windows.Forms.Button();
            this.BtnRouteDelete = new System.Windows.Forms.Button();
            this.BtnRouteCancel = new System.Windows.Forms.Button();
            this.GbRoute.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbRoute
            // 
            this.GbRoute.Controls.Add(this.TbRouteDropOff);
            this.GbRoute.Controls.Add(this.TbRoutePickup);
            this.GbRoute.Controls.Add(this.TxtRouteDropoff);
            this.GbRoute.Controls.Add(this.TxtRoutePickup);
            this.GbRoute.Location = new System.Drawing.Point(12, 12);
            this.GbRoute.Name = "GbRoute";
            this.GbRoute.Size = new System.Drawing.Size(440, 251);
            this.GbRoute.TabIndex = 0;
            this.GbRoute.TabStop = false;
            this.GbRoute.Text = "Routes ";
            // 
            // TbRouteDropOff
            // 
            this.TbRouteDropOff.Location = new System.Drawing.Point(61, 63);
            this.TbRouteDropOff.Name = "TbRouteDropOff";
            this.TbRouteDropOff.Size = new System.Drawing.Size(100, 20);
            this.TbRouteDropOff.TabIndex = 3;
            // 
            // TbRoutePickup
            // 
            this.TbRoutePickup.Location = new System.Drawing.Point(49, 32);
            this.TbRoutePickup.Name = "TbRoutePickup";
            this.TbRoutePickup.Size = new System.Drawing.Size(100, 20);
            this.TbRoutePickup.TabIndex = 2;
            // 
            // TxtRouteDropoff
            // 
            this.TxtRouteDropoff.AutoSize = true;
            this.TxtRouteDropoff.Location = new System.Drawing.Point(7, 63);
            this.TxtRouteDropoff.Name = "TxtRouteDropoff";
            this.TxtRouteDropoff.Size = new System.Drawing.Size(48, 13);
            this.TxtRouteDropoff.TabIndex = 1;
            this.TxtRouteDropoff.Text = "Drop off:";
            // 
            // TxtRoutePickup
            // 
            this.TxtRoutePickup.AutoSize = true;
            this.TxtRoutePickup.Location = new System.Drawing.Point(7, 32);
            this.TxtRoutePickup.Name = "TxtRoutePickup";
            this.TxtRoutePickup.Size = new System.Drawing.Size(43, 13);
            this.TxtRoutePickup.TabIndex = 0;
            this.TxtRoutePickup.Text = "Pickup:";
            // 
            // BtnRouteCreate
            // 
            this.BtnRouteCreate.Location = new System.Drawing.Point(377, 287);
            this.BtnRouteCreate.Name = "BtnRouteCreate";
            this.BtnRouteCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnRouteCreate.TabIndex = 1;
            this.BtnRouteCreate.Text = "Create";
            this.BtnRouteCreate.UseVisualStyleBackColor = true;
            this.BtnRouteCreate.Click += new System.EventHandler(this.BtnRouteCreate_Click);
            // 
            // BtnRouteDelete
            // 
            this.BtnRouteDelete.Location = new System.Drawing.Point(296, 287);
            this.BtnRouteDelete.Name = "BtnRouteDelete";
            this.BtnRouteDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnRouteDelete.TabIndex = 2;
            this.BtnRouteDelete.Text = "Delete";
            this.BtnRouteDelete.UseVisualStyleBackColor = true;
            // 
            // BtnRouteCancel
            // 
            this.BtnRouteCancel.Location = new System.Drawing.Point(215, 287);
            this.BtnRouteCancel.Name = "BtnRouteCancel";
            this.BtnRouteCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnRouteCancel.TabIndex = 3;
            this.BtnRouteCancel.Text = "Cancel";
            this.BtnRouteCancel.UseVisualStyleBackColor = true;
            this.BtnRouteCancel.Click += new System.EventHandler(this.BtnRouteCancel_Click);
            // 
            // EditRouteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.BtnRouteCancel);
            this.Controls.Add(this.BtnRouteDelete);
            this.Controls.Add(this.BtnRouteCreate);
            this.Controls.Add(this.GbRoute);
            this.Name = "EditRouteView";
            this.Text = "EditRouteView";
            this.GbRoute.ResumeLayout(false);
            this.GbRoute.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbRoute;
        private System.Windows.Forms.TextBox TbRouteDropOff;
        private System.Windows.Forms.TextBox TbRoutePickup;
        private System.Windows.Forms.Label TxtRouteDropoff;
        private System.Windows.Forms.Label TxtRoutePickup;
        private System.Windows.Forms.Button BtnRouteCreate;
        private System.Windows.Forms.Button BtnRouteDelete;
        private System.Windows.Forms.Button BtnRouteCancel;
    }
}