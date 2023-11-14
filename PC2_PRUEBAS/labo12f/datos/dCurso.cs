using entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class dCurso
    {
        dbinstitutoEntities dbcontexto = new dbinstitutoEntities();

        public List<Curso> SeleccionarTodos()
        {
            // Consulta SQL para seleccionar todos los cursos
            string query = "SELECT * FROM Curso";
            return dbcontexto.Database.SqlQuery<Curso>(query).ToList();
        }

        public Curso SeleccionarPorId(int id)
        {
            // Consulta SQL para seleccionar un curso por su ID
            string query = "SELECT * FROM Curso WHERE Id_curso = @id";
            SqlParameter parameter = new SqlParameter("@id", id);
            return dbcontexto.Database.SqlQuery<Curso>(query, parameter).SingleOrDefault();
        }

        public void Insertar(Curso curso)
        {
            // Consulta SQL para insertar un nuevo curso
            string query = "INSERT INTO Curso (Nombrecurso) VALUES (@nombrecurso)";
            SqlParameter parameter = new SqlParameter("@nombrecurso", curso.Nombrecurso);
            dbcontexto.Database.ExecuteSqlCommand(query, parameter);
        }

        public void Actualizar(Curso curso)
        {
            // Consulta SQL para actualizar un curso por su ID
            string query = "UPDATE Curso SET Nombrecurso = @nombrecurso WHERE Id_curso = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@nombrecurso", curso.Nombrecurso),
                new SqlParameter("@id", curso.Id_curso)
            };
            dbcontexto.Database.ExecuteSqlCommand(query, parameters);
        }

        public void EliminarPorId(int id)
        {
            // Consulta SQL para eliminar un curso por su ID
            string query = "DELETE FROM Curso WHERE Id_curso = @id";
            SqlParameter parameter = new SqlParameter("@id", id);
            dbcontexto.Database.ExecuteSqlCommand(query, parameter);
        }

        public List<Docente> ObtenerDocentesPorCurso(string nombreCurso)
        {
            // Consulta SQL para obtener docentes por curso
            string query = "SELECT Docente.* FROM Docente INNER JOIN DocentexCurso ON Docente.Id_docente = DocentexCurso.Id_docente " +
                           "INNER JOIN Curso ON DocentexCurso.Id_curso = Curso.Id_curso " +
                           "WHERE Curso.Nombrecurso = @nombreCurso";

            var parameter = new SqlParameter("@nombreCurso", nombreCurso);
            return dbcontexto.Database.SqlQuery<Docente>(query, parameter).ToList();
        }
    }
}
