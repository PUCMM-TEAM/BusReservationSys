using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BRS.Core.Models;
using BRS.Core.Repositories;
using BRS.Data.SqlRepositories;

namespace BRS.DesktopUI
{
    public partial class VehicleListView : Form
    {
        public VehicleListView()
        {
            InitializeComponent();
            IRepository<Vehicle> repo = new VehicleSqlRepository();
            //Context context = new Context();//Manages the data.Can get or set data
            //var list = context.Destinations.ToList();//Gets info from database
            List<Vehicle> vehicle = repo.ReadAll().ToList();
            var bindingList = new BindingList<Vehicle>(vehicle);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVVehicle.DataSource = source;

        }
    }
}
