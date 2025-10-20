using System.Data.Common;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
  private readonly ITaskService _taskService;

  public TaskController(ITaskService taskService)
  {
    _taskService = taskService;
  }

  [HttpGet]
  public IActionResult GetAll()
  {
    return Ok(_taskService.GetAllTasks());
  }
}
