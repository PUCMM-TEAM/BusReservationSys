using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Models
{
    public class Route : Entity{
        public virtual Destination Pickup { get; set; }
        public virtual Destination DropOff { get; set; }

        public string RouteName { get { return Pickup.Name + " - " + DropOff.Name; } }
    }
}
