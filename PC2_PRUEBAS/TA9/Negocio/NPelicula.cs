using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPelicula
    {
        private DPelicula dPelicula = new DPelicula();
        public NPelicula() { }
        public String Registrar(Pelicula pelicula)
        {
            return dPelicula.Registrar(pelicula);
        }
        public String Modificar(Pelicula pelicula)
        {
            return dPelicula.Modificar(pelicula);
        }

        public String Eliminar(int id)
        {
            return dPelicula.Eliminar(id);
        }
        public List<Pelicula> ListarTodo()
        {
            return dPelicula.ListarTodo();
        }
        public List<Pelicula> OrdenarPorFechaEstreno(List<Pelicula> peliculas, int indice)
        {
            return dPelicula.OrdenarPorFechaEstreno(peliculas, indice);
        }
        public List<Pelicula> BuscarPorGenero(String genero)
        {
            return dPelicula.BuscarPorGenero(genero);
        }

    }
}
