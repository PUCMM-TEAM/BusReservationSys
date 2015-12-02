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
            this.MtbPaymentNumPass = new System.Windows.Forms.MaskedTextBox();
            this.TbPaymentDepartureDate = new System.Windows.Forms.TextBox();
            this.TbPaymentDestination = new System.Windows.Forms.TextBox();
            this.TbPaymentOrigin = new System.Windows.Forms.TextBox();
            this.TxtPaymentDepartureDate = new System.Windows.Forms.Label();
            this.TxtPaymentNumPass = new System.Windows.Forms.Label();
            this.TxtPaymentDestination = new System.Windows.Forms.Label();
            this.TxtPaymentOrigin = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.BtnPaymentCancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(441, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trip Info";
            // 
            // MtbPaymentNumPass
            // 
            this.MtbPaymentNumPass.Location = new System.Drawing.Point(129, 96);
            this.MtbPaymentNumPass.Mask = "00";
            this.MtbPaymentNumPass.Name = "MtbPaymentNumPass";
            this.MtbPaymentNumPass.Size = new System.Drawing.Size(20, 20);
            this.MtbPaymentNumPass.TabIndex = 7;
            // 
            // TbPaymentDepartureDate
            // 
            this.TbPaymentDepartureDate.Location = new System.Drawing.Point(94, 74);
            this.TbPaymentDepartureDate.Name = "TbPaymentDepartureDate";
            this.TbPaymentDepartureDate.Size = new System.Drawing.Size(100, 20);
            this.TbPaymentDepartureDate.TabIndex = 6;
            // 
            // TbPaymentDestination
            // 
            this.TbPaymentDestination.Location = new System.Drawing.Point(74, 49);
            this.TbPaymentDestination.Name = "TbPaymentDestination";
            this.TbPaymentDestination.Size = new System.Drawing.Size(100, 20);
            this.TbPaymentDestination.TabIndex = 5;
            // 
            // TbPaymentOrigin
            // 
            this.TbPaymentOrigin.Location = new System.Drawing.Point(49, 25);
            this.TbPaymentOrigin.Name = "TbPaymentOrigin";
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
            this.TxtPaymentNumPass.Location = new System.Drawing.Point(5, 96);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(9, 152);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(448, 110);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(199, 87);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Expiration Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 83);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(284, 59);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 20);
            this.textBox5.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "CVC";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(284, 37);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(284, 14);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Card Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(199, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Card Holder";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 41);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Email:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 16);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(9, 267);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(448, 55);
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
            // PaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 352);
            this.Controls.Add(this.BtnPaymentCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label19;
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
    }
}