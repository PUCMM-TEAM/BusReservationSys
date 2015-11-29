using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Core.Models {
  public class Trip : Entity {
    public byte DateAvailable { get; set; }
    public int DepartureTime { get; set; }
    public int ArrivalTime { get; set; }
    public float Price { get; set; }
    public virtual Route Route { get; set; }
    public virtual Vehicle Vehicle{ get; set; }

  }
}
