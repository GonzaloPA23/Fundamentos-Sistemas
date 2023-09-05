using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TADS pila, colas, etc.
using System.Collections;

namespace Sesion04
{
    class Pila
    {
        public void Run()
        {
            string palabra;

            Stack miPila = new Stack();
            Console.WriteLine("Ingreso de la Informacion en la Pila");
            miPila.Push("Registro 1 -  Pila");
            miPila.Push("Registro 2 -  Pila");
            miPila.Push("Registro 3 -  Pila");
            miPila.Push("Registro 4 -  Pila");
            miPila.Push("Registro 5 -  Pila");
            Console.WriteLine("Impresion de la Pila");
            for (int i = 0; i < 5; i++)
            {
                palabra = (string)miPila.Pop();
                Console.WriteLine(palabra);
            }

            Console.ReadKey();
        }
    }
}
