using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SimpleAngularMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleAngularMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", "", GetTalks());
        }

        private string GetTalks()
        {
            var talks = new[] {
                new Talks { Id = 1001, Name = "Real Time Web Applications with SignalR", Speaker = "Sean You", Venue = "Hall 101", Duration = "45m" },
                new Talks { Id = 1002, Name = "Power of Node.js", Speaker = "Earnest Hemington", Venue = "Hall 102", Duration = "45m" },
                new Talks { Id = 1003, Name = "Getting started with AngularJS", Speaker = "Monte Vista", Venue = "Hall 103", Duration = "60m" },
                new Talks { Id = 1004, Name = "Microsoft Azure - Your cloud destination", Speaker = "Gaurav mantri", Venue = "Hall 104", Duration = "45m" }
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(talks, Formatting.None, settings);
        }

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