using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionDesWookies.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Start(int nbWookies, int nbDroides, string nomPlanete)
        {
            return this.View();
        }
    }
}