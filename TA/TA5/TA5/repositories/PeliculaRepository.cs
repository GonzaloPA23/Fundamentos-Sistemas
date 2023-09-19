using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA5.entities;

namespace TA5.repositories
{
    internal class PeliculaRepository
    {
        // Atributos
        private static List<Pelicula> peliculas = new();
        // Constructor
        public PeliculaRepository(){}
        // Metodos
            // Verificar si existe una pelicula
        public bool ExistePelicula(String codigoPelicula)
        {
            return peliculas.Exists(pelicula => pelicula.Codigo.Equals(codigoPelicula));
        }
            // Insertar una pelicula
        public void InsertarPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }
            // Listar todas las peliculas
        // El tipo static permite que el metodo sea llamado sin necesidad de instanciar la clase PeliculaRepository 
        public static List<Pelicula> ListarTodo()
        {
            return peliculas;
        }
        // Metodos para la busqueda de peliculas y listado de las mismas
            // Buscar peliculas por género
        public List<Pelicula> ListarPorGenero(String genero)
        {
            return peliculas.FindAll(pelicula => pelicula.Genero.Equals(genero));
        }

            // Buscar peliculas por nombre de actor
        public List<Pelicula> ListarPorNombreActor (String nombreActor)
        {
            List<Pelicula> peliculasTemp = new();
            foreach (Pelicula pelicula in peliculas)
            {
                bool existe = pelicula.Personajes.Exists(pelicula => pelicula.NombreActor.Equals(nombreActor));
                if (existe) { peliculasTemp.Add(pelicula); }
            }
            return peliculasTemp;
        }
        // Buscar los que tienen menor cantidad de personajes de Sexo Femenino
        public List<Pelicula> ListarPorMenosPersonajesFemeninos()
        {
            List<Pelicula> peliculasTemp = new();
            int minimoTotal = 10000;
            foreach(Pelicula pelicula in peliculas)
            {
                int cantidadPersonajesFemeninos = pelicula.Personajes.Count(personaje => personaje.Genero.Equals("Femenino") || personaje.Genero.Equals("femenino"));
                if (cantidadPersonajesFemeninos < minimoTotal)
                {
                    minimoTotal = cantidadPersonajesFemeninos;
                    peliculasTemp.Clear();
                    peliculasTemp.Add(pelicula);
                }
                else if (cantidadPersonajesFemeninos == minimoTotal)
                {
                    peliculasTemp.Add(pelicula);
                }
            }
            return peliculasTemp;
        }

    }
}
