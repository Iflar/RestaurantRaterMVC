using ResturantRaterMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResturantRaterMVC.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDbContex _db = new RestaurantDbContex();

        // GET: Restaurant/Index
        public ActionResult Index()
        {
            return View(_db.Restaurants.ToList());
        }


    }
}