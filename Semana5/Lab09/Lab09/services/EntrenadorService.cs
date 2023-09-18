using Lab09.Entities;
using Lab09.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.services
{
    internal class EntrenadorService
    {
        public EntrenadorService() { }
        private EntrenadorRepository eR = new();

        public bool Insertar(Entrenador entrenador)
        {
            if (eR.ExisteEntrenador(entrenador.Codigo))
            {
                return false;
            }else
            {
                eR.Insertar(entrenador);
                return true;
            }
        }

        public List<Entrenador> ListarTodo()
        {
            // solo aquí se pone EntrenadorRepository.ListarTodo() porque es un método estático y no se necesita instanciar la clase para usarlo. 
            return EntrenadorRepository.ListarTodo(); 
        }

        public List<Entrenador> ListarPorRegion(String region)
        {
            return eR.ListarPorRegion(region);
        }

        public List<Entrenador> ListarPorNombrePokemon(String nombrePokemon)
        {
            return eR.ListarPorNombrePokemon(nombrePokemon);
        }

        public List<Entrenador> ListarPorMenosPokemons()
        {
            return eR.ListarPorMenosPokemons();
        }
    }
}
