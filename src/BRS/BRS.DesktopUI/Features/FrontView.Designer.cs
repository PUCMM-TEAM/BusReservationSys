using System.ComponentModel;
using System.Windows.Forms;

namespace BRS.DesktopUI {
  partial class FormFrontView {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFrontView));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinationReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DGVFrontTrips = new System.Windows.Forms.DataGridView();
            this.TxtFrontTrips = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFrontTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(377, 27);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(296, 27);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.TabIndex = 2;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userReportsToolStripMenuItem,
            this.destinationReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // userReportsToolStripMenuItem
            // 
            this.userReportsToolStripMenuItem.Name = "userReportsToolStripMenuItem";
            this.userReportsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.userReportsToolStripMenuItem.Text = "UserReports";
            this.userReportsToolStripMenuItem.Click += new System.EventHandler(this.userReportsToolStripMenuItem_Click);
            // 
            // destinationReportsToolStripMenuItem
            // 
            this.destinationReportsToolStripMenuItem.Name = "destinationReportsToolStripMenuItem";
            this.destinationReportsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.destinationReportsToolStripMenuItem.Text = "DestinationReports";
            this.destinationReportsToolStripMenuItem.Click += new System.EventHandler(this.destinationReportsToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Koala.jpg");
            this.imageList1.Images.SetKeyName(1, "Lighthouse.jpg");
            this.imageList1.Images.SetKeyName(2, "Penguins.jpg");
            // 
            // DGVFrontTrips
            // 
            this.DGVFrontTrips.AllowUserToAddRows = false;
            this.DGVFrontTrips.AllowUserToDeleteRows = false;
            this.DGVFrontTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFrontTrips.Location = new System.Drawing.Point(12, 80);
            this.DGVFrontTrips.Name = "DGVFrontTrips";
            this.DGVFrontTrips.ReadOnly = true;
            this.DGVFrontTrips.Size = new System.Drawing.Size(440, 230);
            this.DGVFrontTrips.TabIndex = 3;
            // 
            // TxtFrontTrips
            // 
            this.TxtFrontTrips.AutoSize = true;
            this.TxtFrontTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFrontTrips.Location = new System.Drawing.Point(13, 61);
            this.TxtFrontTrips.Name = "TxtFrontTrips";
            this.TxtFrontTrips.Size = new System.Drawing.Size(114, 16);
            this.TxtFrontTrips.TabIndex = 4;
            this.TxtFrontTrips.Text = "Available Trips";
            // 
            // FormFrontView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.TxtFrontTrips);
            this.Controls.Add(this.DGVFrontTrips);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFrontView";
            this.Text = "BusReservationSys";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFrontTrips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private Button BtnLogin;
        private Button BtnRegister;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem userReportsToolStripMenuItem;
        private ToolStripMenuItem destinationReportsToolStripMenuItem;
        private ListView listView1;
        private ImageList imageList1;
    }
}

