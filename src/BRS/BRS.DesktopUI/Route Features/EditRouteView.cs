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
    /// <summary>
    /// Clase representativa del formulario de la edicion de una ruta.
    /// </summary>
    public partial class EditRouteView : Form
    {
        RouteRepository repo = new RouteRepository();
       // private Context db = new Context();

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public EditRouteView()
        {
            InitializeComponent();
           
            var list = RepositoryFactory.Instance().RouteRepository().ReadAll().ToList();
            var bindingList = new BindingList<Route>(list);
            var source = new BindingSource(bindingList, null);

         

            CbRoutePickup.DisplayMember = "Pickup.Name";
            CbRoutePickup.ValueMember = "ID";

            CbRouteDropoff.DisplayMember = "Dropoff.Name";
            CbRouteDropoff.ValueMember = "ID";

            CbRoutePickup.DataSource = source;
            CbRouteDropoff.DataSource = source;

            this.CbRoutePickup.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Handler del boton de salir del formulario.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnRouteCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handler del boton que crea una ruta nueva.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnRouteCreate_Click(object sender, EventArgs e)
        {
            Route route= new Route();
            route.Pickup = (Destination)CbRoutePickup.SelectedItem;
            route.DropOff = (Destination)CbRouteDropoff.SelectedItem;
            // RepositoryFactory.Instance().RouteRepository().Create(route);

        }

        private void CbRoutePickup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CbRouteDropoff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handler del boton para accesar al formulario de rutas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRouteList_Click(object sender, EventArgs e)
        {
            RouteListView routeview = new RouteListView();
            routeview.Show();
        }
    }
}
