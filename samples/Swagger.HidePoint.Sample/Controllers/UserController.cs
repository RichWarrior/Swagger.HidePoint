using Microsoft.AspNetCore.Mvc;
using Swagger.HidePoint.Attributes;
using System.Linq;

namespace Swagger.HidePoint.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        [HttpGet("GetList")]
        //[Hide]
        public IActionResult GetList()
        {
            return new JsonResult(dummyDatas);
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            return new JsonResult(dummyDatas.FirstOrDefault());
        }
        
    }
}
