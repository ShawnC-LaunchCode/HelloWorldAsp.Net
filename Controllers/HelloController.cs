using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAsp.Net.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("/helloshawn/")]
        public IActionResult Index()
        {
            string html = "<h1> Hello World!!!</h1>";
            return Content(html, "text/html");
        }
        
        [HttpGet]
        [Route("/hello/welcome/{name?}")]
        public IActionResult Welcome(string name = "No Name")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
           

        

    }
}
