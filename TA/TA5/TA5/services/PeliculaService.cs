using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA5.entities;
using TA5.repositories;

namespace TA5.services
{
    internal class PeliculaService
    {
        private PeliculaRepository peliculaRepository = new();
        public PeliculaService() { }

        public bool InsertarPelicula (Pelicula pelicula)
        {
            if (peliculaRepository.ExistePelicula(pelicula.Codigo))
            {
                return false;
            }
            else
            {
                peliculaRepository.InsertarPelicula(pelicula);
                return true;
            }
        }

        public List<Pelicula> ListarTodo()
        {
            // solo aquí se pone PeliculaRepository.ListarTodo() porque es un método estático y no se necesita instanciar la clase para usarlo. 
            return PeliculaRepository.ListarTodo();
        }

        public List<Pelicula> ListarPorGenero(String genero)
        {
            return peliculaRepository.ListarPorGenero(genero);
        }

        public List<Pelicula> ListarPorNombreActor(String nombreActor)
        {
            return peliculaRepository.ListarPorNombreActor(nombreActor);
        }

        public List<Pelicula> ListarPorMenosPersonajesFemeninos()
        {
            return peliculaRepository.ListarPorMenosPersonajesFemeninos();
        }
    }
}
