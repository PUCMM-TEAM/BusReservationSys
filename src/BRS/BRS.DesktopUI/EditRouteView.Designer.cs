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
            this.GbRouteDetails = new System.Windows.Forms.GroupBox();
            this.PbRouteImage = new System.Windows.Forms.PictureBox();
            this.GbDescription = new System.Windows.Forms.GroupBox();
            this.TxtOrigin = new System.Windows.Forms.Label();
            this.TxtDestination = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.Label();
            this.TxtDepartureTime = new System.Windows.Forms.Label();
            this.TxtArrivalTime = new System.Windows.Forms.Label();
            this.TxtPassengerCapa = new System.Windows.Forms.Label();
            this.TxtVehicleType = new System.Windows.Forms.Label();
            this.BtnCancel3 = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TbOrigin = new System.Windows.Forms.TextBox();
            this.TbDestination = new System.Windows.Forms.TextBox();
            this.TbPassengerCapa = new System.Windows.Forms.TextBox();
            this.GbRouteDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbRouteImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GbRouteDetails
            // 
            this.GbRouteDetails.BackColor = System.Drawing.Color.LightCyan;
            this.GbRouteDetails.Controls.Add(this.TbPassengerCapa);
            this.GbRouteDetails.Controls.Add(this.TbDestination);
            this.GbRouteDetails.Controls.Add(this.TbOrigin);
            this.GbRouteDetails.Controls.Add(this.TxtVehicleType);
            this.GbRouteDetails.Controls.Add(this.TxtPassengerCapa);
            this.GbRouteDetails.Controls.Add(this.TxtArrivalTime);
            this.GbRouteDetails.Controls.Add(this.TxtDepartureTime);
            this.GbRouteDetails.Controls.Add(this.TxtDate);
            this.GbRouteDetails.Controls.Add(this.TxtDestination);
            this.GbRouteDetails.Controls.Add(this.TxtOrigin);
            this.GbRouteDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbRouteDetails.Location = new System.Drawing.Point(24, 41);
            this.GbRouteDetails.Name = "GbRouteDetails";
            this.GbRouteDetails.Size = new System.Drawing.Size(238, 316);
            this.GbRouteDetails.TabIndex = 0;
            this.GbRouteDetails.TabStop = false;
            this.GbRouteDetails.Text = "Route Details";
            // 
            // PbRouteImage
            // 
            this.PbRouteImage.Location = new System.Drawing.Point(348, 41);
            this.PbRouteImage.Name = "PbRouteImage";
            this.PbRouteImage.Size = new System.Drawing.Size(150, 141);
            this.PbRouteImage.TabIndex = 1;
            this.PbRouteImage.TabStop = false;
            // 
            // GbDescription
            // 
            this.GbDescription.BackColor = System.Drawing.Color.LightCyan;
            this.GbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDescription.Location = new System.Drawing.Point(322, 224);
            this.GbDescription.Name = "GbDescription";
            this.GbDescription.Size = new System.Drawing.Size(200, 133);
            this.GbDescription.TabIndex = 2;
            this.GbDescription.TabStop = false;
            this.GbDescription.Text = "Description";
            this.GbDescription.Enter += new System.EventHandler(this.GbDescription_Enter);
            // 
            // TxtOrigin
            // 
            this.TxtOrigin.AutoSize = true;
            this.TxtOrigin.Location = new System.Drawing.Point(7, 28);
            this.TxtOrigin.Name = "TxtOrigin";
            this.TxtOrigin.Size = new System.Drawing.Size(56, 15);
            this.TxtOrigin.TabIndex = 0;
            this.TxtOrigin.Text = "*Origin:";
            this.TxtOrigin.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtDestination
            // 
            this.TxtDestination.AutoSize = true;
            this.TxtDestination.Location = new System.Drawing.Point(7, 59);
            this.TxtDestination.Name = "TxtDestination";
            this.TxtDestination.Size = new System.Drawing.Size(90, 15);
            this.TxtDestination.TabIndex = 1;
            this.TxtDestination.Text = "*Destination:";
            // 
            // TxtDate
            // 
            this.TxtDate.AutoSize = true;
            this.TxtDate.Location = new System.Drawing.Point(7, 97);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(47, 15);
            this.TxtDate.TabIndex = 2;
            this.TxtDate.Text = "*Date:";
            // 
            // TxtDepartureTime
            // 
            this.TxtDepartureTime.AutoSize = true;
            this.TxtDepartureTime.Location = new System.Drawing.Point(7, 135);
            this.TxtDepartureTime.Name = "TxtDepartureTime";
            this.TxtDepartureTime.Size = new System.Drawing.Size(117, 15);
            this.TxtDepartureTime.TabIndex = 3;
            this.TxtDepartureTime.Text = "*Departure Time:";
            // 
            // TxtArrivalTime
            // 
            this.TxtArrivalTime.AutoSize = true;
            this.TxtArrivalTime.Location = new System.Drawing.Point(6, 173);
            this.TxtArrivalTime.Name = "TxtArrivalTime";
            this.TxtArrivalTime.Size = new System.Drawing.Size(93, 15);
            this.TxtArrivalTime.TabIndex = 4;
            this.TxtArrivalTime.Text = "*Arrival Time:";
            // 
            // TxtPassengerCapa
            // 
            this.TxtPassengerCapa.AutoSize = true;
            this.TxtPassengerCapa.Location = new System.Drawing.Point(7, 211);
            this.TxtPassengerCapa.Name = "TxtPassengerCapa";
            this.TxtPassengerCapa.Size = new System.Drawing.Size(143, 15);
            this.TxtPassengerCapa.TabIndex = 5;
            this.TxtPassengerCapa.Text = "*Passenger Capacity:";
            // 
            // TxtVehicleType
            // 
            this.TxtVehicleType.AutoSize = true;
            this.TxtVehicleType.Location = new System.Drawing.Point(7, 249);
            this.TxtVehicleType.Name = "TxtVehicleType";
            this.TxtVehicleType.Size = new System.Drawing.Size(98, 15);
            this.TxtVehicleType.TabIndex = 6;
            this.TxtVehicleType.Text = "*Vehicle Type:";
            // 
            // BtnCancel3
            // 
            this.BtnCancel3.Location = new System.Drawing.Point(322, 407);
            this.BtnCancel3.Name = "BtnCancel3";
            this.BtnCancel3.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel3.TabIndex = 3;
            this.BtnCancel3.Text = "Cancel";
            this.BtnCancel3.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(413, 407);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(504, 407);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 5;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // TbOrigin
            // 
            this.TbOrigin.Location = new System.Drawing.Point(70, 28);
            this.TbOrigin.Name = "TbOrigin";
            this.TbOrigin.Size = new System.Drawing.Size(100, 21);
            this.TbOrigin.TabIndex = 7;
            // 
            // TbDestination
            // 
            this.TbDestination.Location = new System.Drawing.Point(103, 59);
            this.TbDestination.Name = "TbDestination";
            this.TbDestination.Size = new System.Drawing.Size(100, 21);
            this.TbDestination.TabIndex = 8;
            // 
            // TbPassengerCapa
            // 
            this.TbPassengerCapa.Location = new System.Drawing.Point(157, 211);
            this.TbPassengerCapa.Name = "TbPassengerCapa";
            this.TbPassengerCapa.Size = new System.Drawing.Size(29, 21);
            this.TbPassengerCapa.TabIndex = 9;
            // 
            // EditRouteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel3);
            this.Controls.Add(this.GbDescription);
            this.Controls.Add(this.PbRouteImage);
            this.Controls.Add(this.GbRouteDetails);
            this.Name = "EditRouteView";
            this.Text = "Edit Route";
            this.GbRouteDetails.ResumeLayout(false);
            this.GbRouteDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbRouteImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbRouteDetails;
        private System.Windows.Forms.Label TxtOrigin;
        private System.Windows.Forms.PictureBox PbRouteImage;
        private System.Windows.Forms.GroupBox GbDescription;
        private System.Windows.Forms.Label TxtVehicleType;
        private System.Windows.Forms.Label TxtPassengerCapa;
        private System.Windows.Forms.Label TxtArrivalTime;
        private System.Windows.Forms.Label TxtDepartureTime;
        private System.Windows.Forms.Label TxtDate;
        private System.Windows.Forms.Label TxtDestination;
        private System.Windows.Forms.Button BtnCancel3;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox TbPassengerCapa;
        private System.Windows.Forms.TextBox TbDestination;
        private System.Windows.Forms.TextBox TbOrigin;
    }
}