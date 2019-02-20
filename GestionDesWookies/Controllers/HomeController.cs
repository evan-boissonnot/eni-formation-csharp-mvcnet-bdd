using StarWarsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionDesWookies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Wookie> list = (new WookieDataLayer()).SelectAll();

            this.ViewBag.MesWookies = list;

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
    }
}