using System.ComponentModel;
using System.Windows.Forms;

namespace BRS.DesktopUI
{
    partial class EditRouteView
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
            this.GbRoute = new System.Windows.Forms.GroupBox();
            this.CbRouteDropoff = new System.Windows.Forms.ComboBox();
            this.CbRoutePickup = new System.Windows.Forms.ComboBox();
            this.TxtRouteDropoff = new System.Windows.Forms.Label();
            this.TxtRoutePickup = new System.Windows.Forms.Label();
            this.BtnRouteCreate = new System.Windows.Forms.Button();
            this.BtnRouteDelete = new System.Windows.Forms.Button();
            this.BtnRouteCancel = new System.Windows.Forms.Button();
            this.BtnRouteList = new System.Windows.Forms.Button();
            this.GbRoute.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbRoute
            // 
            this.GbRoute.Controls.Add(this.CbRouteDropoff);
            this.GbRoute.Controls.Add(this.CbRoutePickup);
            this.GbRoute.Controls.Add(this.TxtRouteDropoff);
            this.GbRoute.Controls.Add(this.TxtRoutePickup);
            this.GbRoute.Location = new System.Drawing.Point(12, 12);
            this.GbRoute.Name = "GbRoute";
            this.GbRoute.Size = new System.Drawing.Size(440, 251);
            this.GbRoute.TabIndex = 0;
            this.GbRoute.TabStop = false;
            this.GbRoute.Text = "Routes ";
            // 
            // CbRouteDropoff
            // 
            this.CbRouteDropoff.FormattingEnabled = true;
            this.CbRouteDropoff.Location = new System.Drawing.Point(61, 63);
            this.CbRouteDropoff.Name = "CbRouteDropoff";
            this.CbRouteDropoff.Size = new System.Drawing.Size(121, 21);
            this.CbRouteDropoff.TabIndex = 5;
            this.CbRouteDropoff.SelectedIndexChanged += new System.EventHandler(this.CbRouteDropoff_SelectedIndexChanged);
            // 
            // CbRoutePickup
            // 
            this.CbRoutePickup.FormattingEnabled = true;
            this.CbRoutePickup.Location = new System.Drawing.Point(56, 32);
            this.CbRoutePickup.Name = "CbRoutePickup";
            this.CbRoutePickup.Size = new System.Drawing.Size(121, 21);
            this.CbRoutePickup.TabIndex = 4;
            this.CbRoutePickup.SelectedIndexChanged += new System.EventHandler(this.CbRoutePickup_SelectedIndexChanged);
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
            this.BtnRouteCancel.Location = new System.Drawing.Point(134, 287);
            this.BtnRouteCancel.Name = "BtnRouteCancel";
            this.BtnRouteCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnRouteCancel.TabIndex = 3;
            this.BtnRouteCancel.Text = "Cancel";
            this.BtnRouteCancel.UseVisualStyleBackColor = true;
            this.BtnRouteCancel.Click += new System.EventHandler(this.BtnRouteCancel_Click);
            // 
            // BtnRouteList
            // 
            this.BtnRouteList.Location = new System.Drawing.Point(215, 287);
            this.BtnRouteList.Name = "BtnRouteList";
            this.BtnRouteList.Size = new System.Drawing.Size(75, 23);
            this.BtnRouteList.TabIndex = 4;
            this.BtnRouteList.Text = "List";
            this.BtnRouteList.UseVisualStyleBackColor = true;
            this.BtnRouteList.Click += new System.EventHandler(this.BtnRouteList_Click);
            // 
            // EditRouteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.BtnRouteList);
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

        private GroupBox GbRoute;
        private Label TxtRouteDropoff;
        private Label TxtRoutePickup;
        private Button BtnRouteCreate;
        private Button BtnRouteDelete;
        private Button BtnRouteCancel;
        private ComboBox CbRouteDropoff;
        private ComboBox CbRoutePickup;
    }
}