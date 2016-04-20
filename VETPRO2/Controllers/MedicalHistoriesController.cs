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
    public class MedicalHistoriesController : Controller
    {
        private VetContext db = new VetContext();

        // GET: MedicalHistories
        public ActionResult Index()
        {
            return View(db.MedicalHistory.ToList());
        }

        // GET: MedicalHistories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalHistory medicalHistory = db.MedicalHistory.Find(id);
            if (medicalHistory == null)
            {
                return HttpNotFound();
            }
            return View(medicalHistory);
        }

        // GET: MedicalHistories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AnimalId,Year,Vaccination,Reason")] MedicalHistory medicalHistory)
        {
            if (ModelState.IsValid)
            {
                db.MedicalHistory.Add(medicalHistory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medicalHistory);
        }

        // GET: MedicalHistories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalHistory medicalHistory = db.MedicalHistory.Find(id);
            if (medicalHistory == null)
            {
                return HttpNotFound();
            }
            return View(medicalHistory);
        }

        // POST: MedicalHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AnimalId,Year,Vaccination,Reason")] MedicalHistory medicalHistory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicalHistory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medicalHistory);
        }

        // GET: MedicalHistories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalHistory medicalHistory = db.MedicalHistory.Find(id);
            if (medicalHistory == null)
            {
                return HttpNotFound();
            }
            return View(medicalHistory);
        }

        // POST: MedicalHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MedicalHistory medicalHistory = db.MedicalHistory.Find(id);
            db.MedicalHistory.Remove(medicalHistory);
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
