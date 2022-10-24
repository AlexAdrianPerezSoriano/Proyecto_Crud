using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Crud.Interfaces;
using Proyecto_Crud.Models.Respuesta;

namespace Proyecto_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly PersonaInterface _persona;
        public PersonaController(PersonaInterface persona)
        {
            this._persona = persona;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            RespuestaClass _respuesta = new RespuestaClass();
            try
            {
                _respuesta.Data = _persona.GetAll();
                _respuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);
        }
    }
}
