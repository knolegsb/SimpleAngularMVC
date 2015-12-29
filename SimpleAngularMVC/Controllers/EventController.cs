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
    public class EventController : Controller
    {
        TalkRepository talkRepo = new TalkRepository();
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTalkDetails()
        {
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(talkRepo.GetTalks(), settings),
                ContentType = "application/json"
            };
            return jsonResult;
        }

        public ActionResult GetSpeakerDetails()
        {
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(talkRepo.GetSpeakers(), settings),
                ContentType = "application/json"
            };
            return jsonResult;
        }
    }
}