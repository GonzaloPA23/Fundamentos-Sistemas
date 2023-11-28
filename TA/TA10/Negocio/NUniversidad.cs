using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class NUniversidad
    {
        private DUniversidad dUniversidad = new DUniversidad();

        public String Registrar(Universidad universidad)
        {
            return dUniversidad.Registrar(universidad);
        }

        public String Modificar(Universidad universidad)
        {
            return dUniversidad.Modificar(universidad);
        }

        public String Eliminar(int id)
        {
            return dUniversidad.Eliminar(id);
        }

        public List<Universidad> ListarTodo()
        {
            return dUniversidad.ListarTodo();
        }
    }
}
