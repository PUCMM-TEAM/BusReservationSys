using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Models
{
    class Route : Entity{

        public Destination Pickup { get; set; }

        public Destination DropOff { get; set; }

    }
}
