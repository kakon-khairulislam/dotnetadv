using labtask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labtask1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult welcome()
        {
            ViewBag.CompanyName = "Fidelity Investments";
            ViewBag.shortinfo = "Your fund is safe with us";
            return View();
        }
        public ActionResult aboutus()
        {
            return View(); 
        }
        public ActionResult teamandmembers()
        {
            var e1 = new Models.teamandmembers()
            {
                Position = "CEO",
                Name = "Mr. Donald Krump",
                Salary = "2000$"

            };
            var e2 = new Models.teamandmembers()
            {
                Position = "Manager",
                Name = "Sheikh Lasina",
                Salary = "500$"
            };
            var e3 = new teamandmembers()
            {
                Position = "Intern",
                Name = "Naren Modi",
                Salary = "50$"
            };
            teamandmembers[] eds = new teamandmembers[] { e1, e2, e3 };

            return View(eds);
        }
        public ActionResult contactus()
        {
            return View();
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
        [HttpGet]
        public ActionResult login()
        {
            //ViewBag.Name = Request["Username"];
            return View();
        }
        [HttpPost]
        public ActionResult login(string Username, string Password)
        {
            //ViewBag.Name = form["Username"];
            ViewBag.Name = Username;
            return View();
        }
        [HttpGet]
        public ActionResult signUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signUp(User u)
        {

            var test = u.Dob.Date.ToString("yyyy-MM-dd");
            if (ModelState.IsValid)
            {
                return RedirectToAction("login");
            }
            return View(u);
        }
    }

    
}