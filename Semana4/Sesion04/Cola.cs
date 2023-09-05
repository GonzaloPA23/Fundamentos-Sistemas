using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TADS pila, colas, etc.
using System.Collections;

namespace Sesion04
{
    class Cola
    {
        public void Run()
        {
            string palabra;

            Queue miCola = new Queue();
            Console.WriteLine("Parte 1 - Ingreso de la Informacion en la Cola");
            miCola.Enqueue("Registro 1 - Cola");
            miCola.Enqueue("Registro 2 - Cola");
            miCola.Enqueue("Registro 3 - Cola");
            miCola.Enqueue("Registro 4 - Cola");
            miCola.Enqueue("Registro 5 - Cola");
            miCola.Enqueue("Registro 6 - Cola");

            Console.WriteLine("Impresion de la Cola");
            for (int i = 0; i < 6; i++)
            {
                palabra = (string)miCola.Dequeue();
                Console.WriteLine(palabra);
            }

            Console.ReadKey();

            Queue<string> marcas = new Queue<string>();

            Console.WriteLine("\nParte 2 - Trabajando con Marcas!!!");
            marcas.Enqueue("1 - Audi");
            marcas.Enqueue("2 - Opel");
            marcas.Enqueue("3 - BMW");
            marcas.Enqueue("4 - Toyota");
            marcas.Enqueue("5 - Nissan");
            marcas.Enqueue("6 - Mazda");
            Console.WriteLine("----------------");
            Console.WriteLine($"La primera marca es {marcas.Peek()}"); //Audi
            Console.WriteLine($"La primera marca (otra vez) es {marcas.Dequeue()}"); //Audi
            Console.WriteLine($"La segunda marca es {marcas.Dequeue()}"); //Opel
            Console.WriteLine("----------------");
            Console.WriteLine("Impresion de la Cola");
            foreach (string marca in marcas)
                Console.WriteLine(marca);

            Console.ReadKey();
        }
    }
}
