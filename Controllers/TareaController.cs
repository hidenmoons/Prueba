using Microsoft.AspNetCore.Mvc;
using webapi.Services;
using webapi.Models;
namespace webapi.Controllers;

[Route("api/[controller]")]

public class TareaController : ControllerBase
{
    ITareaServic tareasService;

    public TareaController( ITareaServic service)
    {
        tareasService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(tareasService.Get());
    }
}