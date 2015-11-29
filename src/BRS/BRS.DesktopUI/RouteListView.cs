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

            //Context context = new Context();
            //IEnumerable<Destination> destinations = context.Destinations.ToList();

            //destinations.Select(x => x);

            Context context = new Context();//Manages the data.Can get or set data
            var list = context.Routes.ToList();//Gets info from database
            var bindingList = new BindingList<Route>(list);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVRoutes.DataSource = source;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
