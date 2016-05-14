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
    public class AnimalHistoriesController : Controller
    {
        private VetContext db = new VetContext();

        // GET: AnimalHistories
        public ActionResult Index()
        {
            return View(db.AnimalHistory.ToList());
        }

        // GET: AnimalHistories/Details/5
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

        // GET: AnimalHistories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalHistories/Create
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

        // GET: AnimalHistories/Edit/5
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

        // POST: AnimalHistories/Edit/5
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

        // GET: AnimalHistories/Delete/5
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

        // POST: AnimalHistories/Delete/5
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
