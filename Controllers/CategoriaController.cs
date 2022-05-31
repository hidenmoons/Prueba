using Microsoft.AspNetCore.Mvc;
using webapi.Services;
using webapi.Models;
namespace webapi.Controllers;

[Route("api/[controller]")]
public class CategoriaController: ControllerBase
{
    ICategoriaService categoriaService;

    public CategoriaController( ICategoriaService service)
    {
        categoriaService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(categoriaService.Get());
    }
    [HttpPost]
    public IActionResult Post([FromBody] Categoria categoria)
    {
        return Ok(categoriaService.Save(categoria));
    }
     [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] Categoria categoria)
    {
        return Ok(categoriaService.Update(id,categoria));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        categoriaService.Delete(id);
        return Ok();
    }

}