using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BL;
using DTO;

namespace PIApruebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly string Cadena;

        public UsuarioController(IConfiguration Config)
        {
            Cadena = Config.GetConnectionString("PROD");
        }

        [HttpGet]
        [Route("ConsultarUsuarios")]
        public IActionResult ConsultarUsuarios() 
        {
            List<ConsultarUSUARIO> lstUsuarios = BL_USUARIO.Consultar(Cadena);

            if (lstUsuarios.Count > 0)
            {
                return StatusCode(StatusCodes.Status200OK, lstUsuarios);
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest, null);
            }
        }
    }
}
