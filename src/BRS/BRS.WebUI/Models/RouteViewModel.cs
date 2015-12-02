using System.Collections.Generic;
using BRS.Core.Models;

namespace BRS.WebUI.Models {
  public class RouteViewModel {
    public int Id { get; set; }
    public int PickUpId { get; set; }
    public int DropOffId { get; set; }
    public IEnumerable<Destination> Destinations { get; set; } 
  }
}