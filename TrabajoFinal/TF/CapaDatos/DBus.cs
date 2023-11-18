using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DBus
    {
        // Constructor vacío
        public DBus() { }
        // Metodo para listar los buses
        public List<Bus> ListarBuses()
        {
            using (var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Bus.ToList();
                }
                catch (Exception ex) 
                {
                    return new List<Bus>();
                }
            }
        }
        // Metodo para registrar un bus
        public int RegistrarBus(Bus bus, out string mensaje)
        {
            int idbusgenerado = 0;
            mensaje = string.Empty;

            try
            {
                using(var context = new DB_PerlaAltomayoEntities())
                {
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ChoferId", bus.ChoferId),
                        new SqlParameter("@Matricula", bus.Matricula),
                        new SqlParameter("@Tipo", bus.Tipo),
                        new SqlParameter("@AsientosDisponibles", bus.AsientosDisponibles),
                        new SqlParameter("@PuntoSalida", bus.PuntoSalida),
                        new SqlParameter("@Destino", bus.Destino),
                        new SqlParameter("@FechaSalida", bus.FechaSalida),
                        new SqlParameter("@FechaLlegada", bus.FechaLlegada),
                        new SqlParameter("@PrecioAsiento", bus.PrecioAsiento),
                        new SqlParameter("@IdResultado", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output },
                        new SqlParameter("@Mensaje", System.Data.SqlDbType.VarChar, 200) { Direction = System.Data.ParameterDirection.Output }
                    };
                    context.Database.ExecuteSqlCommand("EXEC SP_RegistrarBus @ChoferId, @Matricula, @Tipo, @AsientosDisponibles, @PuntoSalida, @Destino, @FechaSalida, @FechaLlegada, @PrecioAsiento, @IdResultado OUTPUT, @Mensaje OUTPUT", parameters);
                    idbusgenerado = Convert.ToInt32(parameters.Single(p => p.ParameterName == "@IdResultado").Value);
                    mensaje = parameters.Single(p => p.ParameterName == "@Mensaje").Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idbusgenerado = 0;
                mensaje = ex.Message;
            }
            return idbusgenerado;
        }
    }
}
