using System.ComponentModel;
using System.Windows.Forms;

namespace BRS.DesktopUI
{
    partial class EditTripView
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
            this.GbRouteDetails = new System.Windows.Forms.GroupBox();
            this.TxtVehicle = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.Label();
            this.BtnCancel3 = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtArrivalTime = new System.Windows.Forms.Label();
            this.TxtDepartureTime = new System.Windows.Forms.Label();
            this.TxtRoute = new System.Windows.Forms.Label();
            this.CbTripRoute = new System.Windows.Forms.ComboBox();
            this.CbTripVehicle = new System.Windows.Forms.ComboBox();
            this.ChLunes = new System.Windows.Forms.CheckBox();
            this.ChMartes = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ChJueves = new System.Windows.Forms.CheckBox();
            this.ChViernes = new System.Windows.Forms.CheckBox();
            this.ChSabado = new System.Windows.Forms.CheckBox();
            this.ChDomingo = new System.Windows.Forms.CheckBox();
            this.ChTodos = new System.Windows.Forms.CheckBox();
            this.CbTripDepartureTime = new System.Windows.Forms.ComboBox();
            this.CbTripArrivalTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MtbTripPrice = new System.Windows.Forms.MaskedTextBox();
            this.GbRouteDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbRouteDetails
            // 
            this.GbRouteDetails.BackColor = System.Drawing.Color.LightCyan;
            this.GbRouteDetails.Controls.Add(this.MtbTripPrice);
            this.GbRouteDetails.Controls.Add(this.label1);
            this.GbRouteDetails.Controls.Add(this.CbTripArrivalTime);
            this.GbRouteDetails.Controls.Add(this.CbTripDepartureTime);
            this.GbRouteDetails.Controls.Add(this.ChTodos);
            this.GbRouteDetails.Controls.Add(this.ChDomingo);
            this.GbRouteDetails.Controls.Add(this.ChSabado);
            this.GbRouteDetails.Controls.Add(this.ChViernes);
            this.GbRouteDetails.Controls.Add(this.ChJueves);
            this.GbRouteDetails.Controls.Add(this.checkBox1);
            this.GbRouteDetails.Controls.Add(this.ChMartes);
            this.GbRouteDetails.Controls.Add(this.ChLunes);
            this.GbRouteDetails.Controls.Add(this.CbTripVehicle);
            this.GbRouteDetails.Controls.Add(this.CbTripRoute);
            this.GbRouteDetails.Controls.Add(this.TxtVehicle);
            this.GbRouteDetails.Controls.Add(this.TxtArrivalTime);
            this.GbRouteDetails.Controls.Add(this.TxtDepartureTime);
            this.GbRouteDetails.Controls.Add(this.TxtDate);
            this.GbRouteDetails.Controls.Add(this.TxtRoute);
            this.GbRouteDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbRouteDetails.Location = new System.Drawing.Point(12, 12);
            this.GbRouteDetails.Name = "GbRouteDetails";
            this.GbRouteDetails.Size = new System.Drawing.Size(600, 363);
            this.GbRouteDetails.TabIndex = 0;
            this.GbRouteDetails.TabStop = false;
            this.GbRouteDetails.Text = "Trip Details";
            this.GbRouteDetails.Enter += new System.EventHandler(this.GbRouteDetails_Enter);
            // 
            // TxtVehicle
            // 
            this.TxtVehicle.AutoSize = true;
            this.TxtVehicle.Location = new System.Drawing.Point(7, 200);
            this.TxtVehicle.Name = "TxtVehicle";
            this.TxtVehicle.Size = new System.Drawing.Size(64, 15);
            this.TxtVehicle.TabIndex = 6;
            this.TxtVehicle.Text = "*Vehicle:";
            // 
            // TxtDate
            // 
            this.TxtDate.AutoSize = true;
            this.TxtDate.Location = new System.Drawing.Point(6, 60);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(116, 15);
            this.TxtDate.TabIndex = 2;
            this.TxtDate.Text = "*Available Dates:";
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
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtArrivalTime
            // 
            this.TxtArrivalTime.AutoSize = true;
            this.TxtArrivalTime.Location = new System.Drawing.Point(6, 165);
            this.TxtArrivalTime.Name = "TxtArrivalTime";
            this.TxtArrivalTime.Size = new System.Drawing.Size(93, 15);
            this.TxtArrivalTime.TabIndex = 4;
            this.TxtArrivalTime.Text = "*Arrival Time:";
            this.TxtArrivalTime.Click += new System.EventHandler(this.TxtArrivalTime_Click);
            // 
            // TxtDepartureTime
            // 
            this.TxtDepartureTime.AutoSize = true;
            this.TxtDepartureTime.Location = new System.Drawing.Point(6, 128);
            this.TxtDepartureTime.Name = "TxtDepartureTime";
            this.TxtDepartureTime.Size = new System.Drawing.Size(117, 15);
            this.TxtDepartureTime.TabIndex = 3;
            this.TxtDepartureTime.Text = "*Departure Time:";
            // 
            // TxtRoute
            // 
            this.TxtRoute.AutoSize = true;
            this.TxtRoute.Location = new System.Drawing.Point(7, 28);
            this.TxtRoute.Name = "TxtRoute";
            this.TxtRoute.Size = new System.Drawing.Size(55, 15);
            this.TxtRoute.TabIndex = 0;
            this.TxtRoute.Text = "*Route:";
            this.TxtRoute.Click += new System.EventHandler(this.label1_Click);
            // 
            // CbTripRoute
            // 
            this.CbTripRoute.FormattingEnabled = true;
            this.CbTripRoute.Location = new System.Drawing.Point(69, 28);
            this.CbTripRoute.Name = "CbTripRoute";
            this.CbTripRoute.Size = new System.Drawing.Size(121, 23);
            this.CbTripRoute.TabIndex = 10;
            // 
            // CbTripVehicle
            // 
            this.CbTripVehicle.FormattingEnabled = true;
            this.CbTripVehicle.Location = new System.Drawing.Point(78, 200);
            this.CbTripVehicle.Name = "CbTripVehicle";
            this.CbTripVehicle.Size = new System.Drawing.Size(121, 23);
            this.CbTripVehicle.TabIndex = 11;
            // 
            // ChLunes
            // 
            this.ChLunes.AutoSize = true;
            this.ChLunes.Location = new System.Drawing.Point(129, 60);
            this.ChLunes.Name = "ChLunes";
            this.ChLunes.Size = new System.Drawing.Size(65, 19);
            this.ChLunes.TabIndex = 12;
            this.ChLunes.Text = "Lunes";
            this.ChLunes.UseVisualStyleBackColor = true;
            // 
            // ChMartes
            // 
            this.ChMartes.AutoSize = true;
            this.ChMartes.Location = new System.Drawing.Point(200, 60);
            this.ChMartes.Name = "ChMartes";
            this.ChMartes.Size = new System.Drawing.Size(70, 19);
            this.ChMartes.TabIndex = 13;
            this.ChMartes.Text = "Martes";
            this.ChMartes.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(276, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Miercoles";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ChJueves
            // 
            this.ChJueves.AutoSize = true;
            this.ChJueves.Location = new System.Drawing.Point(371, 60);
            this.ChJueves.Name = "ChJueves";
            this.ChJueves.Size = new System.Drawing.Size(70, 19);
            this.ChJueves.TabIndex = 15;
            this.ChJueves.Text = "Jueves";
            this.ChJueves.UseVisualStyleBackColor = true;
            // 
            // ChViernes
            // 
            this.ChViernes.AutoSize = true;
            this.ChViernes.Location = new System.Drawing.Point(447, 60);
            this.ChViernes.Name = "ChViernes";
            this.ChViernes.Size = new System.Drawing.Size(74, 19);
            this.ChViernes.TabIndex = 16;
            this.ChViernes.Text = "Viernes";
            this.ChViernes.UseVisualStyleBackColor = true;
            // 
            // ChSabado
            // 
            this.ChSabado.AutoSize = true;
            this.ChSabado.Location = new System.Drawing.Point(129, 85);
            this.ChSabado.Name = "ChSabado";
            this.ChSabado.Size = new System.Drawing.Size(75, 19);
            this.ChSabado.TabIndex = 17;
            this.ChSabado.Text = "Sabado";
            this.ChSabado.UseVisualStyleBackColor = true;
            // 
            // ChDomingo
            // 
            this.ChDomingo.AutoSize = true;
            this.ChDomingo.Location = new System.Drawing.Point(210, 85);
            this.ChDomingo.Name = "ChDomingo";
            this.ChDomingo.Size = new System.Drawing.Size(84, 19);
            this.ChDomingo.TabIndex = 18;
            this.ChDomingo.Text = "Domingo";
            this.ChDomingo.UseVisualStyleBackColor = true;
            // 
            // ChTodos
            // 
            this.ChTodos.AutoSize = true;
            this.ChTodos.Location = new System.Drawing.Point(300, 85);
            this.ChTodos.Name = "ChTodos";
            this.ChTodos.Size = new System.Drawing.Size(119, 19);
            this.ChTodos.TabIndex = 19;
            this.ChTodos.Text = "Todos los dias";
            this.ChTodos.UseVisualStyleBackColor = true;
            this.ChTodos.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // CbTripDepartureTime
            // 
            this.CbTripDepartureTime.FormattingEnabled = true;
            this.CbTripDepartureTime.Location = new System.Drawing.Point(130, 128);
            this.CbTripDepartureTime.Name = "CbTripDepartureTime";
            this.CbTripDepartureTime.Size = new System.Drawing.Size(121, 23);
            this.CbTripDepartureTime.TabIndex = 20;
            // 
            // CbTripArrivalTime
            // 
            this.CbTripArrivalTime.FormattingEnabled = true;
            this.CbTripArrivalTime.Location = new System.Drawing.Point(105, 165);
            this.CbTripArrivalTime.Name = "CbTripArrivalTime";
            this.CbTripArrivalTime.Size = new System.Drawing.Size(121, 23);
            this.CbTripArrivalTime.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "*Price:";
            // 
            // MtbTripPrice
            // 
            this.MtbTripPrice.Location = new System.Drawing.Point(64, 238);
            this.MtbTripPrice.Mask = "0000";
            this.MtbTripPrice.Name = "MtbTripPrice";
            this.MtbTripPrice.Size = new System.Drawing.Size(46, 21);
            this.MtbTripPrice.TabIndex = 23;
            // 
            // EditTripView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel3);
            this.Controls.Add(this.GbRouteDetails);
            this.Name = "EditTripView";
            this.Text = "Edit Route";
            this.GbRouteDetails.ResumeLayout(false);
            this.GbRouteDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GbRouteDetails;
        private Label TxtVehicle;
        private Label TxtDate;
        private Button BtnCancel3;
        private Button BtnDelete;
        private Button BtnCreate;
        private ComboBox CbTripRoute;
        private Label TxtArrivalTime;
        private Label TxtDepartureTime;
        private Label TxtRoute;
        private ComboBox CbTripVehicle;
        private CheckBox ChTodos;
        private CheckBox ChDomingo;
        private CheckBox ChSabado;
        private CheckBox ChViernes;
        private CheckBox ChJueves;
        private CheckBox checkBox1;
        private CheckBox ChMartes;
        private CheckBox ChLunes;
        private ComboBox CbTripArrivalTime;
        private ComboBox CbTripDepartureTime;
        private MaskedTextBox MtbTripPrice;
        private Label label1;
    }
}