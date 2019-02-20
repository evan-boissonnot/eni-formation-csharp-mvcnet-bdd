using StarWarsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionDesWookies.Controllers
{
    public class WookieController : Controller
    {
        // GET: Wookie
        public ActionResult Index()
        {
            List<Wookie> list = (new WookieDataLayer()).SelectAll();

            return View(list);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(Planete wookie)
        {
            return this.View();
        }
    }
}