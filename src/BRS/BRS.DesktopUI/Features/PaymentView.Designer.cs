namespace BRS.DesktopUI {
  partial class PaymentView {
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
            this.ChPaymentAgree = new System.Windows.Forms.CheckBox();
            this.BtnPaymentPay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbPaymentPrice = new System.Windows.Forms.TextBox();
            this.TxtPaymentPrice = new System.Windows.Forms.Label();
            this.TbPaymentaArrivalTime = new System.Windows.Forms.TextBox();
            this.TbPaymentDepartureTime = new System.Windows.Forms.TextBox();
            this.TxtPaymentArrivalTime = new System.Windows.Forms.Label();
            this.TxtPaymentDepartureTime = new System.Windows.Forms.Label();
            this.MtbPaymentNumPass = new System.Windows.Forms.MaskedTextBox();
            this.TbPaymentDepartureDate = new System.Windows.Forms.TextBox();
            this.TbPaymentDestination = new System.Windows.Forms.TextBox();
            this.TbPaymentOrigin = new System.Windows.Forms.TextBox();
            this.TxtPaymentDepartureDate = new System.Windows.Forms.Label();
            this.TxtPaymentNumPass = new System.Windows.Forms.Label();
            this.TxtPaymentDestination = new System.Windows.Forms.Label();
            this.TxtPaymentOrigin = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.BtnPaymentCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbPaymentVehicle = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChPaymentAgree
            // 
            this.ChPaymentAgree.AutoSize = true;
            this.ChPaymentAgree.Location = new System.Drawing.Point(12, 327);
            this.ChPaymentAgree.Margin = new System.Windows.Forms.Padding(2);
            this.ChPaymentAgree.Name = "ChPaymentAgree";
            this.ChPaymentAgree.Size = new System.Drawing.Size(60, 17);
            this.ChPaymentAgree.TabIndex = 0;
            this.ChPaymentAgree.Text = "I Agree";
            this.ChPaymentAgree.UseVisualStyleBackColor = true;
            // 
            // BtnPaymentPay
            // 
            this.BtnPaymentPay.Location = new System.Drawing.Point(385, 329);
            this.BtnPaymentPay.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPaymentPay.Name = "BtnPaymentPay";
            this.BtnPaymentPay.Size = new System.Drawing.Size(56, 19);
            this.BtnPaymentPay.TabIndex = 1;
            this.BtnPaymentPay.Text = "Pay Now";
            this.BtnPaymentPay.UseVisualStyleBackColor = true;
            this.BtnPaymentPay.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbPaymentVehicle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbPaymentPrice);
            this.groupBox1.Controls.Add(this.TxtPaymentPrice);
            this.groupBox1.Controls.Add(this.TbPaymentaArrivalTime);
            this.groupBox1.Controls.Add(this.TbPaymentDepartureTime);
            this.groupBox1.Controls.Add(this.TxtPaymentArrivalTime);
            this.groupBox1.Controls.Add(this.TxtPaymentDepartureTime);
            this.groupBox1.Controls.Add(this.MtbPaymentNumPass);
            this.groupBox1.Controls.Add(this.TbPaymentDepartureDate);
            this.groupBox1.Controls.Add(this.TbPaymentDestination);
            this.groupBox1.Controls.Add(this.TbPaymentOrigin);
            this.groupBox1.Controls.Add(this.TxtPaymentDepartureDate);
            this.groupBox1.Controls.Add(this.TxtPaymentNumPass);
            this.groupBox1.Controls.Add(this.TxtPaymentDestination);
            this.groupBox1.Controls.Add(this.TxtPaymentOrigin);
            this.groupBox1.Location = new System.Drawing.Point(16, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(441, 229);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirmation:";
            // 
            // TbPaymentPrice
            // 
            this.TbPaymentPrice.Location = new System.Drawing.Point(45, 194);
            this.TbPaymentPrice.Name = "TbPaymentPrice";
            this.TbPaymentPrice.ReadOnly = true;
            this.TbPaymentPrice.Size = new System.Drawing.Size(100, 20);
            this.TbPaymentPrice.TabIndex = 13;
            // 
            // TxtPaymentPrice
            // 
            this.TxtPaymentPrice.AutoSize = true;
            this.TxtPaymentPrice.Location = new System.Drawing.Point(5, 194);
            this.TxtPaymentPrice.Name = "TxtPaymentPrice";
            this.TxtPaymentPrice.Size = new System.Drawing.Size(34, 13);
            this.TxtPaymentPrice.TabIndex = 12;
            this.TxtPaymentPrice.Text = "Price:";
            // 
            // TbPaymentaArrivalTime
            // 
            this.TbPaymentaArrivalTime.Location = new System.Drawing.Point(76, 127);
            this.TbPaymentaArrivalTime.Name = "TbPaymentaArrivalTime";
            this.TbPaymentaArrivalTime.ReadOnly = true;
            this.TbPaymentaArrivalTime.Size = new System.Drawing.Size(100, 20);
            this.TbPaymentaArrivalTime.TabIndex = 11;
            // 
            // TbPaymentDepartureTime
            // 
            this.TbPaymentDepartureTime.Location = new System.Drawing.Point(95, 101);
            this.TbPaymentDepartureTime.Name = "TbPaymentDepartureTime";
            this.TbPaymentDepartureTime.ReadOnly = true;
            this.TbPaymentDepartureTime.Size = new System.Drawing.Size(100, 20);
            this.TbPaymentDepartureTime.TabIndex = 10;
            // 
            // TxtPaymentArrivalTime
            // 
            this.TxtPaymentArrivalTime.AutoSize = true;
            this.TxtPaymentArrivalTime.Location = new System.Drawing.Point(5, 127);
            this.TxtPaymentArrivalTime.Name = "TxtPaymentArrivalTime";
            this.TxtPaymentArrivalTime.Size = new System.Drawing.Size(65, 13);
            this.TxtPaymentArrivalTime.TabIndex = 9;
            this.TxtPaymentArrivalTime.Text = "Arrival Time:";
            // 
            // TxtPaymentDepartureTime
            // 
            this.TxtPaymentDepartureTime.AutoSize = true;
            this.TxtPaymentDepartureTime.Location = new System.Drawing.Point(5, 101);
            this.TxtPaymentDepartureTime.Name = "TxtPaymentDepartureTime";
            this.TxtPaymentDepartureTime.Size = new System.Drawing.Size(83, 13);
            this.TxtPaymentDepartureTime.TabIndex = 8;
            this.TxtPaymentDepartureTime.Text = "Departure Time:";
            // 
            // MtbPaymentNumPass
            // 
            this.MtbPaymentNumPass.Location = new System.Drawing.Point(128, 160);
            this.MtbPaymentNumPass.Mask = "00";
            this.MtbPaymentNumPass.Name = "MtbPaymentNumPass";
            this.MtbPaymentNumPass.ReadOnly = true;
            this.MtbPaymentNumPass.Size = new System.Drawing.Size(20, 20);
            this.MtbPaymentNumPass.TabIndex = 7;
            // 
            // TbPaymentDepartureDate
            // 
            this.TbPaymentDepartureDate.Location = new System.Drawing.Point(94, 74);
            this.TbPaymentDepartureDate.Name = "TbPaymentDepartureDate";
            this.TbPaymentDepartureDate.ReadOnly = true;
            this.TbPaymentDepartureDate.Size = new System.Drawing.Size(100, 20);
            this.TbPaymentDepartureDate.TabIndex = 6;
            // 
            // TbPaymentDestination
            // 
            this.TbPaymentDestination.Location = new System.Drawing.Point(74, 49);
            this.TbPaymentDestination.Name = "TbPaymentDestination";
            this.TbPaymentDestination.ReadOnly = true;
            this.TbPaymentDestination.Size = new System.Drawing.Size(100, 20);
            this.TbPaymentDestination.TabIndex = 5;
            // 
            // TbPaymentOrigin
            // 
            this.TbPaymentOrigin.Location = new System.Drawing.Point(49, 25);
            this.TbPaymentOrigin.Name = "TbPaymentOrigin";
            this.TbPaymentOrigin.ReadOnly = true;
            this.TbPaymentOrigin.Size = new System.Drawing.Size(100, 20);
            this.TbPaymentOrigin.TabIndex = 4;
            // 
            // TxtPaymentDepartureDate
            // 
            this.TxtPaymentDepartureDate.AutoSize = true;
            this.TxtPaymentDepartureDate.Location = new System.Drawing.Point(5, 74);
            this.TxtPaymentDepartureDate.Name = "TxtPaymentDepartureDate";
            this.TxtPaymentDepartureDate.Size = new System.Drawing.Size(83, 13);
            this.TxtPaymentDepartureDate.TabIndex = 3;
            this.TxtPaymentDepartureDate.Text = "Departure Date:";
            // 
            // TxtPaymentNumPass
            // 
            this.TxtPaymentNumPass.AutoSize = true;
            this.TxtPaymentNumPass.Location = new System.Drawing.Point(5, 160);
            this.TxtPaymentNumPass.Name = "TxtPaymentNumPass";
            this.TxtPaymentNumPass.Size = new System.Drawing.Size(117, 13);
            this.TxtPaymentNumPass.TabIndex = 2;
            this.TxtPaymentNumPass.Text = "Number of Passengers:";
            // 
            // TxtPaymentDestination
            // 
            this.TxtPaymentDestination.AutoSize = true;
            this.TxtPaymentDestination.Location = new System.Drawing.Point(5, 49);
            this.TxtPaymentDestination.Name = "TxtPaymentDestination";
            this.TxtPaymentDestination.Size = new System.Drawing.Size(63, 13);
            this.TxtPaymentDestination.TabIndex = 1;
            this.TxtPaymentDestination.Text = "Destination:";
            // 
            // TxtPaymentOrigin
            // 
            this.TxtPaymentOrigin.AutoSize = true;
            this.TxtPaymentOrigin.Location = new System.Drawing.Point(5, 25);
            this.TxtPaymentOrigin.Name = "TxtPaymentOrigin";
            this.TxtPaymentOrigin.Size = new System.Drawing.Size(37, 13);
            this.TxtPaymentOrigin.TabIndex = 0;
            this.TxtPaymentOrigin.Text = "Origin:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(9, 259);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(448, 63);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contract";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 24);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(341, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod";
            // 
            // BtnPaymentCancel
            // 
            this.BtnPaymentCancel.Location = new System.Drawing.Point(324, 329);
            this.BtnPaymentCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPaymentCancel.Name = "BtnPaymentCancel";
            this.BtnPaymentCancel.Size = new System.Drawing.Size(56, 19);
            this.BtnPaymentCancel.TabIndex = 24;
            this.BtnPaymentCancel.Text = "Cancel";
            this.BtnPaymentCancel.UseVisualStyleBackColor = true;
            this.BtnPaymentCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vehicle:";
            // 
            // TbPaymentVehicle
            // 
            this.TbPaymentVehicle.Location = new System.Drawing.Point(273, 25);
            this.TbPaymentVehicle.Name = "TbPaymentVehicle";
            this.TbPaymentVehicle.ReadOnly = true;
            this.TbPaymentVehicle.Size = new System.Drawing.Size(100, 20);
            this.TbPaymentVehicle.TabIndex = 15;
            // 
            // PaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 352);
            this.Controls.Add(this.BtnPaymentCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnPaymentPay);
            this.Controls.Add(this.ChPaymentAgree);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaymentView";
            this.Text = "PaymentView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox ChPaymentAgree;
    private System.Windows.Forms.Button BtnPaymentPay;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Button BtnPaymentCancel;
        private System.Windows.Forms.Label TxtPaymentOrigin;
        private System.Windows.Forms.Label TxtPaymentDestination;
        private System.Windows.Forms.Label TxtPaymentDepartureDate;
        private System.Windows.Forms.Label TxtPaymentNumPass;
        private System.Windows.Forms.MaskedTextBox MtbPaymentNumPass;
        private System.Windows.Forms.TextBox TbPaymentDepartureDate;
        private System.Windows.Forms.TextBox TbPaymentDestination;
        private System.Windows.Forms.TextBox TbPaymentOrigin;
        private System.Windows.Forms.TextBox TbPaymentaArrivalTime;
        private System.Windows.Forms.TextBox TbPaymentDepartureTime;
        private System.Windows.Forms.Label TxtPaymentArrivalTime;
        private System.Windows.Forms.Label TxtPaymentDepartureTime;
        private System.Windows.Forms.TextBox TbPaymentPrice;
        private System.Windows.Forms.Label TxtPaymentPrice;
        private System.Windows.Forms.TextBox TbPaymentVehicle;
        private System.Windows.Forms.Label label1;
    }
}