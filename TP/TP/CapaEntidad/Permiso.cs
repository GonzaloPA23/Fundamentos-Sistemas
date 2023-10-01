using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Permiso
    {
        public int Id { get; set; }
        public Rol ObjRol { get; set; }
        public string NombreMenu { get; set; }
    }
}
