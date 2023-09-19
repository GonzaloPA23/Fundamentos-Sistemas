using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA5.entities
{
    internal class Personaje
    {
        public Personaje() { }
        public String Codigo { get; set; }
        public String NombrePersonaje { get; set; }
        public String NombreActor { get; set; }
        public String Genero { get; set; }
        public int MinutosAparicion { get; set; }
    }
}
