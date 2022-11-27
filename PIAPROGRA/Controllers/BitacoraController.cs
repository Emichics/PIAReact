using BL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PIApruebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BitacoraController : ControllerBase
    {
        private readonly string Cadena;

        public BitacoraController(IConfiguration Config)
        {
            Cadena = Config.GetConnectionString("PROD");
        }

        [HttpPost]
        [Route("EstablecerPCompra")]
        public IActionResult EstablecerPCompra([FromBody] PrecioCompra registro)
        {
            List<string> lstValidacion = BL_BITACORA.EstablecerPCompra(Cadena, registro);

            if (lstValidacion[0] == "00")
            {
                return StatusCode(StatusCodes.Status200OK, "ok");
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, null);
            }

        }
        [HttpPost]
        [Route("EstablecerPVenta")]
        public IActionResult EstablecerPVenta([FromBody] PrecioVenta registro)
        {
            List<string> lstValidacion = BL_BITACORA.EstablecerPVenta(Cadena, registro);

            if (lstValidacion[0] == "00")
            {
                return StatusCode(StatusCodes.Status200OK, "ok");
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, null);
            }

        }
    }
}
