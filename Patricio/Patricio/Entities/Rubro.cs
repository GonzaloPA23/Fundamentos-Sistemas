using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patricio.Entities
{
    class Rubro
    {
        public Rubro() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Prioridad { get; set; }
        public List<Empresa> Empresas { get; set; }
    }
}
