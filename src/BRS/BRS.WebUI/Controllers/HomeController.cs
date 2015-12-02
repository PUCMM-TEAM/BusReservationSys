using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BRS.Core.Models;
using BRS.Data;
using BRS.WebUI.Models;

namespace BRS.WebUI.Controllers {
  public class HomeController : Controller {
    private Context db = new Context();

    public ActionResult Index() {
      SearchResultViewModel vmodel = new SearchResultViewModel();
      List<Trip> trips = db.Trips.ToList();
      vmodel.Trips = trips;
      vmodel.DepartureDate = DateTime.Now;
      vmodel.NoPassengers = 1;
      return View(vmodel);
    }

    [HttpPost]
    public ActionResult Index(int originId, int destinationId, DateTime date, int noPassengers) {
      SearchResultViewModel vmodel = new SearchResultViewModel();
      List<Trip> trips = db.Trips.ToList();
      var result = trips.Where(x => x.Route.Pickup.ID == originId && x.Route.DropOff.ID == destinationId).ToList();
      vmodel.Trips = trips;
      vmodel.DepartureDate = date;
      vmodel.NoPassengers = noPassengers;

      if(ModelState.IsValid)
      return RedirectToAction("Index", "Reservation", new {originId = originId, destinationId = originId, date = date, noPassengers = noPassengers});

      return View(vmodel);
    }



    public ActionResult About() {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact() {
      ViewBag.Message = "Your contact page.";

      return View();
    }



    public ActionResult DestinationsAutocomplete(string term) {

      var items = db.Destinations.ToList();
      var filteredItems = items.Where(x => x.Name.ToLower().Contains(term.ToLower()));
      return Json(filteredItems, JsonRequestBehavior.AllowGet);
    }
  }


}