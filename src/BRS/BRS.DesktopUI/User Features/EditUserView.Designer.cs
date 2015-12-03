namespace BRS.DesktopUI {
  partial class EditUserView {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.TbUserUsername = new System.Windows.Forms.TextBox();
            this.TbUserPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUserCreate = new System.Windows.Forms.Button();
            this.BtnUserDelete = new System.Windows.Forms.Button();
            this.BtnUserCancel = new System.Windows.Forms.Button();
            this.BtnUserList = new System.Windows.Forms.Button();
            this.TxtUserEmail = new System.Windows.Forms.Label();
            this.TbUserEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // TbUserUsername
            // 
            this.TbUserUsername.Location = new System.Drawing.Point(80, 28);
            this.TbUserUsername.Margin = new System.Windows.Forms.Padding(2);
            this.TbUserUsername.Name = "TbUserUsername";
            this.TbUserUsername.Size = new System.Drawing.Size(152, 20);
            this.TbUserUsername.TabIndex = 1;
            // 
            // TbUserPassword
            // 
            this.TbUserPassword.Location = new System.Drawing.Point(78, 102);
            this.TbUserPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TbUserPassword.Name = "TbUserPassword";
            this.TbUserPassword.Size = new System.Drawing.Size(152, 20);
            this.TbUserPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // BtnUserCreate
            // 
            this.BtnUserCreate.Location = new System.Drawing.Point(401, 323);
            this.BtnUserCreate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUserCreate.Name = "BtnUserCreate";
            this.BtnUserCreate.Size = new System.Drawing.Size(56, 19);
            this.BtnUserCreate.TabIndex = 6;
            this.BtnUserCreate.Text = "Create";
            this.BtnUserCreate.UseVisualStyleBackColor = true;
            this.BtnUserCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnUserDelete
            // 
            this.BtnUserDelete.Location = new System.Drawing.Point(340, 323);
            this.BtnUserDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUserDelete.Name = "BtnUserDelete";
            this.BtnUserDelete.Size = new System.Drawing.Size(56, 19);
            this.BtnUserDelete.TabIndex = 7;
            this.BtnUserDelete.Text = "Delete";
            this.BtnUserDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUserCancel
            // 
            this.BtnUserCancel.Location = new System.Drawing.Point(220, 323);
            this.BtnUserCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUserCancel.Name = "BtnUserCancel";
            this.BtnUserCancel.Size = new System.Drawing.Size(56, 19);
            this.BtnUserCancel.TabIndex = 8;
            this.BtnUserCancel.Text = "Cancel";
            this.BtnUserCancel.UseVisualStyleBackColor = true;
            this.BtnUserCancel.Click += new System.EventHandler(this.BtnUserCancel_Click);
            // 
            // BtnUserList
            // 
            this.BtnUserList.Location = new System.Drawing.Point(280, 322);
            this.BtnUserList.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUserList.Name = "BtnUserList";
            this.BtnUserList.Size = new System.Drawing.Size(56, 19);
            this.BtnUserList.TabIndex = 9;
            this.BtnUserList.Text = "List";
            this.BtnUserList.UseVisualStyleBackColor = true;
            this.BtnUserList.Click += new System.EventHandler(this.BtnUserList_Click);
            // 
            // TxtUserEmail
            // 
            this.TxtUserEmail.AutoSize = true;
            this.TxtUserEmail.Location = new System.Drawing.Point(18, 63);
            this.TxtUserEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtUserEmail.Name = "TxtUserEmail";
            this.TxtUserEmail.Size = new System.Drawing.Size(35, 13);
            this.TxtUserEmail.TabIndex = 10;
            this.TxtUserEmail.Text = "Email:";
            // 
            // TbUserEmail
            // 
            this.TbUserEmail.Location = new System.Drawing.Point(57, 63);
            this.TbUserEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TbUserEmail.Name = "TbUserEmail";
            this.TbUserEmail.Size = new System.Drawing.Size(152, 20);
            this.TbUserEmail.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbUserEmail);
            this.groupBox1.Controls.Add(this.TbUserUsername);
            this.groupBox1.Controls.Add(this.TxtUserEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbUserPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 224);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // EditUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(466, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnUserList);
            this.Controls.Add(this.BtnUserCancel);
            this.Controls.Add(this.BtnUserDelete);
            this.Controls.Add(this.BtnUserCreate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditUserView";
            this.Text = "EditUserView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TbUserUsername;
    private System.Windows.Forms.TextBox TbUserPassword;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button BtnUserCreate;
    private System.Windows.Forms.Button BtnUserDelete;
    private System.Windows.Forms.Button BtnUserCancel;
        private System.Windows.Forms.Button BtnUserList;
        private System.Windows.Forms.Label TxtUserEmail;
        private System.Windows.Forms.TextBox TbUserEmail;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}