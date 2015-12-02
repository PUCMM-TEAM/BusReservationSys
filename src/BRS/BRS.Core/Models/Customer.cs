using System;
using System.Collections.Generic;

namespace BRS.Core.Models
{
  public class Customer : Entity{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public virtual IEnumerable<CreditCard> CreditCards { get; set; } 
    }
}
