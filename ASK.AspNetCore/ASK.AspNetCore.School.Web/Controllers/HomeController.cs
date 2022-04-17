using Microsoft.AspNetCore.Mvc;

namespace ASK.AspNetCore.School.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
