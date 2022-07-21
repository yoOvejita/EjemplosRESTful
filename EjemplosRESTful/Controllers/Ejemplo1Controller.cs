using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EjemplosRESTful.Controllers
{
    [Route("api/ejemplo1")]
    public class Ejemplo1Controller : Controller
    {
        [HttpGet("prueba1")]
        public async Task<IActionResult> prueba1()
        {
            try
            {
                return Ok("Esta es una prueba.");
            }
            catch
            {
                return BadRequest();
            }
            
        }

        [Produces("text/html")] //revisar
        [HttpGet("prueba2")]
        public async Task<IActionResult> prueba2()
        {
            try
            {
                return Ok("<h3><b><i>Esta es una prueba grande.</i></b></h3>");
            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("prueba3/{val}")]
        public async Task<IActionResult> prueba3(string val)
        {
            try
            {
                return Ok("Buenas noches señor " + val);
            }
            catch
            {
                return BadRequest();
            }

        }

    }
}
