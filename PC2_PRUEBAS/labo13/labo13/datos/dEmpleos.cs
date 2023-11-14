using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using entidades;

namespace datos
{
    public class dEmpleos
    {
        private dbRRHHEntities dbcontexto = new dbRRHHEntities();

        public List<Empleos> SeleccionarTodos()
        {
            string query = "SELECT * FROM Empleos";
            return dbcontexto.Database.SqlQuery<Empleos>(query).ToList();
        }

        public void Insertar(Empleos empleo)
        {
            string query = "INSERT INTO Empleos (NombreDelEmpleo, SalarioMínimo, SalarioMáximo) VALUES (@nombre, @minimo, @maximo)";
            SqlParameter[] parameters =
            {
            new SqlParameter("@nombre", empleo.NombreDelEmpleo),
            new SqlParameter("@minimo", empleo.SalarioMínimo),
            new SqlParameter("@maximo", empleo.SalarioMáximo)
        };
            dbcontexto.Database.ExecuteSqlCommand(query, parameters);
        }

        public void Eliminar(int codigo)
        {
            string query = "DELETE FROM Empleos WHERE Código = @codigo";
            SqlParameter parameter = new SqlParameter("@codigo", codigo);
            dbcontexto.Database.ExecuteSqlCommand(query, parameter);
        }

        public void Modificar(Empleos empleo)
        {
            string query = "UPDATE Empleos SET NombreDelEmpleo = @nombre, SalarioMínimo = @minimo, SalarioMáximo = @maximo WHERE Código = @codigo";
            SqlParameter[] parameters =
            {
            new SqlParameter("@nombre", empleo.NombreDelEmpleo),
            new SqlParameter("@minimo", empleo.SalarioMínimo),
            new SqlParameter("@maximo", empleo.SalarioMáximo),
            new SqlParameter("@codigo", empleo.Código)
        };
            dbcontexto.Database.ExecuteSqlCommand(query, parameters);
        }

        public List<Empleos> ConsultarPorSalarioYNombre(decimal salarioMínimo, decimal salarioMáximo, string nombre)
        {
            string query = "SELECT * FROM Empleos WHERE SalarioMínimo >= @minimo AND SalarioMáximo <= @maximo AND NombreDelEmpleo LIKE @nombre";
            SqlParameter[] parameters =
            {
            new SqlParameter("@minimo", salarioMínimo),
            new SqlParameter("@maximo", salarioMáximo),
            new SqlParameter("@nombre", "%" + nombre + "%")
        };
            return dbcontexto.Database.SqlQuery<Empleos>(query, parameters).ToList();
        }
    }
}
