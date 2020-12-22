using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StatisticsService.API.Controllers
{
    [ApiController, Route("[controller]")]
    public class StatisticsController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }
    }
}