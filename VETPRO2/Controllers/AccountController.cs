using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VETPRO2.Models;

namespace VETPRO2.Controllers
{
    public class AccountController : Controller
    {
        private VetContext db = new VetContext();
        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Create", "FacilityCompositeModel");
            }
    }
        public ActionResult Index()
        {
            return View(db.UserAccount.ToList());
        }
        // GET: Account
        public ActionResult Login2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login2(UserAccount userAccount)
        {
            var user = db.UserAccount
                .FirstOrDefault(u => u.Username == userAccount.Username && u.Password == userAccount.Password);
            if (user != null)
            {
                Session["UserId"] = user.UserId;
                Session["Username"] = user.Username;
                return RedirectToAction("Create", "FacilityCompositeModel");
            }
            else
            {
                ModelState.AddModelError("", "Username or Password is wrong.");
            }
            return View();
        }

        public ActionResult Register2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register2(UserAccount userAccount)
        {
            if (ModelState.IsValid)
            {
                userAccount.UserId = Guid.NewGuid().ToString();
                db.UserAccount.Add(userAccount);
                db.SaveChanges();
                return RedirectToAction("Login2");
            }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Register2", "Account");
        }
    }
}