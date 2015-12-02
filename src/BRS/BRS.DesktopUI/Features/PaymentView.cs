using System;
using System.Windows.Forms;
using BRS.Core.Models;
using BRS.Data;
using BRS.Core.Repositories;

namespace BRS.DesktopUI {
  public partial class PaymentView : Form {

        Trip trip;
        int noPassengers;
        DateTime value;
        Customer customer;
        CreditCard credit;

        public PaymentView()
        {
      InitializeComponent();

          
    }

      
    private void label10_Click(object sender, EventArgs e) {

    }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(ChPaymentAgree.Checked)
            {

                customer = new Customer();
                customer.FirstName = "Rafael";
                customer.LastName = "White";
                customer.Birthday = value.ToString();
                customer.CreatedDate = DateTime.Now;
                customer.ModifiedDate = DateTime.Now;
                customer.Deleted = false;

                credit = new CreditCard();
                credit.CardHolder = "Rafael";
                credit.CardNumber = "588282";
                credit.ExpirationDate = 0;
                credit.CVC = "123";
                credit.CreatedDate = DateTime.Now;
                credit.ModifiedDate = DateTime.Now;
                credit.Deleted = false;

                Reservation reservation = new Reservation();
                reservation.ID = 0;
                reservation.Trip = trip;
                reservation.Customer = customer;
                reservation.CreditCard = credit;
                //reservation.Customer = RepositoryFactory.Instance().CustomerRepository().Read(2);
                //reservation.CreditCard = RepositoryFactory.Instance().CreditCardRepository().Read(1);
                reservation.ReservationDate = value;
                reservation.NumPassenger = noPassengers;
                reservation.CreatedDate = DateTime.Now;
                reservation.ModifiedDate = DateTime.Now;


                RepositoryFactory.Instance().ReservationRepository().Create(reservation);

                MessageBox.Show("The reservation was made");

             


            }
            else
            {
                MessageBox.Show("You must agree to the terms and conditions");
            }
        }
    }
}
