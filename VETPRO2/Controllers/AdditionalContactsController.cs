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
    public class AdditionalContactsController : Controller
    {
        private VetContext db = new VetContext();

        // GET: AdditionalContacts
        public ActionResult Index()
        {
            return View(db.AdditionalContact.ToList());
        }

        // GET: AdditionalContacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdditionalContact additionalContact = db.AdditionalContact.Find(id);
            if (additionalContact == null)
            {
                return HttpNotFound();
            }
            return View(additionalContact);
        }

        // GET: AdditionalContacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdditionalContacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,OwnerId,FirstName,LastName,PetRelation,PhoneNumber")] AdditionalContact additionalContact)
        {
            if (ModelState.IsValid)
            {
                db.AdditionalContact.Add(additionalContact);
                db.SaveChanges();
                return RedirectToAction("Create", "AdditionalPetInfoes");
            }

            return View(additionalContact);
        }

        // GET: AdditionalContacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdditionalContact additionalContact = db.AdditionalContact.Find(id);
            if (additionalContact == null)
            {
                return HttpNotFound();
            }
            return View(additionalContact);
        }

        // POST: AdditionalContacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,OwnerId,FirstName,LastName,PetRelation,PhoneNumber")] AdditionalContact additionalContact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(additionalContact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(additionalContact);
        }

        // GET: AdditionalContacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdditionalContact additionalContact = db.AdditionalContact.Find(id);
            if (additionalContact == null)
            {
                return HttpNotFound();
            }
            return View(additionalContact);
        }

        // POST: AdditionalContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdditionalContact additionalContact = db.AdditionalContact.Find(id);
            db.AdditionalContact.Remove(additionalContact);
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
