﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionDesWookies.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Login(string email)
        {
            return View();
        }
    }
}