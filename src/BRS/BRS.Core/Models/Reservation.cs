using System;

namespace BRS.Core.Models
{
    public class Reservation : Entity{
      public Trip Trip { get; set; }
      public Customer Customer { get; set; }
      public int NumPassenger { get; set; }
      public CreditCard CreditCard { get; set; }
      public DateTime ReservationDate { get; set; }

    }
}
