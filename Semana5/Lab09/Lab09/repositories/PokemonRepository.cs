using Lab09.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.repositories
{
    internal class PokemonRepository
    {
        public PokemonRepository() { }

        public bool ExistePokemon(String codigoPokemon)
        {
            // Acá se llama al método estático ListarTodo() de la clase EntrenadorRepository para obtener la lista de entrenadores y poder buscar el pokemon en cada entrenador (en su lista de pokemones).
            // Esto es porque la lista de pokemones está en la clase Entrenador, no en la clase Pokemon. 
            List<Entrenador> entrenadores = EntrenadorRepository.ListarTodo(); 
            foreach (Entrenador en in entrenadores)
            {
                bool existe = en.Pokemones.Exists(pokemon => pokemon.Codigo.Equals(codigoPokemon));
                if (existe)
                {
                    return true;
                }
            }
            return false;
        }

        public void Insertar(String codigoEntrenador, Pokemon pokemon)
        {
            Entrenador? en = EntrenadorRepository.ListarTodo().Find(en => en.Codigo.Equals(codigoEntrenador));
            if(en != null)
            {
                en.Pokemones.Add(pokemon);
            }
        }

        public List<Pokemon> ListarTodo(String codigoEntrenador)
        {
            Entrenador? en = EntrenadorRepository.ListarTodo().Find(en => en.Codigo.Equals(codigoEntrenador));
            if (en != null)
            {
                return en.Pokemones;
            }
            else
            {
                return new List<Pokemon>();
            }
        }
    }
}
