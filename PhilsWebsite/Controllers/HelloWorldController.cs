using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PhilsWebsite.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        //Get: /HelloWorld/Welcome/
        //reuires using System.Text.Encodings.Web;

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello World" + name;
            ViewData["Numtimes"] = numTimes;
            return View();
        }
    }
}
