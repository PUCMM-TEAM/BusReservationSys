
using System;
using System.Collections.Generic;
using System.Linq;
using BRS.Core.Models;
using BRS.Data;

namespace BRS.Logical.ReservationHandlers {
  public class ReservationHandler{
    private Context _context;

    public ReservationHandler(){
      _context = new Context();
    }

    public IEnumerable<Trip> SearchForTrips(int origin, int destination, DateTime date, int noPassengers){
      var list = _context.Trips.Where(x => x.Route.Pickup.ID == origin && x.Route.DropOff.ID == destination && x.Deleted == false);
      return list.ToList();
    } 
  }
}
