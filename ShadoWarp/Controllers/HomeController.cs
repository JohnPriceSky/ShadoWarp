using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShadoWarp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Mother of Guitars";
            return View();
        }
        //POST: Home/Ankieta
        [HttpPost]
        public ActionResult Ankieta()
        {
            ViewBag.Title = "Wynik";
            return View();
        }
    }
}