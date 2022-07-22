using EjemplosRESTful.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EjemplosRESTful.Controllers
{
    [Route("api/ejemplo2")]
    public class Ejemplo2Controller : Controller
    {
        [Produces("application/json")]
        [HttpGet("prueba1")]
        public async Task<IActionResult> prueba1()
        {
            try
            {
                Producto producto = new Producto() { 
                    id = "abc-001",
                    nombre = "Atun",
                    precio = 14.5
                };
                return Ok(producto);
            }
            catch
            {
                return BadRequest();
            }

        }
        [Produces("application/json")]
        [HttpGet("prueba2")]
        public async Task<IActionResult> prueba2()
        {
            try
            {
                List<Producto> productos = new List<Producto>() {
                new Producto()
                {
                    id = "abc-001",
                    nombre = "Atun",
                    precio = 14.5
                },
                new Producto()
                {
                    id = "abc-002",
                    nombre = "Fideo",
                    precio = 5
                },
                new Producto()
                {
                    id = "xyz-007",
                    nombre = "Leche deslactosadas",
                    precio = 25
                }
                };
                return Ok(productos);
            }
            catch
            {
                return BadRequest();
            }

        }
    }
}
