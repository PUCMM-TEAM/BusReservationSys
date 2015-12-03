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
  /// <summary>
  /// Clase representativa del formulario de listas de rutas.
  /// </summary>
  public partial class RouteListView : Form {
    /// <summary>
    /// Constructor de la clase.
    /// </summary>
    public RouteListView() {
      InitializeComponent();


            IRepository<Route> repo = RepositoryFactory.Instance().RouteRepository();
            List<Route> routes = repo.ReadAll().ToList();
            var bindingList = new BindingList<Route>(routes);
            var source = new BindingSource(bindingList, null);
            DGVRoutes.DataSource = source;

        }
  }
}
