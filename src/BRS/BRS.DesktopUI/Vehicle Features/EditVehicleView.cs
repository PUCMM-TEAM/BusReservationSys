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

namespace BRS.DesktopUI.VehicleFeatures
{
   

    public partial class EditVehicleView : Form
    {
        VehicleRepository repo = new VehicleRepository();
        public EditVehicleView()
        {
            InitializeComponent();
        }

        private void BtnVehicleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVehicleCreate_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = TbVehicleName.Text.ToString();
            vehicle.PassengerCapacity = Int32.Parse(MtbVehiclePassCap.Text.ToString());
            vehicle.VehicleType = TbVehicleVeTy.Text.ToString();
            vehicle.Image = TbVehicleImage.Text.ToString();
            //db.Destinations.Add(destination);
            //db.SaveChanges();
            repo.Create(vehicle);
        }

        private void BtnVehicleList_Click(object sender, EventArgs e)
        {
            VehicleListView vehicleview = new VehicleListView();
            vehicleview.Show();
        }
    }
}
