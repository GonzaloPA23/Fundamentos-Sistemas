using Lab09.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.repositories
{
    internal class EntrenadorRepository
    {
        private static List<Entrenador> entrenadores = new();

        public EntrenadorRepository() { }

        public bool ExisteEntrenador(String codigoEntrenador)
        {
            return entrenadores.Exists(entrenador => entrenador.Codigo == codigoEntrenador);
        }

        public void Insertar(Entrenador entrenador)
        {
            entrenadores.Add(entrenador);
        }

        public static List<Entrenador> ListarTodo()
        {
            return entrenadores;
        }

        public List<Entrenador> ListarPorRegion(String region)
        {
            return entrenadores.FindAll(en => en.Region.Equals(region));
        }

        public List<Entrenador> ListarPorNombrePokemon(String nombrePokemon)
        {
            List<Entrenador> entrenadoresTemp = new();
            foreach (Entrenador entrenador in entrenadores)
            {
                bool existe = entrenador.Pokemones.Exists(pokemon => pokemon.Nombre.Equals(nombrePokemon));
                if (existe)
                {
                    entrenadoresTemp.Add(entrenador);
                }
            }
            return entrenadoresTemp;
        }

        public List<Entrenador> ListarPorMenosPokemons()
        {
            List<Entrenador> entrenadoresTemp = new();
            int minTotal = 6;
            foreach (Entrenador entrenador in entrenadores)
            {
                if(entrenador.Pokemones.Count < minTotal)
                {
                    minTotal = entrenador.Pokemones.Count;
                    entrenadoresTemp.Clear();
                    entrenadoresTemp.Add(entrenador);
                }
                else if(entrenador.Pokemones.Count == minTotal)
                {
                    entrenadoresTemp.Add(entrenador);
                }
            }
            return entrenadoresTemp;
        }
    }
}
