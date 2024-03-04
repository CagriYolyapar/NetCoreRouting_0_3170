using Microsoft.AspNetCore.Mvc;

namespace NetCoreRouting_0.Controllers
{
    public class SimulationController : Controller
    {
        public IActionResult SimulationIndex()
        {
            return View();
        }
    }
}
