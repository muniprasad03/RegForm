using RegForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace RegForm.Controllers
{
    public class HomeController : Controller
    {
        RegDbContext reg = new RegDbContext();
        public ActionResult Index()
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
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterModel registerModel)
        {
            reg.registerModels.Add(registerModel);
            reg.SaveChanges();
            return View();
        }

        public ActionResult List()
        {
            RegDbContext entities = new RegDbContext();
            return View(from customer in entities.registerModels.Take(10)
                        select customer);
        }
    }
}