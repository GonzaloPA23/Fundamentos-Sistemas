using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDocentexUniversidad
    {
        public String Asignar(DocentexUniversidad docentexUniversidad)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.DocentexUniversidad.Add(docentexUniversidad);
                    context.SaveChanges();
                }
                return "Asignado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<DocentexUniversidad> ListarTodo()
        {
            List<DocentexUniversidad> docentexUniversidades = new List<DocentexUniversidad>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    docentexUniversidades = context.DocentexUniversidad.ToList();
                }
                return docentexUniversidades;
            }
            catch (Exception ex)
            {
                return docentexUniversidades;
            }
        }
    }
}
