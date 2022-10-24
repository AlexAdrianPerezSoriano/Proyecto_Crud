using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Proyecto_Crud.Data;
using Proyecto_Crud.Models;
using Proyecto_Crud.Models.Request;

namespace Proyecto_Crud.Interfaces
{
    public class PersonaMetodos : PersonaInterface
    {
        private readonly DataContext _context;
        public PersonaMetodos(DataContext context)
        {
            _context = context;
        }
        public void Add(PersonaRequest request)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Personas> GetAll()
        {
            return _context.Personas.Include(
                Personas => Personas.Personas.ICollection).OrderByDescending(
                Personas1 => Personas1.Personas.IdPersona);
        }
        //AGREGAR PERSONAS


        //LISTAR PERSONAS
    }
}
