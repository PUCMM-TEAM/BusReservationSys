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
  public class RouteController : Controller {
    private Context db = new Context();

    // GET: Route
    public ActionResult Index() {
      return View(db.Routes.ToList());
    }

    // GET: Route/Details/5
    public ActionResult Details(int? id) {
      if (id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Route route = db.Routes.Find(id);
      if (route == null) {
        return HttpNotFound();
      }
      return View(route);
    }

    // GET: Route/Create
    public ActionResult Create() {
      RouteViewModel vmRoute = new RouteViewModel();
      vmRoute.Destinations = GetDestinations();

      return View(vmRoute);
    }

    // POST: Route/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "ID,PickUpId,DropOffId")] RouteViewModel model) {
      if (ModelState.IsValid) {
        Route route = new Route();
        route.ID = 0;
        route.Pickup = GetDestination(model.PickUpId);
        route.DropOff = GetDestination(model.DropOffId);
        route.CreatedDate = DateTime.Now;
        route.ModifiedDate = DateTime.Now;
        route.Deleted = false;

        db.Routes.Add(route);
        db.SaveChanges();
        return RedirectToAction("Index");
      }

      model.Destinations = GetDestinations();
      return View(model);
    }

    private Destination GetDestination(int pickUpId) {
      return db.Destinations.First(x => x.ID == pickUpId);
    }

    // GET: Route/Edit/5
    public ActionResult Edit(int? id) {
      if (id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Route route = db.Routes.Find(id);
      if (route == null) {
        return HttpNotFound();
      }
      return View(route);
    }

    // POST: Route/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "ID,CreatedDate,ModifiedDate,Deleted")] Route route) {
      if (ModelState.IsValid) {
        db.Entry(route).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(route);
    }

    // GET: Route/Delete/5
    public ActionResult Delete(int? id) {
      if (id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Route route = db.Routes.Find(id);
      if (route == null) {
        return HttpNotFound();
      }
      return View(route);
    }

    // POST: Route/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id) {
      Route route = db.Routes.Find(id);
      db.Routes.Remove(route);
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
