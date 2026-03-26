using Microsoft.AspNetCore.Mvc;

namespace VersionControlAPI.Controllers
{

        [ApiController]
        [Route("api/[controller]")]
        public class NameController :ControllerBase
        {
            [HttpGet]
            public IActionResult Get()
            {
                return Ok(new
                {
                    name = "Nicole Cortes Wright"
                });
            }

        }


    
}
