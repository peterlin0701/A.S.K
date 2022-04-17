using Microsoft.AspNetCore.Mvc;

namespace ASK.AspNetCoreRoute.Controllers
{
    public class HomeController : Controller
    {
        private readonly RouteConfig _routeConfig;

        public HomeController(RouteConfig routeConfig)
        {
            _routeConfig = routeConfig;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
