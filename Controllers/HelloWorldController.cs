using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController: ControllerBase{

//private readonly ILogger<HelloWorldController> _logger;
IHelloWorldService helloWorldService;

public HelloWorldController(IHelloWorldService helloWorld)
{
    helloWorldService = helloWorld;

}
[HttpGet]
public IActionResult Get()
{
   // _logger.LogInformation("Retornando hello world");
    return Ok(helloWorldService.GetHelloWorld());
}

}