using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Models
{
    public class Schedule :Entity{
        public int DepartureTime { get; set; }

        public int ArrivalTime { get; set; }
    }
}
