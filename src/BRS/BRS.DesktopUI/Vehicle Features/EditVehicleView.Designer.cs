using System.ComponentModel;
using System.Windows.Forms;

namespace BRS.DesktopUI.VehicleFeatures
{
    partial class EditVehicleView
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
            this.GbVehicle = new System.Windows.Forms.GroupBox();
            this.TbVehicleImage = new System.Windows.Forms.TextBox();
            this.MtbVehiclePassCap = new System.Windows.Forms.MaskedTextBox();
            this.TbVehicleDescription = new System.Windows.Forms.TextBox();
            this.TbVehicleVeTy = new System.Windows.Forms.TextBox();
            this.TbVehicleName = new System.Windows.Forms.TextBox();
            this.TxtVehicleImage = new System.Windows.Forms.Label();
            this.TxtVechicleDescription = new System.Windows.Forms.Label();
            this.TxtVehicleVeTy = new System.Windows.Forms.Label();
            this.TxtVehiclePassCap = new System.Windows.Forms.Label();
            this.TxtVehicleName = new System.Windows.Forms.Label();
            this.BtnVehicleCreate = new System.Windows.Forms.Button();
            this.BtnVehicleDelete = new System.Windows.Forms.Button();
            this.BtnVehicleCancel = new System.Windows.Forms.Button();
            this.BtnVehicleList = new System.Windows.Forms.Button();
            this.GbVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbVehicle
            // 
            this.GbVehicle.Controls.Add(this.TbVehicleImage);
            this.GbVehicle.Controls.Add(this.MtbVehiclePassCap);
            this.GbVehicle.Controls.Add(this.TbVehicleDescription);
            this.GbVehicle.Controls.Add(this.TbVehicleVeTy);
            this.GbVehicle.Controls.Add(this.TbVehicleName);
            this.GbVehicle.Controls.Add(this.TxtVehicleImage);
            this.GbVehicle.Controls.Add(this.TxtVechicleDescription);
            this.GbVehicle.Controls.Add(this.TxtVehicleVeTy);
            this.GbVehicle.Controls.Add(this.TxtVehiclePassCap);
            this.GbVehicle.Controls.Add(this.TxtVehicleName);
            this.GbVehicle.Location = new System.Drawing.Point(12, 12);
            this.GbVehicle.Name = "GbVehicle";
            this.GbVehicle.Size = new System.Drawing.Size(418, 251);
            this.GbVehicle.TabIndex = 0;
            this.GbVehicle.TabStop = false;
            this.GbVehicle.Text = "Vehicle Information";
            // 
            // TbVehicleImage
            // 
            this.TbVehicleImage.Location = new System.Drawing.Point(63, 183);
            this.TbVehicleImage.Name = "TbVehicleImage";
            this.TbVehicleImage.Size = new System.Drawing.Size(100, 20);
            this.TbVehicleImage.TabIndex = 9;
            // 
            // MtbVehiclePassCap
            // 
            this.MtbVehiclePassCap.Location = new System.Drawing.Point(149, 81);
            this.MtbVehiclePassCap.Mask = "00";
            this.MtbVehiclePassCap.Name = "MtbVehiclePassCap";
            this.MtbVehiclePassCap.Size = new System.Drawing.Size(23, 20);
            this.MtbVehiclePassCap.TabIndex = 8;
            // 
            // TbVehicleDescription
            // 
            this.TbVehicleDescription.Location = new System.Drawing.Point(95, 147);
            this.TbVehicleDescription.Name = "TbVehicleDescription";
            this.TbVehicleDescription.Size = new System.Drawing.Size(100, 20);
            this.TbVehicleDescription.TabIndex = 7;
            // 
            // TbVehicleVeTy
            // 
            this.TbVehicleVeTy.Location = new System.Drawing.Point(103, 116);
            this.TbVehicleVeTy.Name = "TbVehicleVeTy";
            this.TbVehicleVeTy.Size = new System.Drawing.Size(100, 20);
            this.TbVehicleVeTy.TabIndex = 6;
            // 
            // TbVehicleName
            // 
            this.TbVehicleName.Location = new System.Drawing.Point(62, 50);
            this.TbVehicleName.Name = "TbVehicleName";
            this.TbVehicleName.Size = new System.Drawing.Size(100, 20);
            this.TbVehicleName.TabIndex = 5;
            // 
            // TxtVehicleImage
            // 
            this.TxtVehicleImage.AutoSize = true;
            this.TxtVehicleImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleImage.Location = new System.Drawing.Point(5, 183);
            this.TxtVehicleImage.Name = "TxtVehicleImage";
            this.TxtVehicleImage.Size = new System.Drawing.Size(51, 15);
            this.TxtVehicleImage.TabIndex = 4;
            this.TxtVehicleImage.Text = "Image:";
            // 
            // TxtVechicleDescription
            // 
            this.TxtVechicleDescription.AutoSize = true;
            this.TxtVechicleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVechicleDescription.Location = new System.Drawing.Point(5, 147);
            this.TxtVechicleDescription.Name = "TxtVechicleDescription";
            this.TxtVechicleDescription.Size = new System.Drawing.Size(84, 15);
            this.TxtVechicleDescription.TabIndex = 3;
            this.TxtVechicleDescription.Text = "Description:";
            // 
            // TxtVehicleVeTy
            // 
            this.TxtVehicleVeTy.AutoSize = true;
            this.TxtVehicleVeTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleVeTy.Location = new System.Drawing.Point(5, 116);
            this.TxtVehicleVeTy.Name = "TxtVehicleVeTy";
            this.TxtVehicleVeTy.Size = new System.Drawing.Size(92, 15);
            this.TxtVehicleVeTy.TabIndex = 2;
            this.TxtVehicleVeTy.Text = "Vehicle Type:";
            // 
            // TxtVehiclePassCap
            // 
            this.TxtVehiclePassCap.AutoSize = true;
            this.TxtVehiclePassCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehiclePassCap.Location = new System.Drawing.Point(5, 81);
            this.TxtVehiclePassCap.Name = "TxtVehiclePassCap";
            this.TxtVehiclePassCap.Size = new System.Drawing.Size(137, 15);
            this.TxtVehiclePassCap.TabIndex = 1;
            this.TxtVehiclePassCap.Text = "Passenger Capacity:";
            // 
            // TxtVehicleName
            // 
            this.TxtVehicleName.AutoSize = true;
            this.TxtVehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleName.Location = new System.Drawing.Point(6, 50);
            this.TxtVehicleName.Name = "TxtVehicleName";
            this.TxtVehicleName.Size = new System.Drawing.Size(49, 15);
            this.TxtVehicleName.TabIndex = 0;
            this.TxtVehicleName.Text = "Name:";
            // 
            // BtnVehicleCreate
            // 
            this.BtnVehicleCreate.Location = new System.Drawing.Point(377, 287);
            this.BtnVehicleCreate.Name = "BtnVehicleCreate";
            this.BtnVehicleCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnVehicleCreate.TabIndex = 1;
            this.BtnVehicleCreate.Text = "Create";
            this.BtnVehicleCreate.UseVisualStyleBackColor = true;
            this.BtnVehicleCreate.Click += new System.EventHandler(this.BtnVehicleCreate_Click);
            // 
            // BtnVehicleDelete
            // 
            this.BtnVehicleDelete.Location = new System.Drawing.Point(296, 287);
            this.BtnVehicleDelete.Name = "BtnVehicleDelete";
            this.BtnVehicleDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnVehicleDelete.TabIndex = 2;
            this.BtnVehicleDelete.Text = "Delete";
            this.BtnVehicleDelete.UseVisualStyleBackColor = true;
            // 
            // BtnVehicleCancel
            // 
            this.BtnVehicleCancel.Location = new System.Drawing.Point(134, 287);
            this.BtnVehicleCancel.Name = "BtnVehicleCancel";
            this.BtnVehicleCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnVehicleCancel.TabIndex = 3;
            this.BtnVehicleCancel.Text = "Cancel";
            this.BtnVehicleCancel.UseVisualStyleBackColor = true;
            this.BtnVehicleCancel.Click += new System.EventHandler(this.BtnVehicleCancel_Click);
            // 
            // BtnVehicleList
            // 
            this.BtnVehicleList.Location = new System.Drawing.Point(215, 287);
            this.BtnVehicleList.Name = "BtnVehicleList";
            this.BtnVehicleList.Size = new System.Drawing.Size(75, 23);
            this.BtnVehicleList.TabIndex = 4;
            this.BtnVehicleList.Text = "List";
            this.BtnVehicleList.UseVisualStyleBackColor = true;
            this.BtnVehicleList.Click += new System.EventHandler(this.BtnVehicleList_Click);
            // 
            // EditVehicleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.BtnVehicleList);
            this.Controls.Add(this.BtnVehicleCancel);
            this.Controls.Add(this.BtnVehicleDelete);
            this.Controls.Add(this.BtnVehicleCreate);
            this.Controls.Add(this.GbVehicle);
            this.Name = "EditVehicleView";
            this.Text = "EditVehicleView";
            this.GbVehicle.ResumeLayout(false);
            this.GbVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GbVehicle;
        private Label TxtVechicleDescription;
        private Label TxtVehicleVeTy;
        private Label TxtVehiclePassCap;
        private Label TxtVehicleName;
        private Button BtnVehicleCreate;
        private Button BtnVehicleDelete;
        private Button BtnVehicleCancel;
        private Label TxtVehicleImage;
        private MaskedTextBox MtbVehiclePassCap;
        private TextBox TbVehicleDescription;
        private TextBox TbVehicleVeTy;
        private TextBox TbVehicleName;
        private TextBox TbVehicleImage;
    }
}