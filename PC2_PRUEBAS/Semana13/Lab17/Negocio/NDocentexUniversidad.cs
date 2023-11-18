using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDocentexUniversidad
    {
        private NDocentexUniversidad nDocentexUniversidad = new NDocentexUniversidad();
        public String Asignar(DocentexUniversidad docentexUniversidad)
        {
            return nDocentexUniversidad.Asignar(docentexUniversidad);
        }

        public List<DocentexUniversidad> ListarTodo()
        {
            return nDocentexUniversidad.ListarTodo();
        }
    }
}
