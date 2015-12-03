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
    /// Clase representativa del formulario de la edicion de viajes.
    /// </summary>
    public partial class EditTripView : Form
    {
        /// <summary>
        /// Representa el repositorio de viajes.
        /// </summary>
        TripRepository repo = new TripRepository();
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public EditTripView()
        {
            InitializeComponent();

            var list = RepositoryFactory.Instance().RouteRepository().ReadAll().ToList();
            var bindingList = new BindingList<Route>(list);
            var source = new BindingSource(bindingList, null);

            var vehiclelist = RepositoryFactory.Instance().VehicleRepository().ReadAll().ToList();
            var bindinglistv = new BindingList<Vehicle>(vehiclelist);
            var vehiclesource = new BindingSource(bindingList, null);


            CbTripRoute.DisplayMember = "RouteName";
            CbTripRoute.ValueMember = "ID";

            CbTripVehicle.DisplayMember = "Name";
            CbTripVehicle.ValueMember = "ID";

            CbTripRoute.DataSource = source;
            CbTripVehicle.DataSource = vehiclesource;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GbDescription_Enter(object sender, EventArgs e)
        {

        }

        private void GbRouteDetails_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtArrivalTime_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handler del boton para crear un viaje.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        /// Falta implementacion.
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Trip trip = new Trip();
            //trip.Route = CbTripRoute.SelectedValue.GetType()
            //trip.DateAvailable =
            //trip.DepartureTime =
            //trip.ArrivalTime =
            //trip.Vehicle =
            //trip.Price = float.Parse(MtbTripPrice.Text.ToString());
            trip.CreatedDate = DateTime.Now;
            trip.ModifiedDate = DateTime.Now;

            RepositoryFactory.Instance().TripRepository().Create(trip);
        
        }

        /// <summary>
        /// Handler del boton para ir al formulario de los viajes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTripList_Click(object sender, EventArgs e)
        {
            TripListView tripview = new TripListView();
            tripview.Show();
        }
    }
}
