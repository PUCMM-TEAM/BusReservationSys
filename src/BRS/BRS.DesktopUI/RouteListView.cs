using BRS.Core.Models;
using BRS.Data.EF_Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRS.DesktopUI {
  public partial class RouteListView : Form {
    public RouteListView() {

      InitializeComponent();
      DBContext context = new DBContext();//Manages the data.Can get or set data
      var list = context.Destinations.ToList();//Gets info from database
      var bindingList = new BindingList<Destination>(list);//Create a new list to show data from database
      var source = new BindingSource(bindingList, null);//fill with data
      DGVRoutes.DataSource = source;

        }
  }
}
