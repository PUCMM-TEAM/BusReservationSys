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
    public partial class AdminEditView : Form
    {
        public AdminEditView()
        {
            InitializeComponent();
        }

        private void BtnAdminUser_Click(object sender, EventArgs e)
        {
            EditUserView userview = new EditUserView();
            userview.Show();
        }

        private void BtnAdminTrip_Click(object sender, EventArgs e)
        {
            EditTripView tripview = new EditTripView();
            tripview.Show();
        }

        private void BtnAdminRoute_Click(object sender, EventArgs e)
        {
            EditRouteView routeview = new EditRouteView();
            routeview.Show();
        }

        private void BtnAdminDestination_Click(object sender, EventArgs e)
        {
            EditDestinationView destinationview = new EditDestinationView();
            destinationview.Show();
        }
    }
}
