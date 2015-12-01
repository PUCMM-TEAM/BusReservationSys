using BRS.Core.Models;
using BRS.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRS.DesktopUI
{
    public partial class SearchView : Form
    {
        public SearchView()
        {
            InitializeComponent();
            TripRepository repotrips = new TripRepository();
            //Populate listview
           
           LVSearch.Items.AddRange(new ListViewItem[]{
        new ListViewItem("Amy Alberts"),
        new ListViewItem("Amy Recker"),
        new ListViewItem("Erin Hagens"),
        new ListViewItem("Barry Johnson"),
        new ListViewItem("Jay Hamlin"),
        new ListViewItem("Brian Valentine"),
        new ListViewItem("Brian Welker"),
        new ListViewItem("Daniel Weisman") });




            //Populate combo boxes
            //RouteRepository reporoutes = new RouteRepository();
            //VehicleRepository repovehicles = new VehicleRepository();

            //BindingSource routebs = new BindingSource();
            //BindingSource vehiclebs = new BindingSource();



            BindingSource bs = new BindingSource();
            BindingSource bs2 = new BindingSource();
            bs.DataSource = new List<Destino>();// From where the data comes from
            bs.Add(new Destino() { Name = "Santo Domingo" });
            bs.Add(new Destino() { Name = "Santiago" });


            bs2.DataSource = new List<Destino>();
            bs2.Add(new Destino() { Name = "Santo Domingo" });
            bs2.Add(new Destino() { Name = "Santiago" });


            // routebs.DataSource = reporoutes.ReadAll().ToList();
            // vehiclebs.DataSource = repovehicles.ReadAll().ToList();

            CbSearchRoute.DataSource = bs;
            CbSearchVehicle.DataSource = bs2;

            CbSearchRoute.DisplayMember = "Name";
            CbSearchRoute.ValueMember = "Name";
            CbSearchVehicle.DisplayMember = "Name";
            CbSearchVehicle.ValueMember = "Name";
           
        }

        private void TxtPassengerCapa_Click(object sender, EventArgs e)
        {

        }

        private void TxtArrivalTime_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PaymentView paymentview = new PaymentView();
            paymentview.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
        }
    }
}
