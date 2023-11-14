using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPelicula
    {
        public DPelicula() { }
        public String Registrar(Pelicula pelicula)
        {
            try
            {
                using(var context = new DBTA9Entities())
                {
                    context.Pelicula.Add(pelicula);
                    context.SaveChanges();
                }
                return "Se ha registrado la película correctamente.";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        public String Modificar(Pelicula pelicula)
        {
            try
            {
                using (var context = new DBTA9Entities())
                {
                    Pelicula peliculaTemp = context.Pelicula.Find(pelicula.Id);
                    peliculaTemp.Titulo = pelicula.Titulo;
                    peliculaTemp.Director = pelicula.Director;
                    peliculaTemp.Genero = pelicula.Genero;
                    peliculaTemp.FechaEstreno = pelicula.FechaEstreno;
                    peliculaTemp.Pais = pelicula.Pais;

                    context.SaveChanges();
                }
                return "Se ha modificado el registro correctamente.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public String Eliminar(int id)
        {
            try
            {
                using (var context = new DBTA9Entities())
                {
                    Pelicula peliculaTemp = context.Pelicula.Find(id);
                    context.Pelicula.Remove(peliculaTemp);

                    context.SaveChanges();
                }
                return "Se ha eliminado el registro correctamente.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Pelicula>ListarTodo()
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            try
            {
                using(var context = new DBTA9Entities())
                {
                    peliculas = context.Pelicula.ToList();
                }
                return peliculas;
            }
            catch(Exception e)
            {
                return peliculas;
            }
        }
        public List<Pelicula> OrdenarPorFechaEstreno(List<Pelicula> peliculas, int indice)
        {
            if (peliculas != null)
            {
                if (indice == 0) peliculas = peliculas.OrderByDescending(p => p.FechaEstreno).ToList();
                else peliculas = peliculas.OrderBy(p => p.FechaEstreno).ToList();
                return peliculas;
            }
            else
            {
                return new List<Pelicula>();
            }
            
        }
        public List<Pelicula> BuscarPorGenero(String genero)
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            try
            {
                using(var context = new DBTA9Entities())
                {
                    peliculas = context.Pelicula.Where(p => p.Genero.Equals(genero)).ToList();
                }
                return peliculas;
            }
            catch(Exception e)
            {
                return peliculas;
            }
        }
    }
}
