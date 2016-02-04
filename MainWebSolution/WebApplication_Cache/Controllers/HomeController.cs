using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace WebApplication_Cache.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Location=OutputCacheLocation.Any, SqlDependency=]
        public ActionResult DownloadVideo()
        {

        }
    }
}