using System.Net;

public class LoggingMiddleware
{
  private readonly RequestDelegate _next;

  public LoggingMiddleware(RequestDelegate next) => _next = next;

  public async Task InvokeAsync(HttpContext context)
  {
    Console.WriteLine($"Incoming request: {context.Request.Method} {context.Request.Path}");
    await _next(context);
  }
}