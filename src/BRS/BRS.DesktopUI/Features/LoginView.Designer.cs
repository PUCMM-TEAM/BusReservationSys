namespace BRS.DesktopUI
{
    partial class LoginView
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
            this.GbLogin = new System.Windows.Forms.GroupBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.BtnLogin2 = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.Label();
            this.GbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbLogin
            // 
            this.GbLogin.BackColor = System.Drawing.Color.LightCyan;
            this.GbLogin.Controls.Add(this.TbPassword);
            this.GbLogin.Controls.Add(this.TbUsername);
            this.GbLogin.Controls.Add(this.BtnLogin2);
            this.GbLogin.Controls.Add(this.BtnCancel);
            this.GbLogin.Controls.Add(this.TxtPassword);
            this.GbLogin.Controls.Add(this.TxtUsername);
            this.GbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbLogin.Location = new System.Drawing.Point(12, 13);
            this.GbLogin.Name = "GbLogin";
            this.GbLogin.Size = new System.Drawing.Size(280, 177);
            this.GbLogin.TabIndex = 0;
            this.GbLogin.TabStop = false;
            this.GbLogin.Text = "Login";
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(92, 65);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(152, 22);
            this.TbPassword.TabIndex = 13;
            this.TbPassword.UseSystemPasswordChar = true;
            // 
            // TbUsername
            // 
            this.TbUsername.Location = new System.Drawing.Point(92, 28);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(152, 22);
            this.TbUsername.TabIndex = 12;
            // 
            // BtnLogin2
            // 
            this.BtnLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin2.Location = new System.Drawing.Point(199, 140);
            this.BtnLogin2.Name = "BtnLogin2";
            this.BtnLogin2.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin2.TabIndex = 11;
            this.BtnLogin2.Text = "Login";
            this.BtnLogin2.UseVisualStyleBackColor = true;
            this.BtnLogin2.Click += new System.EventHandler(this.BtnLogin2_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(6, 140);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.AutoSize = true;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(6, 65);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(80, 16);
            this.TxtPassword.TabIndex = 7;
            this.TxtPassword.Text = "Password:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.AutoSize = true;
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(6, 28);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(83, 16);
            this.TxtUsername.TabIndex = 6;
            this.TxtUsername.Text = "Username:";
            this.TxtUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(304, 202);
            this.Controls.Add(this.GbLogin);
            this.Name = "LoginView";
            this.Text = "Login";
            this.GbLogin.ResumeLayout(false);
            this.GbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbLogin;
        private System.Windows.Forms.Button BtnLogin2;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label TxtPassword;
        private System.Windows.Forms.Label TxtUsername;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbUsername;
    }
}