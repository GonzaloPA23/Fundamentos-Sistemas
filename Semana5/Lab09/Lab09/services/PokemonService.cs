using Lab09.Entities;
using Lab09.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.services
{
    internal class PokemonService
    {
        String codigoEntrenador;
        public PokemonService(String codigoEntrenador) {
            this.codigoEntrenador = codigoEntrenador;
        }
        private PokemonRepository pR = new();

        public bool Insertar(Pokemon pokemon)
        {
            if(pR.ExistePokemon(pokemon.Codigo))
            {
                return false;
            }else
            {
                pR.Insertar(codigoEntrenador, pokemon);
                return true;
            }
        }

        public List<Pokemon> ListarTodo()
        {
            return pR.ListarTodo(codigoEntrenador);
        }
    }
}
