using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        // Calls the controller's View method.
        //Controller methods are referred to as action methods 
        public IActionResult Index()
        {
            return View();
        }

        // 

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}


//every public method in a controller is callable as an HTTP endpoint 

//An HTTP endpoint: Is a targetable URL in the web applicaiton 