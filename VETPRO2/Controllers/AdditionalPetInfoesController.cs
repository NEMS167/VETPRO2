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
    public class AdditionalPetInfoesController : Controller
    {
        private VetContext db = new VetContext();

        // GET: AdditionalPetInfoes
        public ActionResult Index()
        {
            return View(db.AdditonalPetInfo.ToList());
        }

        // GET: AdditionalPetInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdditionalPetInfo additionalPetInfo = db.AdditonalPetInfo.Find(id);
            if (additionalPetInfo == null)
            {
                return HttpNotFound();
            }
            return View(additionalPetInfo);
        }

        // GET: AdditionalPetInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdditionalPetInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AnimalId,Belongings,Comment")] AdditionalPetInfo additionalPetInfo)
        {
            if (ModelState.IsValid)
            {
                db.AdditonalPetInfo.Add(additionalPetInfo);
                db.SaveChanges();
                return RedirectToAction("Index", "AnimalInfoes");
            }

            return View(additionalPetInfo);
        }

        // GET: AdditionalPetInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdditionalPetInfo additionalPetInfo = db.AdditonalPetInfo.Find(id);
            if (additionalPetInfo == null)
            {
                return HttpNotFound();
            }
            return View(additionalPetInfo);
        }

        // POST: AdditionalPetInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AnimalId,Belongings,Comment")] AdditionalPetInfo additionalPetInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(additionalPetInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(additionalPetInfo);
        }

        // GET: AdditionalPetInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdditionalPetInfo additionalPetInfo = db.AdditonalPetInfo.Find(id);
            if (additionalPetInfo == null)
            {
                return HttpNotFound();
            }
            return View(additionalPetInfo);
        }

        // POST: AdditionalPetInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdditionalPetInfo additionalPetInfo = db.AdditonalPetInfo.Find(id);
            db.AdditonalPetInfo.Remove(additionalPetInfo);
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
