using System;
using System.Collections.Generic;

namespace Proyecto_Crud.Models
{
    public partial class Usuario
    {
        public int? IdPersona { get; set; }
        public int IdUsuario { get; set; }
        public string? Usuario1 { get; set; }
        //Usuario 1 porque la clase se llama usuario
        public string? Clave { get; set; }
        public string? Estado { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}
