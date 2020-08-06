using Microsoft.AspNetCore.Mvc;
using Swagger.HidePoint.Attributes;
using System.Linq;

namespace Swagger.HidePoint.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Hide]
    public class CustomerController : BaseController
    {
        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            return new JsonResult(dummyDatas);
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get(int id)
        {
            return new JsonResult(dummyDatas.FirstOrDefault());
        }
    }
}
