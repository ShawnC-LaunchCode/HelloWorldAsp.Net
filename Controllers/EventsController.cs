using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAsp.Net.Controllers
{
    public class EventsController : Controller
    {
        static private List<string> Events = new List<string>();

        [HttpGet]
        public IActionResult Index()
        {
            Events.Add("Strange Loop");
            Events.Add("Grace Hopper");
            Events.Add("Code with Pride");
            ViewBag.events = Events;

            return View();
        }
    }
}
