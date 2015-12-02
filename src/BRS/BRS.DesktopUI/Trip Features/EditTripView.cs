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
    public partial class EditTripView : Form
    {
        TripRepository repo = new TripRepository();
        public EditTripView()
        {
            InitializeComponent();
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

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Trip trip = new Trip();
            //trip.Route =
            //trip.DateAvailable =
            //trip.DepartureTime =
            //trip.ArrivalTime =
            //trip.Vehicle =
            trip.Price = float.Parse(MtbTripPrice.Text.ToString());
            //db.Destinations.Add(destination);
            //db.SaveChanges();
            repo.Create(trip);
        }

        private void BtnTripList_Click(object sender, EventArgs e)
        {
            TripListView tripview = new TripListView();
            tripview.Show();
        }
    }
}
