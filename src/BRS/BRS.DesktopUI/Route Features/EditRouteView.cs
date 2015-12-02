using System;
using System.Windows.Forms;
using BRS.Core.Models;
using BRS.Data.Repositories;

namespace BRS.DesktopUI
{
    public partial class EditRouteView : Form
    {
        RouteRepository repo = new RouteRepository();
       // private Context db = new Context();

        public EditRouteView()
        {
            InitializeComponent();
           
            var list = RepositoryFactory.Instance().RouteRepository().ReadAll().ToList();
            var bindingList = new BindingList<Route>(list);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data

         

            CbRoutePickup.DisplayMember = "Pickup.Name";
            CbRoutePickup.ValueMember = "ID";

            CbRouteDropoff.DisplayMember = "Dropoff.Name";
            CbRouteDropoff.ValueMember = "ID";

            CbRoutePickup.DataSource = source;
            CbRouteDropoff.DataSource = source;

            CbRoutePickup.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnRouteCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRouteCreate_Click(object sender, EventArgs e)
        {
            Route route= new Route();
            //route.Pickup = CbRoutePickup.
            //route.DropOff = CbRouteDropoff;
            //db.Destinations.Add(destination);
            //db.SaveChanges();
            repo.Create(route);
        }

        private void CbRoutePickup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CbRouteDropoff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnRouteList_Click(object sender, EventArgs e)
        {
            RouteListView routeview = new RouteListView();
            routeview.Show();
        }
    }
}
