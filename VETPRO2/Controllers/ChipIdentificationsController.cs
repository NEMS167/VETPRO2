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
    public class ChipIdentificationsController : Controller
    {
        private VetContext db = new VetContext();

        // GET: ChipIdentifications
        public ActionResult Index()
        {
            return View(db.ChipIdentification.ToList());
        }

        // GET: ChipIdentifications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChipIdentification chipIdentification = db.ChipIdentification.Find(id);
            if (chipIdentification == null)
            {
                return HttpNotFound();
            }
            return View(chipIdentification);
        }

        // GET: ChipIdentifications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChipIdentifications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AnimalId,MicrochipNumber,EartagNumber")] ChipIdentification chipIdentification)
        {
            if (ModelState.IsValid)
            {
                db.ChipIdentification.Add(chipIdentification);
                db.SaveChanges();
                return RedirectToAction("Create", "Insurances");
            }

            return View(chipIdentification);
        }

        // GET: ChipIdentifications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChipIdentification chipIdentification = db.ChipIdentification.Find(id);
            if (chipIdentification == null)
            {
                return HttpNotFound();
            }
            return View(chipIdentification);
        }

        // POST: ChipIdentifications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AnimalId,MicrochipNumber,EartagNumber")] ChipIdentification chipIdentification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chipIdentification).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chipIdentification);
        }

        // GET: ChipIdentifications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChipIdentification chipIdentification = db.ChipIdentification.Find(id);
            if (chipIdentification == null)
            {
                return HttpNotFound();
            }
            return View(chipIdentification);
        }

        // POST: ChipIdentifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChipIdentification chipIdentification = db.ChipIdentification.Find(id);
            db.ChipIdentification.Remove(chipIdentification);
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
