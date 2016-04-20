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
    public class AnimalBehaviorsController : Controller
    {
        private VetContext db = new VetContext();

        // GET: AnimalBehaviors
        public ActionResult Index()
        {
            return View(db.AnimalBehavior.ToList());
        }

        // GET: AnimalBehaviors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalBehavior animalBehavior = db.AnimalBehavior.Find(id);
            if (animalBehavior == null)
            {
                return HttpNotFound();
            }
            return View(animalBehavior);
        }

        // GET: AnimalBehaviors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalBehaviors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AnimalId,AggressionComments")] AnimalBehavior animalBehavior)
        {
            if (ModelState.IsValid)
            {
                db.AnimalBehavior.Add(animalBehavior);
                db.SaveChanges();
                return RedirectToAction("Create", "AnimalHistories");
            }

            return View(animalBehavior);
        }

        // GET: AnimalBehaviors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalBehavior animalBehavior = db.AnimalBehavior.Find(id);
            if (animalBehavior == null)
            {
                return HttpNotFound();
            }
            return View(animalBehavior);
        }

        // POST: AnimalBehaviors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AnimalId,AggressionComments")] AnimalBehavior animalBehavior)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animalBehavior).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(animalBehavior);
        }

        // GET: AnimalBehaviors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalBehavior animalBehavior = db.AnimalBehavior.Find(id);
            if (animalBehavior == null)
            {
                return HttpNotFound();
            }
            return View(animalBehavior);
        }

        // POST: AnimalBehaviors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnimalBehavior animalBehavior = db.AnimalBehavior.Find(id);
            db.AnimalBehavior.Remove(animalBehavior);
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
