using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRS.Core.Views;

namespace BRS.Logical.Handlers {
  public class NavigationHandler {

    public static void GoToHomeView(IHomeView view){
      view.Show();
    }

    public static void GoToSearchView(ISearchView view){
      view.Show();
    }

    public static void GoToBookingPreConfirmationView(){
      
    }

    public static void GoToBookingConfirmationView(){
      
    }

    public static void GoToLoginView(){
      
    }

    public static void GoToRegistrationView(){
      
    }

  }
}
