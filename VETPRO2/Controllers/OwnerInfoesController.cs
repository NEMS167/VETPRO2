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
    public class OwnerInfoesController : Controller
    {
        private VetContext db = new VetContext();

        // GET: OwnerInfoes
        public ActionResult Index()
        {
            return View(db.OwnerInfos.ToList());
        }

        // GET: OwnerInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnerInfo ownerInfo = db.OwnerInfos.Find(id);
            if (ownerInfo == null)
            {
                return HttpNotFound();
            }
            return View(ownerInfo);
        }

        // GET: OwnerInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OwnerInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OwnerId,FirstName,LastName,HomeAddress,City,State,County,ZipCode,HomePhone,CellPhone,DriversLicenseNumber,HumanEvacNumber,Email")] OwnerInfo ownerInfo)
        {
            if (ModelState.IsValid)
            {
                db.OwnerInfos.Add(ownerInfo);
                db.SaveChanges();
                return RedirectToAction("Create", "AnimalInfoes");
            }

            return View(ownerInfo);
        }

        // GET: OwnerInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnerInfo ownerInfo = db.OwnerInfos.Find(id);
            if (ownerInfo == null)
            {
                return HttpNotFound();
            }
            return View(ownerInfo);
        }

        // POST: OwnerInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OwnerId,FirstName,LastName,HomeAddress,City,State,County,ZipCode,HomePhone,CellPhone,DriversLicenseNumber,HumanEvacNumber,Email")] OwnerInfo ownerInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ownerInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ownerInfo);
        }

        // GET: OwnerInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnerInfo ownerInfo = db.OwnerInfos.Find(id);
            if (ownerInfo == null)
            {
                return HttpNotFound();
            }
            return View(ownerInfo);
        }

        // POST: OwnerInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OwnerInfo ownerInfo = db.OwnerInfos.Find(id);
            db.OwnerInfos.Remove(ownerInfo);
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
