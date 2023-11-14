using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using entidades;
namespace datos
{
    public class dDocente
    {
        dbinstitutoEntities dbcontexto = new dbinstitutoEntities();

        public List<Docente> SeleccionarTodos()
        {
            // Consulta SQL para seleccionar todos los docentes
            string query = "SELECT * FROM Docente";
            return dbcontexto.Database.SqlQuery<Docente>(query).ToList();
        }

        public Docente SeleccionarPorId(int id)
        {
            // Consulta SQL para seleccionar un docente por su ID
            string query = "SELECT * FROM Docente WHERE Id_docente = @id";
            SqlParameter parameter = new SqlParameter("@id", id);
            return dbcontexto.Database.SqlQuery<Docente>(query, parameter).SingleOrDefault();
        }

        public void Insertar(Docente docente)
        {
            // Consulta SQL para insertar un nuevo docente
            string query = "INSERT INTO Docente (Nombre, Apellido, Escuela) VALUES (@nombre, @apellido, @escuela)";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@nombre", docente.Nombre),
        new SqlParameter("@apellido", docente.Apellido),
        new SqlParameter("@escuela", docente.Escuela)
            };
            dbcontexto.Database.ExecuteSqlCommand(query, parameters);
        }
        public void Actualizar(Docente docente)
        {
            // Consulta SQL para actualizar un docente por su ID
            string query = "UPDATE Docente SET Nombre = @nombre, Apellido = @apellido, Escuela = @escuela WHERE Id_docente = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@nombre", docente.Nombre),
                new SqlParameter("@apellido", docente.Apellido),
                new SqlParameter("@escuela", docente.Escuela),
                new SqlParameter("@id", docente.Id_docente)
            };
            dbcontexto.Database.ExecuteSqlCommand(query, parameters);
        }

        public void EliminarPorId(int id)
        {
            // Consulta SQL para eliminar un docente por su ID
            string query = "DELETE FROM Docente WHERE Id_docente = @id";
            SqlParameter parameter = new SqlParameter("@id", id);
            dbcontexto.Database.ExecuteSqlCommand(query, parameter);
        }
    }
}
