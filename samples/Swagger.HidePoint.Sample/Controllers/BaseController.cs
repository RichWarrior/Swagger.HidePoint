using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Swagger.HidePoint.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public static List<string> dummyDatas = new List<string>()
        {
            "Renesmee Page",
            "Suraj Nolan",
            "Rickie Yates"
        };
    }
}
