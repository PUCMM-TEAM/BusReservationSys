using System;
using System.Collections.Generic;
using BRS.Core.Models;

namespace BRS.WebUI.Models {
  public class SearchResultViewModel {
    public IEnumerable<Trip> Trips { get; set; }
    public int NoPassengers { get; set; }
    public DateTime DepartureDate { get; set; }
  }
}