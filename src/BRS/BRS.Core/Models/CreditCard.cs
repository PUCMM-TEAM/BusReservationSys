using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Models
{
  public class CreditCard: Entity{

        public string CardHolder { get; set; }

        public string CardNumber { get; set; }

        public string CVC { get; set; }

        public int ExpirationDate { get; set; }


    }
}
