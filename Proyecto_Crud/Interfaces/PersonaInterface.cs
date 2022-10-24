using Proyecto_Crud.Models;
using Proyecto_Crud.Models.Request;

namespace Proyecto_Crud.Interfaces
{
    public interface PersonaInterface
    {
        public IQueryable<Personas> GetAll();
        //Para obtener la LISTA de personas
        public void Add(PersonaRequest request);
        //Para AGREGAR personas
    }
}
