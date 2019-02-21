using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace GestionDesWookies.Constraints
{
    public class ValidationNombreConstraint : IRouteConstraint
    {


        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            bool isValid = false;
            string maValeur = values[parameterName].ToString();
            int resultat = 0;

            if (int.TryParse(maValeur, out resultat))
            {
                if (parameterName == "nbWookies")
                {
                    isValid = resultat >= 50 && resultat < 1000;
                }
                else if (parameterName == "NbDroides")
                {
                    isValid = resultat > 1000;
                }
            }

            return isValid;
        }
    }
}