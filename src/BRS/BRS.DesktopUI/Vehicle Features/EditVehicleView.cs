using System;
using System.Windows.Forms;
using BRS.Core.Models;
using BRS.Data.Repositories;

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
            Close();
        }

        private void BtnVehicleCreate_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = TbVehicleName.Text;
            vehicle.PassengerCapacity = Int32.Parse(MtbVehiclePassCap.Text);
            vehicle.VehicleType = TbVehicleVeTy.Text;
            vehicle.Image = TbVehicleImage.Text;
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
