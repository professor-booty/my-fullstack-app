public class TaskService : ITaskService
{
  public IEnumerable<TaskItem> GetAllTasks()
  {
    return new List<TaskItem>
    {
      new TaskItem {
        Id = 1,
        Title = "First task",
        IsComplete = false
      }
    };
  }
}