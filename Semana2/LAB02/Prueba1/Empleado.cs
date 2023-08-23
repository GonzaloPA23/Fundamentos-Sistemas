using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    class Empleado
    {
        public Empleado() { }
        public Empleado(String nombre, String categoria,int minutosTardanza, int llamadasAtencion) {
            Nombre = nombre;
            Categoria = categoria;
            LlamadasAtencion = llamadasAtencion;
        }
        public String Nombre { get; set; }
        public String Categoria { get; set; }
        public int MinutosTardanza { get; set; }
        public int LlamadasAtencion { get; set; }
        public double Pago { get; set; }
    }
}
