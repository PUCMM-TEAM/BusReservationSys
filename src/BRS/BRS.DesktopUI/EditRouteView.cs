using BRS.Core.Models;
using BRS.Data;
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
    public partial class EditRouteView : Form
    {
        private Context db = new Context();

        public EditRouteView()
        {
            InitializeComponent();
        }

        private void BtnRouteCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRouteCreate_Click(object sender, EventArgs e)
        {
            Route route = new Route();
            //route.Pickup = TbRoutePickup.Text;
            //route.DropOff = TbRouteDropOff.Text;
            db.Routes.Add(route);
            db.SaveChanges();
        }
    }
}
