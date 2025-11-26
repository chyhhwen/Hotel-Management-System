using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_System.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string showhello()
        {
            return "sd";
        }

        [HttpGet]
        public string showprice(string product = "未知商品", int? price = null)
        {
            return $"商品是:{product}，價格是:{price}";
        }

    }
}