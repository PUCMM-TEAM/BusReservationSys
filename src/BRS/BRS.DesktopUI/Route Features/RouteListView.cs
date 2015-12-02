using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRS.Core.Models;
using BRS.Data;
using BRS.Data.Repositories;
using BRS.Core.Repositories;
using BRS.Data.SqlRepositories;

namespace BRS.DesktopUI {
  public partial class RouteListView : Form {
    public RouteListView() {
      InitializeComponent();

            //Context context = new Context();
            // IEnumerable<Destination> destinations = context.Destinations.ToList();

            // destinations.Select(x => x);

            IRepository<Route> repo = RepositoryFactory.Instance().RouteRepository();
            List<Route> routes = repo.ReadAll().ToList();
            var bindingList = new BindingList<Route>(routes);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVRoutes.DataSource = source;




        }
  }
}
