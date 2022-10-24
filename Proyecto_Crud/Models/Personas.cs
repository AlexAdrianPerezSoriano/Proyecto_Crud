using Proyecto_Crud.Data;
using System;
using System.Collections.Generic;

namespace Proyecto_Crud.Models
{
    public partial class Personas
    {
        public Personas(DataContext Persona1)
        {
            Persona1 = new HashSet<Personas>();
        }

        public int IdPersona { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<Personas> Persona { get; set; }
        public virtual Personas? IdPersonaNavigation { get; set; }
    }
}
