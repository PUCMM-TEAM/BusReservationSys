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

namespace BRS.DesktopUI.VehicleFeatures
{
   
    /// <summary>
    /// Clase representativa del formulario de editar vehiculos.
    /// </summary>
    public partial class EditVehicleView : Form
    {
        /// <summary>
        /// Representa el repositorio de los vehiculos.
        /// </summary>
        VehicleRepository repo = new VehicleRepository();
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public EditVehicleView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler del boton para salir del formulario.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnVehicleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Handler del boton para crear un vehiculo.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnVehicleCreate_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = TbVehicleName.Text.ToString();
            vehicle.PassengerCapacity = Int32.Parse(MtbVehiclePassCap.Text.ToString());
            vehicle.VehicleType = TbVehicleVeTy.Text.ToString();
            // vehicle.Image = TbVehicleImage.Text.ToString();
            RepositoryFactory.Instance().VehicleRepository().Create(vehicle);
            MessageBox.Show("Vehicle succcesfully created"); 
            
        }

        /// <summary>
        /// Handler del boton para ir al formulario de vehiculos.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnVehicleList_Click(object sender, EventArgs e)
        {
            VehicleListView vehicleview = new VehicleListView();
            vehicleview.Show();
        }
    }
}
