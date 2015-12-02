using System.Collections.Generic;
using BRS.Core.Models;

namespace BRS.WebUI.Models {
  public class TripViewModel {
    public int Id { get; set; }
    public byte DateAvailable { get; set; }
    public int DepartureTime { get; set; }
    public int ArrivalTime { get; set; }
    public float Price { get; set; }
    public int RouteId { get; set; }
    public int VehicleId { get; set; }
    public IEnumerable<Route> Routes { get; set; }
    public IEnumerable<Vehicle> Vehicles { get; set; } 
  }
}