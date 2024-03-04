using Microsoft.AspNetCore.Mvc;
using NetCoreRouting_0.Models;
using System.Diagnostics;

namespace NetCoreRouting_0.Controllers
{
    //Attribute Based Routing
    [Route("simRoute")] //İcerideki yer tutuculara dikkat ediniz..Unutmayın ki Attribute Based Routing eger Middleware'deki default'ta bir Controller'a denk geliyorsa o sistemi ezer...
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/a/Deneme")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("DDD")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
