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

namespace BRS.DesktopUI {
  public partial class PaymentView : Form {

        Trip trip;
        int noPassengers;
        DateTime value;

        public PaymentView()
        {
      InitializeComponent();
            
    }

      
    private void label10_Click(object sender, EventArgs e) {

    }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setModel(Trip trip, int noPassengers, DateTime value)
        {
            
            this.trip = trip;
            this.noPassengers = noPassengers;
            this.value = value;
            setValuesto();

        }

        public void setValuesto()
        {
            
            TbPaymentOrigin.Text = trip.Route.Pickup.Name.ToString();
            TbPaymentDestination.Text = trip.Route.DropOff.Name.ToString();
            TbPaymentDepartureDate.Text = value.ToString();
            MtbPaymentNumPass.Text = noPassengers.ToString();
           

        }

    }
}
