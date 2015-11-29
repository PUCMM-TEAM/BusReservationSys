using BRS.Core.Models;
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
    public partial class EditRouteView : Form
    {
        RouteRepository repo = new RouteRepository();
        //private Context db = new Context();

        public EditRouteView()
        {
            InitializeComponent();
            //BindingSource bs = new BindingSource();
            //BindingSource bs2 = new BindingSource();
            //bs.DataSource = new List<Destino>();// From where the data comes from
            //bs.Add(new Destino() { Name = "Santo Domingo" });
            //bs.Add(new Destino() { Name = "Santiago" });

            //bs2.DataSource = new List<Destino>();
            //bs2.Add(new Destino() { Name = "Santo Domingo" });
            //bs2.Add(new Destino() { Name = "Santiago" });

            //Context context = new Context();//Manages the data.Can get or set data
            //var list = context.Routes.ToList();//Gets info from database
            //var bindingList = new BindingList<Route>(list);//Create a new list to show data from database
            //var source = new BindingSource(bindingList, null);//fill with data

            //CbRoutePickup.DataSource = bs;
            //CbRouteDropoff.DataSource = bs2;

            CbRoutePickup.DisplayMember = "Name";
            CbRoutePickup.ValueMember = "Name";

            CbRouteDropoff.DisplayMember = "Name";
            CbRouteDropoff.ValueMember = "Name";

            this.CbRoutePickup.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnRouteCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
