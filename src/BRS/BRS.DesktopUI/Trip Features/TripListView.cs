using BRS.Core.Models;
using BRS.Core.Repositories;
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
    public partial class TripListView : Form
    {
        public TripListView()
        {
            InitializeComponent();
            IRepository<Trip> repo = RepositoryFactory.Instance().TripRepository();
            //Context context = new Context();//Manages the data.Can get or set data
            //var list = context.Destinations.ToList();//Gets info from database
            List<Trip> trip = repo.ReadAll().ToList();
            var bindingList = new BindingList<Trip>(trip);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVTrip.DataSource = source;
        }
    }
}
