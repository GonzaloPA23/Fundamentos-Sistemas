using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC1.Modelos
{
    internal class Viaje
    {
        public Viaje() { }
        public String Codigo { get; set; }
        public String Destino { get;set; }
        public String FechaSalida { get; set; }
        public String FechaRegreso { get; set; }
        public double Precio { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
