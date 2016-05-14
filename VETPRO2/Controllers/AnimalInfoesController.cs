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
    public class AnimalInfoesController : Controller
    {
        private VetContext db = new VetContext();

        // GET: AnimalInfoes
        public ActionResult Index()
        {
            return View(db.AnimalInfo.ToList());
        }

        // GET: AnimalInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalInfo animalInfo = db.AnimalInfo.Find(id);
            if (animalInfo == null)
            {
                return HttpNotFound();
            }
            return View(animalInfo);
        }

        // GET: AnimalInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnimalId,OwnerId,AnimalName,AnimalSpecies,AnimalBreed,AnimalAge,AnimalEstimatedWeight,AnimalDescription")] AnimalInfo animalInfo)
        {
            if (ModelState.IsValid)
            {
                db.AnimalInfo.Add(animalInfo);
                db.SaveChanges();
                return RedirectToAction("Create", "AnimalBehaviors");
            }

            return View(animalInfo);
        }

        // GET: AnimalInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalInfo animalInfo = db.AnimalInfo.Find(id);
            if (animalInfo == null)
            {
                return HttpNotFound();
            }
            return View(animalInfo);
        }

        // POST: AnimalInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnimalId,OwnerId,AnimalName,AnimalSpecies,AnimalBreed,AnimalAge,AnimalEstimatedWeight,AnimalDescription")] AnimalInfo animalInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animalInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(animalInfo);
        }

        // GET: AnimalInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalInfo animalInfo = db.AnimalInfo.Find(id);
            if (animalInfo == null)
            {
                return HttpNotFound();
            }
            return View(animalInfo);
        }

        // POST: AnimalInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnimalInfo animalInfo = db.AnimalInfo.Find(id);
            AnimalBehavior animalBehavior = db.AnimalBehavior.Find(id);
            AnimalHistory animalHistory = db.AnimalHistory.Find(id);
            ChipIdentification chipIdentification = db.ChipIdentification.Find(id);
            AdditionalContact additionalContact = db.AdditionalContact.Find(id);
            AdditionalPetInfo additionalPetInfo = db.AdditonalPetInfo.Find(id);
            Insurance insurance = db.Insurance.Find(id);
            MedicalHistory medicalHistory = db.MedicalHistory.Find(id);
            SecondaryContact secondaryContact = db.SecondaryContact.Find(id);
            TrackingOperations trackingOperations = db.TrackingOperations.Find(id);
            db.AnimalInfo.Remove(animalInfo);
            db.AnimalBehavior.Remove(animalBehavior);
            db.AnimalHistory.Remove(animalHistory);
            db.ChipIdentification.Remove(chipIdentification);
            db.AdditionalContact.Remove(additionalContact);
            db.AdditonalPetInfo.Remove(additionalPetInfo);
            db.Insurance.Remove(insurance);
            db.MedicalHistory.Remove(medicalHistory);
            db.SecondaryContact.Remove(secondaryContact);
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
