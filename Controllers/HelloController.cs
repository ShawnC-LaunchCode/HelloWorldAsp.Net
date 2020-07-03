using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAsp.Net.Controllers
{
    [Route("/helloshawn/")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloshawn/'>" + "<input type='text' name='name'/>" + "<input type='submit' value='Greet Me'/>" + "<form/>";
            return Content(html, "text/html");
        }
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "No Name")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
           

        

    }
}
