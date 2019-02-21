using StarWarsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionDesWookies.Controllers
{
    public class DroideController : Controller
    {
        private DroideDataLayer _dataLayer = new DroideDataLayer();

        // GET: Droide
        public ActionResult Index()
        {
            return View(this._dataLayer.SelectAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            this.SetModeleList();

            return this.View();
        }

        [HttpPost]
        public ActionResult Create(Droide droide)
        {
            this._dataLayer.Add(droide);

            this.SetModeleList();
            return this.View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            this.SetModeleList();

            Droide droide = this._dataLayer.SelectOne(id);

            return this.View(droide);
        }

        [HttpPost]
        public ActionResult Edit(Droide droide)
        {
            this._dataLayer.Edit(droide);

            this.SetModeleList();
            return this.View(droide);
        }

        private void SetModeleList()
        {
            this.ViewBag.ListeModele = (new ModeleDataLayer()).SelectAll();
        }
    }
}