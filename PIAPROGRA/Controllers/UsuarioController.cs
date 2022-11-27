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
        [HttpPost]
        [Route("AgregarUsuario")]
        public IActionResult AgregarUsuario([FromBody] AgregarUSUARIO Usuario)
        {
            List<string> lstValidacion = BL_USUARIO.AgregarUsuario(Cadena, Usuario);

            if (lstValidacion[0] == "00")
            {
                return StatusCode(StatusCodes.Status200OK, "ok");
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, null);
            }

        }

        [HttpPut]
        [Route("ModificarUsuario")]
        public IActionResult ModificarUsuario([FromBody] ModificarUSUARIO Usuario)
        {
            List<string> lstValidacion = BL_USUARIO.ModificarUsuario(Cadena,Usuario);

            if (lstValidacion[0] == "00")
            {
                return StatusCode(StatusCodes.Status200OK, "ok");
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest, null);
            }
        }

        [HttpPut]
        [Route("DeshabilitarUsuario/{id:int}")]
        public IActionResult DeshabilitarUsuario(int id)
        {
            List<string> lstValidacion = BL_USUARIO.DeshabilitarUsuario(Cadena, id);

            if (lstValidacion[0] == "00")
            {
                return StatusCode(StatusCodes.Status200OK, "ok");
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest, null);
            }
        }
    }
}
