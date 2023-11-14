using entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class dDocentexCurso
    {
        dbinstitutoEntities dbcontexto = new dbinstitutoEntities();

        public List<DocentexCurso> SeleccionarTodos()
        {
            // Consulta SQL para seleccionar todos los registros de DocentexCurso
            string query = "SELECT * FROM DocentexCurso";
            return dbcontexto.Database.SqlQuery<DocentexCurso>(query).ToList();
        }

        public DocentexCurso SeleccionarPorId(int id)
        {
            // Consulta SQL para seleccionar un registro de DocentexCurso por su ID
            string query = "SELECT * FROM DocentexCurso WHERE Id_docente = @id";
            SqlParameter parameter = new SqlParameter("@id", id);
            return dbcontexto.Database.SqlQuery<DocentexCurso>(query, parameter).SingleOrDefault();
        }

        public void Insertar(DocentexCurso docentexCurso)
        {
            // Consulta SQL para insertar un nuevo registro en DocentexCurso
            string query = "INSERT INTO DocentexCurso (Id_docente, Id_curso, Semestre) VALUES (@id_docente, @id_curso, @semestre)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id_docente", docentexCurso.Id_docente),
                new SqlParameter("@id_curso", docentexCurso.Id_curso),
                new SqlParameter("@semestre", docentexCurso.Semestre)
            };
            dbcontexto.Database.ExecuteSqlCommand(query, parameters);
        }

        public void Actualizar(DocentexCurso docentexCurso)
        {
            // Consulta SQL para actualizar un registro en DocentexCurso por su ID
            string query = "UPDATE DocentexCurso SET Id_curso = @id_curso, Semestre = @semestre WHERE Id_docente = @id_docente";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id_curso", docentexCurso.Id_curso),
                new SqlParameter("@semestre", docentexCurso.Semestre),
                new SqlParameter("@id_docente", docentexCurso.Id_docente)
            };
            dbcontexto.Database.ExecuteSqlCommand(query, parameters);
        }

        public void EliminarPorId(int id)
        {
            // Consulta SQL para eliminar un registro en DocentexCurso por su ID
            string query = "DELETE FROM DocentexCurso WHERE Id_docente = @id";
            SqlParameter parameter = new SqlParameter("@id", id);
            dbcontexto.Database.ExecuteSqlCommand(query, parameter);
        }
    }
}
