﻿namespace BRS.DesktopUI
{
    partial class SearchView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CbSearchArrivalTime = new System.Windows.Forms.ComboBox();
            this.CbSearchDepartueTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtArrivalTime = new System.Windows.Forms.Label();
            this.TxtDepartureTime = new System.Windows.Forms.Label();
            this.LVSearch = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.TxtRoute = new System.Windows.Forms.Label();
            this.CbSearchRoute = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbSearchVehicle = new System.Windows.Forms.ComboBox();
            this.Route = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvailableDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.CbSearchVehicle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CbSearchRoute);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.CbSearchArrivalTime);
            this.groupBox1.Controls.Add(this.CbSearchDepartueTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtArrivalTime);
            this.groupBox1.Controls.Add(this.TxtDepartureTime);
            this.groupBox1.Controls.Add(this.TxtRoute);
            this.groupBox1.Location = new System.Drawing.Point(372, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(77, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // CbSearchArrivalTime
            // 
            this.CbSearchArrivalTime.FormattingEnabled = true;
            this.CbSearchArrivalTime.Location = new System.Drawing.Point(77, 141);
            this.CbSearchArrivalTime.Name = "CbSearchArrivalTime";
            this.CbSearchArrivalTime.Size = new System.Drawing.Size(101, 21);
            this.CbSearchArrivalTime.TabIndex = 20;
            // 
            // CbSearchDepartueTime
            // 
            this.CbSearchDepartueTime.FormattingEnabled = true;
            this.CbSearchDepartueTime.Location = new System.Drawing.Point(95, 114);
            this.CbSearchDepartueTime.Name = "CbSearchDepartueTime";
            this.CbSearchDepartueTime.Size = new System.Drawing.Size(101, 21);
            this.CbSearchDepartueTime.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Arrival Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Departure Date:";
            // 
            // TxtArrivalTime
            // 
            this.TxtArrivalTime.AutoSize = true;
            this.TxtArrivalTime.Location = new System.Drawing.Point(6, 141);
            this.TxtArrivalTime.Name = "TxtArrivalTime";
            this.TxtArrivalTime.Size = new System.Drawing.Size(65, 13);
            this.TxtArrivalTime.TabIndex = 14;
            this.TxtArrivalTime.Text = "Arrival Time:";
            this.TxtArrivalTime.Click += new System.EventHandler(this.TxtArrivalTime_Click);
            // 
            // TxtDepartureTime
            // 
            this.TxtDepartureTime.AutoSize = true;
            this.TxtDepartureTime.Location = new System.Drawing.Point(6, 114);
            this.TxtDepartureTime.Name = "TxtDepartureTime";
            this.TxtDepartureTime.Size = new System.Drawing.Size(83, 13);
            this.TxtDepartureTime.TabIndex = 13;
            this.TxtDepartureTime.Text = "Departure Time:";
            // 
            // LVSearch
            // 
            this.LVSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Route,
            this.AvailableDate,
            this.DepartureTime,
            this.ArrivalTime,
            this.Vehicle,
            this.Price});
            this.LVSearch.Location = new System.Drawing.Point(13, 60);
            this.LVSearch.Name = "LVSearch";
            this.LVSearch.Size = new System.Drawing.Size(353, 339);
            this.LVSearch.TabIndex = 1;
            this.LVSearch.UseCompatibleStateImageBehavior = false;
            this.LVSearch.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 2;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Book Trip";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TxtRoute
            // 
            this.TxtRoute.AutoSize = true;
            this.TxtRoute.Location = new System.Drawing.Point(6, 27);
            this.TxtRoute.Name = "TxtRoute";
            this.TxtRoute.Size = new System.Drawing.Size(39, 13);
            this.TxtRoute.TabIndex = 9;
            this.TxtRoute.Text = "Route:";
            // 
            // CbSearchRoute
            // 
            this.CbSearchRoute.FormattingEnabled = true;
            this.CbSearchRoute.Location = new System.Drawing.Point(52, 27);
            this.CbSearchRoute.Name = "CbSearchRoute";
            this.CbSearchRoute.Size = new System.Drawing.Size(121, 21);
            this.CbSearchRoute.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Vehicle:";
            // 
            // CbSearchVehicle
            // 
            this.CbSearchVehicle.FormattingEnabled = true;
            this.CbSearchVehicle.Location = new System.Drawing.Point(58, 172);
            this.CbSearchVehicle.Name = "CbSearchVehicle";
            this.CbSearchVehicle.Size = new System.Drawing.Size(121, 21);
            this.CbSearchVehicle.TabIndex = 27;
            // 
            // Route
            // 
            this.Route.Text = "Route";
            this.Route.Width = 84;
            // 
            // AvailableDate
            // 
            this.AvailableDate.Text = "AvailableDate";
            this.AvailableDate.Width = 91;
            // 
            // DepartureTime
            // 
            this.DepartureTime.Text = "DepartureTime";
            this.DepartureTime.Width = 76;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.Text = "ArrivalTime";
            this.ArrivalTime.Width = 61;
            // 
            // Vehicle
            // 
            this.Vehicle.Text = "Vehicle";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // SearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LVSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchView";
            this.Text = "SearchView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView LVSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label TxtArrivalTime;
        private System.Windows.Forms.Label TxtDepartureTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CbSearchArrivalTime;
        private System.Windows.Forms.ComboBox CbSearchDepartueTime;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox CbSearchVehicle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbSearchRoute;
        private System.Windows.Forms.Label TxtRoute;
        private System.Windows.Forms.ColumnHeader Route;
        private System.Windows.Forms.ColumnHeader AvailableDate;
        private System.Windows.Forms.ColumnHeader DepartureTime;
        private System.Windows.Forms.ColumnHeader ArrivalTime;
        private System.Windows.Forms.ColumnHeader Vehicle;
        private System.Windows.Forms.ColumnHeader Price;
    }
}