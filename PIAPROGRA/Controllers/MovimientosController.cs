using BL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PIApruebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientosController : ControllerBase
    {
        private readonly string Cadena;

        public MovimientosController(IConfiguration Config)
        {
            Cadena = Config.GetConnectionString("PROD");
        }

        [HttpPost]
        [Route("HacerCompra")]
        public IActionResult HacerCompra([FromBody] COMPRA Movimiento)
        {
            List<string> lstValidacion = BL_MOVIMIENTO.HacerCompra(Cadena, Movimiento);

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
        [Route("HacerVenta")]
        public IActionResult HacerVenta([FromBody] VENTA Movimiento)
        {
            List<string> lstValidacion = BL_MOVIMIENTO.HacerVenta(Cadena, Movimiento);

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
