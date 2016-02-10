using OnlineShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public JsonResult GetDealPrice(int? productId)
        {
            var product = new Product { ProductId = 1, Name = "ProductName", Price = 10.40m };
            return Json(25);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}