using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Web.Ej1;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ControllerEj1 : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<string> names)
    {
        var person1 = new Person(names[0]);
        var person2 = new Person(names[1]);
        var person3 = new Person(names[2]);

        List<Person> personas = new List<Person> { person1, person2, person3};

        var saludos = personas.Select(persona => persona.GetSaludo()).ToList();


    
        return Ok(saludos);
    }
}
