using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DArticulo
    {
        public List<ARTICULO> ListarArticulos()
        {
            List<ARTICULO> articulos = new List<ARTICULO>();
            try
            {
                using (var context = new dbCasaEmpenioEntities())
                {
                    articulos = context.ARTICULO.ToList();
                }
                return articulos;
            }
            catch (Exception ex)
            {
                return articulos;
            }
        }

        public String RegistrarArticulo(ARTICULO articulo)
        {
            String mensaje = string.Empty;
            try
            {
                using (var context = new dbCasaEmpenioEntities())
                {
                    context.ARTICULO.Add(articulo);
                    context.SaveChanges();
                    mensaje = "Articulo registrado correctamente";
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String ModificarArticulo(ARTICULO articulo)
        {
            try
            {
                using (var context = new dbCasaEmpenioEntities())
                {
                    ARTICULO artiTemp = context.ARTICULO.Find(articulo.codarticulo);
                    artiTemp.descripcion = articulo.descripcion;
                    artiTemp.pais = articulo.pais;
                    artiTemp.fecharegistro = articulo.fecharegistro;
                    artiTemp.precio = articulo.precio;
                    artiTemp.tipo = articulo.tipo;
                    artiTemp.paraofrecer = articulo.paraofrecer;
                    context.SaveChanges();
                }
                return "Articulo modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String EliminarArticulo(string codarticulo)
        {
            try
            {
                using (var context = new dbCasaEmpenioEntities())
                {
                    ARTICULO artiTemp = context.ARTICULO.Find(codarticulo);
                    context.ARTICULO.Remove(artiTemp);
                    context.SaveChanges();
                }
                return "Articulo eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Listar articulos con el mayor tiempo de registro
        public List<ARTICULO> ListarArticulosMayorTiempo()
        {
            List<ARTICULO> articulos = new List<ARTICULO>();
            try
            {
                using (var context = new dbCasaEmpenioEntities())
                {
                    articulos = context.ARTICULO.OrderByDescending(a => a.fecharegistro).ToList();
                }
                return articulos;
            }
            catch (Exception ex)
            {
                return articulos;
            }
        }

        // Mostrar el o los tipos de articulos que tienen la menor cantidad de articulos con el campo para ofrecer en verdadero
        public List<String> ListarArticulosMenorCantidad()
        {
            List<String> articulos = new List<String>();
            try
            {
                using (var context = new dbCasaEmpenioEntities())
                {
                    articulos = context.ARTICULO.Where(a => a.paraofrecer == "Verdadero").GroupBy(a => a.tipo).Select(a => a.Key).ToList();
                }
                return articulos;
            }
            catch (Exception ex)
            {
                return articulos;
            }
        }

        // Mostrar por cada pais el precio promedio de los articulos que se encuentran registrados en el sistema entre 1 a 4 años cumplidos, entre 5 y 9 años cumplidos y los que tienen más de 0 años cumplidos al dia de hoy
        public List<decimal> ListarPromedioPrecioXPais(String pais)
        {
            List<decimal> promedios = new List<decimal>();
            try
            {
                using (var context = new dbCasaEmpenioEntities())
                {
                    promedios.Add(context.ARTICULO.Where(a => a.pais == pais && a.fecharegistro.Value.Year >= DateTime.Now.Year - 4 && a.fecharegistro.Value.Year <= DateTime.Now.Year - 1).Average(a => a.precio).Value);
                    promedios.Add(context.ARTICULO.Where(a => a.pais == pais && a.fecharegistro.Value.Year >= DateTime.Now.Year - 9 && a.fecharegistro.Value.Year <= DateTime.Now.Year - 5).Average(a => a.precio).Value);
                    promedios.Add(context.ARTICULO.Where(a => a.pais == pais && a.fecharegistro.Value.Year <= DateTime.Now.Year - 10).Average(a => a.precio).Value);
                }
                return promedios;
            }
            catch (Exception ex)
            {
                return promedios;
            }
        }

        // Listar los articulos que tengan la fecha de registro desde el 4 de enero del 2023 hasta el 31 de diciembre del 2023
        public List<ARTICULO> ListarArticulosXFechaRegistro()
        {
            List<ARTICULO> articulos = new List<ARTICULO>();
            try
            {
                using (var context = new dbCasaEmpenioEntities())
                {
                    articulos = context.ARTICULO
                        .Where(a => a.fecharegistro >= new DateTime(2023, 1, 4) && a.fecharegistro <= new DateTime(2023, 12, 31))
                        .ToList();
                }
                return articulos;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return articulos;
            }

        }
    }
}
