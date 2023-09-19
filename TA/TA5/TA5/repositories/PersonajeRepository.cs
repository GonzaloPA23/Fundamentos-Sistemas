using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA5.entities;

namespace TA5.repositories
{
    internal class PersonajeRepository
    {
        public PersonajeRepository() { }
        public bool ExistePersonaje(String codigoPersonaje)
        {
            List<Pelicula> peliculas = PeliculaRepository.ListarTodo();
            foreach (Pelicula pelicula in peliculas)
            {
                bool existe = pelicula.Personajes.Exists(perosnaje => perosnaje.Codigo.Equals(codigoPersonaje));
                if (existe) { return true; }
            }
            return false;
        }

        // Insertar personaje
        public void InsertarPersonaje(String codigoPelicula, Personaje personaje)
        {
            Pelicula? pelicula = PeliculaRepository.ListarTodo().Find(pelicula => pelicula.Codigo.Equals(codigoPelicula));
            if (pelicula != null)
            {
                pelicula.Personajes.Add(personaje);
            }
        }

        // Listar todos los personajes
        public List<Personaje> ListarTodo(String codigoPelicula)
        {
            Pelicula? pelicula = PeliculaRepository.ListarTodo().Find(pelicula => pelicula.Codigo.Equals(codigoPelicula));
            if (pelicula != null) { return pelicula.Personajes; }
            else { return new List<Personaje>(); }
        }
        // Buscar personajes por el codigo de pelicula que tengan más de 40 minutos de aparaición

        public List<Personaje> ListarPorCodigoPeliculaMasDe40Minutos(String codigoPelicula)
        {
            Pelicula? pelicula = PeliculaRepository.ListarTodo().Find(pelicula => pelicula.Codigo.Equals(codigoPelicula));
            if (pelicula != null)
            {
               List<Personaje> personajesTemp = pelicula.Personajes.FindAll(personaje => personaje.MinutosAparicion > 40);
               if (personajesTemp.Count > 0) { return personajesTemp; }
               else { return new List<Personaje>(); }
            }else { return new List<Personaje>(); }
        }

        // Buscar por género de personaje
        public List<Personaje> ListarPorGeneroPersonaje(String genero)
        {
            return PeliculaRepository.ListarTodo().SelectMany(pelicula => pelicula.Personajes).Where(personaje => personaje.Genero.Equals(genero)).ToList();
        }
    }
}
