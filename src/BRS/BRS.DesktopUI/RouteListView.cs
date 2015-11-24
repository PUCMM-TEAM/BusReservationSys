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


namespace BRS.DesktopUI {
  public partial class RouteListView : Form {
    public RouteListView() {
      InitializeComponent();

     Context context = new Context();
      IEnumerable<Destination> destinations = context.Destinations.ToList();

      destinations.Select(x => x);
    }
  }
}
