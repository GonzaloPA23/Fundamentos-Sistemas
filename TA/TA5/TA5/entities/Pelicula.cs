using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA5.entities
{
    internal class Pelicula
    {
        public Pelicula() { }
        public String Codigo { get; set; }
        public String Pais { get; set; }
        public String Nombre { get; set; }
        public String Genero { get; set; }
        public int DuracionMinutos { get; set; }
        public List<Personaje> Personajes { get; set; }
    }
}
