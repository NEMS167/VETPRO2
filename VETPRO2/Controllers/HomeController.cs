using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VETPRO2.Models;

namespace VETPRO2.Controllers
{
    public class HomeController : Controller
    {
        private VetContext db = new VetContext();

        public ActionResult StartPage()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CompositeModel model)
        {
            if (ModelState.IsValid)
            {
                model.AnimalInfo.AnimalId = Guid.NewGuid().ToString();
                db.AnimalInfo.Add(model.AnimalInfo);
                db.AnimalBehavior.Add(model.AnimalBehavior);
                db.AnimalHistory.Add(model.AnimalHistory);
                db.AdditonalPetInfo.Add(model.AdditionalPetInfo);
                db.ChipIdentification.Add(model.ChipIdentification);
                db.SaveChanges();
                return RedirectToAction("Index", "AnimalInfoes");
            }

            throw new Exception("My Model state is not valid");
        }
    }
}