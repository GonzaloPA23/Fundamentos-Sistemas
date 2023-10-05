using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public class PermisoCapaNegocio
    {
        private PermisoCapaDatos permisoCapaDatos = new PermisoCapaDatos();
        public List<Permiso> ListarPermisos(int idUsuario)
        {
            return permisoCapaDatos.ListarPermisos(idUsuario);
        }
    }
}
