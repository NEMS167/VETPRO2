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

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CompositeModel model)
        {
            if (ModelState.IsValid)
            {
                db.AnimalInfos.Add(model.AnimalInfo);
                db.AnimalHistory.Add(model.AnimalHistory2);
                db.AnimalBehavior.Add(model.AnimalBehavior);
                db.AdditonalPetInfo.Add(model.AdditionalPetInfo);
                db.ChipIdentification.Add(model.ChipIdentification);
                db.SaveChanges();
                return View("Index", model);
            }
            //model.HeaderText = "Strongly typed model used here, no view bag";
            return View(model);
        }

        public ActionResult MyEditActionOne(CompositeModel model)
        {
            if (ModelState.IsValid)
            {
                db.AnimalInfos.Add(model.AnimalInfo);
                db.AnimalHistory.Add(model.AnimalHistory2);
                db.AnimalBehavior.Add(model.AnimalBehavior);
                db.AdditonalPetInfo.Add(model.AdditionalPetInfo);
                db.ChipIdentification.Add(model.ChipIdentification);
                db.SaveChanges();
                return View("Index", model);
            }

            throw new Exception("My Model state is not valid");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}