using Microsoft.AspNetCore.Mvc;
using System;

namespace HNGPublicAPI.Controllers
{
    [ApiController]
    [Route("api/info")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            var response = new
            {
                email = "imaesty0016@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("o"), 
                github_url = "https://github.com/SamB-ima/PublicInfoAPI" 
            };

            return Ok(response);
        }
    }
}
