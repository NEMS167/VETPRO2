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
    public class ShelterOperationsController : Controller
    {
        private VetContext db = new VetContext();

        // GET: ShelterOperations
        public ActionResult Index()
        {
            return View(db.ShelterOperationses.ToList());
        }

        // GET: ShelterOperations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShelterOperations shelterOperations = db.ShelterOperationses.Find(id);
            if (shelterOperations == null)
            {
                return HttpNotFound();
            }
            return View(shelterOperations);
        }

        // GET: ShelterOperations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShelterOperations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,JobName,Description")] ShelterOperations shelterOperations)
        {
            if (ModelState.IsValid)
            {
                db.ShelterOperationses.Add(shelterOperations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shelterOperations);
        }

        // GET: ShelterOperations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShelterOperations shelterOperations = db.ShelterOperationses.Find(id);
            if (shelterOperations == null)
            {
                return HttpNotFound();
            }
            return View(shelterOperations);
        }

        // POST: ShelterOperations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,JobName,Description")] ShelterOperations shelterOperations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shelterOperations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shelterOperations);
        }

        // GET: ShelterOperations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShelterOperations shelterOperations = db.ShelterOperationses.Find(id);
            if (shelterOperations == null)
            {
                return HttpNotFound();
            }
            return View(shelterOperations);
        }

        // POST: ShelterOperations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShelterOperations shelterOperations = db.ShelterOperationses.Find(id);
            db.ShelterOperationses.Remove(shelterOperations);
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
