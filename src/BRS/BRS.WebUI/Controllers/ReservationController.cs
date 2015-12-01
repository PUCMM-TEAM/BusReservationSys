using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BRS.Core.Models;
using BRS.Data;
using BRS.WebUI.Models;

namespace BRS.WebUI.Controllers
{
    public class ReservationController : Controller
    {
      private Context db = new Context();

        // GET: Reservation
        public ActionResult Index(){
          SearchResultViewModel vmodel = new SearchResultViewModel();
          List<Trip> trips = db.Trips.ToList();
          vmodel.Trips = trips;
          vmodel.DepartureDate = DateTime.Now;
          vmodel.NoPassengers = 1;
          return View(vmodel);
        }

      [HttpPost]
      public ActionResult Index(int originId, int destinationId, DateTime date, int noPassengers){
        SearchResultViewModel vmodel = new SearchResultViewModel();
        List<Trip> trips = db.Trips.ToList(); 
        var result = trips.Where(x => x.Route.Pickup.ID == originId && x.Route.DropOff.ID == destinationId).ToList();
        vmodel.Trips = trips;
        vmodel.DepartureDate = date;
        vmodel.NoPassengers = noPassengers;
        
        return View(vmodel);
      }

      public ActionResult Book(int tripId, DateTime departureDate, int noPassengers) {
        
        ReservationViewModel reservation = new ReservationViewModel();
        reservation.Trip = db.Trips.Find(tripId);
        reservation.DepartureDate = departureDate;
        reservation.NoPassengers = noPassengers;
        reservation.Price = reservation.Trip.Price;
        return View(reservation);
      }

      [HttpPost]
      public ActionResult Book([Bind(Include = "Name,Email,CardHolder,CardNumber,CVC,ExpirationDate,TripId,DepartureDate,NoPassengers,Price")] ReservationViewModel vModel) {
              vModel.Trip = db.Trips.Find(vModel.TripId);
        if (ModelState.IsValid){

          string[] name = vModel.Name.Split(' ');
          Customer cust = new Customer{FirstName = name[0], LastName = name[1], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false};
          
          Reservation reservation = new Reservation{
            ID = 0,
            CreatedDate = DateTime.Now,
            CreditCard = new CreditCard { CardHolder = vModel.CardHolder,CardNumber = vModel.CardNumber, CreatedDate = DateTime.Now, CVC = vModel.CVC, Deleted = false, ExpirationDate = vModel.ExpirationDate.Millisecond, ModifiedDate = DateTime.Now},
            Customer = cust,
            Deleted = false,
            ModifiedDate = DateTime.Now,
            NumPassenger = vModel.NoPassengers,
            ReservationDate = DateTime.Now,
            Trip = vModel.Trip
          };

          db.Reservations.Add(reservation);
          db.SaveChanges();
          return RedirectToAction("Index");
        }
  
        return View(vModel);
      }

      private static int GetDayOfWeek(DateTime date) {

        switch (date.DayOfWeek){
          case DayOfWeek.Monday:
            return 1;
            case DayOfWeek.Tuesday:
            return 2;
            case DayOfWeek.Wednesday:
            return 4;
            case DayOfWeek.Thursday:
            return 8;
            case DayOfWeek.Friday:
            return 16;
            case DayOfWeek.Saturday:
            return 32;
            case DayOfWeek.Sunday:
            return 64;
        }

        return 0;
      }

      public ActionResult DestinationsAutocomplete(string term){

        var items = db.Destinations.ToList();
        var filteredItems = items.Where(x => x.Name.ToLower().Contains(term.ToLower()));
        return Json(filteredItems, JsonRequestBehavior.AllowGet);
      }
    }
}