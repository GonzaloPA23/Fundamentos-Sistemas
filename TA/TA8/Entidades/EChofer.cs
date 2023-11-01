using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EChofer
    {
        public EChofer() { }    
        public int Id { get; set; }
        public String Dni { get; set; }
        public String NombreCompleto { get; set; }
        public String Celular { get; set; }
        public String Correo { get; set; }
        public String FechaRegistro { get; set; } // se autogenera en la base de datos
    }
}
