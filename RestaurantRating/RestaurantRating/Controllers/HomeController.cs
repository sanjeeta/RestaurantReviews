using RestaurantRating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantRating.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RestaurantDBContext db = new RestaurantDBContext();
            db.Restaurants.ToList();
            return View();
        }
    }
}
