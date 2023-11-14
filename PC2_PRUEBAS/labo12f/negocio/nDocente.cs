using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using datos;
using entidades;

namespace negocio
{
    public class nDocente
    {
        private dDocente _dataDocente = new dDocente();

        public List<Docente> ObtenerTodosLosDocentes()
        {
            return _dataDocente.SeleccionarTodos();
        }

        public Docente ObtenerDocentePorId(int id)
        {
            return _dataDocente.SeleccionarPorId(id);
        }

        public void AgregarDocente(Docente docente)
        {
            _dataDocente.Insertar(docente);
        }

        public void ActualizarDocente(Docente docente)
        {
            _dataDocente.Actualizar(docente);
        }

        public void EliminarDocentePorId(int id)
        {
            _dataDocente.EliminarPorId(id);
        }
    }
}
