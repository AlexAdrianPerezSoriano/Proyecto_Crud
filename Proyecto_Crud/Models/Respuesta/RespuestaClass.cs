using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Proyecto_Crud.Models.Respuesta
{
    public class RespuestaClass
    {
        public int Exito { get; set; }
        public String Mensaje { get; set; }

        public object Data { get; set; }

        public RespuestaClass()
        {
            this.Exito = 0;
        }
    }
}
