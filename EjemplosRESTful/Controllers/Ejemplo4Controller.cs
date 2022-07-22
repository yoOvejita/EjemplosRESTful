using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace EjemplosRESTful.Controllers
{
    [Route("api/ejemplo4")]
    [ApiController]
    public class Ejemplo4Controller : ControllerBase
    {
        [HttpPost("prueba1")]
        public async Task<IActionResult> prueba1(IFormFile archivo)
        {
            try
            {
                var ruta = Path.Combine(Directory.GetCurrentDirectory(), "imagenes", archivo.FileName);
                var stream = new FileStream(ruta, FileMode.Create);
                archivo.CopyToAsync(stream);
                return Ok(new { nombre = archivo.FileName, longitud = archivo.Length});
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpPost("prueba2")]
        public async Task<IActionResult> prueba2(List<IFormFile> archivos)
        {
            try
            {
                //var res = new List<>();
                foreach (IFormFile archivo in archivos) {
                    var ruta = Path.Combine(Directory.GetCurrentDirectory(), "imagenes", archivo.FileName);
                    var stream = new FileStream(ruta, FileMode.Create);
                    archivo.CopyToAsync(stream);
                }
                
                return Ok("ok");
            }
            catch
            {
                return BadRequest();
            }

        }
    }

}
