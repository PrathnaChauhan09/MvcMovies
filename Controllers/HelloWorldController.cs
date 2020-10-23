using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovies.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //Get : /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //
        //Get : /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["message"] = "Hello " + name+",";
            ViewData["numTimes"] = numTimes;

            return View();
        }
    }
}
