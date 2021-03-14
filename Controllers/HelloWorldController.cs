using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: URL base/HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: URL base/HelloWorld/Welcome/ 

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        [Route("bienvenido/{name}")]
        public IActionResult OtroWelcome (string name, int numTimes = 1){
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View("Welcome");
        }
    }
}