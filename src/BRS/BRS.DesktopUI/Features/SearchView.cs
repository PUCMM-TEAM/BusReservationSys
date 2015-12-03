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
    /// <summary>
    /// Clase representativa del formulario de la busqueda de viajes.
    /// </summary>
    public partial class SearchView : Form
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public SearchView()
        {
            InitializeComponent();
            MtbSearchNumPass.Text = "01";
            IRepository<Trip> repo = RepositoryFactory.Instance().TripRepository();
            List<Trip> trip = repo.ReadAll().ToList();
            var bindingList = new BindingList<Trip>(trip);
            var source = new BindingSource(bindingList, null);
            DGVSearchTrip.DataSource = source;

            DGVSearchTrip.Columns["Deleted"].Visible = false;
            DGVSearchTrip.Columns["CreatedDate"].Visible = false;
            DGVSearchTrip.Columns["ModifiedDate"].Visible = false;
            DGVSearchTrip.Columns["ID"].Visible = false;

            
            var originlist = RepositoryFactory.Instance().DestinationRepository().ReadAll().ToList();
            var bindinglistori = new BindingList<Destination>(originlist);
            var sourceori = new BindingSource(bindinglistori, null);
            

            
            var departure_list = RepositoryFactory.Instance().TripRepository().ReadAll().ToList();
            var bind_list_departure = new BindingList<Trip>(departure_list);
            var source_departure = new BindingSource(bind_list_departure, null);

            var arrival_list = RepositoryFactory.Instance().TripRepository().ReadAll().ToList();
            var bind_list_arrival = new BindingList<Trip>(arrival_list);
            var source_arrival = new BindingSource(bind_list_arrival, null);

            
            var vehiclelist = RepositoryFactory.Instance().VehicleRepository().ReadAll().ToList();
            var bindinglistvehicle = new BindingList<Vehicle>(vehiclelist);
            var sourcevehicle = new BindingSource(bindinglistvehicle, null);

            
            CbSearchOrigin.DisplayMember = "Name";
            CbSearchOrigin.ValueMember = "ID";

            CbSearchDestination.DisplayMember = "Name";
            CbSearchDestination.ValueMember = "ID";

           
            CbSearchOrigin.DataSource = sourceori;
            CbSearchDestination.DataSource = sourceori;
       

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

        /// <summary>
        /// Handler del evento de doble clickeo en el data grid view.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
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
