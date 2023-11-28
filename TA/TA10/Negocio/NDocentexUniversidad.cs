using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NDocentexUniversidad
    {
        private DDocentexUniversidad dDocentexUniversidad = new DDocentexUniversidad();
        public String Asignar(DocentexUniversidad docentexUniversidad)
        {
            return dDocentexUniversidad.Asignar(docentexUniversidad);
        }

        public List<DocentexUniversidad> ListarTodo()
        {
            return dDocentexUniversidad.ListarTodo();
        }
    }
}
