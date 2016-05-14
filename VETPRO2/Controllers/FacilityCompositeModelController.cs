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
    public class FacilityCompositeModelController : Controller
    {
        private VetContext db = new VetContext();

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
        public ActionResult Create(FacilityCompositeModel facilitymodel)
        {
            if (ModelState.IsValid)
            {
                if (Session["UserId"] != null)
                {
                    var g = Session["UserId"];
                    facilitymodel.FacilityInfo.FacilityId = g.ToString();
                    db.FacilityInfo.Add(facilitymodel.FacilityInfo);
                    db.FacilityContact.Add(facilitymodel.FacilityContact);
                    db.FacilitySecondaryContact.Add(facilitymodel.FacilitySecondaryContact);
                    db.FacilityAdditionalInfo.Add(facilitymodel.FacilityAdditionalInfo);
                    db.FacilityCapacity.Add(facilitymodel.FacilityCapacity);
                    db.FacilityOccupancy.Add(facilitymodel.FacilityOccupancy);
                    db.SaveChanges();
                    return RedirectToAction("Details", "FacilityInfoes", new {id = facilitymodel.FacilityInfo.Id});
                }
            }

            throw new Exception("My Model state is not valid");
        }
    }
}