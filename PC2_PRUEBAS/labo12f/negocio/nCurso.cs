using datos;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class nCurso
    {
        private dCurso _dataCurso = new dCurso();
        /*
        public List<Curso> ObtenerTodosLosCursos()
        {
            return _dataCurso.SeleccionarTodos();
        }
        */
        public List<string> ObtenerNombresCursos()
        {
            List<Curso> cursos = _dataCurso.SeleccionarTodos();
            List<string> nombresCursos = cursos.Select(curso => curso.Nombrecurso).ToList();
            return nombresCursos;
        }

        public List<Curso> ObtenerTodosLosCursos()
        {
            return _dataCurso.SeleccionarTodos();
        }

        public Curso ObtenerCursoPorId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del curso debe ser un número positivo.");
            }

            return _dataCurso.SeleccionarPorId(id);
        }

        public void AgregarCurso(string nombreCurso)
        {
            if (string.IsNullOrWhiteSpace(nombreCurso))
            {
                throw new ArgumentException("El nombre del curso no puede estar vacío.");
            }

            Curso nuevoCurso = new Curso
            {
                Nombrecurso = nombreCurso
            };

            _dataCurso.Insertar(nuevoCurso);
        }

        public void ActualizarCurso(int id, string nuevoNombreCurso)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del curso debe ser un número positivo.");
            }

            if (string.IsNullOrWhiteSpace(nuevoNombreCurso))
            {
                throw new ArgumentException("El nombre del curso no puede estar vacío.");
            }

            Curso cursoExistente = _dataCurso.SeleccionarPorId(id);

            if (cursoExistente == null)
            {
                throw new InvalidOperationException("El curso que intenta actualizar no existe.");
            }

            cursoExistente.Nombrecurso = nuevoNombreCurso;
            _dataCurso.Actualizar(cursoExistente);
        }

        public void EliminarCurso(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del curso debe ser un número positivo.");
            }

            _dataCurso.EliminarPorId(id);
        }

        public List<Docente> ObtenerDocentesPorCurso(string nombreCurso)
        {
            return _dataCurso.ObtenerDocentesPorCurso(nombreCurso);
        }
    }
}
