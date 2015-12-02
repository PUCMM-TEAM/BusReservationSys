using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BRS.Data.Repositories;

namespace BRS.DesktopUI
{
    public partial class SearchView : Form
    {
        public SearchView()
        {
            InitializeComponent();
            TripRepository repotrips = new TripRepository();
            //Populate listview
           
           LVSearch.Items.AddRange(new[]{
        new ListViewItem("Amy Alberts"),
        new ListViewItem("Amy Recker"),
        new ListViewItem("Erin Hagens"),
        new ListViewItem("Barry Johnson"),
        new ListViewItem("Jay Hamlin"),
        new ListViewItem("Brian Valentine"),
        new ListViewItem("Brian Welker"),
        new ListViewItem("Daniel Weisman") });


            //Departure time and Arrival Time
            var departure_list = RepositoryFactory.Instance().TripRepository().ReadAll().ToList();
            var bind_list_departure = new BindingList<Trip>(departure_list);//Create a new list to show data from database
            var source_departure = new BindingSource(bind_list_departure, null);//fill with data

            var arrival_list = RepositoryFactory.Instance().TripRepository().ReadAll().ToList();
            var bind_list_arrival = new BindingList<Trip>(arrival_list);//Create a new list to show data from database
            var source_arrival = new BindingSource(bind_list_arrival, null);//fill with data

            //Vehicle
            var vehiclelist = RepositoryFactory.Instance().VehicleRepository().ReadAll().ToList();
            var bindinglistvehicle = new BindingList<Vehicle>(vehiclelist);//Create a new list to show data from database
            var sourcevehicle = new BindingSource(bindinglistvehicle, null);//fill with data

            //Origin and Destination
            CbSearchOrigin.DisplayMember = "Name";
            CbSearchOrigin.ValueMember = "ID";

            CbSearchDestination.DisplayMember = "Name";
            CbSearchDestination.ValueMember = "ID";

            ////Departure time and Arrival Time
            //CbSearchDepartueTime.DisplayMember = "DepartureTime";
            //CbSearchDepartueTime.ValueMember = "ID";

            BindingSource bs = new BindingSource();
            BindingSource bs2 = new BindingSource();
            bs.DataSource = new List<Destino>();// From where the data comes from
            bs.Add(new Destino{ Name = "Santo Domingo" });
            bs.Add(new Destino{ Name = "Santiago" });


            bs2.DataSource = new List<Destino>();
            bs2.Add(new Destino{ Name = "Santo Domingo" });
            bs2.Add(new Destino{ Name = "Santiago" });


            //Origin and Destination
            CbSearchOrigin.DataSource = sourceori;
            CbSearchDestination.DataSource = sourceori;
            ////Departure time and Arrival Time
            //CbSearchDepartueTime.DataSource = source_departure;
            //CbSearchArrivalTime.DataSource = source_arrival;

            ////Vehicle
            //CbSearchVehicle.DataSource = sourcevehicle;

        }

        private void TxtPassengerCapa_Click(object sender, EventArgs e)
        {

        }

        private void TxtArrivalTime_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void DGVSearchTrip_DoubleClick(object sender, EventArgs e)
        {
            int idx = DGVSearchTrip.CurrentCell.RowIndex;
            
            Trip trip = (Trip)DGVSearchTrip.Rows[idx].DataBoundItem;
            PaymentView paymentview = new PaymentView();

            int noPassengers = int.Parse(MtbSearchNumPass.Text);

            paymentview.setModel(trip, noPassengers, dateTimePicker1.Value);

            paymentview.Show();

        }
    }
}
