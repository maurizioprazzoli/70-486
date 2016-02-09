using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Various.Controllers
{
    public class BagelController : Controller
    {
        public string GetBagel(string bagelName)
        {
            return "GetBagel";
        }

        public string Test(string bagelName)
        {
            return "Test";
        }
    }
}