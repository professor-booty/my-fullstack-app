using Microsoft.AspNetCore.Mvc;

namespace backend_controllers.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GreetingController : ControllerBase
{    
  [HttpGet]
  public IActionResult GetGreeting()
  {
    return Ok(new { message = "Welcome to ASP.NET Core API!" });
  }
}
