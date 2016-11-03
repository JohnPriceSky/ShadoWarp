using ShadoWarp.Models;
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
            AnkietaModelView m = new AnkietaModelView(Request["ilelat"]);
            ViewBag.Title = "Wynik";
            return View(m);
        }
        //GET: News
        public ActionResult News()
        {
            ViewBag.Title = "News";
            return View();
        }
        //GET: About
        public ActionResult About()
        {
            ViewBag.Title = "O autorze";
            return View();
        }
        //GET: LogIn
        public ActionResult LogIn()
        {
            ViewBag.Title = "Zaloguj się";
            return View();
        }
    }
}