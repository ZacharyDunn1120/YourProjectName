using Microsoft.AspNetCore.Mvc;

namespace YourProjectName.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var response = new { name = "Zachary Dunn" }; 
            return Ok(response);
        }
    }
}
