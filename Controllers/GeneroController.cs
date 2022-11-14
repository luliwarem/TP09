using Microsoft.AspNetCore.Mvc;
using TP09_Szmedra_Waremkraut.Models;
namespace TP09_Szmedra_Waremkraut.Controllers;

[ApiController]
[Route("[controller]")]

public class GeneroController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<Genero> lista = BD.ObtenerGenero();
        return Ok(lista);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id){
        
        if(id < 1){
            return BadRequest();   
        }
        
        Genero g = BD.ObtenerGenero(id);
        
        if(g == null){
            return NotFound();
        }
        
        return Ok(g);
    }

    [HttpDelete("{id}")]

    public IActionResult Delete(int id){

        if(id < 1){
            return BadRequest();   
        }
        
        Genero g = BD.ObtenerGenero(id);

        
        if(g == null){
            return NotFound();
        }

        BD.EliminarGenero(id);

        
        return Ok();

    }
    
    [HttpPost]
    public IActionResult Post(string nombre){
        
        if(nombre == null || nombre == ""){
            return BadRequest();
        }
        
        BD.AgregarGenero(nombre);
        return CreatedAtAction(nameof(Post),null);
    }

    [HttpPut]
    public IActionResult Put(int id, string nombre){
        
        
        if(id < 1){
            return BadRequest();   
        }

        Genero g = BD.ObtenerGenero(id);

        if(g == null){
            return NotFound();
        }
        
        BD.ModificarGenero(id,nombre);

        return Ok();

    }

}
