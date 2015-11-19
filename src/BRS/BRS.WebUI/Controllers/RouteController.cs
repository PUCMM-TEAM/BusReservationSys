using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BRS.Core.Models;
using BRS.Data.EF_Context;

namespace BRS.WebUI.Controllers {
  public class RouteController : Controller {
    private DBContext db = new DBContext();

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
      PopulatePickupDropDownList();
      PopulateDropOffDropDownList();
      return View();
    }

    private void PopulatePickupDropDownList(Object selectedDestination = null) {
      var destinationQuery = from d in db.Destinations
                             orderby d.Name
                             select d;

      ViewBag.PickupID = new SelectList(destinationQuery, "PickupID", "Name", selectedDestination);
    }

    private void PopulateDropOffDropDownList(Object selectedDestination = null) {
      var destinationQuery = from d in db.Destinations
                             orderby d.Name
                             select d;

      ViewBag.DropOffID = new SelectList(destinationQuery, "DropOffID", "Name", selectedDestination);
    }

    // POST: Route/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "ID,PickupID,DropOffID")] Route route) {
      try {
        if (ModelState.IsValid) {
          db.Routes.Add(route);
          db.SaveChanges();
          return RedirectToAction("Index");
        }
      } catch (RetryLimitExceededException) {
        ModelState.AddModelError("", "Unable to save changes. Try again, and if the problems persists, see your system administrator.");
      }

      PopulatePickupDropDownList(route.Pickup.ID);
      PopulatePickupDropDownList(route.DropOff.ID);
      return View(route);
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

      PopulatePickupDropDownList(route.Pickup.ID);
      PopulatePickupDropDownList(route.DropOff.ID);
      return View(route);
    }

    // POST: Route/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost, ActionName("Edit")]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "ID,PickupID,DropOffID")] Route route) {
      if (ModelState.IsValid) {
        db.Entry(route).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
      }

      PopulatePickupDropDownList(route.Pickup.ID);
      PopulatePickupDropDownList(route.DropOff.ID);
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


  }
}
