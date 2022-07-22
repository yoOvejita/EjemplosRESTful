using EjemplosRESTful.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EjemplosRESTful.Controllers
{
    [Route("api/ejemplo3")]
    [ApiController]
    public class Ejemplo3Controller : ControllerBase
    {
        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("prueba1")]
        public async Task<IActionResult> prueba1([FromBody] Producto prod)
        {
            try
            {
                prod.nombre += " [AGOTADO]";
                return Ok(prod);
            }
            catch
            {
                return BadRequest();
            }

        }

        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPut("prueba2")]
        public async Task<IActionResult> prueba2([FromBody] Producto prod)
        {
            try
            {
                prod.nombre += " [OFERTA -20%]";
                return Ok(prod);
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpDelete("prueba3/{id}")]
        public async Task<IActionResult> prueba3(string id)
        {
            try
            {
                //Debug.WriteLine("");
                return Ok(id);
            }
            catch
            {
                return BadRequest();
            }

        }
    }
}
