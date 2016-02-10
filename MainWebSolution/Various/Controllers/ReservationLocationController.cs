using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Various.Models;

namespace Various.Controllers
{
    public class ReservationLocationController : Controller
    {
        // GET: CityAndState
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reservation(ReservationLocation pos)
        {
            if (this.HttpContext.Request.RequestType == "POST")
                System.Diagnostics.Debug.Write("xxxxx");
            return View(pos);
        }
    }
}