using System;

namespace BRS.Core.Models
{
    /// <summary>
    /// Clase representativa de la entidad reservacion.
    /// </summary>
    public class Reservation : Entity{
      /// <summary>
      /// Representa un viaje.
      /// </summary>
      public Trip Trip { get; set; }
      /// <summary>
      /// Representa un cliente.
      /// </summary>
      public Customer Customer { get; set; }
      /// <summary>
      /// Representa el numero de pasajeros.
      /// </summary>
      public int NumPassenger { get; set; }
      /// <summary>
      /// Representa una tarjeta de credito.
      /// </summary>
      public CreditCard CreditCard { get; set; }
      /// <summary>
      /// Representa la fecha de reservacion.
      /// </summary>
      public DateTime ReservationDate { get; set; }

    }
}
