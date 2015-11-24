using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Models
{
    public class Vehicle : Entity{
      public string Name { get; set; }
        public int PassengerCapacity { get; set; }
        public string VehicleType { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
