using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    
    public class NArticulo
    {
        private DArticulo dArticulo = new DArticulo();
        public List<ARTICULO> ListarArticulos()
        {
            return dArticulo.ListarArticulos();
        }

        public String RegistrarArticulo(ARTICULO articulo)
        {
            // validar campos vacios
            if (articulo.codarticulo == null || articulo.descripcion == null || articulo.pais == null || articulo.fecharegistro == null || articulo.precio == null || articulo.tipo == null || articulo.paraofrecer == null)
            {
                return "Todos los campos son obligatorios";
            }
            // validar que el articulo no exista
            if (dArticulo.ListarArticulos().Where(a => a.codarticulo == articulo.codarticulo).Count() > 0)
            {
                return "El articulo ya existe";
            }
            // validar que el precio sea mayor a 0
            if (articulo.precio <= 0)
            {
                return "El precio debe ser mayor a 0";
            }
            // validar que la fecha de registro no sea mayor a la fecha actual
            if (articulo.fecharegistro > DateTime.Now)
            {
                return "La fecha de registro no puede ser mayor a la fecha actual";
            }

            return dArticulo.RegistrarArticulo(articulo);
        }

        public String ModificarArticulo(ARTICULO articulo)
        {       
            // validar campos vacios
            if (articulo.descripcion == null || articulo.pais == null || articulo.fecharegistro == null || articulo.precio == null || articulo.tipo == null || articulo.paraofrecer == null)
            {
                return "Todos los campos son obligatorios";
            }
            // validar que el precio sea mayor a 0
            if (articulo.precio <= 0)
            {
                return "El precio debe ser mayor a 0";
            }
            // validar que la fecha de registro no sea mayor a la fecha actual
            if (articulo.fecharegistro > DateTime.Now)
            {
                return "La fecha de registro no puede ser mayor a la fecha actual";
            }

            return dArticulo.ModificarArticulo(articulo);
        }

        public String EliminarArticulo(string codarticulo)
        {
            // Validar que se seleccione un articulo
            if (codarticulo == null)
            {
                return "Seleccione un articulo";
            }
            return dArticulo.EliminarArticulo(codarticulo);
        }

        // Listar articulos con el mayor tiempo de registro
        public List<ARTICULO> ListarArticulosMayorTiempo()
        {
            // validar que existan articulos registrados
            if (dArticulo.ListarArticulos().Count() == 0)
            {
                return new List<ARTICULO>();
            }
            return dArticulo.ListarArticulosMayorTiempo();
        }

        // Mostrar el o los tipos de articulos que tienen la menor cantidad de articulos con el campo para ofrecer en verdadero
        public List<String> ListarArticulosMenorCantidad()
        {
            // validar que existan articulos registrados
            if (dArticulo.ListarArticulos().Count() == 0)
            {
                return new List<String>();
            }
            return dArticulo.ListarArticulosMenorCantidad();
        }

        // Mostrar por cada pais el precio promedio de los articulos que se encuentran registrados en el sistema entre 1 a 4 años cumplidos, entre 5 y 9 años cumplidos y los que tienen más de 0 años cumplidos al dia de hoy
        public List<decimal> ListarPromedioPrecioXPais(String pais)
        {
            // validar que existan articulos registrados 
            if (dArticulo.ListarArticulos().Count() == 0)
            {
                return new List<decimal>();
            }
            return dArticulo.ListarPromedioPrecioXPais(pais);
        }
    }
}
