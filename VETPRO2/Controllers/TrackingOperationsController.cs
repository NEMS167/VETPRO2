using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VETPRO2.Models;

namespace VETPRO2.Controllers
{
    public class TrackingOperationsController : Controller
    {
        private VetContext db = new VetContext();

        // GET: TrackingOperations
        public ActionResult Index()
        {
            return View(db.TrackingOperations.ToList());
        }

        // GET: TrackingOperations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrackingOperations trackingOperations = db.TrackingOperations.Find(id);
            if (trackingOperations == null)
            {
                return HttpNotFound();
            }
            return View(trackingOperations);
        }

        // GET: TrackingOperations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrackingOperations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MovementStatus,Description")] TrackingOperations trackingOperations)
        {
            if (ModelState.IsValid)
            {
                db.TrackingOperations.Add(trackingOperations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trackingOperations);
        }

        // GET: TrackingOperations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrackingOperations trackingOperations = db.TrackingOperations.Find(id);
            if (trackingOperations == null)
            {
                return HttpNotFound();
            }
            return View(trackingOperations);
        }

        // POST: TrackingOperations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MovementStatus,Description")] TrackingOperations trackingOperations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trackingOperations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trackingOperations);
        }

        // GET: TrackingOperations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrackingOperations trackingOperations = db.TrackingOperations.Find(id);
            if (trackingOperations == null)
            {
                return HttpNotFound();
            }
            return View(trackingOperations);
        }

        // POST: TrackingOperations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrackingOperations trackingOperations = db.TrackingOperations.Find(id);
            db.TrackingOperations.Remove(trackingOperations);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
