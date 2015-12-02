using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRS.Data.SqlRepositories;

namespace BRS.Logical.Handlers {
  public class StateManager {
    
    private MyState _currentState = MyState.HomePage;

    public static bool IsRoleEligible(){
      return true;
    }

  }

  public enum MyState{
      HomePage,
      Query,
      PreBooking,
      BookingConfirmation,
      Login,
      Register,
      DestinationMaintenance,
      RouteMaintenance,
      Vehiclemaintenance,
      TripMaintenance
    }
}
