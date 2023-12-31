﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA5.entities;
using TA5.repositories;

namespace TA5.services
{
    internal class PersonajeService
    {
        private
        PersonajeRepository personajeRepository = new();
        String codigoPelicula;
        public PersonajeService(String codigoPelicula)
        {
            this.codigoPelicula = codigoPelicula;
        }
        public PersonajeService() { }

        public bool InsertarPersonaje(Personaje personaje)
        {
            if (personajeRepository.ExistePersonaje(personaje.Codigo))
            {
                return false;
            }
            else
            {
                personajeRepository.InsertarPersonaje(codigoPelicula, personaje);
                return true;
            }
        }

        public List<Personaje> ListarTodo()
        {
            return personajeRepository.ListarTodo(codigoPelicula);
        }

        public List<Personaje> ListarPorCodigoPeliculaMasDe40Minutos()
        {
            return personajeRepository.ListarPorCodigoPeliculaMasDe40Minutos(codigoPelicula);
        }

        public List<Personaje> ListarPorGeneroPersonaje(String genero)
        {
            return personajeRepository.ListarPorGeneroPersonaje(genero);
        }
    }
}
