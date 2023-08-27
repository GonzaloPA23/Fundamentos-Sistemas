using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Arreglos
{
    internal class ModelRegister
    {
        public ModelRegister() { }
        public ModelRegister(String name, String typeCar, String typeService)
        {
            Name = name;
            TypeCar = typeCar;
            TypeService = typeService;
        }

        public String Name { get; set; }
        public String TypeCar { get; set; }
        public String TypeService { get; set; }
        public double MontoAPagar { get; set;}

    }
}
