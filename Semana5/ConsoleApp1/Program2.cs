using System;
using System.Collections.Generic;
using System.Linq;

// Definir la clase Compra para almacenar información sobre cada compra
class Compra
{
    public string DniCliente { get; set; }
    public decimal Monto { get; set; }
    public DateTime Fecha { get; set; }
}

// Definir la clase Caja para almacenar información sobre cada caja
class Caja
{
    public int Codigo { get; set; }
    public string NombreCajero { get; set; }
    public List<Compra> Compras { get; } = new List<Compra>();
}

class Program
{
    static List<Caja> cajas = new List<Caja>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Crear una Caja");
            Console.WriteLine("2. Registrar una compra");
            Console.WriteLine("3. Listar las compras de una caja");
            Console.WriteLine("4. Obtener la caja con más compras");
            Console.WriteLine("5. Listar las cajas de un cliente");
            Console.WriteLine("6. Obtener el o los clientes con menor monto de compra");
            Console.WriteLine("7. Obtener el monto total de compras de todas las cajas");
            Console.WriteLine("8. Salir");
            Console.Write("Eliga una Opcion: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:CrearCaja();break;
                case 2:RegistrarCompra(); break;
                //case 3:ListarComprasDeCaja();break;
                //case 4: ObtenerCajaConMasCompras(); break;
                //case 5:ListarCajasDeCliente();break;
                //case 6:ObtenerClientesConMenorMonto(); break;
               // case 7: ObtenerMontoTotalDeCompras();break;
                case 8: Environment.Exit(0); break;
                default: Console.WriteLine("Opción no válida. Intente de nuevo.");break;
            }
        }
    }

    static void CrearCaja()
    {
        Console.Write("Ingrese el código de la caja: ");
        int codigo = int.Parse(Console.ReadLine());

        if (cajas.Any(c => c.Codigo == codigo))
        {
            Console.WriteLine("Ya existe una caja con ese código.");
        }
        else
        {
            Console.Write("Ingrese el nombre del cajero: ");
            string nombreCajero = Console.ReadLine();

            Caja caja = new Caja { Codigo = codigo, NombreCajero = nombreCajero };
            cajas.Add(caja);
            Console.WriteLine("Caja creada exitosamente.");
        }
    }

    static void RegistrarCompra()
    {
        Console.Write("Ingrese el código de la caja: ");
        int codigoCaja = int.Parse(Console.ReadLine());

        Caja caja = cajas.FirstOrDefault(c => c.Codigo == codigoCaja);
        if (caja == null)
        {
            Console.WriteLine("No se encontró una caja con ese código.");
        }
        else
        {
            Console.Write("Ingrese el DNI del cliente: ");
            string dniCliente = Console.ReadLine();

            Console.Write("Ingrese el monto de la compra: ");
            decimal montoCompra = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese la fecha de la compra (yyyy-MM-dd): ");
            DateTime fechaCompra = DateTime.Parse(Console.ReadLine());

            Compra compra = new Compra { DniCliente = dniCliente, Monto = montoCompra, Fecha = fechaCompra };
            caja.Compras.Add(compra);
            Console.WriteLine("Compra registrada exitosamente.");
        }
    }

    // Implementa el resto de las funciones según los requerimientos funcionales
}
