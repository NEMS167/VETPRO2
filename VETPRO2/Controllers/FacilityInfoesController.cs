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
    public class FacilityInfoesController : Controller
    {
        private VetContext db = new VetContext();

        // GET: FacilityInfoes
        public ActionResult Index()
        {
            return View(db.FacilityInfo.ToList());
        }

        // GET: FacilityInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityInfo facilityInfo = db.FacilityInfo.Find(id);
            if (facilityInfo == null)
            {
                return HttpNotFound();
            }
            return View(facilityInfo);
        }

        // GET: FacilityInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FacilityId,LocationKind,LocationName,Address,City,State,ZipCode,PhoneNumber,Directions,OperationalHours")] FacilityInfo facilityInfo)
        {
            if (ModelState.IsValid)
            {
                db.FacilityInfo.Add(facilityInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilityInfo);
        }

        // GET: FacilityInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityInfo facilityInfo = db.FacilityInfo.Find(id);
            if (facilityInfo == null)
            {
                return HttpNotFound();
            }
            return View(facilityInfo);
        }

        // POST: FacilityInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FacilityId,LocationKind,LocationName,Address,City,State,ZipCode,PhoneNumber,Directions,OperationalHours")] FacilityInfo facilityInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facilityInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facilityInfo);
        }

        // GET: FacilityInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityInfo facilityInfo = db.FacilityInfo.Find(id);
            if (facilityInfo == null)
            {
                return HttpNotFound();
            }
            return View(facilityInfo);
        }

        // POST: FacilityInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacilityInfo facilityInfo = db.FacilityInfo.Find(id);
            db.FacilityInfo.Remove(facilityInfo);
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
