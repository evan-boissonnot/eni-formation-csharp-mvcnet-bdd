using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAspnetLog4Net
{
    public class MyLogger
    {

        public static void Log(string message)
        {
            var type = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;

            LogManager.GetLogger(type)
                      .Error(message);
        }

       
    }
}