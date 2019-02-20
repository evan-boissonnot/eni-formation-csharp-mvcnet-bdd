using StarWarsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionDesWookies.Controllers
{
    public class PlaneteController : Controller
    {
        // GET: Plaenete
        public ActionResult Index()
        {
            return View();
        }

        // GET: Plaenete/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Plaenete/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plaenete/Create
        [HttpPost]
        public ActionResult Create(Planete planete)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Plaenete/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Plaenete/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Plaenete/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Plaenete/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
