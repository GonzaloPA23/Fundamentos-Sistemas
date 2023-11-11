using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class NUsuario
    {
        private DUsuario dUsuario = new DUsuario();
        public List<Usuario> ListarUsuarios()
        {
            return dUsuario.ListarUsuarios();
        }
    }
}
