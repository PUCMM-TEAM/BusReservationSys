using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
