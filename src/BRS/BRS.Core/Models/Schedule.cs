using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Models
{
    class Schedule :Entity{
        public DateTime Date { get; set; }

        public int DepartureTime { get; set; }

        public int ArrivalTime { get; set; }

       
    }
}
