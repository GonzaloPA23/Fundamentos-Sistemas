using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        public int Id { get; set; }
        public Rol ObjRol { get; set; }
        public String NombreMenu { get; set; }
    }
}
