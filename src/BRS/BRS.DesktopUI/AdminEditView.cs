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
    /// Clase representativa del formulario de la pagina principal del administrador.
    /// </summary>
    public partial class AdminEditView : Form
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public AdminEditView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler del boton para ir formulario para editar un usuario.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnAdminUser_Click(object sender, EventArgs e)
        {
            EditUserView userview = new EditUserView();
            userview.Show();
        }

        /// <summary>
        /// Handler del boton para ir formulario para editar un viaje.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnAdminTrip_Click(object sender, EventArgs e)
        {
            EditTripView tripview = new EditTripView();
            tripview.Show();
        }

        /// <summary>
        /// Handler del boton para ir formulario para editar un ruta.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnAdminRoute_Click(object sender, EventArgs e)
        {
            EditRouteView routeview = new EditRouteView();
            routeview.Show();
        }

        /// <summary>
        /// Handler del boton para ir formulario para editar un destino.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnAdminDestination_Click(object sender, EventArgs e)
        {
            EditDestinationView destinationview = new EditDestinationView();
            destinationview.Show();
        }
    }
}
