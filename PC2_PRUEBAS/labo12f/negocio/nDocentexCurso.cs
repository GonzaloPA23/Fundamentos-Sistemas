using datos;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class nDocentexCurso
    {
        private dDocentexCurso _dataDocentexCurso = new dDocentexCurso();

        public List<DocentexCurso> ObtenerTodosLosDocentexCursos()
        {
            return _dataDocentexCurso.SeleccionarTodos();
        }

        public DocentexCurso ObtenerDocentexCursoPorId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del DocentexCurso debe ser un número positivo.");
            }

            return _dataDocentexCurso.SeleccionarPorId(id);
        }

        public void AgregarDocentexCurso(int idDocente, int idCurso, string semestre)
        {
            if (idDocente <= 0 || idCurso <= 0)
            {
                throw new ArgumentException("El ID del docente y el ID del curso deben ser números positivos.");
            }

            if (string.IsNullOrWhiteSpace(semestre))
            {
                throw new ArgumentException("El campo del semestre no puede estar vacío.");
            }

            DocentexCurso nuevoDocentexCurso = new DocentexCurso
            {
                Id_docente = idDocente,
                Id_curso = idCurso,
                Semestre = semestre
            };

            _dataDocentexCurso.Insertar(nuevoDocentexCurso);
        }

        public void ActualizarDocentexCurso(int id, int idDocente, int idCurso, string semestre)
        {
            if (id <= 0 || idDocente <= 0 || idCurso <= 0)
            {
                throw new ArgumentException("El ID del DocentexCurso, del docente y del curso deben ser números positivos.");
            }

            if (string.IsNullOrWhiteSpace(semestre))
            {
                throw new ArgumentException("El campo del semestre no puede estar vacío.");
            }

            DocentexCurso docentexCursoExistente = _dataDocentexCurso.SeleccionarPorId(id);

            if (docentexCursoExistente == null)
            {
                throw new InvalidOperationException("El DocentexCurso que intenta actualizar no existe.");
            }

            docentexCursoExistente.Id_docente = idDocente;
            docentexCursoExistente.Id_curso = idCurso;
            docentexCursoExistente.Semestre = semestre;

            _dataDocentexCurso.Actualizar(docentexCursoExistente);
        }

        public void EliminarDocentexCurso(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del DocentexCurso debe ser un número positivo.");
            }

            _dataDocentexCurso.EliminarPorId(id);
        }
    }
}
