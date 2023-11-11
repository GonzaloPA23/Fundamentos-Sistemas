using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DUsuario
    {
        // Constructor vacío
        public DUsuario() { }
        // Metodo para listar los usuarios
        public List<Usuario> ListarUsuarios()
        {
            using(var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Usuario.ToList();
                }
                catch (Exception e)
                {
                    return new List<Usuario>();
                }
            }
        }
    }
}
