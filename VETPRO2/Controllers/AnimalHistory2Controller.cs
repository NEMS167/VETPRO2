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
    public class AnimalHistoryController : Controller
    {
        private VetContext db = new VetContext();

        // GET: AnimalHistory2
        public ActionResult Index()
        {
            return View(db.AnimalHistory.ToList());
        }

        // GET: AnimalHistory2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalHistory animalHistory = db.AnimalHistory.Find(id);
            if (animalHistory == null)
            {
                return HttpNotFound();
            }
            return View(animalHistory);
        }

        // GET: AnimalHistory2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalHistory2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CurrentMedication,AnimalAllergies")] AnimalHistory animalHistory)
        {
            if (ModelState.IsValid)
            {
                db.AnimalHistory.Add(animalHistory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(animalHistory);
        }

        // GET: AnimalHistory2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalHistory animalHistory = db.AnimalHistory.Find(id);
            if (animalHistory == null)
            {
                return HttpNotFound();
            }
            return View(animalHistory);
        }

        // POST: AnimalHistory2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CurrentMedication,AnimalAllergies")] AnimalHistory animalHistory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animalHistory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(animalHistory);
        }

        // GET: AnimalHistory2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalHistory animalHistory = db.AnimalHistory.Find(id);
            if (animalHistory == null)
            {
                return HttpNotFound();
            }
            return View(animalHistory);
        }

        // POST: AnimalHistory2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnimalHistory animalHistory = db.AnimalHistory.Find(id);
            db.AnimalHistory.Remove(animalHistory);
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
