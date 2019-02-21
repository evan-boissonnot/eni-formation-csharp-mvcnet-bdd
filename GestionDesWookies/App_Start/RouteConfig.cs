using GestionDesWookies.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GestionDesWookies
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "LancerJeu",
                url: "lancer-jeu/{nbWookies}/{nbDroides}/{nomPlanete}",
                defaults: new { controller = "Game", action = "Start" },
                constraints: new { nbWookies =  new ValidationNombreConstraint(),
                                   nbDroides = new ValidationNombreConstraint() }
            );

            routes.MapRoute(
                name: "Login",
                url: "se-logger/{email}/{password}",
                defaults: new { controller = "Player", action = "Login" },
                //constraints: new { email = @".{5}$", password = @"[A-Z].{4}$" }
                constraints: new { email = new MaSuperConstraint() }
            );

            routes.MapRoute(
                name: "ListeDesDroides",
                url: "liste/droides",
                defaults: new { controller = "Droide", action = "Index" }
            );

            routes.MapRoute(
                name: "EditionDroide",
                url: "edition-droide/{id}",
                defaults: new { controller = "Droide", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
