using ADMulkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADMulkey.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About me";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How to Contact Me (Click the images below)";

            return View();
        }

        public ActionResult VisitorsLog()
        {
            ViewBag.Message = "Welcome! Please enter as much of the below information as you can. There are no required fields.";

            void yourButtonId_Click(Object sender, EventArgs e)
            {
                User testUser = new User();
                testUser.firstName = Request.Form["firstName"];
                testUser.lastName = Request.Form["lastName"];
                ViewBag.Message2 = "Welcome " + testUser.firstName + " " + testUser.lastName + ".";
            }

            return View();
        }

        public ActionResult CurrentWorks()
        {
            ViewBag.Message = "Programming is fun! Frustrating at times, but still fun.";

            return View();
        }

        public ActionResult ViewCustomer()
        {
            Customer customer = new Customer();
            customer.iD = Guid.NewGuid().ToString();
            customer.name = "John Smith";
            customer.telephone = "(123) 456-7890";

            return View(customer);
        }
    }//End of class HomeController
}//End of namespace ADMulkey.Controllers