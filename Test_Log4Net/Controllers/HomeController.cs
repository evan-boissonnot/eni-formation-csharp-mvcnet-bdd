using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_Log4Net.Controllers
{
    public class HomeController : Controller
    {
        private ILog _logger = LogManager.GetLogger(typeof(HomeController));

        protected override void OnException(ExceptionContext filterContext)
        {

            this._logger.Error("Ah  au secours");
            base.OnException(filterContext);
        }

        public ActionResult Index()
        {
            throw new Exception();

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