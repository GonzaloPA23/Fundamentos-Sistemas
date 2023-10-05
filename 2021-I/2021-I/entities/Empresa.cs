using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_I.entities
{
    internal class Empresa
    {
        public Empresa() { }

        public String Ruc { get; set; }
        public String Nombre { get; set; }
        public String Celular { get; set; }
        public String Distrito { get; set; }
        public String Direccion { get; set; }
        public DateTime Fecha { get; set; }
        public String Tamanio { get; set; }
        public String Estado { get; set; }
    }
}
