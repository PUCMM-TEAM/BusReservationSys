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
            this.TbName = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.Label();
            this.TbID = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.GbDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbDestination
            // 
            this.GbDestination.Controls.Add(this.TbID);
            this.GbDestination.Controls.Add(this.TxtID);
            this.GbDestination.Controls.Add(this.TbName);
            this.GbDestination.Controls.Add(this.TxtName);
            this.GbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDestination.Location = new System.Drawing.Point(12, 12);
            this.GbDestination.Name = "GbDestination";
            this.GbDestination.Size = new System.Drawing.Size(440, 207);
            this.GbDestination.TabIndex = 0;
            this.GbDestination.TabStop = false;
            this.GbDestination.Text = "Destination Information";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(61, 81);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(100, 26);
            this.TbName.TabIndex = 3;
            this.TbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(6, 81);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(49, 16);
            this.TxtName.TabIndex = 2;
            this.TxtName.Text = "Name";
            // 
            // TxtID
            // 
            this.TxtID.AutoSize = true;
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(6, 50);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(23, 16);
            this.TxtID.TabIndex = 4;
            this.TxtID.Text = "ID";
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(36, 50);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(100, 26);
            this.TbID.TabIndex = 5;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(215, 287);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(296, 287);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(377, 287);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // EditDestinationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.GbDestination);
            this.Name = "EditDestinationView";
            this.Text = "EditDestinationView";
            this.GbDestination.ResumeLayout(false);
            this.GbDestination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDestination;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label TxtName;
        private System.Windows.Forms.Label TxtID;
        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCreate;
    }
}