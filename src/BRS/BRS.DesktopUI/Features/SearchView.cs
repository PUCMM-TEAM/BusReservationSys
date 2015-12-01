using BRS.Core.Models;
using BRS.Core.Repositories;
using BRS.Data;
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
            IRepository<Trip> repo = RepositoryFactory.Instance().TripRepository();
            List<Trip> trip = repo.ReadAll().ToList();
            var bindingList = new BindingList<Trip>(trip);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVSearchTrip.DataSource = source;

            //Origin and Destination
            var originlist = RepositoryFactory.Instance().DestinationRepository().ReadAll().ToList();
            var bindinglistori = new BindingList<Destination>(originlist);//Create a new list to show data from database
            var sourceori = new BindingSource(bindinglistori, null);//fill with data
            

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

            //Departure time and Arrival Time
            CbSearchDepartueTime.DisplayMember = "DepartureTime";
            CbSearchDepartueTime.ValueMember = "ID";

            CbSearchArrivalTime.DisplayMember = "ArrivalTime";
            CbSearchArrivalTime.ValueMember = "ID";


            //Vehicle
            CbSearchVehicle.DisplayMember = "Name";
            CbSearchVehicle.ValueMember = "ID";


            //Origin and Destination
            CbSearchOrigin.DataSource = sourceori;
            CbSearchDestination.DataSource = sourceori;
            //Departure time and Arrival Time
            CbSearchDepartueTime.DataSource = source_departure;
            CbSearchArrivalTime.DataSource = source_arrival;

            //Vehicle
            CbSearchVehicle.DataSource = sourcevehicle;

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

        private void DGVSearchTrip_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
