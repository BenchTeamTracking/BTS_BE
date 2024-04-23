using BTS_BE.Controllers.Api;
using Microsoft.AspNetCore.Mvc;

namespace BTS_BE.Controllers
{
    public class AttendanceController: BaseApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
