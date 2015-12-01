using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BRS.Core.Models;
using BRS.Data;
using BRS.WebUI.Models;

namespace BRS.WebUI.Controllers {
  public class TripController : Controller {
    private Context db = new Context();
    // GET: Trip
    public ActionResult Index() {
      return View(db.Trips.ToList());
    }

    // GET: Trip/Details/5
    public ActionResult Details(int? id) {
      if (id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Trip trip = db.Trips.Find(id);
      if (trip == null) {
        return HttpNotFound();
      }
      return View(trip);
    }

    // GET: Trip/Create
    public ActionResult Create() {
      TripViewModel vmRoute = new TripViewModel();
      vmRoute.Routes = db.Routes.ToList();
      vmRoute.Vehicles = db.Vehicles.ToList();

      return View(vmRoute);
    }

    // POST: Trip/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "ID,DateAvailable,DepartureTime,ArrivalTime,Price,RouteId,VehicleId")] TripViewModel tripVm, int[] dateAvailable) {
      tripVm.Routes = db.Routes.ToList();
      tripVm.Vehicles = db.Vehicles.ToList();

      if (ModelState.IsValid) {
        Trip trip = new Trip {
          ID = 0,
          ArrivalTime = tripVm.ArrivalTime,
          DepartureTime = tripVm.DepartureTime,
          DateAvailable = (byte)dateAvailable.Sum(x => x),
          Route = tripVm.Routes.First(x => x.ID == tripVm.RouteId),
          Vehicle = tripVm.Vehicles.First(x => x.ID == tripVm.VehicleId),
          Price = tripVm.Price,
          CreatedDate = DateTime.Now,
          ModifiedDate = DateTime.Now,
          Deleted = false
        };

        db.Trips.Add(trip);
        db.SaveChanges();
        return RedirectToAction("Index");
      }

      return View(tripVm);
    }

    // GET: Trip/Edit/5
    public ActionResult Edit(int? id) {
      if (id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Trip trip = db.Trips.Find(id);
      if (trip == null) {
        return HttpNotFound();
      }
      return View(trip);
    }

    // POST: Trip/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "ID,DateAvailable,DepartureTime,ArrivalTime,Price,CreatedDate,ModifiedDate,Deleted")] Trip trip) {
      if (ModelState.IsValid) {
        db.Entry(trip).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(trip);
    }

    // GET: Trip/Delete/5
    public ActionResult Delete(int? id) {
      if (id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Trip trip = db.Trips.Find(id);
      if (trip == null) {
        return HttpNotFound();
      }
      return View(trip);
    }

    // POST: Trip/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id) {
      Trip trip = db.Trips.Find(id);
      db.Trips.Remove(trip);
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    protected override void Dispose(bool disposing) {
      if (disposing) {
        db.Dispose();
      }
      base.Dispose(disposing);
    }

    private IEnumerable<Destination> GetDestinations() {
      return db.Destinations.Select(x => x);
    }

  }
}
