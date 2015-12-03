namespace BRS.DesktopUI
{
    partial class EditDestinationView
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
            this.GbDestination = new System.Windows.Forms.GroupBox();
            this.TbDestinationName = new System.Windows.Forms.TextBox();
            this.TxtDestinationName = new System.Windows.Forms.Label();
            this.BtnDestinationCreate = new System.Windows.Forms.Button();
            this.BtnDestinationDelete = new System.Windows.Forms.Button();
            this.BtnDestinationCancel = new System.Windows.Forms.Button();
            this.BtnDestinationList = new System.Windows.Forms.Button();
            this.GbDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbDestination
            // 
            this.GbDestination.Controls.Add(this.TbDestinationName);
            this.GbDestination.Controls.Add(this.TxtDestinationName);
            this.GbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDestination.Location = new System.Drawing.Point(12, 12);
            this.GbDestination.Name = "GbDestination";
            this.GbDestination.Size = new System.Drawing.Size(440, 253);
            this.GbDestination.TabIndex = 0;
            this.GbDestination.TabStop = false;
            this.GbDestination.Text = "Destination Information";
            // 
            // TbDestinationName
            // 
            this.TbDestinationName.Location = new System.Drawing.Point(61, 41);
            this.TbDestinationName.Name = "TbDestinationName";
            this.TbDestinationName.Size = new System.Drawing.Size(100, 26);
            this.TbDestinationName.TabIndex = 3;
            // 
            // TxtDestinationName
            // 
            this.TxtDestinationName.AutoSize = true;
            this.TxtDestinationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDestinationName.Location = new System.Drawing.Point(6, 41);
            this.TxtDestinationName.Name = "TxtDestinationName";
            this.TxtDestinationName.Size = new System.Drawing.Size(49, 16);
            this.TxtDestinationName.TabIndex = 1;
            this.TxtDestinationName.Text = "Name";
            // 
            // BtnDestinationCreate
            // 
            this.BtnDestinationCreate.Location = new System.Drawing.Point(377, 287);
            this.BtnDestinationCreate.Name = "BtnDestinationCreate";
            this.BtnDestinationCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnDestinationCreate.TabIndex = 1;
            this.BtnDestinationCreate.Text = "Create";
            this.BtnDestinationCreate.UseVisualStyleBackColor = true;
            this.BtnDestinationCreate.Click += new System.EventHandler(this.BtnDestinationCreate_Click);
            // 
            // BtnDestinationDelete
            // 
            this.BtnDestinationDelete.Location = new System.Drawing.Point(296, 287);
            this.BtnDestinationDelete.Name = "BtnDestinationDelete";
            this.BtnDestinationDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDestinationDelete.TabIndex = 2;
            this.BtnDestinationDelete.Text = "Delete";
            this.BtnDestinationDelete.UseVisualStyleBackColor = true;
            // 
            // BtnDestinationCancel
            // 
            this.BtnDestinationCancel.Location = new System.Drawing.Point(134, 287);
            this.BtnDestinationCancel.Name = "BtnDestinationCancel";
            this.BtnDestinationCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnDestinationCancel.TabIndex = 3;
            this.BtnDestinationCancel.Text = "Cancel";
            this.BtnDestinationCancel.UseVisualStyleBackColor = true;
            // 
            // BtnDestinationList
            // 
            this.BtnDestinationList.Location = new System.Drawing.Point(215, 287);
            this.BtnDestinationList.Name = "BtnDestinationList";
            this.BtnDestinationList.Size = new System.Drawing.Size(75, 23);
            this.BtnDestinationList.TabIndex = 4;
            this.BtnDestinationList.Text = "List";
            this.BtnDestinationList.UseVisualStyleBackColor = true;
            this.BtnDestinationList.Click += new System.EventHandler(this.BtnDestinationList_Click);
            // 
            // EditDestinationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.BtnDestinationList);
            this.Controls.Add(this.BtnDestinationCancel);
            this.Controls.Add(this.BtnDestinationDelete);
            this.Controls.Add(this.BtnDestinationCreate);
            this.Controls.Add(this.GbDestination);
            this.Name = "EditDestinationView";
            this.Text = "EditDestinationView";
            this.GbDestination.ResumeLayout(false);
            this.GbDestination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDestination;
        private System.Windows.Forms.TextBox TbDestinationName;
        private System.Windows.Forms.Label TxtDestinationName;
        private System.Windows.Forms.Button BtnDestinationCreate;
        private System.Windows.Forms.Button BtnDestinationDelete;
        private System.Windows.Forms.Button BtnDestinationCancel;
        private System.Windows.Forms.Button BtnDestinationList;
    }
}