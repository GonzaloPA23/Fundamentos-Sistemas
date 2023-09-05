using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Sesion04
{
    class EjercicioPila
    {
        public void EjePila()
        {
            // Resolvemos este ejercicio mediante pilas en C#, daremos la vuelta a la
            // siguiente cadena: "Bienvenidos al Mundo de Visual C# - Pila".
            Console.WriteLine("Bienvenidos al Mundo de Visual C# - Pila");
            Console.WriteLine("Invirtiendo la Cadena con Pila");
            Console.WriteLine(CadenaReves("Bienvenidos al Mundo de Visual C# - Pila"));
        }
        public static string CadenaReves(string cadena)
        {
            string response = "";
            char[] caracteres = cadena.ToCharArray(); //convertimos la cadena a un array de caracteres

            Stack miPila = new Stack();//declaro la pila

            foreach (var item in caracteres)
            {   miPila.Push(item);//voy apilando los caracteres de la cadena
            }
            while (miPila.Count > 0)
            { //ingreso hasta vacear la pila
                response += miPila.Pop();  //voy desapilando los caracteres y los concateno
                                           //también podríamos haber hecho un peek pero luego un pop
            }
            return response;
        }
    }
}
