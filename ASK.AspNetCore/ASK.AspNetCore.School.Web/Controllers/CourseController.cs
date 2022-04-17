using ASK.AspNetCore.School.Web.Datas;
using ASK.AspNetCore.School.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASK.AspNetCore.School.Web.Controllers
{
    public class CourseController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(CourseRepository.GetList());
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View(CourseRepository.Get(1));
        }

        [HttpPost]
        public IActionResult Edit(Course model)
        {
            if(ModelState.IsValid)
            {
                return View(model);
            }

            return View(CourseRepository.Get(1));
        }

        [HttpGet]

        public IActionResult Details()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Delete()
        {
            return RedirectToAction("Index");
        }

        public string GetMessage()
        {
            return string.Empty;
        }
    }
}
