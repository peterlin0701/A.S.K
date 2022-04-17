using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASK.AspNetCoreRoute.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        //TODO: (5)請讓以下網址可以正常運作 http://localhost:5179/api/Course/id/1
        [HttpGet("id/{id=1}")]
        public IActionResult Get(int id)
        {
            return new JsonResult(new { message = "Congratulations on completing an assignment" });
        }
    }
}
