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
using BRS.Core.Repositories;
using BRS.Logical.Account;

namespace BRS.DesktopUI {
  /// <summary>
  /// Clase representativa del formulario de pago.
  /// </summary>
  public partial class PaymentView : Form {
        /// <summary>
        /// Representa un viaje.
        /// </summary>
        Trip trip;
        /// <summary>
        /// Representa el numero de pasajeros.
        /// </summary>
        int noPassengers;

        /// <summary>
        /// representa una fecha.
        /// </summary>
        DateTime value;
        /// <summary>
        /// Representa un cliente.
        /// </summary>
        Customer customer;

        /// <summary>
        /// Representa una tarjerta de credito.
        /// </summary>
        CreditCard credit;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public PaymentView()
        {
      InitializeComponent();

          
    }

      
    private void label10_Click(object sender, EventArgs e) {

    }
        /// <summary>
        /// Handler del buton de salir del formulario.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Set de un modelo.
        /// </summary>
        /// <param name="trip">Representa un viaje</param>
        /// <param name="noPassengers">Representa el numero de pasajeros.</param>
        /// <param name="value">Representa una fecha</param>
        public void setModel(Trip trip, int noPassengers, DateTime value)
        {
            
            this.trip = trip;
            this.noPassengers = noPassengers;
            this.value = value;
            setValuesto();

        }

        /// <summary>
        /// Set para establer valores desde las componentes del formularios.
        /// </summary>
        public void setValuesto()
        {
            
            TbPaymentOrigin.Text = trip.Route.Pickup.Name.ToString();
            TbPaymentDestination.Text = trip.Route.DropOff.Name.ToString();
            TbPaymentDepartureDate.Text = value.ToString();
            MtbPaymentNumPass.Text = noPassengers.ToString();
            TbPaymentDepartureTime.Text = trip.DepartureTime.ToString();
            TbPaymentaArrivalTime.Text = trip.ArrivalTime.ToString();
            TbPaymentPrice.Text = trip.Price.ToString();
            TbPaymentVehicle.Text = trip.Vehicle.Name.ToString();
           

        }

        /// <summary>
        /// Handler del botn para hacer la reservacion.
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Data del evento</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(ChPaymentAgree.Checked)
            {

                customer = new Customer();
                customer.FirstName = "Rafael";
                customer.LastName = "White";
                customer.Birthday = value;
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
                reservation.Customer = AccountManager.Instance.CurrentUser.Customer;
                //reservation.CreditCard = AccountManager.Instance.CurrentUser.Customer.CreditCards.FirstOrDefault();
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
