using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using entidades;
using datos;

namespace negocio
{
    public class nEmpleos
    {
        private dEmpleos _dataEmpleos = new dEmpleos();

        public List<Empleos> ObtenerTodosLosEmpleos()
        {
            return _dataEmpleos.SeleccionarTodos();
        }

        public void AgregarEmpleo(string nombre, decimal salarioMinimo, decimal salarioMaximo)
        {
            Empleos nuevoEmpleo = new Empleos
            {
                NombreDelEmpleo = nombre,
                SalarioMínimo = salarioMinimo,
                SalarioMáximo = salarioMaximo
            };
            _dataEmpleos.Insertar(nuevoEmpleo);
        }

        public void EliminarEmpleo(int codigo)
        {
            _dataEmpleos.Eliminar(codigo);
        }

        public void ModificarEmpleo(Empleos empleo)
        {
            _dataEmpleos.Modificar(empleo);
        }

        public List<Empleos> ConsultarEmpleos(decimal salarioMinimo, decimal salarioMaximo, string nombre)
        {
            return _dataEmpleos.ConsultarPorSalarioYNombre(salarioMinimo, salarioMaximo, nombre);
        }
    }
}
