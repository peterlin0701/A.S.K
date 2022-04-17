using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASK.AspNetCoreRoute.Controllers.API
{
    //TODO: (4) 請讓以下網址可以正常運作 http://localhost:5179/api/Product/Detail
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("Detail")]
        public IActionResult Get()
        {
            return new JsonResult(new { message = "Congratulations on completing an assignment" });
        }
    }
}
