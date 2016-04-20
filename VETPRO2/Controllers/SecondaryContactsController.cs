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
    public class SecondaryContactsController : Controller
    {
        private VetContext db = new VetContext();

        // GET: SecondaryContacts
        public ActionResult Index()
        {
            return View(db.SecondaryContacts.ToList());
        }

        // GET: SecondaryContacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondaryContact secondaryContact = db.SecondaryContacts.Find(id);
            if (secondaryContact == null)
            {
                return HttpNotFound();
            }
            return View(secondaryContact);
        }

        // GET: SecondaryContacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecondaryContacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,OwnerId,FirstName,LastName,HomeAddress,City,State,ZipCode,HomePhone,CellPhone,DriversLicenseNumber,HumanEvacNumber")] SecondaryContact secondaryContact)
        {
            if (ModelState.IsValid)
            {
                db.SecondaryContacts.Add(secondaryContact);
                db.SaveChanges();
                return RedirectToAction("Create", "AdditionalContacts");
            }

            return View(secondaryContact);
        }

        // GET: SecondaryContacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondaryContact secondaryContact = db.SecondaryContacts.Find(id);
            if (secondaryContact == null)
            {
                return HttpNotFound();
            }
            return View(secondaryContact);
        }

        // POST: SecondaryContacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,OwnerId,FirstName,LastName,HomeAddress,City,State,ZipCode,HomePhone,CellPhone,DriversLicenseNumber,HumanEvacNumber")] SecondaryContact secondaryContact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(secondaryContact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(secondaryContact);
        }

        // GET: SecondaryContacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondaryContact secondaryContact = db.SecondaryContacts.Find(id);
            if (secondaryContact == null)
            {
                return HttpNotFound();
            }
            return View(secondaryContact);
        }

        // POST: SecondaryContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SecondaryContact secondaryContact = db.SecondaryContacts.Find(id);
            db.SecondaryContacts.Remove(secondaryContact);
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
