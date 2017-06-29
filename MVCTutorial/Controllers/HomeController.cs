using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
       
        //public string Index(string id, string name)
        //{
        //    // return "ID = " + id + "Name = " + Request.QueryString["name"];
        //    return "Id = " + id + "Name = " + name;
        //}

        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "India",
                "U.S.",
                "U.K.",
                "Canada"
            };

            ViewData["Countries"] = new List<string>()
            {
                "India",
                "U.S.",
                "U.K.",
                "Canada"
            };
            return View();
        }

        //public string GetDetails()
        //{
        //    return "Get details invoked!";
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}